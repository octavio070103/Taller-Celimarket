using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using capaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CD_Rol
    {

        public List<rol> ListarRol()
        {
            List<rol> listaRol = new List<rol>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    // hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    //2da forma para realizar una consulta utilizando un obj mejorando el enfoque y es mas dinamico
                    //creamo un obj query de tipo StringBuilder para cosntruit la consulta SQL
                    StringBuilder query = new StringBuilder();
                    //se agrega la consulta a query usando el método AppendLine
                    query.AppendLine("SELECT id_rol, nombre_rol FROM rol");

                    //creo un obj cmd de tipo sqlcommand este objeto se utiliza para ejecutar comandos SQL en la base de datos. 
                    //Toma dos argumentos: la consulta SQL query(que la construimos como una cadena con el toString) o consulta nueva que se ejecutará y la conexión a la base de datos s decir el nuestro obj de tipo sql conenectrion que creamois llamado objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.
                                        //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader dr = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    { 
                        while (dr.Read())
                        {
                            //creo una lista de rol donde me va servir para ir agregrando cada rol en un obj proveniente de mi BD
                            listaRol.Add(new rol
                            {
                                id_rol = Convert.ToInt32(dr["id_rol"]),
                                nombre_rol = dr["nombre_rol"].ToString()

                            }) ;
                        }
                    }// Al salir de este bloque, la conexión se cerrará automáticamente.


                }
                catch (Exception ex)                  
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error de conexión: " + ex.Message);
                    listaRol = new List<rol>();//aca decimos que si hubo un error que me retorne la lista como vacia
                }
            }
            return listaRol; // Devolvemos la listaRol con los obj cargados y sino se encontro nada vendra vacia

        }

        public int obtenerIDRolSeleccionada(string nombre_rol)
        {
            int id_RolObtenido = 0; // Inicializa la variable a devolverque va a contener el valor del id_rol obteneido apartir del nombre del rol

            using (SqlConnection obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    // Consulta SQL parametrizada
                    string query = "SELECT r.id_rol FROM rol r WHERE r.nombre_rol = @nombre_rol";

                    using (SqlCommand cmd = new SqlCommand(query, obj_conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_rol", nombre_rol);
                        obj_conexion.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id_RolObtenido = dr.GetInt32(0); // Lee el valor del primer campo (en este caso, id_categoria)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }

            return id_RolObtenido;
        }
    }
}
