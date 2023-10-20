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
    public class CD_Permiso
    {
        public List<motivo_permiso> listaMotivosPermisos()
        {
            List<motivo_permiso> lista = new List<motivo_permiso>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT m.id_motivo_permiso,m.nombre_motivo_permiso");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM Motivo_permiso m");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.

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
                            lista.Add(new motivo_permiso
                            {
                                id_motivo_permiso = Convert.ToInt32(dr["id_motivo_permiso"]),
                                nombre_motivo_permiso = dr["nombre_motivo_permiso"].ToString(),
                                

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
        public int registrarPermiso(permiso obj_permiso,out string mensaje )
        {
            int id_permiso_generado = 0;
            mensaje = string.Empty;

            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARPERMISO", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARPERMISO) que defini en mi BD para registrar el permiso y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@tipo_permiso", obj_permiso.tipo_permiso);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@fecha_iniciio", obj_permiso.fecha_inicio);
                        cmd.Parameters.AddWithValue("@fecha_finalizacion", obj_permiso.fecha_finalizacion);
                        cmd.Parameters.AddWithValue("@comentario_justificacion", obj_permiso.comentario_justifiacion);
                        cmd.Parameters.AddWithValue("@estado_aprobacion", obj_permiso.estado_aprobacion);
                        cmd.Parameters.AddWithValue("@estado_permiso", obj_permiso.estado_permiso);
                        cmd.Parameters.AddWithValue("@id_usuario", obj_permiso.obj_usuario);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@id_resultado_permiso", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_permiso_generado = Convert.ToInt32(cmd.Parameters["@id_resultado_permiso"].Value); //como es un entero debo de convertir el valor que me devuelve a int

                        mensaje = cmd.Parameters["@mensaje"].Value.ToString(); //asignamos el valor de salida que me da el proc alm de @mensaje a mi var mensaje
                    }
                    catch (Exception ex)
                    {
                        // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                        Console.WriteLine("Error de conexión: " + ex.Message);                     
                    }
                }

            }catch(Exception ex)
            {
                id_permiso_generado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }



            return id_permiso_generado;
        }


    }
}
