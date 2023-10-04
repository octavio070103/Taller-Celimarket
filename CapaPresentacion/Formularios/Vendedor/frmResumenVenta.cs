using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class frmResumenVenta : Form
    {

        public frmResumenVenta(DataGridView pResumen, string[] pDatosResumen)
        {
            InitializeComponent();
            cargarResumenVenta(pResumen, pDatosResumen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarResumenVenta(DataGridView pResumen, string[] pDatosResumen)
        {
            DataGridViewRow auxFilaAgregar;

            lblNombreCli.Text = pDatosResumen[0];
            lblMetodoPago.Text = pDatosResumen[1];
            lblTotal.Text = pDatosResumen[2];

            foreach (DataGridViewRow fila in pResumen.Rows)
            {

                auxFilaAgregar = (DataGridViewRow)fila.Clone(); // Clona los campos de la fila extraida de pResumen

                for (int i = 0; i < fila.Cells.Count; i++)
                {
                    // Recorre cada celda de la fila y lo asigna a las celdas de la fila a agregar
                    auxFilaAgregar.Cells[i].Value = fila.Cells[i].Value;
                }

                dtgvResumen.Rows.Add(auxFilaAgregar);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
