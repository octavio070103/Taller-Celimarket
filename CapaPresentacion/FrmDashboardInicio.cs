using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin;
using DocumentFormat.OpenXml.Spreadsheet;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System.Collections;
using System.Collections.Generic;


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
            // Obtener el nombre del mes y el a�o actual
            string mesYAnioActual = fechaActual.ToString("MMMM yyyy");//fechaActual.ToString("MMMM yyyy") formatea la fecha actual para obtener el nombre completo del mes seguido del a�o en el formato "mes a�o

            lblDashInicio.Text = lblDashInicio.Text + " " + mesYAnioActual;//cargo el text con la fecha actual 

            chartTop5ProductMasVendidosDelMes();
            charVentasDelMesPorDia();
            charStockProducPorCategor();
            cargarDatosNegocioEstadisticas();
        }

        public void chartTop5ProductMasVendidosDelMes()
        {
            DateTime fechaActual = DateTime.Now;
            int anio = fechaActual.Year;
            int mes = fechaActual.Month;

            // Limpiar el chart antes de agregar nuevos datos
            chart3.Series[0].Points.Clear();

            CL_DashBoard obj_CL_DashBoard = new CL_DashBoard();
            // Se crean dos arraylist que contendran los nombres de los productos y sus cantidades vendidas
            List<ProductosMasVendidosDelMes> listaProducMasVendiPorMes = obj_CL_DashBoard.obtenerProductosMasVendidos(anio, mes);

            // Iterar sobre la lista de productos m�s vendidos y agregar los puntos al chart
            foreach (ProductosMasVendidosDelMes producto in listaProducMasVendiPorMes)
            {
                // Se carga el grafico con los resultados obtenidos de la base de datos  en un punto o point del chart
                chart3.Series[0].Points.AddXY(producto.nombre_producto, producto.cantProducVendido);
            }


        }

        public void charVentasDelMesPorDia()
        {
            DateTime fechaActual = DateTime.Now;
            int anio = fechaActual.Year;
            int mes = fechaActual.Month;

            CL_DashBoard obj_CL_DashBoard = new CL_DashBoard();
            // Se crean dos arraylist que contendran DiaVenta =los dias que se realizo esa venta y cantidadVenPorDia=la cantVenntas que se realizo ese dia
            (var DiaVenta, var cantidadVenPorDia) = obj_CL_DashBoard.obtenerVentasDelMesPorDia(anio, mes);

            // Formatea la fecha directamente en la base de datos o aqu� en C# seg�n tus preferencias
            //   var DiaVentaFormateado = DiaVenta.Select(d => d.ToString("MMMM dd")).ToArray();

            // Se carga el grafico con los resultados obtenidos de la base de datos con los arraylist cargados
            chartVentas.Series[0].Points.DataBindXY(DiaVenta, cantidadVenPorDia);
        }

        public void charStockProducPorCategor()
        {
            CL_DashBoard obj_CL_DashBoard = new CL_DashBoard();
            // Se crean dos arraylist que contendran DiaVenta =los dias que se realizo esa venta y cantidadVenPorDia=la cantVenntas que se realizo ese dia
            (var categoria, var stock) = obj_CL_DashBoard.obtenerStockProducPorCategor();

            // Se carga el grafico con los resultados obtenidos de la base de datos con los arraylist cargados
            chartStockProductoCateogria.Series[0].Points.DataBindXY(categoria, stock);
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