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
    public class CD_Negocio
    {
        public negocio obtenerDatosNegocio()
        {
            negocio obj_negocio = new negocio();

            try
            {
                using (SqlConnection conexion = new SqlConnection(CD_conexion.cadena))
                {
                    conexion.Open();

                    string query = "SELECT id_negocio,nombre_negocio,CUIT,direccion,telefono,email_negocio from Negocio WHERE id_negocio=1 ";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr =cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj_negocio = new negocio()
                            {
                                id_negocio = Convert.ToInt32(dr["id_negocio"]),
                                nombre_negocio = dr["nombre_negocio"].ToString(),
                                direccion_negocio = dr["direccion"].ToString(),
                                CUIT = dr["CUIT"].ToString(),
                                telefono_negocio = dr["telefono"].ToString(),
                                email_negocio = dr["email_negocio"].ToString()

                            };

                        }

                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            return obj_negocio;//retornamos el objeto obtenido de la consulta 
        }


        public bool guardarDatosNegocio(negocio obj_negocio,out string mensaje)
        {
            mensaje =string.Empty; //seteo mi var mensaje de salida
            bool respuesta = true;
            try
            {
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Negocio SET nombre_negocio=@nombre_negocio ,");
                    query.AppendLine("SET direccion =direccion_negocio,");
                    query.AppendLine("SET CUIT =@CUIT,");
                    query.AppendLine("SET telefono= @telefono_negocio,");
                    query.AppendLine("SET email_negocio=@email_negocio");
                    query.AppendLine("WHERE id_negocio=1");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);

                    //le paso un valor(nombre_negocio que traigo como parametro) al paraemtro @nombre_negocio de m iconsulta y asi para realizar el query
                    cmd.Parameters.AddWithValue("@nombre_negocio", obj_negocio.nombre_negocio);
                    cmd.Parameters.AddWithValue("@direccion_negocio", obj_negocio.direccion_negocio);
                    cmd.Parameters.AddWithValue("@CUIT", obj_negocio.CUIT);
                    cmd.Parameters.AddWithValue("@telefono_negocio", obj_negocio.telefono_negocio);
                    cmd.Parameters.AddWithValue("@email_negocio", obj_negocio.email_negocio);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //aca pregunto si el numero de fila que me devuelve mi consulta en <1 es decir que no me actulizo que me muestre el sig mensaje
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos, Intente de nuevo";
                        respuesta = false;
                    }

                }

            }
            catch (Exception ex)
            {
                mensaje = "Error al ejecutar la consulta: " + ex.Message;
                respuesta = false;
            }
            return respuesta;
        }

        //al logo como es una img l ovoy a tratar como un array de bytes,lo voy a convertir el logo en un array de bytes
        public byte[] obtenerLogoNegocio(out bool obtenido) //este parametro de salida de tipo bool nos va a permitir saber de verda si se pudo obtener el logo
        {
            obtenido = true;
            byte[] logoBytes = new byte[0]; //inicializo el tamanio de mi array en 0 
            try
            {
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    Obj_conexion.Open();
                    string query = "SELECT logo from Negocio WHERE id_negocio=1 ";
                    SqlCommand cmd = new SqlCommand(query, Obj_conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            logoBytes = (byte[])dr["logo"]; //convierto el resultado que lo leo de la base de datos

                        }

                    }

                }

            }
            catch (Exception ex)
            {
                logoBytes= new byte[0]; //aca le asigno un tamnio de 0 en caso de que ocurra una excepcion y obtenido =false es decir que nose pudo obtener el logo
                obtenido = false;
            }
            return logoBytes;
        }

        public bool ActualizarLogoNegocio(byte[] imagenLogo, out string mensaje)
        {
            mensaje =string.Empty;
            bool respuesta = true;
            try
            {
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Negocio SET logo=@logo ");
                    query.AppendLine("WHERE id_negocio=1");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);

                    //le paso un valor(imageLogo que traigo como parametro) al paraemtro @nombre_negocio de m iconsulta y asi para realizar el query
                    cmd.Parameters.AddWithValue("@logo", imagenLogo);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //aca pregunto si el numero de fila que me devuelve mi consulta en <1 es decir que no me actulizo que me muestre el sig mensaje
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo Actualizar el logo, Intente de nuevo";
                        respuesta = false;
                    }

                }

            }
            catch (Exception ex)
            {
                mensaje = "Error al ejecutar la consulta: " + ex.Message;
                respuesta = false;
            }

            return respuesta;   
        }

    }
}
