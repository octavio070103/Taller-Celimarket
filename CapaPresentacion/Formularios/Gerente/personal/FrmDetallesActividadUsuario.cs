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

namespace CapaPresentacion.Formularios.Gerente.personal
{
    public partial class FrmDetallesActividadUsuario : Form
    {
        public FrmDetallesActividadUsuario()
        {
            InitializeComponent();
        }




        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void picMaxPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaxPantalla.Visible = false;
            picRestaurar.Visible = true;
        }


        /*funcionalidades para que cuando el usuario cliquee en algunos de estos controles pueda mover toda el formulario*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
