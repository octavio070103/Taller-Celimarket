using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using capaEntidad;
//librerias importante 

namespace CapaDatos
{
    public class CD_usuario
    {
        public List<usuario> listarUsuarios()
        {
            List<usuario> lista = new List<usuario>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    string query = "select id_usuario,nombre,apellido,dni,email,password,telefono,estado_usuario from usuario";

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query, Obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //a mi lista de usuario le estoy agregrando un usaurio
                            lista.Add(new usuario
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                dni = dr["dni"].ToString(),
                                email = dr["email"].ToString(),
                                password = dr["password"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado_usuario = Convert.ToBoolean(dr["estado_usuario"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                     
                }
            }
            return lista; // Devolvemos la lista de usuarios
        }

        public usuario AutenticarUsuario(string dni, string password)
        {
            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    //Define una cadena de consulta SQL que se utilizará para seleccionar datos de la tabla usuario en la base de datos.selecionando las colunasaz
                    //ver que @dni y @password se defininen como marcadores de posición en lugar de valores concretos. y lego en cmd.paramereters le asigno un valor especifico o real
                    string query = "SELECT id_usuario, nombre, apellido, dni, email, password, telefono, estado_usuario  FROM usuario WHERE dni = @dni AND password = @password";

                    //creo un obj cmd de tipo sqlcommand este objeto se utiliza para ejecutar comandos SQL en la base de datos. 
                    //Toma dos argumentos: la consulta SQL query o consulta nueva que se ejecutará y la conexión a la base de datos s decir el nuestro obj de tipo sql conenectrion que creamois llamado objConexion 
                    SqlCommand cmd = new SqlCommand(query, Obj_conexion);

                    //agregan parámetros a la consulta SQL. Los valores de @dni y @password se asignan a los valores de dni y password proporcionados como argumentos al método.
                    //Esto se hace para evitar la inyección de SQL y garantizar que los valores se utilicen de manera segura en la consulta.
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader dr = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {
                        //Este condicional verifica si hay al menos una fila de resultados en el SqlDataReader.
                        //Si es así, significa que se encontró un usuario con el dni y password proporcionados que coinciden en la base de datos.
                        if (dr.Read())
                        {
                            //creo un objeto usuario y cargo en cada atributo del objeto usuario los datos recuperados de la consulta dr.read()
                            return new usuario
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                dni = dr["dni"].ToString(),
                                email = dr["email"].ToString(),
                                password = dr["password"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado_usuario = Convert.ToBoolean(dr["estado_usuario"]),
                                //obj_id_rol = new rol { IdRol = Convert.ToInt32(dr["rol_id"]) }

                            };

                        }
                    }// Al salir de este bloque, la conexión se cerrará automáticamente.

                }
                catch (Exception ex)
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error de conexión: " + ex.Message);

                }
            }
            return null; // Devolvemos null si no se encontró el usuario
        }


    }
}