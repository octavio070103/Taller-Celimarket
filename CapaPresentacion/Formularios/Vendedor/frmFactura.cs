using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin.Categoria;
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

            lblNroFactura.Text = auxFactura.nroFactura.ToString();
            lblNombreCli.Text = auxFactura.nombreCliente;
            lblDni.Text = auxFactura.dni;
            lblTelefono.Text = auxFactura.telefono;
            lblFecha.Text = auxFactura.fechaVenta;

            // Datos del negocio
            lblNombreNegocio.Text = auxFactura.nombreNegocio;
            lblDireccion.Text = auxFactura.direccionNegocio;
            lblCuit.Text = auxFactura.cuitNegocio;

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

    }
}
