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
            MenuAdmin form2 = new MenuAdmin();
            form2.Show();
        }
    }
}