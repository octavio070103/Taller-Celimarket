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


        /** Permite cargar el datagrid con las ventas registradas
         */
        private void listarVentas()
        {
            // *** Se instancia un objeto venta que permite interactuar con la base de datos
            CD_venta Obj_venta = new CD_venta();

            dtgvRegistroVentas.DataSource = Obj_venta.listarVentas();
        }


        /** Permite cargar la lista de ventas ni bien se abre el formulario
         */
        private void ModuloRegistroVentas_Load(object sender, EventArgs e)
        {
            listarVentas();
        }
    }
}
