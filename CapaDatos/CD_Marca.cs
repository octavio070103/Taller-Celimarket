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
    public class CD_Marca
    {
        public List<marca> listarMarcas()
        {
            List<marca> lista = new List<marca>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT m.Id_marca,m.Nombre,m.fecha_creacion");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM Marca m");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de usuario le estoy agregrando un usaurio
                            lista.Add(new marca
                            {
                                id_marca = Convert.ToInt32(dr["Id_marca"]),
                                nombre_marca = dr["Nombre"].ToString(),
                                fecha_creacion_marca= dr.GetDateTime(dr.GetOrdinal("fecha_creacion"))

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return lista; // Devolvemos la lista de usuarios
        }

        public int obtenerIDMarcaSeleccionada(string nombre_marca)
        {
            int id_MarcaObtenido = 0; // Inicializa la variable a devolver

            using (SqlConnection obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    // Consulta SQL parametrizada
                    string query = "SELECT m.id_marca FROM Marca m WHERE m.Nombre = @nombre_marca";

                    using (SqlCommand cmd = new SqlCommand(query, obj_conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_marca", nombre_marca);
                        obj_conexion.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id_MarcaObtenido = dr.GetInt32(0); // Lee el valor del primer campo (en este caso, id_categoria)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }

            return id_MarcaObtenido;
        }
    }
}
