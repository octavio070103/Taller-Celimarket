using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Net;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using CapaLogica;
using capaEntidad;
using CapaDatos;
using CapaPresentacion.Formularios.Admin;

namespace Proyecto_Taller.Presentacion.Formularios.Login
{
    //creamos la clase llamada login que hereda de la clase Form(Clase base para formularios enh windows form
    public partial class formLogin : Form
    {
        private bool isMaximized = false; // Variable para realizar seguimiento del estado de maximización

        //El constructor public Form2() es el método que se llama cuando se crea un nuevo objeto de la clase Form2. InitializeComponent() es un método que inicializa
        //todos los componentes visuales (controles) en el formulario.
        public formLogin()
        {
            InitializeComponent();
        }


        /*funcionalidades para que cuando el usuario cliquee en algunos de estos controles pueda mover toda el formulario*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /*                                                                          */


        private void lblDeliMarket_Click(object sender, EventArgs e)
        {

        }
        /*
         * creacion de bordes redondeados para los controles de windows forms en C#
         */
        public static class ControlHelpers
        {
            //Esta función es estática y se encuentra en la clase ControlHelpers. Su propósito es aplicar bordes redondeados a un control específico.
            //Acepta dos parámetros: el control al que se le aplicarán los bordes redondeados y el radio del borde redondeado.
            public static void ApplyRoundCorners(Control control, int cornerRadius)
            {
                //GraphicsPath es una clase que se utiliza para construir formas gráficas
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                path.AddArc(control.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
                path.AddArc(control.Width - cornerRadius * 2, control.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                path.AddArc(0, control.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                control.Region = new Region(path);//Después de crear la ruta con los arcos, se crea una nueva región utilizando esa ruta y se asigna a la propiedad Region del control. Esto crea la apariencia visual de bordes redondeados para el control.
            }
        }

        //como llamo con el evento load del formulario esto hara que  los bordes redondeados se aplicarán cuando el formulario se cargue.
        private void formLogin_Load(object sender, EventArgs e)
        {
            ControlHelpers.ApplyRoundCorners(panel1, 10);
            ControlHelpers.ApplyRoundCorners(txtUsuario, 5);
            ControlHelpers.ApplyRoundCorners(txtPassword, 5);
            ControlHelpers.ApplyRoundCorners(btnLogin, 10);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal; // Cambiar a tamaño normal
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; // Cambiar a maximizado
                isMaximized = true;
            }
        }

        /*funcionalidades para que cuando el usuario cliquee en algunos de estos controles pueda mover toda el formulario*/
        private void formLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*****************************Funcional****************************/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                borrarMensajeError();
        

                // Llamamos a un método de autenticación en la capa de lógica de negocios
                CL_usuario obj_capaLogica = new CL_usuario();
                usuario obj_usuario = obj_capaLogica.AutenticarUsuario(txtUsuario.Text, txtPassword.Text);
                
                /*Ejemplo hasta conectar a la BD autenticación y validación del usuario y contraseña*/

                if (obj_usuario != null)
                {
                    // Usuario autenticado con éxito
                    MessageBox.Show("¡Inicio de sesión exitoso!", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //aes el formulario que quiero qeu se abra y le paso el usuario actual como parametro
                    MenuAdministrador formAbrir = new MenuAdministrador(obj_usuario);
                    formAbrir.Show();
                    this.Hide();
                }
                else
                {
                    // Credenciales incorrectas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool validarCampos()
        {
            bool validacion = true;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password) || usuario == "USUARIO" || password == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(txtUsuario, "Ingrese su usuario");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(txtPassword, "Ingrese su contraseña");
                validacion = false;
            }

            return validacion;
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtUsuario, ""); // Limpiar mensaje de error
            errorProvider1.SetError(txtPassword, ""); // Limpiar mensaje de error

        }


    }
}
