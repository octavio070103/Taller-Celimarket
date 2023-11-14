using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.Producto
{
    public partial class FrmRegistrarMarca : Form
    {

        public FrmRegistrarMarca()
        {
            InitializeComponent();

        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar la edicion de la categoria?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }
        public void LimpiarCampos()
        {
            txtNombreMarca.Text = "";
        }
    }
}
