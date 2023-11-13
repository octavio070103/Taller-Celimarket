using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Gerente.caja;
using CapaPresentacion.Formularios.Gerente.permiso;
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
        private Form formularioActivo = null;
        private Form formularioSolicitudActualmente = null; //con estdeermino e lformacutal de la solicitud,si esta abierto el permiso o la cosnulta

        public MenuVendedo(capaEntidad.usuario objUsuario = null)
        {
            InitializeComponent();
            personalizarDiseno();

            /** Permite personalizar los campos de Nombre de usuario y Rol cuando el usuario inicia sesion.
             */

            if (objUsuario == null)
            {
                /** Si el usuario es nulo, se crea un usuario por default. Esto permite realizar 
                 * prueba de funcionamiento.
                 */

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
                        nombre_rol = "Vendedor"
                    }
                };
            }
            else
            {
                /** Entrara aqui en caso de que un usuario registrado sea quien inicie sesión.
                 */
                usuarioActual = objUsuario;
            }

        }

        private void personalizarDiseno()
        {
            //**** Este metodo oculta los SUBMENUS del menu lateral al iniciar ***
            //PSubmenu1.Visible = false;
        }


        /** Permite abrir el modulo dedicado al registro, eliminacion y modificacion de clientes.
         */
        private void btnAbrirClientes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmModuloCliente());
            lblTituloMenu.Text = btnAbrirClientes.Text;
        }


        /** Permite abrir el modulo dedicado a las ventas del dia a dia.
         */
        private void button4_Click(object sender, EventArgs e)
        {
            //aca determino sino hay ninguna caja abierta que no pueda realizar la venta
            determinarAperturaCaja();

        }
        private void determinarAperturaCaja()
        {

            caja_apertura obj_cajaAperturaActual = new CL_Caja().obtenerCajaAperturaPorFecha(DateTime.Now);//obtengo la caja apertura para la fecha en la que se cierra la caja
            //si entra al if significa que la caja no fue abierta anteriormente es decir no se abrio la caja por lo que no voy a pdoer realizar ninguna venta y no me deberia dejar navegar por el formulario debo de devolver al gome
            if ((obj_cajaAperturaActual == null) || (obj_cajaAperturaActual.estado_apertura == 0)) //aca pregunto si la cajaApertura es null es decir que no se abrio ninguna cajaapertura en esta fecha que entre al if o si el estado_apertura==0 que pase lo mismo ya que esto siginifica que esa cajapertura fue cerrada
            {

                if (advertenciaIniciarVenta() == DialogResult.OK)
                {
                    //no hago nada sino puedo realizar la venta
                }

            }
            else//si va por el elsse significa que si hay una caja abierta
            {
                //**** Falta el codigo a ejecutar
                abrirFormularioHijo(new frmModuloVenta(usuarioActual));
                lblTituloMenu.Text = button5.Text;
            }

        }

        private DialogResult advertenciaIniciarVenta()
        {
            Advertencia_iniciar_venta frmAdveriniciarVenta = new Advertencia_iniciar_venta();
            DialogResult resultado = frmAdveriniciarVenta.ShowDialog();
            return resultado;
        }

        /** Permite abrir un formulario dentro del menu del vendedor.
        */
        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo == null)
            {
                //** Se le indican las propiedades que debe tomar el form al ejecutarse

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


        /** Permite cargar los label de rol y nombre de acuerdo al usuario del vendedor
         */
        private void MenuVendedo_Load(object sender, EventArgs e)
        {
            lblRolUsuario.Text = usuarioActual.obj_rol.nombre_rol;
            lblNombreUsuario.Text = usuarioActual.obj_persona.nombre + " " + usuarioActual.obj_persona.apellido;
        }


        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /** Permite maximizar la pantalla de la aplicacion
         */
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


        /** Permite acceder al modulo de registro de consultas
         */
        private void btnRegistrarConsultas_Click_1(object sender, EventArgs e)
        {
            if (panelCrearSolicitud.Visible == true)
            {
                panelCrearSolicitud.Visible = false;
            }
            else
            {
                panelCrearSolicitud.Visible = true;
            }
        }
        private void iconbtnCrearPermiso_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual si está abierto
            CerrarFormularioActual();
            FrmSolicitudPermiso formPermiso = new FrmSolicitudPermiso(usuarioActual);
            formPermiso.Show();

            formularioSolicitudActualmente = formPermiso;    // Actualizar la referencia al formulario actualmente abierto
        }

        private void iconBtnCrearConsulta_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual si está abierto
            CerrarFormularioActual();
            FrmSolicitudConsulta formConsulta = new FrmSolicitudConsulta(usuarioActual);
            formConsulta.Show();

            formularioSolicitudActualmente = formConsulta;    // Actualizar la referencia al formulario actualmente abierto
        }

        private void CerrarFormularioActual()
        {
            if (formularioSolicitudActualmente != null && !formularioSolicitudActualmente.IsDisposed)
            {
                formularioSolicitudActualmente.Close();
            }
        }

        /** Permite volver al menu principal
         */
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

        }

        /** Permite acceder al modulo de registro de ventas del dia del vendedor
         */
        private void btnRegistroVen_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ModuloRegistroGeren(usuarioActual));
        }


        /** Permite al usuario cerrar sesion
         */
        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("¿Esta seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (salida == DialogResult.OK)
            {
                // Redirige al usuario a la pantalla de inicio de sesión.
                formLogin loginForm = new formLogin();
                loginForm.Show();

                // Cierra el formulario actual.
                this.Close();
            }
        }

        private void picCerrarSesion_Click(object sender, EventArgs e)
        {
            lblCerrarSesion_Click(sender, e);
        }

      
    }
}
