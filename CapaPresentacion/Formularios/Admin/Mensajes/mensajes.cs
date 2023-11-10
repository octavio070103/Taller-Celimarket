using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.Mensajes
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Establece el resultado de DialogResult como OK para indicar que el usuario eligió "Aceptar".
            this.DialogResult = DialogResult.OK;

            // Cierra la ventana emergente.
            this.Close();
        }
    }
}
