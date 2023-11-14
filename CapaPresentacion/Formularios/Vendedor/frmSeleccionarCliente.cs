using CapaLogica;
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
    public partial class frmSeleccionarCliente : Form
    {

        frmModuloVenta auxModuloVenta;

        public frmSeleccionarCliente(frmModuloVenta pModuloVenta)
        {
            InitializeComponent();
            this.auxModuloVenta = pModuloVenta;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string[] auxDatosCliente = new string[2];

            DataGridViewRow filaSeleccionada = new DataGridViewRow();

            if (dtgvSelecClientes.Rows.Count > 0)
            {

                filaSeleccionada = dtgvSelecClientes.CurrentRow;

                auxDatosCliente[0] = filaSeleccionada.Cells[0].Value.ToString();
                auxDatosCliente[1] = filaSeleccionada.Cells[2].Value.ToString()
                                    + " " + filaSeleccionada.Cells[3].Value.ToString(); ;

                auxModuloVenta.seleccionarCliente(auxDatosCliente);
                this.Close();
            }

        }


        private void cargarListaClientes()
        {
            CL_Cliente cliente = new CL_Cliente();
            dtgvSelecClientes.DataSource = cliente.obtenerListaClientes();
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            cboFiltro.SelectedIndex = 0;
            cargarListaClientes();
            configurarDatagridView();
        }


        private void buscarCliente(string pTerminoBusqueda, string pTipoBusqueda)
        {
            CL_Cliente auxCliente = new CL_Cliente();
            int tipoBusqueda;

            switch (pTipoBusqueda)
            {
                case "Apellido":
                    tipoBusqueda = 1;
                    break;

                case "Nombre":
                    tipoBusqueda = 2;
                    break;

                default:
                    tipoBusqueda = 0;
                    break;
            }

            dtgvSelecClientes.DataSource = null;
            dtgvSelecClientes.DataSource = auxCliente.buscarCliente(pTerminoBusqueda, tipoBusqueda);
            configurarDatagridView();
        }


        private void configurarDatagridView()
        {
            if (dtgvSelecClientes.Rows.Count > 0)
            {
                dtgvSelecClientes.Columns[0].HeaderText = "ID Cliente";
                dtgvSelecClientes.Columns[1].HeaderText = "DNI";
                dtgvSelecClientes.Columns[2].HeaderText = "Apellido";
                dtgvSelecClientes.Columns[3].HeaderText = "Nombre";
                dtgvSelecClientes.Columns[4].HeaderText = "Fecha de nacimiento";
                dtgvSelecClientes.Columns[5].HeaderText = "Telefono";
                dtgvSelecClientes.Columns[6].HeaderText = "Fecha de registro";
            }
            else
            {
                dtgvSelecClientes.Columns[0].HeaderText = "ID Cliente";
                dtgvSelecClientes.Columns[1].HeaderText = "DNI";
                dtgvSelecClientes.Columns[2].HeaderText = "Apellido";
                dtgvSelecClientes.Columns[3].HeaderText = "Nombre";
                dtgvSelecClientes.Columns[4].HeaderText = "Fecha de nacimiento";
                dtgvSelecClientes.Columns[5].HeaderText = "Telefono";
                dtgvSelecClientes.Columns[6].HeaderText = "Fecha de registro";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            buscarCliente(txtNombre.Text, cboFiltro.Text);
        }
    }
}
