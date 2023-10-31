using CapaDatos;
using capaEntidad;
using CapaLogica;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class frmResumenVenta : Form
    {
        private string[] datosResumen;
        private DataGridView listaDetalle;

        public frmResumenVenta(DataGridView pResumen, string[] pDatosResumen)
        {
            InitializeComponent();
            cargarResumenVenta(pResumen, pDatosResumen);
            datosResumen = pDatosResumen;
            listaDetalle = pResumen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarResumenVenta(DataGridView pResumen, string[] pDatosResumen)
        {
            DataGridViewRow auxFilaAgregar;

            lblNombreCli.Text = pDatosResumen[0];
            lblMetodoPago.Text = pDatosResumen[1];
            lblTotal.Text = pDatosResumen[2];

            foreach (DataGridViewRow fila in pResumen.Rows)
            {

                auxFilaAgregar = (DataGridViewRow)fila.Clone(); // Clona los campos de la fila extraida de pResumen

                for (int i = 0; i < fila.Cells.Count; i++)
                {
                    // Recorre cada celda de la fila y lo asigna a las celdas de la fila a agregar
                    auxFilaAgregar.Cells[i].Value = fila.Cells[i].Value;
                }

                dtgvResumen.Rows.Add(auxFilaAgregar);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string mensajeResultado = "";
            registrarVentaCompleta(out mensajeResultado);
            MessageBox.Show(mensajeResultado);
            
            /*detalle_venta auxDetalle = new detalle_venta
            {
                cantidad_detalle_venta = 1,
                precio_detalle_venta = 30,
                subtotal_detalle_venta = 30,
                id_producto = 1,
                id_venta = 3,
                fecha_creacion_detalle_venta = DateTime.Now,
                
            };
            string mensajeResultado = "";
            CL_Venta auxVenta = new CL_Venta();

            auxVenta.registrarDetalleVenta(auxDetalle, out mensajeResultado);
            /*string mensajeResultado = "";

            registrarVentaCompleta(mensajeResultado);
            MessageBox.Show(mensajeResultado); */
        }


        private void cargarListaDetalleVenta(List<detalle_venta> auxListaDetalle, int pIdVenta)
        {
            foreach ( DataGridViewRow fila in listaDetalle.Rows )
            {
               
                int auxCantidad = int.Parse(fila.Cells["cantidad_producto_carrito"].Value.ToString());
                float auxPrecio = float.Parse(fila.Cells["precio_producto_carrito"].Value.ToString());
                float auxSubtotal = float.Parse(fila.Cells["subtotal_producto_carrito"].Value.ToString());
                int auxIdProducto = int.Parse(fila.Cells["id_producto_carrito"].Value.ToString());

                detalle_venta auxDetalle = new detalle_venta
                {
                    cantidad_detalle_venta = auxCantidad,
                    precio_detalle_venta = auxPrecio,
                    subtotal_detalle_venta = auxSubtotal,
                    fecha_creacion_detalle_venta = DateTime.Now,
                    id_producto = auxIdProducto,
                    id_venta = pIdVenta
                };

                auxListaDetalle.Add(auxDetalle);
            }
        }
        
        private void registrarVentaCompleta(out string mensajeResultado)
        {
            CL_Venta auxVenta = new CL_Venta();
            int idVentaRegistrada = 2;
            int resultadoEjec;

            venta ventaRealizada = new venta
            {
                id_usuario = int.Parse(datosResumen[3].ToString()),
                id_cliente = int.Parse(datosResumen[4].ToString()),
                id_metodo_pago = int.Parse(datosResumen[5].ToString()),
                fecha_venta = DateTime.Now,
                fecha_creacion_venta = DateTime.Now
            };

            auxVenta.registrarVenta(ventaRealizada, out idVentaRegistrada, out resultadoEjec);

            List<detalle_venta> auxListaDetalle = new List<detalle_venta>();

            cargarListaDetalleVenta(auxListaDetalle, idVentaRegistrada);

            auxVenta.registrarDetalleVenta(auxListaDetalle, out mensajeResultado);
        }
        /*
        private void registrarListaDetalleVenta(int idVentaRegistrada, out string mensajeResultado)
        {
            CL_Venta auxDetalleVenta = new CL_Venta();
            mensajeResultado = "";

            List<detalle_venta> auxListaDetalle = obtenerListaDetalleVenta(dtgvResumen, idVentaRegistrada);

            foreach (detalle_venta itemDetalle in auxListaDetalle)
            {
                auxDetalleVenta.registrarDetalleVenta(itemDetalle, out mensajeResultado);
            }
        }


        private List<detalle_venta> obtenerListaDetalleVenta(DataGridView auxListaDetalle, int auxIdVenta)
        {
            List<detalle_venta> listaDetalleVenta = new List<detalle_venta>();

            
            foreach (DataGridViewRow auxFila in auxListaDetalle.Rows)
            {
                detalle_venta auxDetalle = new detalle_venta
                {
                    cantidad_detalle_venta = int.Parse(auxFila.Cells["cantidad_resumen"].Value.ToString()),
                    precio_detalle_venta = float.Parse(auxFila.Cells["precio_resumen"].Value.ToString()),
                    subtotal_detalle_venta = float.Parse(auxFila.Cells["subtotal_resumen"].Value.ToString()),
                    fecha_creacion_detalle_venta = DateTime.Now,
                    id_producto = int.Parse(auxFila.Cells["id_producto_resumen"].Value.ToString()),
                    id_venta = auxIdVenta
                };

                listaDetalleVenta.Add(auxDetalle);
            }

            /*
            for (int i = 1; i<auxListaDetalle.Rows.Count; i++)
            {
                detalle_venta auxDetalle = new detalle_venta
                {
                    cantidad_detalle_venta = int.Parse(auxListaDetalle.Rows[i].Cells["cantidad_resumen"].Value.ToString()),
                    precio_detalle_venta = float.Parse(auxListaDetalle.Rows[i].Cells["precio_resumen"].Value.ToString()),
                    subtotal_detalle_venta = float.Parse(auxListaDetalle.Rows[i].Cells["subtotal_resumen"].Value.ToString()),
                    fecha_creacion_detalle_venta = DateTime.Now,
                    id_producto = int.Parse(auxListaDetalle.Rows[i].Cells["id_producto_resumen"].Value.ToString()),
                    id_venta = auxIdVenta
                };

                listaDetalleVenta.Add(auxDetalle);
            }

            return listaDetalleVenta;
        }*/

    }
}
