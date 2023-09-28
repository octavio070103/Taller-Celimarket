using capaEntidad;
using CapaPresentacion.Formularios.Admin;
using CapaPresentacion.Formularios.Gerente.caja;
using CapaPresentacion.Formularios.Gerente.informes_de_operacion;
using CapaPresentacion.Formularios.Gerente.personal;
using FontAwesome.Sharp;
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

namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    public partial class MenuGerente : Form
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
        public MenuGerente(capaEntidad.usuario objUsuario = null)
        {
            InitializeComponent();

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

            colorFondoOriginal = iconBtnPersonal.BackColor; // Almacena el color de fondo original

            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            PMenuLat.Controls.Add(leftBoderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void MenuGerente_Load(object sender, EventArgs e)
        {
            /*metodos para que cuando el usuario se posicione en ese boton cambie de color o se resalte */
            // Agrega los controladores de eventos a los botones
            iconBtnPersonal.MouseEnter += new EventHandler(iconBtnPersonal_MouseEnter);
            iconBtnPersonal.MouseLeave += new EventHandler(iconBtnPersonal_Leave);

            // Agrega los controladores de eventos a los botones
            iconBtnVentas.MouseEnter += new EventHandler(iconBtnVentas_MouseEnter);
            iconBtnVentas.MouseLeave += new EventHandler(iconBtnVentas_Leave);

            // Agrega los controladores de eventos a los botones
            iconBtnEstadisticas.MouseEnter += new EventHandler(iconBtnEstadisticas_MouseEnter);
            iconBtnEstadisticas.MouseLeave += new EventHandler(iconBtnEstadisticas_Leave);

            // Agrega los controladores de eventos a los botones
            iconBtnOperaciones.MouseEnter += new EventHandler(iconBtnOperaciones_MouseEnter);
            iconBtnOperaciones.MouseLeave += new EventHandler(iconBtnOperaciones_Leave);

            // Agrega los controladores de eventos a los botones
            iconBtnCaja.MouseEnter += new EventHandler(iconBtnCaja_MouseEnter);
            iconBtnCaja.MouseLeave += new EventHandler(iconBtnCaja_Leave);

            //pone los datos de uusario que se registra en el menu
            lblNombreDelUsu.Text = usuarioActual.obj_persona.nombre + " " + usuarioActual.obj_persona.apellido;
            lblRolDelUsu.Text = usuarioActual.obj_rol.descripcion_rol;

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
            MenuGerente menuGerente = new MenuGerente(usuarioActual); // Reemplaza "Form1" con el nombre real de tu formulario principal
            menuGerente.Show();
        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaxPantalla.Visible = true;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMaxPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaxPantalla.Visible = false;
            picRestaurar.Visible = true;
        }

        private void pictureMenuHambur_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                PMenuLat.Width -= 10;
                /*elimino el texto que tienen los btoones para evitar que se sobreponga es etexto con el boton al reducir o minimizar el menu */
                iconBtnPersonal.Text = "";
                iconBtnVentas.Text = "";
                iconBtnEstadisticas.Text = "";
                iconBtnOperaciones.Text = "";
                iconBtnCaja.Text = "";


                lblNombreDelUsu.Visible = false;//oculto el boton
                lblRolDelUsu.Visible = false;
                picUsuario.Visible = false;
                lblCerrar.Visible = false;

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
                iconBtnPersonal.Text = "Personal";
                iconBtnVentas.Text = "Ventas";
                iconBtnEstadisticas.Text = "Estadisticas";
                iconBtnOperaciones.Text = "Operaciones";
                iconBtnCaja.Text = "Caja";

                lblNombreDelUsu.Visible = true;//oculto el boton
                lblRolDelUsu.Visible = true;
                picUsuario.Visible = true;
                lblCerrar.Visible = true;

                if (PMenuLat.Width == PMenuLat.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }

        /*metodos para abrir el formulario hijo presionando su respectivo boton */
        private void iconBtnPersonal_Click(object sender, EventArgs e)
        {
               OpenChildForm(new FrmGestionarPersonal(this));
        }

        private void iconBtnVentas_Click(object sender, EventArgs e)
        {
            //  OpenChildForm(new Admin.FrmGestionarUsuario(this));
        }

        private void iconBtnEstadisticas_Click(object sender, EventArgs e)
        {
            //  OpenChildForm(new Admin.FrmGestionarUsuario(this));
        }

        private void iconBtnOperaciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmOpRealizada(this));
        }

        private void iconBtnCaja_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmAperturaCaja(this));
        }


        /*metodos para que cuando el usuario se posicione en ese boton cambie de color o se resalte */
        private void iconBtnPersonal_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnPersonal.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }

        private void iconBtnPersonal_Leave(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse sale del botón
            iconBtnPersonal.BackColor = colorFondoOriginal;
        }

        private void iconBtnVentas_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnVentas.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }
        private void iconBtnVentas_Leave(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse sale del botón
            iconBtnVentas.BackColor = colorFondoOriginal;
        }

        private void iconBtnEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnEstadisticas.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }
        private void iconBtnEstadisticas_Leave(object sender, EventArgs e)
        {
            // Cambia el color de fondo(original) cuando el mouse sale del botón
            iconBtnEstadisticas.BackColor = colorFondoOriginal;
        }

        private void iconBtnOperaciones_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnOperaciones.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }
        private void iconBtnOperaciones_Leave(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse sale del botón
            iconBtnOperaciones.BackColor = colorFondoOriginal;
        }

        private void iconBtnCaja_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse entra en el botón
            iconBtnCaja.BackColor = System.Drawing.Color.DarkGray;// Cambia el color al color de resaltado
        }
        private void iconBtnCaja_Leave(object sender, EventArgs e)
        {
            // Cambia el color de fondo cuando el mouse sale del botón
            iconBtnCaja.BackColor = colorFondoOriginal;
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

        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }

}
