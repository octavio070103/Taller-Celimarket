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
        /**********************************metodos para La tabla Permiso *******************************************/
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
                        cmd.Parameters.AddWithValue("@fecha_inicio", obj_permiso.fecha_inicio);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@fecha_finalizacion", obj_permiso.fecha_finalizacion);
                        cmd.Parameters.AddWithValue("@comentario_justificacion", obj_permiso.comentario_justificacion);
                        cmd.Parameters.AddWithValue("@estado_aprobacion", obj_permiso.estado_aprobacion);
                        cmd.Parameters.AddWithValue("@estado_permiso", obj_permiso.estado_permiso);
                        cmd.Parameters.AddWithValue("@id_usuario", obj_permiso.obj_usuario.id_usuario);
                        cmd.Parameters.AddWithValue("@id_motivo_permiso", obj_permiso.obj_motivo_permiso.id_motivo_permiso);

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

        public bool editarPermiso(permiso obj_permiso, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {


                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_EDITARPERMISO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_EDITARPERMISO) que defini en mi BD para editae el permiso y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_permiso", obj_permiso.id_permiso);
                    cmd.Parameters.AddWithValue("@fecha_inicio",obj_permiso.fecha_inicio);
                    cmd.Parameters.AddWithValue("@fecha_finalizacion",obj_permiso.fecha_finalizacion );//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                    cmd.Parameters.AddWithValue("@comentario_justificacion",obj_permiso.comentario_justificacion);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                    cmd.Parameters.AddWithValue("@estado_permiso",obj_permiso.estado_permiso);
                    cmd.Parameters.AddWithValue("@id_usuario", obj_permiso.obj_usuario.id_usuario);
                    cmd.Parameters.AddWithValue("@id_motivo_permiso", obj_permiso.obj_motivo_permiso.id_motivo_permiso);
                   
                    //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                    cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // le paso el tamnio del parametro mensaje como en mi proc lo def asi

                    // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //ejcutamos nuestro comando
                    cmd.ExecuteNonQuery();

                    //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);

                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();//aca se guarda el msj de error que nos da el proc almacenado 

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                Console.WriteLine("Error de conexión: " + ex.Message); //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

        public bool eliminarPermiso(permiso obj_permiso, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("DARBAJAPERMISO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(DARBAJAPERMISO) que defini en mi BD para dar de baja el permiso y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_permiso", obj_permiso.id_permiso);


                    //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                    cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // le paso el tamnio del parametro mensaje como en mi proc lo def asi

                    // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //ejcutamos nuestro comando
                    cmd.ExecuteNonQuery();

                    //asignamos el valor del repsuesta de mi proc almacenada que es de tipo boolean
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);

                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();//aca se guarda el msj de error o de exito que nos da el proc almacenado 

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

        public List<permiso> listarPermisos()
        {
            List<permiso> listaPermisos = new List<permiso>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla permiso y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (p para PRODUCTO,C para catgoria y m para amrca). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT p.id_permiso,p.fecha_inicio,p.fecha_finalizacion,p.comentario_justificacion,p.estado_aprobacion ,p.estado_permiso," +
                        "u.id_usuario,"+
                        "r.id_rol,r.nombre_rol,"+
                       "pers.id_persona,pers.dni,pers.nombre,pers.apellido,pers.telefono," +
                       "d.id_domicilio,d.numero,d.calle");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM permiso p");// aca le doy el alias p a la tabla de permiso y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN Motivo_permiso m ON p.id_motivo_permiso = m.id_motivo_permiso");//le doy el alias m, y realizo el INNER JOIN entre la tabla permiso y la tabla Motivo_permiso
                    query.AppendLine("INNER JOIN usuario u ON p.id_usuario=u.id_usuario");//le doy el alias u a usuario, y realizo el INNER JOIN entre la tabla permiso y la tabla usuario (que la usare para realizar un jopin y traer los demas datos que encesito mostrar)
                    query.AppendLine("INNER JOIN rol r ON u.id_rol=r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN persona pers ON u.id_persona = pers.id_persona");//le doy el alias pers, y realizo el INNER JOIN entre la tabla usuario y la tabla persona
                    query.AppendLine("INNER JOIN domicilio d ON u.id_domicilio= d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio
                   

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de permiso le estoy agregrando un usaurio
                            listaPermisos.Add(new permiso
                            {
                                id_permiso= Convert.ToInt32(dr["id_permiso"]),
                                fecha_inicio = Convert.ToDateTime(dr["fecha_inicio"]),
                                fecha_finalizacion = Convert.ToDateTime(dr["fecha_finalizacion"]),
                                comentario_justificacion = dr["comentario_justificacion"].ToString(),
                                estado_aprobacion = dr["estado_aprobacion"].ToString(),
                                estado_permiso = Convert.ToInt32(dr["estado_permiso"]),
                                
                                //como los datos del usuario que debo de traer al momento de hacer el INNER JOIN son de tipo usuario edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_permiso
                                obj_usuario =new usuario()
                                {
                                    id_usuario=Convert.ToInt32(dr["id_usuario"]),

                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo rol edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_rol = new rol()
                                    {
                                        id_rol = Convert.ToInt32(dr["id_rol"]),
                                        nombre_rol = dr["nombre_rol"].ToString(),
                                    },
                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo persona edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_persona = new persona()
                                    {
                                        id_persona = Convert.ToInt32(dr["id_persona"]),
                                        dni=dr["dni"].ToString(),
                                        nombre = dr["nombre"].ToString(),
                                        apellido = dr["apellido"].ToString(),
                                        telefono = dr["telefono"].ToString()
                                    },
                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo obj_domicilio edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_domicilio = new domicilio()
                                    {
                                        id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                        numero= Convert.ToInt32(dr["numero"]),
                                        calle = dr["calle"].ToString()
                                    }
                                    
                                },

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return listaPermisos; // Devolvemos la lista de productos que obtuvimos en la consulta
        }

        /**********************************metodos para La tabla Motivo Permiso *******************************************/
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

        public int obtenerIDMotivoPermisoSeleccionada(string nombre_motivo_permiso)
        {
            int id_motivoPermisoObtenido = 0; // Inicializa la variable a devolver

            using (SqlConnection obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    // Consulta SQL parametrizada
                    string query = "SELECT m.id_motivo_permiso FROM Motivo_permiso m WHERE nombre_motivo_permiso = @nombre_motivo_permiso";

                    using (SqlCommand cmd = new SqlCommand(query, obj_conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_motivo_permiso", nombre_motivo_permiso);
                        obj_conexion.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id_motivoPermisoObtenido = dr.GetInt32(0); // Lee el valor del primer campo (en este caso, id_producto)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);

                }
            }

            return id_motivoPermisoObtenido; //aca devuelvop el id obtenido de la consulta a la BD
        }
    }
}
