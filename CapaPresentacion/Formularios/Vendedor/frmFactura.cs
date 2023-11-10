using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin.Categoria;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//instalmos los nuggets itexsharp y itexxml y importamos las librerias a usar
using System.IO;
using iText.Kernel.Pdf;
using iText.Html2pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Win32;
using DocumentFormat.OpenXml.ExtendedProperties;
using static System.Resources.ResXFileRef;
using Microsoft.VisualBasic.Logging;


namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class frmFactura : Form
    {
        private int idVenta;

        public frmFactura(int pIdVenta)
        {
            InitializeComponent();
            idVenta = pIdVenta;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarListaProductos(int pIdVenta)
        {
            CL_Venta auxVenta = new CL_Venta();
            dtgvProductos.DataSource = auxVenta.listarDetalleVenta(pIdVenta);
        }

        private void cargarDatosFactura(int pIdVenta)
        {
            CL_Venta auxVenta = new CL_Venta();
            factura auxFactura = auxVenta.obtenerDatosFactura(pIdVenta);

            //Datos de la Factura
            lblTipoFac.Text = " A"; //agregar el campo tipo de factura
            lblFacturaNro.Text = auxFactura.nroFactura.ToString();
            lblFechaFactura.Text = DateTime.Now.ToString("dd/MM/yyyy"); //fecha en la que se genera la factura

            // Datos del negocio
            lblNomNegocio.Text = auxFactura.nombreNegocio;
            lblCUIT.Text = auxFactura.cuitNegocio;
            lblDomNegocio.Text = auxFactura.direccionNegocio;
            lblTelefNegocio.Text = auxFactura.telefono_negocio;
            lblEmailNegocio.Text = auxFactura.email_negocio; //fijarse como traer el email del negocio

            //datos del cliente
            lblNombreCliente.Text = auxFactura.nombreCliente;
            lblDniCliente.Text = auxFactura.dni_cliente;
            lblTelefCliente.Text = auxFactura.telefono_cliente;//fijarse como traer el telefono del cliente sino lo saco

            //datos del vendedor
            lblNomVendedor.Text = auxFactura.nombreVendedor;//traer nom vendedor
            lblDniVendedor.Text = auxFactura.dniVendedor;
            lblFechaVenta.Text = auxFactura.fechaVenta;
            lblMetPago.Text = auxFactura.nombre_tipo_pago + " " + auxFactura.nombre_metodo_pago;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            cargarDatosFactura(idVenta);
            cargarListaProductos(idVenta);
            dtgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lblTotal.Text = "$" + sumarTotalVenta(dtgvProductos).ToString();
        }

        private float sumarTotalVenta(DataGridView pListaVenta)
        {
            float auxTotal = 0;

            foreach (DataGridViewRow fila in pListaVenta.Rows)
            {
                auxTotal = auxTotal + float.Parse(fila.Cells["Subtotal"].Value.ToString());
            }

            return auxTotal;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

            // Generamos el contenido HTML y CSS
            string contenidoHTML = ContenidoHTML.ObtenerContenidoHTML();
            //FACTURA
            contenidoHTML = contenidoHTML.Replace("@tipoFac", lblTipoFac.Text);
            contenidoHTML = contenidoHTML.Replace("@numFactura", lblFacturaNro.Text);
            contenidoHTML = contenidoHTML.Replace("@fechaFactura", lblFechaFactura.Text);//fecha en la que se realizo la factura

            //negocio
            contenidoHTML = contenidoHTML.Replace("@nombre_negocio", lblNomNegocio.Text);
            contenidoHTML = contenidoHTML.Replace("@CUIT", lblCUIT.Text);
            contenidoHTML = contenidoHTML.Replace("@email_negocio", lblEmailNegocio.Text);
            contenidoHTML = contenidoHTML.Replace("@direccion", lblDomNegocio.Text);
            contenidoHTML = contenidoHTML.Replace("@telefono_negocio", lblTelefNegocio.Text);
            //cliente
            contenidoHTML = contenidoHTML.Replace("@Nombre", lblNombreCliente.Text);
            contenidoHTML = contenidoHTML.Replace("@dniCliente", lblDniCliente.Text);
            contenidoHTML = contenidoHTML.Replace("@telefono_cliente", lblTelefCliente.Text);
            //vendedor
            contenidoHTML = contenidoHTML.Replace("@nombreVendedor", lblNomVendedor.Text);
            contenidoHTML = contenidoHTML.Replace("@metPago", lblMetPago.Text);
            contenidoHTML = contenidoHTML.Replace("@fechaVenta", lblFechaVenta.Text);//fecha en la que se realizo la venta

            //aca obtneemos y reemplzamos en el html los productos que iran en nuestra factura
            string filas = string.Empty;
            decimal total = 0;
            decimal iva = 0.21m;//a "m" al final de un número decimal indica que el literal numérico debe ser tratado como un tipo decimal en lugar de un double
            /*falta */
            foreach (DataGridViewRow row in dtgvProductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["MarcaProducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Subtotal"].Value.ToString());
            }
            contenidoHTML = contenidoHTML.Replace("@FILAS", filas);
            contenidoHTML = contenidoHTML.Replace("@Subtotal", total.ToString());
            contenidoHTML = contenidoHTML.Replace("@Descuento", "0");
            contenidoHTML = contenidoHTML.Replace("@IVA", (total * iva).ToString());//IVAAplicado=Subtotal*(0,21)
            contenidoHTML = contenidoHTML.Replace("@Total", (total + (total * iva)).ToString());//total=subtotal+IVAAplicado

            string estilosCSS = EstilosCSS.ObtenerEstilosCSS();


            bool logoObtenido = false;
            byte[] byteImage = new CL_Negocio().obtenerLogoNegocio(out logoObtenido);//obtemos el logo de la empresa que cargamos en la BD,donde llammamos a ese metodo y le pasamos la var de slaida logoObtenido para saber si l opudo obtener o no
            if (logoObtenido)
            {
                /*
                System.Drawing.Image imgLogo = ByteToImage(byteImage); //aca digo que se cargue el piclogo con el resultado del metodo bytetoimage que me conveirte el array de byte en Image
                string base64Image = ImageToBase64(imgLogo);
                contenidoHTML = contenidoHTML.Replace("@imgBase64", base64Image);
                */

                string base64Image = ByteToBase64(byteImage);// Utilicé un nuevo método ByteToBase64 para convertir esos bytes a una cadena de datos base64.

                // Continuación del código (reemplazar en el HTML)
                contenidoHTML = contenidoHTML.Replace("@imgBase64", "data:image/png;base64," + base64Image);//reemplazp @imgBase64 en tu HTML con la URL de datos base64 de la imagen obtenida desde la base de datos.
                                                                                                            //data:image/png;base64," es parte de la URL de datos (data URL) que se utiliza para incrustar datos directamente en el código fuente, en lugar de cargarlos desde un archivo externo. En este caso, se utiliza para incrustar una imagen en formato PNG en tu HTML.
                                                                                                            //data:": Indica que estamos utilizando una URL de datos.,image/png": Especifica el tipo MIME de los datos, en este caso, una imagen en formato PNG.            ";base64,": Indica que los datos que siguen están codificados en base64.
            }


            try
            {
                // Crea un archivo temporal con extensión .html y escribe el contenido HTML,Guardar el contenido HTML en un archivo temporal para convertirlo a PDF al momento de mostrarlo e imporimirl oluego
                string tempFilePath = Path.Combine(Path.GetTempPath(), "FacturaCompra" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".html");////aca le damos el nombre por defecto que tendra el archivo que es FacturaCompra concatenado el aniomesdiamin y seg en el que se ejecuta concatenado a la ext .html ya que creamos un archivo temporal hmtl que leugo lo imprimimos
                File.WriteAllText(tempFilePath, contenidoHTML);
                File.WriteAllText(Path.Combine(Path.GetTempPath(), "estilos.css"), estilosCSS);

                // Abre el archivo HTML en el navegador web predeterminado
                Process.Start(new ProcessStartInfo(tempFilePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el contenido HTML en el navegador: " + ex.Message);
            }

        }
        //este metodo me va a permitir convertir mi arrat de bit que contiene mi iamgen a tipo Image para poder mostrar el logo
        public System.Drawing.Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();   //creo este obj para guardar en memeoria mi array
            ms.Write(imageBytes, 0, imageBytes.Length); //aca leo ese array
            System.Drawing.Image image = new Bitmap(ms);//cremaos nuestra imagen de tipo image

            return image;
        }
        //convertimos esa cadena de bytes a una representación de imagen en el HTML en este caso una cadena de datps nase64
        public string ByteToBase64(byte[] byteImage)
        {
            return Convert.ToBase64String(byteImage);//Utilicé un nuevo método ByteToBase64 para convertir esos bytes a una cadena de datos base64.
        }

        /* probar este con itex7
        public void imprimir2()
        {
            
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtnombres.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdocumento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    PdfWriter writer = new PdfWriter(stream);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document document = new Document(pdfDoc);

                    //Agregamos la imagen del banner al documento
                    iText.Layout.Element.Image img = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(Properties.Resources.shop));
                    img.ScaleToFit(60, 60);
                    img.SetFixedPosition(pdfDoc.GetLeftMargin(), pdfDoc.GetPageSize().GetTop() - 60);

                    document.Add(img);
                    document.Add(new Paragraph(""));

                    HtmlConverter.ConvertToPdf(PaginaHTML_Texto, pdfDoc);

                    document.Close();
                }
            }
        
        }*/
    }
}
