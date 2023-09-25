using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_domicilio
    {
        public int registrarDomicilio(domicilio obj_domicilio,out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            int id_domicilio_registrado = 0;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca

            try 
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARDOMICILIO", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARDOMICILIO) que defini en mi BD para registrar el domicilio y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@calle",obj_domicilio.calle);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@codigo_postal",obj_domicilio.codigo_postal);
                        cmd.Parameters.AddWithValue("@numero",obj_domicilio.numero);
                        cmd.Parameters.AddWithValue("@localidad",obj_domicilio.localidad);
                        cmd.Parameters.AddWithValue("@provincia",obj_domicilio.provincia);
                        cmd.Parameters.AddWithValue("@descripcion", obj_domicilio.descripcion);
                        cmd.Parameters.AddWithValue("@estado_domicilio", obj_domicilio.estado_domicilio);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@id_domicilio_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi variable de salidad de mi procedimiento almacenado
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_domicilio_registrado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_domicilio_registrado = Convert.ToInt32(cmd.Parameters["@id_domicilio_resultado"].Value);

                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                        Console.WriteLine("Error de conexión: " + ex.Message);
                    }
                }
            }
            catch(Exception ex) 
            {
                id_domicilio_registrado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }

            return id_domicilio_registrado;
        }
    }
}
