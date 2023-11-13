using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaEntidad;
using System.Globalization;
using System.Collections;

namespace CapaDatos
{
    public class CD_venta
    {
        public DataTable listarVentas()
        {
            DataTable tablaVentas = new DataTable();  // Crea una variable auxiliar de la clase DataTable

            // Se instancia un objeto de la clase conexion que servira para conectarse a la base de datos
            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            // Se instancia un objeto de la clase SqlCommand que permitira ejecutar comandos de la base de datos
            SqlCommand cmd = new SqlCommand("SP_ListarVentas", Obj_conexion);

            // Se establece que el comando a ejecutar es un procediento ya almacenado en la base de datos
            cmd.CommandType = CommandType.StoredProcedure;

            // Se abre la conexion con la base de datos, lo cual permitira ejecutar los comandos
            Obj_conexion.Open();

            // Se instancia un objeto de la clase SqlDataReader que permitira leer los resultados de la ejecucion
            // del procedimiento almacenado
            SqlDataReader dataReader = cmd.ExecuteReader();

            tablaVentas.Load(dataReader); // Se cargan los resultados de la ejecucion del procedimiento en la 
                                          // variable tablaVentas

            dataReader.Close();  // Se cierra el dataReader despues de cargar los datos
            Obj_conexion.Close(); // Se cierra la conexion con la base de datos

            return tablaVentas;
        }


        public DataTable listarVentasVendedor(int pIdUsuario)
        {
            DataTable listaVentas = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SP_ListarVentasVendedor", objConexion);

                    comando.Parameters.AddWithValue("@id_usuario", pIdUsuario);

                    comando.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    SqlDataReader dataReader = comando.ExecuteReader();

                    listaVentas.Load(dataReader);

                    dataReader.Close();
                    objConexion.Close();

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }

                return listaVentas;
            }

        }


        public DataTable obtenerMetodosPago()
        {
            DataTable auxListaMetodos = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SP_ObtenerMetodosPago", objConexion);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dataAdapter.Fill(auxListaMetodos);

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }
            }

            return auxListaMetodos;
        }


        public void registrarVenta(venta objVenta, out int idVentaRegistrada, out int resultadoEjec)
        {

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                idVentaRegistrada = 0;
                resultadoEjec = 0;

                try
                {
                    SqlCommand comando = new SqlCommand("SP_RegistrarVenta", objConexion);

                    //*** PARAMETROS DE ENTRADA ***
                    comando.Parameters.AddWithValue("@venta_fecha", objVenta.fecha_venta);
                    comando.Parameters.AddWithValue("@id_cliente", objVenta.id_cliente);
                    comando.Parameters.AddWithValue("@id_metodo_pago", objVenta.id_metodo_pago);
                    comando.Parameters.AddWithValue("@id_usuario", objVenta.id_usuario);
                    comando.Parameters.AddWithValue("@fecha_creacion_venta", objVenta.fecha_creacion_venta);
                    comando.Parameters.AddWithValue("@id_apertura_caja", objVenta.obj_caja_apertura.id_apertura_caja);
                    //*** PARAMETROS DE SALIDA ***
                    // Parametros para las salidas generadas por el procedimiento almacenado
                    SqlParameter resultadoSalida = comando.Parameters.Add("@resultadoEjec", SqlDbType.Int);
                    SqlParameter auxIdVentaRegistrada = comando.Parameters.Add("@IdNuevaVenta", SqlDbType.Int);

                    // Se establece que la variable 'resultadoEjec' es un parametro de salida que almacenara el
                    // resultado que genere el procedimiento almacenado
                    resultadoSalida.Direction = ParameterDirection.Output;
                    auxIdVentaRegistrada.Direction = ParameterDirection.Output;

                    // Se establece que el comando a ejecutar es del tipo procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    // Se abre la conexion con la base de datos
                    objConexion.Open();

                    // Se ejecuta el procedimiento almacenado
                    comando.ExecuteNonQuery();

                    // Obtenemos las salidas generadas por la ejecucion del procedimiento almacenado
                    resultadoEjec = (int)resultadoSalida.Value;
                    idVentaRegistrada = (int)auxIdVentaRegistrada.Value; //(int)comando.Parameters["@IdNuevaVenta"].Value;
                    

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }

            }

        }


        public factura buscarFactura(int pIdVenta)
        {
            factura auxFactura = new factura();

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SP_ObtenerDatosFactura", objConexion);

                    comando.Parameters.AddWithValue("@id_venta", pIdVenta);

                    comando.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    SqlDataReader dataReader = comando.ExecuteReader();

                    if (dataReader.Read())
                    {
                        auxFactura = new factura
                        {
                            nroFactura = int.Parse(dataReader["Numero de factura"].ToString()),
                            nombreCliente = dataReader["Cliente"].ToString(),
                            dni_cliente = dataReader["DNI"].ToString(),
                            telefono_cliente = dataReader["Telefono Cliente"].ToString(),
                            fechaVenta = dataReader["Fecha"].ToString(),
                            nombreNegocio = dataReader["Nombre"].ToString(),
                            cuitNegocio = dataReader["CUIT"].ToString(),
                            direccionNegocio = dataReader["Direccion"].ToString(),
                            email_negocio = dataReader["email_negocio"].ToString(),
                            telefono_negocio = dataReader["Telefono Negocio"].ToString(),
                            nombreVendedor = dataReader["Vendedor"].ToString(),
                            dniVendedor = dataReader["dni Vendedor"].ToString(),
                            nombre_metodo_pago = dataReader["nombre_metodo_pago"].ToString(),
                            nombre_tipo_pago = dataReader["nombre_tipo_pago"].ToString(),
                        };

                    }

                    dataReader.Close();

                    objConexion.Close();

                }
                catch (Exception excepcion)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + excepcion.Message);
                }

            }

            return auxFactura;
        }


        public string[] datosDelNegocioPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            string[] datosNegocio = null;

            // Se instancia un objeto de la clase SqlConnection que servira para conectarse a la base de datos
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {

                try
                {
                    // Se instancia un objeto de la clase SqlCommand que permitira ejecutar comandos de la base de datos
                    SqlCommand cmd = new SqlCommand("SP_DatosDelNegocioPorPeriodo", Obj_conexion);

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
                    cmd.Parameters.AddWithValue("@fechaInicioPer", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFinPer", fechaFin);

                    // Se abre la conexion con la base de datos
                    Obj_conexion.Open();

                    // Se ejecuta el procedimiento en la base de datos
                    cmd.ExecuteNonQuery();

                    // Se asignan los resultados obtenidos de la base de datos para mostrarlos en pantalla
                    datosNegocio = new string[] {
                        cmd.Parameters["@nroVentas"].Value.ToString(),
                        cmd.Parameters["@totalRecaudado"].Value.ToString(),
                        cmd.Parameters["@nroClientes"].Value.ToString(),
                        cmd.Parameters["@nroEmpleado"].Value.ToString(),
                        cmd.Parameters["@nroProveedores"].Value.ToString(),
                        cmd.Parameters["@nroProductos"].Value.ToString()
                    };

                    Obj_conexion.Close();

                }
                catch (Exception excepcion)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + excepcion.Message);
                }

            }

            return datosNegocio;
        }


        public List<productoMasVendido> productosMasVendidosPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            List<productoMasVendido> auxListaVendidos = new List<productoMasVendido>();

            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ProductosMasVendidosPorPeriodo", Obj_conexion);

                    cmd.Parameters.AddWithValue("@fechaInicioPer", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFinPer", fechaFin);

                    // Se establece que el comando ejecutara procedimientos almacenados de la base de datos
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se abre la conexion con la base de datos
                    Obj_conexion.Open();

                    // Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    // Se cargan los resutados obtenidos de la bases de datos en los arraylist
                    while (dataReader.Read())
                    {
                        productoMasVendido auxProducto = new productoMasVendido
                        {
                            nombreProducto = dataReader.GetString(0),
                            cantidadVendida = dataReader.GetInt32(1)
                        };

                        auxListaVendidos.Add(auxProducto);
                    }

                    dataReader.Close();
                    Obj_conexion.Close();

                }
                catch (Exception excepcion)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + excepcion.Message);
                }

            }

            return auxListaVendidos;
        }


        public List<categoriaMasVendida> categoriasMasVendidasPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            List<categoriaMasVendida> auxListaCategorias = new List<categoriaMasVendida>();

            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_CategoriasMasVendidasPorPeriodo", Obj_conexion);

                    cmd.Parameters.AddWithValue("@fechaInicioPer", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFinPer", fechaFin);

                    // Se establece que el comando ejecutara procedimientos almacenados de la base de datos
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se abre la conexion con la base de datos
                    Obj_conexion.Open();

                    // Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    // Se cargan los resutados obtenidos de la bases de datos en los arraylist
                    while (dataReader.Read())
                    {
                        categoriaMasVendida auxProducto = new categoriaMasVendida
                        {
                            nombreCategoria = dataReader.GetString(0),
                            cantidadVendida = dataReader.GetInt32(1)
                        };

                        auxListaCategorias.Add(auxProducto);
                    }

                    dataReader.Close();
                    Obj_conexion.Close();

                }
                catch (Exception excepcion)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + excepcion.Message);
                }

            }

            return auxListaCategorias;
        }


        public DataTable listarVentasVendedorPorPeriodo(int pIdUsuario, DateTime pFechaInicio, DateTime pFechaFin)
        {
            DataTable listaVentas = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SP_ListarVentasVendedorPorPeriodo", objConexion);

                    comando.Parameters.AddWithValue("@id_usuario", pIdUsuario);
                    comando.Parameters.AddWithValue("@fechaInicioPer", pFechaInicio);
                    comando.Parameters.AddWithValue("@fechaFinPer", pFechaFin);

                    comando.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    SqlDataReader dataReader = comando.ExecuteReader();

                    listaVentas.Load(dataReader);

                    dataReader.Close();
                    objConexion.Close();

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }

                return listaVentas;
            }

        }


        public DataTable listarVentasPorPeriodo(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            DataTable listaVentas = new DataTable();

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SP_ListarVentasPorPeriodo", objConexion);

                    comando.Parameters.AddWithValue("@fechaInicioPer", pFechaDesde);
                    comando.Parameters.AddWithValue("@fechaFinPer", pFechaHasta);

                    comando.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    SqlDataReader dataReader = comando.ExecuteReader();

                    listaVentas.Load(dataReader);

                    dataReader.Close();
                    objConexion.Close();

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }

                return listaVentas;

            }

        }

    }
}
