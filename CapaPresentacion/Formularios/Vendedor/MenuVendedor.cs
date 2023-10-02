using capaEntidad;
using CapaPresentacion.Formularios.Vendedor;
using Proyecto_Taller.Presentacion.Formularios.Login;
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
        private static capaEntidad.usuario usuarioActual;

        public MenuVendedo(capaEntidad.usuario objUsuario = null)
        {
            InitializeComponent();
            personalizarDiseno();

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
                        id_rol = 6,
                        descripcion_rol = "Vendedor"
                    }
                };
            }
            else
            {
                //aca le doy asigno ese objeto usuario que me llega mediante el constructor que en este caso seria el usuario que ingreso en la clase FormLogin
                usuarioActual = objUsuario;
            }

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
            lblTituloMenu.Text = btnAbrirClientes.Text;
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
            lblTituloMenu.Text = button5.Text;
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
            lblRolUsuario.Text = usuarioActual.obj_persona.nombre + " " + usuarioActual.obj_persona.apellido;
            lblNombreUsuario.Text = usuarioActual.obj_rol.descripcion_rol;
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
            lblTituloMenu.Text = btnRegistrarConsultas.Text;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

        }

        private void btnRegistroVen_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo( new ModuloRegistroGeren());
        }
    }
}
