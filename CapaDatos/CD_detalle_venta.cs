using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_detalle_venta
    {   
        public void registrarDetalleVenta(List<detalle_venta> listaDetalleVenta, out string mensajeResultado)
        {

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                mensajeResultado = "";

                try
                {
                    foreach (detalle_venta objDetalleVenta in listaDetalleVenta) // borrar si no sirve
                    {
                        SqlCommand comando = new SqlCommand("SP_RegistrarDetalleVenta", objConexion);

                        //*** PARAMETROS DE ENTRADA ***
                        //comando.Parameters.AddWithValue("@id_detalle_venta", objDetalleVenta.id_detalle_venta);
                        comando.Parameters.AddWithValue("@cantidad_detalle_venta", objDetalleVenta.cantidad_detalle_venta);
                        comando.Parameters.AddWithValue("@precio_detalle_venta", objDetalleVenta.precio_detalle_venta);
                        comando.Parameters.AddWithValue("@subtotal_detalle_venta", objDetalleVenta.subtotal_detalle_venta);
                        comando.Parameters.AddWithValue("@id_producto", objDetalleVenta.id_producto);
                        comando.Parameters.AddWithValue("@id_venta", objDetalleVenta.id_venta);
                        comando.Parameters.AddWithValue("@fecha_creacion_detalle_venta", objDetalleVenta.fecha_creacion_detalle_venta);
                        

                        //*** PARAMETROS DE SALIDA ***
                        // Parametros para las salidas generadas por el procedimiento almacenado
                        SqlParameter resultadoSalida = comando.Parameters.Add("@resultadoEjec", SqlDbType.VarChar, 500);

                        // Se establece que la variable 'resultadoEjec' es un parametro de salida que almacenara el
                        // resultado que genere el procedimiento almacenado
                        resultadoSalida.Direction = ParameterDirection.Output;

                        // Se establece que el comando a ejecutar es del tipo procedimiento almacenado
                        comando.CommandType = CommandType.StoredProcedure;

                        // Se abre la conexion con la base de datos
                        objConexion.Open();

                        // Se ejecuta el procedimiento almacenado
                        comando.ExecuteNonQuery();

                        // Obtenemos las salidas generadas por la ejecucion del procedimiento almacenado
                        mensajeResultado = comando.Parameters["@resultadoEjec"].Value.ToString();
                    }


                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }

            }

        }

    }
}
