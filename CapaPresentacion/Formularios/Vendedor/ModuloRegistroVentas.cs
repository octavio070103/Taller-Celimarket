using CapaDatos;
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
    public partial class ModuloRegistroGeren : Form
    {
        public ModuloRegistroGeren()
        {
            InitializeComponent();
        }

        private void listarVentas()
        {
            CD_venta Obj_venta = new CD_venta();

            dtgvRegistroVentas.DataSource = Obj_venta.listarVentas();
        }

        private void ModuloRegistroVentas_Load(object sender, EventArgs e)
        {
            listarVentas();
        }
    }
}
