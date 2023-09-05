using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion.Formularios.Gerente
{
    public partial class GestionarClientes : Form
    {
        CL_Cliente objetoCL = new CL_Cliente();
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {

            //dataGridView1.DataSource = objetoCL.MostrarClien();
        }
    }
}
