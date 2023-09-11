using capaEntidad;
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

namespace CapaPresentacion.Formularios.Admin
{
    public partial class MenuAdministrador : Form
    {
        private Point mouseDownLocation;
        private Size originalSize;

        private IconButton currentBtn;
        private Panel leftBoderBtn;
        private Form currentChildForm;

        private Color colorFondoOriginal; // Variable para almacenar el color de fondo original

        bool sidebarExpand;

        public MenuAdministrador()
        {
            InitializeComponent();
            colorFondoOriginal = iconBtnGestionUsuario.BackColor; // Almacena el color de fondo original

            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            PMenuLat.Controls.Add(leftBoderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        /*funcionalidades para que cuando el usuario cliquee en algunos de estos controles pueda mover toda el formulario*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //con este metodo abro un form secundario dentro de mi form principal que es mi menu 
        internal void OpenChildForm(Form childForm) //internal puede manejar los formularios (hijos de)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PVentana.Controls.Add(childForm);
            PVentana.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloMenu.Text = childForm.Text;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual
            this.Hide();

            // Muestra el formulario principal (el "Home")
            MenuAdministrador menuAdmin = new MenuAdministrador(); // Reemplaza "Form1" con el nombre real de tu formulario principal
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
                iconBtnBackup.Text = "Respaldo y Restauracion";
                iconBtnGestionConsulta.Text = "Gestionar Consultas y Reclamos";
                iconBtnGestionUsuario.Text = "Gestionar Usuario";

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
    }
}
