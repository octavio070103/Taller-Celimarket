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
    public partial class frmModuloConsultas : Form
    {
        public frmModuloConsultas()
        {
            InitializeComponent();
        }

        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxLetras = new Auxiliares();
            auxLetras.soloLetras_KeyPress(sender, e);
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxNumeros = new Auxiliares();
            auxNumeros.soloNumeros_KeyPress(sender, e);
        }


        private bool validarCampos()
        {
            bool validacion = true;

            if (txtApellido.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == ""
                || txtAsunto.Text == "" || cboConsultante.SelectedItem == null || txtConsulta.Text == "")
            {
                validacion = false;
            }

            return validacion;
        }


        private void borrarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtAsunto.Text = "";
            txtConsulta.Text = "";
            cboConsultante.SelectedItem = null;
        }

        private void btnEnviarConsulta_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                MessageBox.Show("Su consulta se envio correctamente", "Consulta enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borrarCampos();

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
