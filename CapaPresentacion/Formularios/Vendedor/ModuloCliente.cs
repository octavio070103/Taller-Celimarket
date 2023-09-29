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
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

                txtDniCliente.Text = dtgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtApellidoCliente.Text = dtgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombreCliente.Text = dtgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtTelefonoCliente.Text = dtgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtDireccionCliente.Text = dtgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtCorreoCliente.Text = dtgvClientes.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dtgvClientes.Rows.Count > 0)
            {
                DialogResult pregunta = MessageBox.Show("Esta a punto de eliminar a un cliente del registro, ¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (pregunta == DialogResult.Yes)
                {
                    eliminarCliente();
                }
            }

        }


        private void eliminarCliente()
        {
            dtgvClientes.Rows.Remove(dtgvClientes.CurrentRow);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtDniCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtCorreoCliente.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.Rows.Count > 0)
            {
                if ( validarCampos() == true )
                {
                    DialogResult pregunta = MessageBox.Show("Esta a punto de modificar este registro, ¿Desea continuar?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(pregunta == DialogResult.Yes)
                    {
                        dtgvClientes.CurrentRow.Cells[0].Value = txtDniCliente.Text;
                        dtgvClientes.CurrentRow.Cells[1].Value = txtApellidoCliente.Text;
                        dtgvClientes.CurrentRow.Cells[2].Value = txtNombreCliente.Text;
                        dtgvClientes.CurrentRow.Cells[3].Value = txtTelefonoCliente.Text;
                        dtgvClientes.CurrentRow.Cells[4].Value = txtDireccionCliente.Text;
                        dtgvClientes.CurrentRow.Cells[5].Value = txtCorreoCliente.Text;

                        limpiarCampos();
                        borrarMensajeError();
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }


            }
        }


        private bool validarCampos()
        {
            bool validacion = true;

            if (txtApellidoCliente.Text == "")
            {
                errorProvider1.SetError(txtApellidoCliente , "Ingrese el apellido");
                validacion = false;
            }

            if (txtNombreCliente.Text == "")
            {
                errorProvider1.SetError(txtNombreCliente, "Ingrese el nombre");
                validacion = false;
            }

            if (txtDniCliente.Text == "")
            {
                errorProvider1.SetError(txtDniCliente, "Ingrese el DNI");
                validacion = false;
            }

            if (txtDireccionCliente.Text == "")
            {
                errorProvider1.SetError(txtDireccionCliente, "Ingrese el domicilio");
                validacion = false;
            }

            if (txtCorreoCliente.Text == "")
            {
                errorProvider1.SetError(txtCorreoCliente, "Ingrese el correo electronico");
                validacion = false;
            }

            if (txtTelefonoCliente.Text == "")
            {
                errorProvider1.SetError(txtTelefonoCliente, "Ingrese el numero de telefono");
                validacion = false;
            }


            return validacion;
        }


        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtApellidoCliente, "");
            errorProvider1.SetError(txtNombreCliente, "");
            errorProvider1.SetError(txtDniCliente, "");
            errorProvider1.SetError(txtDireccionCliente, "");
            errorProvider1.SetError(txtCorreoCliente, "");
            errorProvider1.SetError(txtTelefonoCliente, "");
        }

    }
}
