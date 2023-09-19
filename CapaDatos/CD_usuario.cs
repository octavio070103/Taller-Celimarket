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
using System.Net;
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
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT u.id_usuario, u.nombre, u.apellido, u.dni, u.email,u.password,u.telefono,u.estado_usuario, r.id_rol, r.descripcion_rol,d.id_domicilio,d.calle,d.numero,d.provincia");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM usuario u");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN rol r ON u.id_rol = r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio;");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
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
                              //  estado_usuario = Convert.ToBoolean(dr["estado_usuario"]),
                                estado_usuario = Convert.ToInt32(dr["estado_usuario"]),
                                //como los campos del rol que traigo con el INNER JOIN son de tipo rol los almaceno en ese tipo de obj que forma parte de  mi atributo de mi usuario
                                obj_rol =new rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    descripcion_rol = dr["descripcion_Rol"].ToString(),
                                },

                                obj_domicilio=new domicilio()
                                {
                                    id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                    calle = dr["calle"].ToString(),
                                    numero= Convert.ToInt32(dr["numero"]),
                                    provincia = dr["provincia"].ToString()                
                                }

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
                                // estado_usuario = Convert.ToBoolean(dr["estado_usuario"]),
                                estado_usuario = Convert.ToInt32(dr["estado_usuario"]),
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

        public usuario buscarUsuario(int id_usuario)
        {
            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                { 
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT u.id_usuario, u.nombre, u.apellido, u.dni, u.email,u.password,u.telefono,u.estado_usuario, r.id_rol, r.descripcion_rol,d.id_domicilio,d.calle,d.numero,d.provincia ");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM usuario u");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN rol r ON u.id_rol = r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio
                    query.AppendLine("WHERE id_usuario = @id_usuario; ");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
 
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
                                estado_usuario = Convert.ToInt32(dr["estado_usuario"]),

                                //como los campos del rol que traigo con el INNER JOIN son de tipo rol los almaceno en ese tipo de obj que forma parte de  mi atributo de mi usuario
                                obj_rol = new rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    descripcion_rol = dr["descripcion_Rol"].ToString(),
                                },

                                obj_domicilio = new domicilio()
                                {
                                    id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                    calle = dr["calle"].ToString(),
                                    numero = Convert.ToInt32(dr["numero"]),
                                    provincia = dr["provincia"].ToString()
                                }

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

        public int registrarUsuario(usuario obj_usuario,out string mensaje) //mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            int id_usuario_generado = 0;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca

            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@nombre", obj_usuario.nombre);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@apellido", obj_usuario.apellido);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@dni", obj_usuario.dni);
                        cmd.Parameters.AddWithValue("@email", obj_usuario.email);
                        cmd.Parameters.AddWithValue("@password", obj_usuario.password);//cambiar este por un metodo que haga el has es decir pasarle a registraUSuario la contrase;a pero con el hash aplicado
                        cmd.Parameters.AddWithValue("@telefono", obj_usuario.telefono);
                        cmd.Parameters.AddWithValue("@id_rol", obj_usuario.obj_rol.id_rol);
                        cmd.Parameters.AddWithValue("@id_domicilio", obj_usuario.obj_domicilio.id_domicilio);
                        cmd.Parameters.AddWithValue("@estado_usuario", obj_usuario.estado_usuario);
                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@id_Usuario_resultado", SqlDbType.Int).Direction=ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_usuario_generado = Convert.ToInt32(cmd.Parameters["@id_Usuario_resultado"].Value);

                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                        Console.WriteLine("Error de conexión: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                id_usuario_generado = 0;
                mensaje= ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return id_usuario_generado;
        }

        public bool editarUsuario(usuario obj_usuario, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            bool respuesta = false;
            mensaje= string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                   
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@id_usuario", obj_usuario.id_usuario);
                        cmd.Parameters.AddWithValue("@nombre", obj_usuario.nombre);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@apellido", obj_usuario.apellido);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@dni", obj_usuario.dni);
                        cmd.Parameters.AddWithValue("@email", obj_usuario.email);
                        cmd.Parameters.AddWithValue("@password", obj_usuario.password);//cambiar este por un metodo que haga el has es decir pasarle a registraUSuario la contrase;a pero con el hash aplicado
                        cmd.Parameters.AddWithValue("@telefono", obj_usuario.telefono);
                        cmd.Parameters.AddWithValue("@id_rol", obj_usuario.obj_rol.id_rol);
                        cmd.Parameters.AddWithValue("@id_domicilio", obj_usuario.obj_domicilio.id_domicilio);
                        cmd.Parameters.AddWithValue("@estado_usuario", obj_usuario.estado_usuario);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

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
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

        /************************************************ELIMINAR USUARIO POR COMPLETO DE LA BASE DE DATOS BAJA FISICA*********************************************/

        public bool eliminarUsuarioFisica(usuario obj_usuario, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@id_usuario", obj_usuario.id_usuario);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);

                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();//aca se guarda el msj de error que nos da el proc almacenado 
                    }
                    catch (Exception ex)
                    {
                        // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                        Console.WriteLine("Error de conexión: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

    }
}