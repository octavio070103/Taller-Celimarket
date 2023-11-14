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
        public List<ProductosMasVendidosDelMes> obtenerProductosMasVendidos(int anio,int mes)
        {
           
            List<ProductosMasVendidosDelMes> listaProducMasVendiPorMes = new List<ProductosMasVendidosDelMes>();

            //le paso cadena de la clase conexion ,aca Se instancia una conexión a la base de datos.
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))// Se instancia un Obj_conexion que servira para establecer conexion con la base de datos
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("SELECT TOP 5 dtv.id_producto,p.nombre_producto,SUM(dtv.cantidad_detalle_venta) as cantProducVendido");
                    query.AppendLine("FROM detalle_venta dtv");
                    query.AppendLine("WHERE YEAR(dtv.fecha_creacion_detalle_venta)=@anio AND MONTH(dtv.fecha_creacion_detalle_venta) = @mes");// le paso la condicion de bsuqueda ,que me triaga los regsitros que conicidan con ese anio y ese mes y me los agrupe para poder obtener los datos que quiero
                    query.AppendLine("GROUP BY dtv.id_producto,p.nombre_producto");
                    query.AppendLine("ORDER BY SUM(dtv.cantidad_detalle_venta) DESC");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);

                    //le paso un valor al paraemtro @anio y mes para realizar la consulta
                    cmd.Parameters.AddWithValue("@anio", anio);
                    cmd.Parameters.AddWithValue("@mes", mes);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.



                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios...sqldataread  Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
                    using (SqlDataReader dataReader = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {
                        // Se cargan los resutados obtenidos de la bases de datos en los arraylist
                        while (dataReader.Read())
                        {
                            listaProducMasVendiPorMes.Add(new ProductosMasVendidosDelMes
                            {
                                id_producto = Convert.ToInt32(dataReader["id_producto"]),
                                cantProducVendido=Convert.ToInt32(dataReader["cantProducVendido"]),
                                nombre_producto = dataReader["nombre_producto"].ToString()
                            });
                         
                        }

                        dataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }


            return listaProducMasVendiPorMes; //retonamos los arrays ya cargados en caso de que la consulta haya salido bien sino estaran vacios
        }

        //creo un diccioanrio de datos para poder retornar los dos array que creo ,hago esto para no estar creando una clase ProductosMasVendidosque tenga de atributo estos dos array
        public (ArrayList DiaVenta, ArrayList cantidadVenPorDia) obtenerVentasDelMesPorDia(int anio,int mes)
        {
            ArrayList DiaVenta = new ArrayList(); //creo mi dos array que vna a contener el TOP5 de productos mas vendidos de mi BD y la cantidad de ventas que tuvieron
            ArrayList cantidadVenPorDia = new ArrayList();

            //le paso cadena de la clase conexion ,aca Se instancia una conexión a la base de datos.
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))// Se instancia un Obj_conexion que servira para establecer conexion con la base de datos
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("SELECT venta_fecha,COUNT(venta_fecha) as cantVentaPorDia");
                    query.AppendLine("from venta");
                    query.AppendLine("WHERE YEAR(venta_fecha)=@anio AND MONTH(venta_fecha) = @mes");// le paso la condicion de bsuqueda ,que me triaga los regsitros que conicidan con ese anio y ese mes y me los agrupe para poder obtener los datos que quiero
                    query.AppendLine("GROUP BY venta_fecha");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);

                    //le paso un valor al paraemtro @anio y mes para realizar la consulta
                    cmd.Parameters.AddWithValue("@anio", anio);
                    cmd.Parameters.AddWithValue("@mes", mes);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.



                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios...sqldataread  Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
                    using (SqlDataReader dataReader = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {   
                        // Se cargan los resutados obtenidos de la bases de datos en los arraylist
                        while (dataReader.Read())
                        {
                            DiaVenta.Add(Convert.ToDateTime(dataReader["venta_fecha"]));
                            cantidadVenPorDia.Add(Convert.ToInt32(dataReader["cantVentaPorDia"]));
                        }

                        dataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }


            return (DiaVenta, cantidadVenPorDia); //retonamos los arrays ya cargados en caso de que la consulta haya salido bien sino estaran vacios
        }

        //creo un diccioanrio de datos para poder retornar los dos array que creo ,hago esto para no estar creando una clase ProductosMasVendidosque tenga de atributo estos dos array
        public (ArrayList DiaVenta, ArrayList cantidadVenPorDia) obtenerStockProducPorCategor()
        {
            ArrayList DiaVenta = new ArrayList(); //creo mi dos array que vna a contener el TOP5 de productos mas vendidos de mi BD y la cantidad de ventas que tuvieron
            ArrayList cantidadVenPorDia = new ArrayList();

            //le paso cadena de la clase conexion ,aca Se instancia una conexión a la base de datos.
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))// Se instancia un Obj_conexion que servira para establecer conexion con la base de datos
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("SELECT venta_fecha,COUNT(venta_fecha) as cantVentaPorDia");
                    query.AppendLine("from venta");
                    query.AppendLine("GROUP BY venta_fecha");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);


                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.



                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios...sqldataread  Se almacenan los resultados obtenidos de ejecutar el procedimiento en la base de datos
                    using (SqlDataReader dataReader = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {
                        // Se cargan los resutados obtenidos de la bases de datos en los arraylist
                        while (dataReader.Read())
                        {
                            DiaVenta.Add(Convert.ToDateTime(dataReader["venta_fecha"]));
                            cantidadVenPorDia.Add(Convert.ToInt32(dataReader["cantVentaPorDia"]));
                        }

                        dataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }


            return (DiaVenta, cantidadVenPorDia); //retonamos los arrays ya cargados en caso de que la consulta haya salido bien sino estaran vacios
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
