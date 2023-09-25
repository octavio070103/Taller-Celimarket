using Proyecto_Taller.Presentacion.Formularios.Vendedor;
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
    public partial class frmModuloCliente : Form
    {
        private Form formularioActivo = null;


        public frmModuloCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRegistrarCliente(this));
        }

        public void agregarCliente(string[] pDatosCliente)
        {
            // Agrega los datos al datagrid de clientes
            dtgvClientes.Rows.Add(pDatosCliente);
        }

        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo != null) // cambiar por !=
            {
                formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                //formHijo.Dock = DockStyle.Fill;
                pnlVentanaClientes.Controls.Add(formHijo);
                pnlVentanaClientes.Tag = formHijo;

                formHijo.Location = new Point((pnlVentanaClientes.Width - formHijo.Width) / 2,
                                         (pnlVentanaClientes.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                //formHijo.Dock = DockStyle.Fill;
                pnlVentanaClientes.Controls.Add(formHijo);
                pnlVentanaClientes.Tag = formHijo;

                formHijo.Location = new Point((pnlVentanaClientes.Width - formHijo.Width) / 2,
                         (pnlVentanaClientes.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }

        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvClientes.Rows.Count > 0)
            {
                txtDniCliente.Text = dtgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtApellidoCliente.Text = dtgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombreCliente.Text = dtgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtTelefonoCliente.Text = dtgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtDireccionCliente.Text = dtgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtCorreoCliente.Text = dtgvClientes.CurrentRow.Cells[5].Value.ToString();

            }
        }
    }
}
