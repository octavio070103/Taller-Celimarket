using capaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace CapaPresentacion.Formularios.Admin.consulta_reclamo
{
    public partial class FrmResponderConsulta : Form
    {
        private static capaEntidad.consulta consultaActual;
        public FrmResponderConsulta(consulta p_obj_consulta)
        {
            InitializeComponent();
            consultaActual = p_obj_consulta; //aca le asigno a mi atributo consultaActual el valor p_objcosnulta que me llega como parametro
            txtGmail.Text = consultaActual.obj_usuario.email;
            txtTituloRespuesta.Text = "Respuesta a la consulta sobre " + consultaActual.obj_motivo_consulta.nombre_motivo_consulta;
            txtConsultActual.Text = "El " + consultaActual.fecha_consulta.ToString("dd-MM-yyyy") + ", " + consultaActual.obj_usuario.obj_persona.nombre + " " + consultaActual.obj_usuario.obj_persona.apellido + "(" + consultaActual.obj_usuario.email + ") escribio: \n" + consultaActual.comentario_consulta;

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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (validarRespuesta())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();
                ask = MessageBox.Show("Confirmacion de envio del mensaje ? ", "Confirmar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    string asunto = "La consulta que habias hecho " + txtConsultActual.Text + "\nRespuesta a la consulta: " + txtCuerpoRespuesta.Text;
                    EnviarNotificacionPorCorreo(consultaActual, txtTituloRespuesta.Text, asunto);
                    //aca tendria que poner el metodo para enviar ese respuesta y que se guarde en al base de datos
                }

            }
        }

        /******************************* Responder Consulta **************************/
        public void EnviarNotificacionPorCorreo(consulta obj_consulta, string asunto, string mensaje)
        {
            try
            {
                //CONFIGURAR VALORES
                string Host = "smtp.gmail.com";
                int Puerto = 587;
                string Usuario = "celimarketexpress@gmail.com";
                string Clave = "pqadyqsdvadgeqjc";//clave generada para aplicación en GMAIL

                //PROPORCIONAMOS AUTENTICACION DE GMAIL
                SmtpClient smtp = new SmtpClient(Host, Puerto);
                MailMessage msg = new MailMessage();


                //CREAMOS EL CONTENIDO DEL CORREO
                string[] Destinatario = obj_consulta.obj_usuario.email.Split(',');
                //  string[] DestinatarioCopia = txtCopia.Text.Split(',');
                // string[] DestinatarioCopiaOculta = txtCopiaOculta.Text.Split(',');


                msg.From = new MailAddress(Usuario, "SERVIDOR CORREO CELIMARKET");
                foreach (string correo in Destinatario) if (correo != "") msg.To.Add(new MailAddress(correo));
                // foreach (string correo in DestinatarioCopia) if (correo != "") msg.CC.Add(new MailAddress(correo)); este me sirve por si quiero una copia del correo enviarlo
                //   foreach (string correo in DestinatarioCopiaOculta) if (correo != "") msg.Bcc.Add(new MailAddress(correo)); esto es por si quiero una coipa oculta
                //  foreach (string adjunto in ArchivoAdjuntos) if (adjunto != "") msg.Attachments.Add(new Attachment(adjunto)); esto es por si quiero permitir que s eadjunten archivos
                msg.Subject = asunto;
                msg.IsBodyHtml = false;
                msg.Body = mensaje;


                //ENVIAMOS EL CORREO
                smtp.Credentials = new NetworkCredential(Usuario, Clave);
                smtp.EnableSsl = true;
                smtp.Send(msg);
                MessageBox.Show("Notificacion de Consulta Enviada al correo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }

        }
        /*************validaciones***********************/
        //valdiaciones para el momento de enviar la respuesta de la consulta
        private bool validarRespuesta()
        {
            bool validacion = true;
            string destinatario = txtGmail.Text;
            string cuerpoRespuesta = txtCuerpoRespuesta.Text;
            string tituloRespuesta = txtTituloRespuesta.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(cuerpoRespuesta) || string.IsNullOrWhiteSpace(tituloRespuesta) || string.IsNullOrEmpty(destinatario))
            {
                MessageBox.Show("Por favor, Rellene todos los campos para poder Responder la Consulta", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

       
    }
}
