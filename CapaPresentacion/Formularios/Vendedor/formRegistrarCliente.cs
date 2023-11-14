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
using capaEntidad;
using CapaLogica;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensajeResultado = "";

            borrarMensajeError();
            validarCampos();

            if (validarCampos() == true)
            {
                DialogResult pregunta = MessageBox.Show("¿Seguro que desea registrar un nuevo Cliente?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (pregunta == DialogResult.Yes)
                {
                    persona auxCliente = new persona()
                    {
                        dni = txtDni.Text,
                        apellido = txtApellido.Text,
                        nombre = txtNombre.Text,
                        fecha_nacimiento = dtpFechaNac.Value,
                        telefono = txtTelefono.Text
                    };

                    CL_Cliente auxComando = new CL_Cliente();

                    auxComando.registrarCliente( auxCliente, out mensajeResultado);

                    if ( mensajeResultado == "Se registro al cliente correctamente.")
                    {
                        MessageBox.Show(mensajeResultado, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        auxModuloCliente.recargarListaClientes();
                        this.Close();
                    }
                    else
                    {
                        // Si el cliente no fue registrado correctamente, se mostrara un mensaje de error
                        MessageBox.Show(mensajeResultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private string[] obtenerDatos()
        {
            string[] auxDatosCliente = new String[6];

            auxDatosCliente[0] = txtDni.Text;
            auxDatosCliente[1] = txtApellido.Text;
            auxDatosCliente[2] = txtNombre.Text;
            auxDatosCliente[3] = txtTelefono.Text;
            //auxDatosCliente[4] = txtDomicilio.Text;
            //auxDatosCliente[4] = txtCorreo.Text;

            return auxDatosCliente;
        }


        private bool validarCampos()
        {
            bool validacion = true;

            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "Ingrese el apellido");
                validacion = false;
            }

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                validacion = false;
            }

            if (txtDni.Text == "")
            {
                errorProvider1.SetError(txtDni, "Ingrese el DNI");
                validacion = false;

            }

            if (txtDni.Text != "" && txtDni.Text.Length != 8 )//
            {
                errorProvider1.SetError(txtDni, "El DNI debe contener 8 dígitos");
                validacion = false;
            }

            /*
            if (txtDomicilio.Text == "")
            {
                errorProvider1.SetError(txtDomicilio, "Ingrese el domicilio");
                validacion = false;
            }

            if (txtCorreo.Text == "")
            {
                errorProvider1.SetError(txtCorreo, "Ingrese el correo electronico");
                validacion = false;
            }*/

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Ingrese el numero de telefono");
                validacion = false;
            }


            return validacion;
        }


        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtDni, "");
            //errorProvider1.SetError(txtDomicilio, "");
            //errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtTelefono, "");
        }


        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxSoloLetras = new Auxiliares();
            auxSoloLetras.soloLetras_KeyPress(sender, e);
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxSoloNumeros = new Auxiliares();
            auxSoloNumeros.soloNumeros_KeyPress(sender, e);
        }

    }
}
