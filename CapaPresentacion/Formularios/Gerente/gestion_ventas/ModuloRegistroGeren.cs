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

namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
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

            dtgvRegistroGeren.DataSource = Obj_venta.listarVentas();
        }

        private void ModuloRegistroGeren_Load(object sender, EventArgs e)
        {
            listarVentas();
        }
    }
}
