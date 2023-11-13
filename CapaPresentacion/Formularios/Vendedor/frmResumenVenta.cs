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
        private Form formularioActivo = null;
        private frmModuloVenta formularioPadre = null;//

        public frmResumenVenta(DataGridView pResumen, string[] pDatosResumen, frmModuloVenta pFormPadre)
        {
            InitializeComponent();
            cargarResumenVenta(pResumen, pDatosResumen);
            datosResumen = pDatosResumen;
            listaDetalle = pResumen;
            formularioPadre = pFormPadre;//
        }

        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo == null)
            {
                //** Se le indican las propiedades que debe tomar el form al ejecutarse

                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                pnlResumen.Controls.Add(formHijo);
                pnlResumen.Tag = formHijo;
                formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                pnlResumen.Controls.Add(formHijo);
                pnlResumen.Tag = formHijo;
                formHijo.BringToFront();
                formHijo.Show();
            }

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
            int idVenta = 0;
            registrarVentaCompleta(out mensajeResultado, out idVenta);
            MessageBox.Show(mensajeResultado, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            formularioPadre.reiniciarModuloVenta(sender, e);
            frmFactura auxFactura = new frmFactura(idVenta);
            //
            formularioPadre.abrirFormularioHijo(auxFactura);

            this.Close();
        }


        private void cargarListaDetalleVenta(List<detalle_venta> auxListaDetalle, int pIdVenta)
        {
            foreach (DataGridViewRow fila in listaDetalle.Rows)
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

        private void registrarVentaCompleta(out string mensajeResultado, out int pIdNuevaVenta)
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
            pIdNuevaVenta = idVentaRegistrada;

            List<detalle_venta> auxListaDetalle = new List<detalle_venta>();

            cargarListaDetalleVenta(auxListaDetalle, idVentaRegistrada);

            auxVenta.registrarDetalleVenta(auxListaDetalle, out mensajeResultado);
        }

    }
}
