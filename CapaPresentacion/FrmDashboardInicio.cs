using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System.Collections;

namespace CapaPresentacion
{
    public partial class FrmDashboardInicio : Form
    {
        private MenuAdministrador instancia_menuAdministrador;
        public FrmDashboardInicio(MenuAdministrador p_menuAdministrador)
        {
            InitializeComponent();
            this.instancia_menuAdministrador = p_menuAdministrador;
        }

        private void FrmDashboardInicio_Load(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime fechaActual = DateTime.Now;
            // Obtener el nombre del mes y el año actual
            string mesYAnioActual = fechaActual.ToString("MMMM yyyy");//fechaActual.ToString("MMMM yyyy") formatea la fecha actual para obtener el nombre completo del mes seguido del año en el formato "mes año

            lblDashInicio.Text = lblDashInicio.Text + " " + mesYAnioActual;//cargo el text con la fecha actual 

            chartTop5ProductMasVendidos();
            cargarDatosNegocioEstadisticas();
        }

        public void chartTop5ProductMasVendidos()
        {
            CL_DashBoard obj_CL_DashBoard = new CL_DashBoard();
            // Se crean dos arraylist que contendran los nombres de los productos y sus cantidades vendidas
            (var productos, var cantidadVen) = obj_CL_DashBoard.obtenerProductosMasVendidos();

            // Se carga el grafico con los resultados obtenidos de la base de datos con los arraylist
            chart3.Series[0].Points.DataBindXY(productos, cantidadVen);
        }

        public void cargarDatosNegocioEstadisticas()
        {
            //Obtneemos el mesActual en el que se ejcuta el programa
            int mesActual = DateTime.Now.Month;

            CL_DashBoard obj_CL_DashBoard = new CL_DashBoard();
            capaEntidad.negocioEstadistica obj_negocioEstadistica = obj_CL_DashBoard.obtenerDatosNegocioEstadisticas(mesActual);

            lblNroVentas.Text = obj_negocioEstadistica.nroVentas.ToString();
            lblTotalVentas.Text = obj_negocioEstadistica.totalRecaudado.ToString();
            lblNroCliente.Text = obj_negocioEstadistica.nroClientes.ToString();
            lblNroEmple.Text = obj_negocioEstadistica.nroEmpleado.ToString();
            lblNroProvee.Text = obj_negocioEstadistica.nroProveedores.ToString();
            lblNroProduc.Text = obj_negocioEstadistica.nroProductos.ToString();
            lblTotalStock.Text = obj_negocioEstadistica.totalStock.ToString();
            lblEstadoStock.Text = obj_negocioEstadistica.estadoStock;
        }
    }
}