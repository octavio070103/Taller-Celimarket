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
    public partial class frmSeleccionarCliente : Form
    {

        frmModuloVenta auxModuloVenta;

        public frmSeleccionarCliente(frmModuloVenta pModuloVenta)
        {
            InitializeComponent();
            this.auxModuloVenta = pModuloVenta;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string[] auxDatosCliente = new string[2];

            DataGridViewRow filaSeleccionada = new DataGridViewRow();

            if (dtgvSelecClientes.Rows.Count > 0)
            {

                filaSeleccionada = dtgvSelecClientes.CurrentRow;

                auxDatosCliente[0] = filaSeleccionada.Cells["id_cliente"].Value.ToString();
                auxDatosCliente[1] = filaSeleccionada.Cells["apellido_cliente"].Value.ToString()
                                    + " " + filaSeleccionada.Cells["nombre_cliente"].Value.ToString(); ;

                auxModuloVenta.seleccionarCliente(auxDatosCliente);
                this.Close();
            }

        }

    }
}
