using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace CapaPresentacion.Formularios.Admin.consulta_reclamo
{
    public partial class FrmResponderConsulta : Form
    {

        public FrmResponderConsulta()
        {
            InitializeComponent();

        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Si la ventana está maximizada, cambia a estado normal.
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Si la ventana no está maximizada, cambia a estado maximizado.
                this.WindowState = FormWindowState.Maximized;

            }

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
