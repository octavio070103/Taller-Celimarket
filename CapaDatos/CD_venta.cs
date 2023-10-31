﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaEntidad;

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
                    idVentaRegistrada = (int)comando.Parameters["@IdNuevaVenta"].Value;
                    resultadoEjec = (int)comando.Parameters["@resultadoEjec"].Value;

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
