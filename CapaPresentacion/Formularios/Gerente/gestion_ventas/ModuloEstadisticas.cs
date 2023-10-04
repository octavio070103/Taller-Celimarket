using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
{
    public partial class ModuloEstadisticas : Form
    {
        public ModuloEstadisticas()
        {
            InitializeComponent();
        }

        private void ModuloEstadisticas_Load(object sender, EventArgs e)
        {
            graficoProductosMasVendidos();
            graficoCategoriasMasVendidas();
            datosDelNegocio();
        }


        /** Permite crear un grafico con el top de los 5 productos mas vendidos
         */
        private void graficoProductosMasVendidos()
        {
            // Se crean dos arraylist que contendran los nombres de los productos y sus cantidades vendidas
            ArrayList productos = new ArrayList();
            ArrayList cantidadVen = new ArrayList();

            // Se instancia un objeto que servira para establecer conexion con la base de datos
            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            // Se instancia un SqlCommand que permitira ejecutar comandos de la base de datos
            SqlCommand cmd = new SqlCommand("SP_ProductosMasVendidos", Obj_conexion);

            // Se establece que el comando ejecutara procedimientos almacenados de la base de datos
            cmd.CommandType = CommandType.StoredProcedure;

            // Se abre la conexion con la base de datos
            Obj_conexion.Open();

            // Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
            SqlDataReader dataReader = cmd.ExecuteReader();

            // Se cargan los resutados obtenidos de la bases de datos en los arraylist
            while (dataReader.Read())
            {
                productos.Add(dataReader.GetString(0));
                cantidadVen.Add(dataReader.GetInt32(1));
            }

            // Se carga el grafico con los resultados obtenidos de la base de datos con los arraylist
            chartProductosVen.Series[0].Points.DataBindXY(productos, cantidadVen);

            dataReader.Close();
            Obj_conexion.Close();
        }


        /** Permite crear un grafico con el top de las 5 categorias mas vendidas
         */
        private void graficoCategoriasMasVendidas()
        {
            ArrayList categorias = new ArrayList();
            ArrayList cantidadVen = new ArrayList();


            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            SqlCommand cmd = new SqlCommand("SP_CategoriasMasVendidas", Obj_conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            Obj_conexion.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                categorias.Add(dataReader.GetString(0));
                cantidadVen.Add(dataReader.GetInt32(1));
            }

            chartCategoriasVen.Series[0].Points.DataBindXY(categorias, cantidadVen);

            dataReader.Close();
            Obj_conexion.Close();
        }


        private void datosDelNegocio()
        {
            // Se instancia un objeto de la clase SqlConnection que servira para conectarse a la base de datos
            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            // Se instancia un objeto de la clase SqlCommand que permitira ejecutar comandos de la base de datos
            SqlCommand cmd = new SqlCommand("SP_DatosDelNegocio", Obj_conexion);

            // Se indica que el comando ejectura procedimientos almacenados en la base de datos
            cmd.CommandType = CommandType.StoredProcedure;

            // Se instancian los parametros que seran utilizados para interactuar con el procedimiento almacenado
            SqlParameter nroVentas = new SqlParameter("@nroVentas", SqlDbType.Int);
            SqlParameter totalRecaudado = new SqlParameter("@totalRecaudado", SqlDbType.Float);
            SqlParameter nroClientes = new SqlParameter("@nroClientes", SqlDbType.Float);
            SqlParameter nroEmpleado = new SqlParameter("@nroEmpleado", SqlDbType.Int);
            SqlParameter nroProveedores = new SqlParameter("@nroProveedores", SqlDbType.Int);
            SqlParameter nroProductos = new SqlParameter("@nroProductos", SqlDbType.Int);

            // Se establece que los parametros seran utilizados para recoger los resultados generados por la base de datos
            nroVentas.Direction = ParameterDirection.Output;
            totalRecaudado.Direction = ParameterDirection.Output;
            nroClientes.Direction = ParameterDirection.Output;
            nroEmpleado.Direction = ParameterDirection.Output;
            nroProveedores.Direction = ParameterDirection.Output;
            nroProductos.Direction = ParameterDirection.Output;

            // Se agregan los parametros al comando, los cuales utilizara para recoger los datos
            cmd.Parameters.Add(nroVentas);
            cmd.Parameters.Add(totalRecaudado);
            cmd.Parameters.Add(nroClientes);
            cmd.Parameters.Add(nroEmpleado);
            cmd.Parameters.Add(nroProveedores);
            cmd.Parameters.Add(nroProductos);

            // Se abre la conexion con la base de datos
            Obj_conexion.Open();

            // Se ejecuta el procedimiento en la base de datos
            cmd.ExecuteNonQuery();

            // Se asignan los resultados obtenidos de la base de datos para mostrarlos en pantalla
            lblCantVentas.Text = cmd.Parameters["@nroVentas"].Value.ToString();
            lblTotalRecau.Text = cmd.Parameters["@totalRecaudado"].Value.ToString();
            lblNroClientes.Text = cmd.Parameters["@nroClientes"].Value.ToString();
            lblNroEmpleados.Text = cmd.Parameters["@nroEmpleado"].Value.ToString();
            lblNroProve.Text = cmd.Parameters["@nroProveedores"].Value.ToString();
            lblNroProdu.Text = cmd.Parameters["@nroProductos"].Value.ToString();

            Obj_conexion.Close();

        }

    }
}
