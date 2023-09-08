using CapaPresentacion.Formularios.Admin;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrador form2 = new MenuAdministrador();
            form2.Show();
        }
    }
}