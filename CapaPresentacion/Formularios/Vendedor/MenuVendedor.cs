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
    public partial class MenuVendedo : Form
    {
        public MenuVendedo()
        {
            InitializeComponent();
            personalizarDiseno();
        }

        private void personalizarDiseno()
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral al iniciar ***
            PSubmenu1.Visible = false;
            //*** Hacer para cada submenu - borrar
        }

        private void ocultarSubmenu()
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral ****

            if (PSubmenu1.Visible == true)
            {
                PSubmenu1.Visible = false;
            }

            //*** Hacer para cada submenu - borrar
        }

        private void mostrarSubmenu(Panel subMenu)
        {
            //**** Este metodo permite mostrar un ocultar un determinado submenu al tocar un boton ****

            if (subMenu.Visible == false)
            {
                ocultarSubmenu();       //**** Si el submenu no se ve, oculta los demas submenus
                subMenu.Visible = true; //**** Muestra el submenu indicado

            }
            else
            {
                subMenu.Visible = false; //**** Oculta el submenu al tocar el boton
            }
        }





        private void PMenuLat_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //*** Modificar si es necesario - borrar
            mostrarSubmenu(PSubmenu1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //*** Modificar si es necesario - hacer para cada evento - borrar

            //**** Falta el codigo a ejecutar - borrar 
            abrirFormularioHijo(new FormPrueba());
            ocultarSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //**** Falta el codigo a ejecutar - borrar 
            ocultarSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //**** Falta el codigo a ejecutar - borrar 
            ocultarSubmenu();
        }


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

        }

        private void MenuVendedo_Load(object sender, EventArgs e)
        {

        }

        private void PVentana_Paint(object sender, PaintEventArgs e)
        {

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

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaxPantalla.Visible = true;
        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
