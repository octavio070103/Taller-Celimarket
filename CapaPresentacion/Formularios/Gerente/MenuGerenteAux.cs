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

namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    public partial class MenuGerenteAux : Form
    {
        public MenuGerenteAux()
        {
            InitializeComponent();
            personalizarDiseno();
        }

        private void personalizarDiseno()
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral al iniciar ***
            //PSubmenu1.Visible = false;
            //*** Hacer para cada submenu - borrar
        }

        private void PMenuLat_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAbrirClientes_Click(object sender, EventArgs e)
        {
            //*** Modificar si es necesario - borrar
            abrirFormularioHijo(new frmModuloCliente());
            //mostrarSubmenu(PSubmenu1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //**** Falta el codigo a ejecutar - borrar 
            abrirFormularioHijo(new FormPrueba());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //**** Falta el codigo a ejecutar
            abrirFormularioHijo(new frmModuloVenta());

        }


        private Form formularioActivo = null;
        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo == null) // cambiar por !=
            {

                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                PVentana.Controls.Add(formHijo);
                PVentana.Tag = formHijo;
                //formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                PVentana.Controls.Add(formHijo);
                PVentana.Tag = formHijo;
                formHijo.BringToFront();
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

        private void btnRegistrarConsultas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmModuloConsultas());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

        }
    }
}
