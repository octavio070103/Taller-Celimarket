using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace CapaPresentacion.Formularios.Admin.consulta_reclamo
{
    public partial class FrmResponderConsulta : Form
    {

        public FrmResponderConsulta()
        {
            InitializeComponent();

        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Si la ventana está maximizada, cambia a estado normal.
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Si la ventana no está maximizada, cambia a estado maximizado.
                this.WindowState = FormWindowState.Maximized;

            }

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //valdiaciones para el momento de enviar la respuesta de la consulta
        private bool validarRespuesta()
        {
            bool validacion = true;
            string cuerpoRespuesta = txtCuerpoRespuesta.Text;
            string tituloRespuesta = txtTituloRespuesta.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(cuerpoRespuesta) || string.IsNullOrWhiteSpace(tituloRespuesta))
            {
                MessageBox.Show("Por favor, Rellene todos los campos para poder Responder la Consulta", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(lblTituloRespuesta, "Ingrese un titulo valido");
                errorProvider1.SetError(txtCuerpoRespuesta, "ingrese texto en el cuerpo de la respuesta");
                validacion = false;
            }

            //valido que el titulo solo pueda contener letras 
            if (!EsAlfabetico(tituloRespuesta))
            {
                errorProvider1.SetError(lblTituloRespuesta, "Ingrese un titulo valido");
                MessageBox.Show(" El titulo debe de contener solamente letras ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
        }

        // Función para verificar si una cadena contiene solo letras
        private bool EsAlfabetico(string texto)
        {
            bool espacioEncontrado = false;
            foreach (char c in texto)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (espacioEncontrado)
                    {
                        // Se encontró un espacio en blanco después de otro espacio en blanco
                        return false;
                    }
                    espacioEncontrado = true;
                }
                else if (!char.IsLetter(c))
                {
                    // El carácter no es una letra
                    return false;
                }
                else
                {
                    // Reiniciar el indicador de espacio si se encuentra una letra
                    espacioEncontrado = false;
                }
            }
            return true;
        }
        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblTituloRespuesta, ""); // Limpiar mensaje de error
            errorProvider1.SetError(txtCuerpoRespuesta, "");    // Limpiar mensaje de error

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (validarRespuesta())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();
                ask = MessageBox.Show("Confirmacion de envio del mensaje ? ", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    //aca tendria que poner el metodo para enviar ese respuesta y que se guarde en al base de datos
                }

            }

        }


    }
}
