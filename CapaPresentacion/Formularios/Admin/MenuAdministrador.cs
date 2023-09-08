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
            personalizarDiseno();
            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            PMenuLat.Controls.Add(leftBoderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void personalizarDiseno()
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral al iniciar ***
            PSubmenu1.Visible = false;
            submenuVentas.Visible = false;
            submenuPersonal.Visible = false;
            subMenuPromocion.Visible = false;
            //*** Hacer para cada submenu - borrar
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

        private void ocultarSubmenu(Panel pMenuOcultar)
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral ****

            if (pMenuOcultar.Visible == true)
            {
                pMenuOcultar.Visible = false;
            }

            //*** Hacer para cada submenu - borrar
        }
        private void mostrarSubmenu(Panel subMenu)
        {
            //**** Este metodo permite mostrar un ocultar un determinado submenu al tocar un boton ****
            personalizarDiseno();//con esta funcion aca hago que cuando se llame a mostrarSubmenu me asegure que todos losd emas submenus estan cerrados para ahorrar espacio y quede estetico

            if (subMenu.Visible == false)
            {
                //  ocultarSubmenu(subMenu);       //**** Si el submenu no se ve, oculta los demas submenus
                subMenu.Visible = true; //**** Muestra el submenu indicado

            }
            else
            {
                subMenu.Visible = false; //**** Oculta el submenu al tocar el boton
            }
        }

        /*submenu caja*/
        private void btnCaja_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmListaUsuario(this));
            //*** Modificar si es necesario - borrar
            mostrarSubmenu(PSubmenu1);
        }

        private void btnInfoCaja_Click(object sender, EventArgs e)
        {


            ocultarSubmenu(PSubmenu1);

            //    FrmRegitrarUsuario frmRegistrarUsuario = new FrmRegitrarUsuario(); // Crea una instancia del formulario destino
            //  frmRegistrarUsuario.Show(); // Muestra el formulario destino
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.FrmEditarUsuario(this));
            ocultarSubmenu(PSubmenu1);


        }

        /*submenu Ventas*/
        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(submenuVentas);
            OpenChildForm(new Admin.RegistrarUsuario(this));
        }

        private void btnInfomeVenta_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenuVentas);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenuVentas);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenuVentas);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenuVentas);
        }

        /*submenu Personal*/
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(submenuPersonal);
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenuPersonal);
        }

        private void btnGestionPersonal_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenuPersonal);
        }

        /*sub menu promocion*/
        private void btnPromocionDescuento_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subMenuPromocion);
        }

        /*sub menu promocion*/
        private void btnPromociones_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(subMenuPromocion);
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(subMenuPromocion);
        }

        private void btnPromocionDescuento_Click_2(object sender, EventArgs e)
        {
            mostrarSubmenu(subMenuPromocion);
        }

        private void btnPromociones_Click_2(object sender, EventArgs e)
        {
            ocultarSubmenu(subMenuPromocion);
        }

        private void btnDescuentos_Click_2(object sender, EventArgs e)
        {
            ocultarSubmenu(subMenuPromocion);
        }
        /****ver cuales bvorrar
        private Form formularioActivo = null;
        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo == null) // cambiar por !=
            {
                //formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                PVentana.Controls.Add(formHijo);
                PVentana.Tag = formHijo;
                //formHijo.BringToFront();
                formHijo.Show();
            }

        }*/

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

        private void pictureBox3_Click(object sender, EventArgs e)
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
    }
}
