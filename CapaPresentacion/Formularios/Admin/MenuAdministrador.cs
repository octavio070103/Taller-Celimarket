using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        bool sidebarExpand;

        public MenuAdministrador()
        {
            InitializeComponent();

            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            PMenuLat.Controls.Add(leftBoderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }



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
                if (PMenuLat.Width == PMenuLat.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }

            }
            else
            {
                PMenuLat.Width += 10;
                if (PMenuLat.Width == PMenuLat.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }

        private void btnGestionarUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmListaUsuario(this));
        }

        private void btnGestionarConsultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmGestionarConsulta(this));
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmRespaldo(this));

        }


    }
}
