using CapaPresentacion.Formularios.Admin;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;

namespace CapaPresentacion
{
    public partial class FrmDashboardInicio : Form
    {
        public FrmDashboardInicio()
        {
            InitializeComponent();

        }

        private void FrmDashboardInicio_Load(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime fechaActual = DateTime.Now;
            // Obtener el nombre del mes y el año actual
            string mesYAnioActual = fechaActual.ToString("MMMM yyyy");//fechaActual.ToString("MMMM yyyy") formatea la fecha actual para obtener el nombre completo del mes seguido del año en el formato "mes año

            lblDashInicio.Text = lblDashInicio.Text + " " + mesYAnioActual;//cargo el text con la fecha actual 


        }


    }
}