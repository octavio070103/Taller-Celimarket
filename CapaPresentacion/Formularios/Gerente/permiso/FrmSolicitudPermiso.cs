using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Gerente.permiso
{
    public partial class FrmSolicitudPermiso : Form
    {

        private static capaEntidad.usuario usuarioActual;
        public FrmSolicitudPermiso(capaEntidad.usuario obj_usuario_actual)
        {
            InitializeComponent();
            usuarioActual = obj_usuario_actual;
            cargarDatosUsuario();
            //this.StartPosition = FormStartPosition.Manual;
            // this.Location = new Point(650, 200); // Define la posición en pantalla
           // cargar
        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /***metodo para cargar los textBox del usuario que inicio sesion con sus datos de la base **/
        public void cargarDatosUsuario()
        {
            txtNombre.Text = usuarioActual.obj_persona.nombre;
            txtApellido.Text = usuarioActual.obj_persona.apellido;
            txtEmail.Text = usuarioActual.email;
            txtRol.Text = usuarioActual.obj_rol.nombre_rol;
            txtDni.Text = usuarioActual.obj_persona.dni;
            txtTelefono.Text = usuarioActual.obj_persona.telefono;
            //hago para que sean solo de lectura esos campos
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtRol.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtTelefono.ReadOnly = true;

        }
    }
}
