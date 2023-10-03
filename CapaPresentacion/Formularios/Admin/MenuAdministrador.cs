using capaEntidad;
using FontAwesome.Sharp;
using Proyecto_Taller.Presentacion.Formularios.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class MenuAdministrador : Form
    {
        private Point mouseDownLocation;
        private Size originalSize;

        private Panel leftBoderBtn;

        //esta avr de tipo form se utilizara para llevar un registro del formulario secundario que esta actualmente abierno en el formulario priniciapl
        private Form currentChildForm;
        private IconButton currentBtn;

        private Color colorFondoOriginal; // Variable para almacenar el color de fondo original

        bool sidebarExpand;

        //aca decalro una var de tipo estatica pq no va a varuar su valor y es un obj de clase usuario que esta en la capa de entidad
        private static capaEntidad.usuario usuarioActual;

        //este es el constructor de mi clase menuAdministrador y le paso como parametro a ese contructor un obj de tipo Usuario
        public MenuAdministrador(capaEntidad.usuario objUsuario = null)
        {
            if (objUsuario == null)
            {
                usuarioActual = new capaEntidad.usuario()
                {
                    id_usuario = 5,
                    email = "prueba@gmail",
                    password = "1",
                    estado_usuario = 1,
                    obj_persona = new persona()
                    {
                        id_persona = 5,
                        dni = "111",
                        nombre = "prueba",
                        apellido = "prueba",
                        fecha_nacimiento = new DateTime(2003, 7, 1), // Año, mes, día 
                        telefono = "33"
                    },
                    obj_rol = new rol()
                    {
                        id_rol = 1,
                        descripcion_rol = "administrador"
                    }
                };
            
            }
            else
            {
                //aca le doy asigno ese objeto usuario que me llega mediante el constructor que en este caso seria el usuario que ingreso en la clase FormLogin
                usuarioActual = objUsuario;
            }


            InitializeComponent();
            colorFondoOriginal = iconBtnGestionUsuario.BackColor; // Almacena el color de fondo original

            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            PMenuLat.Controls.Add(leftBoderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            OpenChildForm(new FrmDashboardInicio(this));
        }


        /*funcionalidades para que cuando el usuario cliquee en algunos de estos controles pueda mover toda el formulario*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //con este metodo abro un form secundario dentro de mi form principal que es mi menu 

        //Este es un método llamado OpenChildForm que toma un parámetro de tipo Form llamado childForm. El modificador internal indica que el método solo es accesible desde dentro del mismo ensamblado (assembly),
        //lo que generalmente significa que solo puede ser utilizado dentro del proyecto actual.
        internal void OpenChildForm(Form childForm) //internal puede manejar los formularios (hijos de)
        {
            //Estas líneas verifican si ya hay un formulario secundario abierto (currentChildForm no es nulo).
            //Si hay un formulario secundario abierto, se cierra antes de abrir el nuevo. Esto asegura que solo haya un formulario secundario abierto a la vez en el formulario principal.
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            //configuramos el form
            currentChildForm = childForm;//mi var de seg del form secundario abierto
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //agrego el form al contenedor
            PVentana.Controls.Add(childForm);
            PVentana.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloMenu.Text = childForm.Text;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            
                //aca digo que si hay algun formulario hijo abierto que lo cierre antes de abrir el home
                if (currentChildForm != null)
                {
                    // cierra el formulario actual
                    currentChildForm.Close();

                }
                // Muestra el formulario principal (el "Home")
                MenuAdministrador menuAdmin = new MenuAdministrador(usuarioActual); // Reemplaza "Form1" con el nombre real de tu formulario principal
                menuAdmin.Show();

           
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMaxPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaxPantalla.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaxPantalla.Visible = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                PMenuLat.Width -= 10;
                /*elimino el texto que tienen los btoones para evitar que se sobreponga es etexto con el boton al reducir o minimizar el menu */
                iconBtnBackup.Text = "";
                iconBtnGestionConsulta.Text = "";
                iconBtnGestionUsuario.Text = "";
                iconBtnSesion.Text = "";

                lblNombreDelUsu.Visible = false;//oculto el boton
                lblRolDelUsu.Visible = false;
                picUsuario.Visible = false;


                if (PMenuLat.Width == PMenuLat.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }

            }
            else
            {
                PMenuLat.Width += 10;
                /*agregi el texto que tienen los btoones para evitar que se sobreponga es etexto con el boton al maximizar el menu */
                iconBtnBackup.Text = "Respaldo y Restauracion";
                iconBtnGestionConsulta.Text = "Gestionar Consultas y Reclamos";
                iconBtnGestionUsuario.Text = "Gestionar Usuario";
                iconBtnSesion.Text = "Cerrar Sesion";

                lblNombreDelUsu.Visible = true;//oculto el boton
                lblRolDelUsu.Visible = true;
                picUsuario.Visible = true;


                if (PMenuLat.Width == PMenuLat.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }

        private void iconBtnGestionUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmGestionarUsuario(this));

        }

        private void iconBtnGestionConsulta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmGestionarConsulta(this));
        }

        private void iconBtnBackup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmRespaldo(this));
        }
        private void iconBtnAdminAcceso_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.administrar_acceso.FrmAdministrarAcceso(this));
        }

        private void iconBtnDashBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDashboardInicio(this));
        }


        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // Agrega los controladores de eventos a los botones
            iconBtnGestionUsuario.MouseEnter += new EventHandler(iconBtnGestionUsuario_MouseEnter);
            iconBtnGestionUsuario.MouseLeave += new EventHandler(iconBtnGestionUsuario_Leave);

            // Agrega los controladores de eventos a los botones
            iconBtnGestionUsuario.MouseEnter += new EventHandler(iconBtnGestionUsuario_MouseEnter);
            iconBtnGestionUsuario.MouseLeave += new EventHandler(iconBtnGestionUsuario_Leave);

            // Agrega los controladores de eventos a los botones
            iconBtnGestionUsuario.MouseEnter += new EventHandler(iconBtnGestionUsuario_MouseEnter);
            iconBtnGestionUsuario.MouseLeave += new EventHandler(iconBtnGestionUsuario_Leave);


            //pone los datos de uusario que se registra en el menu
            lblNombreDelUsu.Text = usuarioActual.obj_persona.nombre + " " + usuarioActual.obj_persona.apellido;
            lblRolDelUsu.Text = usuarioActual.obj_rol.descripcion_rol;
        }

        private void iconBtnGestionUsuario_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnGestionUsuario.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }


        private void iconBtnGestionUsuario_Leave(object sender, EventArgs e)
        {// Cambia el color de fondo cuando el mouse sale del botón
            iconBtnGestionUsuario.BackColor = colorFondoOriginal;
        }

        private void iconBtnGestionConsulta_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnGestionConsulta.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }

        private void iconBtnGestionConsulta_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse sale del botón
            iconBtnGestionConsulta.BackColor = colorFondoOriginal;
        }

        private void iconBtnBackup_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnBackup.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }

        private void iconBtnBackup_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse sale del botón
            iconBtnBackup.BackColor = colorFondoOriginal;
        }

        /*funcionalidades para que cuando el usuario cliquee en algunos de estos controles pueda mover toda el formulario*/
        private void PVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PMenuLat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void PLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconBtnSesion_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("Esta seguro que desea salir de la Aplicacion", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (salida == DialogResult.OK)
            {
                // Redirigir al usuario a la pantalla de inicio de sesión o la página principal.
                // Puedes utilizar un formulario diferente para la pantalla de inicio de sesión.
                formLogin loginForm = new formLogin();
                loginForm.Show();

                // Cerrar el formulario actual (formulario principal) después de redirigir.
                this.Close();
            }
        }

       
    }
}
