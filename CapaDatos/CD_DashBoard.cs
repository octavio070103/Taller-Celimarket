using capaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_DashBoard
    {
        /// <summary>
        /// Obtiene los productos más vendidos y la cantidad de ventas.
        /// </summary>
        /// <returns>Tupla con dos ArrayLists: productos y cantidad de ventas.</returns>
        //creo un diccioanrio de datos para poder retornar los dos array que creo ,hago esto para no estar creando una clase ProductosMasVendidosque tenga de atributo estos dos array
        public (ArrayList productos, ArrayList cantidadVen) obtenerProductosMasVendidos()
        {
            ArrayList productos = new ArrayList(); //creo mi dos array que vna a contener el TOP5 de productos mas vendidos de mi BD y la cantidad de ventas que tuvieron
            ArrayList cantidadVen = new ArrayList();

            //le paso cadena de la clase conexion ,aca Se instancia una conexión a la base de datos.
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))// Se instancia un Obj_conexion que servira para establecer conexion con la base de datos
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_ProductosMasVendidos", Obj_conexion); // Se instancia un SqlCommand que permitira ejecutar comandos de la base de datos
                                                                                            // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    // Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    // Se cargan los resutados obtenidos de la bases de datos en los arraylist
                    while (dataReader.Read())
                    {
                        productos.Add(dataReader.GetString(0));
                        cantidadVen.Add(dataReader.GetInt32(1));
                    }

                    dataReader.Close();
                
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }

           
            return (productos, cantidadVen); //retonamos los arrays ya cargados en caso de que la consulta haya salido bien sino estaran vacios
        }

        public negocioEstadistica obtenerDatosNegocioEstadisticas(int mes) //le paso el mes que quiero que me obtenga los datos del negocio
        {
            //le paso cadena de la clase conexion , con using me garantizo la liberacion adecuada de los recursos que ya no son necesarios
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de excepeciones que peude ocurrir al momento de usar la Base de datos
                try
                {
                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_DATOSDELNEGOCIOPORMES", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_DATOSDELNEGOCIOPORMES) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@mes", mes);

                    //declaramos ls parametros de salida que tiene este procedimiento es decir el resultado de esa operacion 
                    SqlParameter nroVentas = new SqlParameter("@nroVentas", SqlDbType.Int);
                    SqlParameter totalRecaudado = new SqlParameter("@totalRecaudado", SqlDbType.Float);
                    SqlParameter nroClientes = new SqlParameter("@nroClientes", SqlDbType.Float);
                    SqlParameter nroEmpleado = new SqlParameter("@nroEmpleado", SqlDbType.Int);
                    SqlParameter nroProveedores = new SqlParameter("@nroProveedores", SqlDbType.Int);
                    SqlParameter nroProductos = new SqlParameter("@nroProductos", SqlDbType.Int);
                    SqlParameter totalStock = new SqlParameter("@totalStock", SqlDbType.Int);
                    SqlParameter estadoStock = new SqlParameter("@estadoStock", SqlDbType.VarChar, 20);

                    // Se establece que los parametros seran utilizados para recoger los resultados generados por la base de datos
                    nroVentas.Direction = ParameterDirection.Output;
                    totalRecaudado.Direction = ParameterDirection.Output;
                    nroClientes.Direction = ParameterDirection.Output;
                    nroEmpleado.Direction = ParameterDirection.Output;
                    nroProveedores.Direction = ParameterDirection.Output;
                    nroProductos.Direction = ParameterDirection.Output;
                    totalStock.Direction = ParameterDirection.Output;
                    estadoStock.Direction = ParameterDirection.Output;

                    // Se agregan los parametros al comando, los cuales utilizara para recoger los datos
                    cmd.Parameters.Add(nroVentas);
                    cmd.Parameters.Add(totalRecaudado);
                    cmd.Parameters.Add(nroClientes);
                    cmd.Parameters.Add(nroEmpleado);
                    cmd.Parameters.Add(nroProveedores);
                    cmd.Parameters.Add(nroProductos);
                    cmd.Parameters.Add(totalStock);
                    cmd.Parameters.Add(estadoStock);

                    // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //ejcutamos nuestro comando
                    cmd.ExecuteNonQuery();

                    //asignamos los resultados obtenidos de la base de datos en mi obj negocioEstadistica
                    return new negocioEstadistica()
                    {
                        nroVentas=Convert.ToInt32(cmd.Parameters["@nroVentas"].Value),
                        totalRecaudado = Convert.ToSingle(cmd.Parameters["@totalRecaudado"].Value),
                        nroClientes = Convert.ToInt32(cmd.Parameters["@nroClientes"].Value),
                        nroEmpleado = Convert.ToInt32(cmd.Parameters["@nroEmpleado"].Value),
                        nroProveedores = Convert.ToInt32(cmd.Parameters["@nroProveedores"].Value),
                        nroProductos = Convert.ToInt32(cmd.Parameters["@nroProductos"].Value),
                        totalStock = Convert.ToInt32(cmd.Parameters["@totalStock"].Value),
                        estadoStock = cmd.Parameters["@estadoStock"].Value.ToString()
                    };

                }
                catch (Exception ex)
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }
            return null;//en caso de que no obtenga los datos de laBD retrna un objeto nulo
        }
    }
}
