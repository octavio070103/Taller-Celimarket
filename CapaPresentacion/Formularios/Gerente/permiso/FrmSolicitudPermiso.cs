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


        public FrmSolicitudPermiso()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(650, 200); // Define la posición en pantalla
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
