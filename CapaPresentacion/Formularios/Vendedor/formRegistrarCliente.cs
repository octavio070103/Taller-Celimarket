using CapaPresentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    public partial class frmRegistrarCliente : Form
    {

        private frmModuloCliente auxModuloCliente;

        public frmRegistrarCliente(frmModuloCliente pModuloCliente)
        {
            InitializeComponent();
            this.auxModuloCliente = pModuloCliente;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares validarNumeros = new Auxiliares();
            validarNumeros.soloNumeros_KeyPress(sender, e);
        }



        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] datosCliente = obtenerDatos();

            auxModuloCliente.agregarCliente(datosCliente);
            this.Close();
        }

        private string[] obtenerDatos()
        {
            string[] auxDatosCliente = new String[6];

            auxDatosCliente[0] = txtDni.Text;
            auxDatosCliente[1] = txtApellido.Text;
            auxDatosCliente[2] = txtNombre.Text;
            auxDatosCliente[3] = txtTelefono.Text;
            auxDatosCliente[4] = txtDomicilio.Text;
            auxDatosCliente[5] = txtCorreo.Text;

            return auxDatosCliente;
        }
    }
}
