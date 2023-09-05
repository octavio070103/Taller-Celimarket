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
        public List<usuario> listar()
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
                            //a mi lista d eusuario le estoy agregrando un usaurio
                            lista.Add(new usuario
                            {
                                id_usuario= Convert.ToInt32(dr["id_usuario"]),
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
                catch(Exception ex)
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error de conexión: " + ex.Message);
                    lista = new List<usuario>();
                }
            }
            return lista; // Devolvemos la lista de usuarios
        }
    }
}
