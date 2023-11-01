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
using System.Reflection.PortableExecutable;
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
                    query.AppendLine("SELECT u.id_usuario, u.email,u.password,u.estado_usuario,u.fecha_creacion_usuario," +
                        "p.id_persona,p.dni,p.nombre,p.apellido,p.fecha_nacimiento,p.telefono," +
                        "r.id_rol, r.nombre_rol," +
                        "d.id_domicilio,d.localidad,d.codigo_postal,d.provincia,d.numero,d.calle,d.descripcion_domicilio");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM usuario u");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN persona p ON u.id_persona = p.id_persona");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN rol r ON u.id_rol = r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio;");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio

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
                            lista.Add(new usuario
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),                              
                                email = dr["email"].ToString(),
                                password = dr["password"].ToString(),
                                estado_usuario = Convert.ToInt32(dr["estado_usuario"]),
                                fecha_registro = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_usuario")),

                                //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo persona los debo de alamcenar en ese tipo de obj persona que formara parte de mi atributo usuario
                                obj_persona = new persona()
                                 {
                                     id_persona= Convert.ToInt32(dr["id_persona"]),
                                     dni = dr["dni"].ToString(),
                                     nombre = dr["nombre"].ToString(),
                                     apellido = dr["apellido"].ToString(),
                                     fecha_nacimiento = dr.GetDateTime(dr.GetOrdinal("fecha_nacimiento")),
                                     telefono = dr["telefono"].ToString()
                                 },
                                //como los campos del rol que traigo con el INNER JOIN son de tipo rol los almaceno en ese tipo de obj que forma parte de  mi atributo de mi usuario
                                obj_rol =new rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    nombre_rol = dr["nombre_rol"].ToString(),
                                },

                                obj_domicilio=new domicilio()
                                {
                                    id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                    codigo_postal = Convert.ToInt32(dr["codigo_postal"]),
                                    localidad = dr["localidad"].ToString(),
                                    provincia = dr["provincia"].ToString(),
                                    numero = Convert.ToInt32(dr["numero"]),
                                    calle = dr["calle"].ToString(),
                                    descripcion = dr["descripcion_domicilio"].ToString(),
                                }

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



        //revisar
        public usuario AutenticarUsuario(string dni, string password)
        {
            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();
                    //Define una cadena de consulta SQL que se utilizará para seleccionar datos de la tabla usuario en la base de datos.selecionando las colunasaz
                    //ver que @dni y @password se defininen como marcadores de posición en lugar de valores concretos. y lego en cmd.paramereters le asigno un valor especifico o real
                    //string query = "SELECT id_usuario, nombre, apellido, dni, email, password, telefono, estado_usuario  FROM usuario WHERE dni = @dni ";
                    
                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio,p para persona y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                                   
                    query.AppendLine("SELECT u.id_usuario, u.email, u.password, u.estado_usuario,u.fecha_creacion_usuario,");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("p.id_persona, p.dni, p.nombre, p.apellido, p.fecha_nacimiento, p.telefono,");
                    query.AppendLine("r.id_rol, r.nombre_rol,");
                    query.AppendLine("d.id_domicilio,d.localidad,d.provincia,d.numero,d.calle,d.descripcion_domicilio");
                    query.AppendLine("FROM usuario u"); // aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN persona p ON u.id_persona = p.id_persona");
                    query.AppendLine("INNER JOIN rol r ON u.id_rol = r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN domicilio d ON u.id_domicilio = d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio
                    query.AppendLine("WHERE dni = @dni;");
                   

                    //creo un obj cmd de tipo sqlcommand este objeto se utiliza para ejecutar comandos SQL en la base de datos. 
                    //Toma dos argumentos: la consulta SQL query o consulta nueva que se ejecutará y la conexión a la base de datos s decir el nuestro obj de tipo sql conenectrion que creamois llamado objConexion 
                    // SqlCommand cmd = new SqlCommand(query, Obj_conexion);

                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //agregan parámetros a la consulta SQL. Los valores de @dni y @password se asignan a los valores de dni y password proporcionados como argumentos al método.
                    //Esto se hace para evitar la inyección de SQL y garantizar que los valores se utilicen de manera segura en la consulta.
                    cmd.Parameters.AddWithValue("@dni", dni);
                    // cmd.Parameters.AddWithValue("@password", password);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader dr = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {
                        //Este condicional verifica si hay al menos una fila de resultados en el SqlDataReader.
                        //Si es así, significa que se encontró un usuario con el dni y password proporcionados que coinciden en la base de datos.
                        if (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay
                        {
                            /* Obtener la contraseña cifrada almacenada en la base de datos*/
                            // string contrasenaCifrada = dr.GetString("ContraseñaUsuario");
                            string hashAlmacenado = dr["password"].ToString(); // Obtener el hash almacenado en la base de datos
                                                                               // Verificamos la contraseña proporcionada después de aplicar el hash y la sal
                            bool contrasenaValida =password== hashAlmacenado; //BCrypt.Net.BCrypt.Verify(password, hashAlmacenado);//("hola", "$2a$11$LfnTies.qV/kGdEomUxkTeoMTN5Ik1WC0tNhD6kcQCXN0QPxt2vZC");//(password, hashAlmacenado);

                            if (contrasenaValida)
                            {
                                //creo un objeto usuario y cargo en cada atributo del objeto usuario los datos recuperados de la consulta dr.read()
                                return new usuario
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    email = dr["email"].ToString(),
                                    password = dr["password"].ToString(),
                                    estado_usuario = Convert.ToInt32(dr["estado_usuario"]),
                                    fecha_registro = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_usuario")),

                                    //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo persona los debo de alamcenar en ese tipo de obj persona que formara parte de mi atributo usuario
                                    obj_persona = new persona()
                                    {
                                        id_persona = Convert.ToInt32(dr["id_persona"]),
                                        dni = dr["dni"].ToString(),
                                        nombre = dr["nombre"].ToString(),
                                        apellido = dr["apellido"].ToString(),
                                        fecha_nacimiento = dr.GetDateTime(dr.GetOrdinal("fecha_nacimiento")),
                                        telefono = dr["telefono"].ToString()
                                    },
                                    //como los campos del rol que traigo con el INNER JOIN son de tipo rol los almaceno en ese tipo de obj que forma parte de  mi atributo de mi usuario
                                    obj_rol = new rol()
                                    {
                                        id_rol = Convert.ToInt32(dr["id_rol"]),
                                        nombre_rol = dr["nombre_rol"].ToString(),
                                    },

                                    obj_domicilio = new domicilio()
                                    {
                                        id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                        localidad = dr["localidad"].ToString(),
                                        provincia = dr["provincia"].ToString(),
                                        numero = Convert.ToInt32(dr["numero"]),
                                        calle = dr["calle"].ToString(),
                                        descripcion= dr["descripcion_domicilio"].ToString(),

                                    }
                                    // estado_usuario = Convert.ToBoolean(dr["estado_usuario"]),
                                    //obj_id_rol = new rol { IdRol = Convert.ToInt32(dr["rol_id"]) }

                                };
                            }

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
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio,p para persona y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT u.id_usuario,u.email,u.password,u.estado_usuario,u.fecha_creacion_usuario,");
                    query.AppendLine("p.id_persona,p.dni,p.nombre, p.apellido,p.fecha_nacimiento,p.telefono,");                  
                    query.AppendLine("r.id_rol, r.nombre_rol,");
                    query.AppendLine("d.id_domicilio,d.codigo_postal,d.localidad,d.provincia,d.numero,d.calle,d.descripcion_domicilio");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM usuario u");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN persona p ON u.id_persona = p.id_persona");
                    query.AppendLine("INNER JOIN rol r ON u.id_rol = r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio
                    query.AppendLine("WHERE id_usuario = @id_usuario; ");//esta consulta se utiliza para filtrar(buscar) la fila en la tabla usuario  y solo realice esas operacion en aquel registro que su campo id_uusario coinidice con el parametro @id_usuario

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
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
                                email = dr["email"].ToString(),
                                password = dr["password"].ToString(),
                                estado_usuario = Convert.ToInt32(dr["estado_usuario"]),
                                fecha_registro = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_usuario")),

                                //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo persona los debo de alamcenar en ese tipo de obj persona que formara parte de mi atributo usuario
                                obj_persona = new persona()
                                {
                                    id_persona = Convert.ToInt32(dr["id_persona"]),
                                    dni = dr["dni"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString(),
                                    fecha_nacimiento = dr.GetDateTime(dr.GetOrdinal("fecha_nacimiento")),
                                    telefono = dr["telefono"].ToString()
                                },
                                //como los campos del rol que traigo con el INNER JOIN son de tipo rol los almaceno en ese tipo de obj que forma parte de  mi atributo de mi usuario
                                obj_rol = new rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    nombre_rol = dr["nombre_rol"].ToString(),
                                },

                                obj_domicilio = new domicilio()
                                {
                                    id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                    codigo_postal = Convert.ToInt32(dr["codigo_postal"]),
                                    localidad = dr["localidad"].ToString(),
                                    provincia = dr["provincia"].ToString(),
                                    numero = Convert.ToInt32(dr["numero"]),
                                    calle = dr["calle"].ToString(),
                                    descripcion = dr["descripcion_domicilio"].ToString(),
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

        public int registrarUsuario(usuario obj_usuario, out string mensaje) //mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
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
                        cmd.Parameters.AddWithValue("@dni", obj_usuario.obj_persona.dni);
                        cmd.Parameters.AddWithValue("@nombre", obj_usuario.obj_persona.nombre);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@apellido", obj_usuario.obj_persona.apellido);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", obj_usuario.obj_persona.fecha_nacimiento);
                        cmd.Parameters.AddWithValue("@telefono",obj_usuario.obj_persona.telefono);
                        cmd.Parameters.AddWithValue("@email", obj_usuario.email);
                        cmd.Parameters.AddWithValue("@password", obj_usuario.password);//cambiar este por un metodo que haga el has es decir pasarle a registraUSuario la contrase;a pero con el hash aplicado
                        cmd.Parameters.AddWithValue("@estado_usuario", obj_usuario.estado_usuario);
                        cmd.Parameters.AddWithValue("@id_rol", obj_usuario.obj_rol.id_rol);
                        cmd.Parameters.AddWithValue("@id_domicilio", obj_usuario.obj_domicilio.id_domicilio);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@id_Usuario_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

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
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
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
                        cmd.Parameters.AddWithValue("@dni", obj_usuario.obj_persona.dni);
                        cmd.Parameters.AddWithValue("@nombre", obj_usuario.obj_persona.nombre);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@apellido", obj_usuario.obj_persona.apellido);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", obj_usuario.obj_persona.fecha_nacimiento);
                        cmd.Parameters.AddWithValue("@telefono", obj_usuario.obj_persona.telefono);
                        cmd.Parameters.AddWithValue("@email", obj_usuario.email);
                        cmd.Parameters.AddWithValue("@password", obj_usuario.password);//cambiar este por un metodo que haga el has es decir pasarle a registraUSuario la contrase;a pero con el hash aplicado
                        cmd.Parameters.AddWithValue("@estado_usuario", obj_usuario.estado_usuario);
                        cmd.Parameters.AddWithValue("@id_rol", obj_usuario.obj_rol.id_rol);
                        cmd.Parameters.AddWithValue("@id_domicilio", obj_usuario.obj_domicilio.id_domicilio);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output; // le paso el tamnio del parametro mensaje como en mi proc lo def asi

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
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

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

        public bool eliminarUsuarioLogico(usuario obj_usuario, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {

            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIOLOGICO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_ELIMINARUSUARIOLOGICO) que defini en mi BD para dar de baja el usuario y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_usuario", obj_usuario.id_usuario);


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
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;

        }

        public bool darDeAltaUsuario(usuario obj_usuario, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_DARALTAUSUARIO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_usuario", obj_usuario.id_usuario);


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
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

        //obtengo una lista de usuario que depende del tipo de filtro(atributo) y del valor que tiene el mismo (p_txtFIltro)
        public List<usuario> listarUsuariosFIltrados(string p_txtFIltro, string atributo)
        {
            List<usuario> listafiltrada = new List<usuario>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT u.id_usuario, u.email,u.password,u.estado_usuario,u.fecha_creacion_usuario," +
                        "p.id_persona,p.dni,p.nombre,p.apellido,p.fecha_nacimiento,p.telefono," +
                        "r.id_rol, r.nombre_rol," +
                        "d.id_domicilio,d.localidad,d.codigo_postal,d.provincia,d.numero,d.calle,d.descripcion_domicilio");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM usuario u");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN persona p ON u.id_persona = p.id_persona");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN rol r ON u.id_rol = r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN domicilio d On u.id_domicilio=d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio

                    //con este if verifico que no sea null el filtro 
                    if (!string.IsNullOrEmpty(p_txtFIltro) && !string.IsNullOrEmpty(atributo))
                    {
                        // Añade la condición de filtrado según el atributo
                        switch (atributo)
                        {
                            case "dni":
                                query.Append("WHERE p.dni LIKE @filtro");
                                break;
                            case "nombre":
                                query.Append("WHERE p.nombre LIKE @filtro");
                                break;
                            case "apellido":
                                query.Append("WHERE p.apellido LIKE @filtro");
                                break;
                            case "rol_usuario":
                                query.Append("WHERE r.id_rol = "+ p_txtFIltro);
                                break;
                            case "estado_usuario":
                                    query.Append("WHERE u.estado_usuario = "+ p_txtFIltro);
                                break;

                            default:
                                // Manejar un atributo desconocido si es necesario.
                                break;
                        }
                    }

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;

                    // creo un parametro llamado filtro y le asigno el valor por el que quiero filtrar,rodeada por símbolos %, lo que significa que la consulta buscará todas las filas en las que el valor de la columna cumple con la condición "contiene" el valor de p_txtFIltro
                    if (!string.IsNullOrEmpty(p_txtFIltro)&& atributo != "estado_usuario" && atributo != "rol_usuario") //si el atirbuto a filtrar es el estaod o el rol que no entre al if ya que a este le paso directamente el valor del filtro
                    {
                        cmd.Parameters.Add(new SqlParameter("@filtro", "%" + p_txtFIltro + "%")); //aca le paso el valor a mi parametro  @filtro que cree
                    }
                
                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de usuario le estoy agregrando un usaurio
                            listafiltrada.Add(new usuario
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                email = dr["email"].ToString(),
                                password = dr["password"].ToString(),
                                estado_usuario = Convert.ToInt32(dr["estado_usuario"]),
                                fecha_registro = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_usuario")),

                                //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo persona los debo de alamcenar en ese tipo de obj persona que formara parte de mi atributo usuario
                                obj_persona = new persona()
                                {
                                    id_persona = Convert.ToInt32(dr["id_persona"]),
                                    dni = dr["dni"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString(),
                                    fecha_nacimiento = dr.GetDateTime(dr.GetOrdinal("fecha_nacimiento")),
                                    telefono = dr["telefono"].ToString()
                                },
                                //como los campos del rol que traigo con el INNER JOIN son de tipo rol los almaceno en ese tipo de obj que forma parte de  mi atributo de mi usuario
                                obj_rol = new rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    nombre_rol = dr["nombre_rol"].ToString(),
                                },

                                obj_domicilio = new domicilio()
                                {
                                    id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                    codigo_postal = Convert.ToInt32(dr["codigo_postal"]),
                                    localidad = dr["localidad"].ToString(),
                                    provincia = dr["provincia"].ToString(),
                                    numero = Convert.ToInt32(dr["numero"]),
                                    calle = dr["calle"].ToString(),
                                    descripcion = dr["descripcion_domicilio"].ToString(),
                                }

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return listafiltrada; // Devolvemos la lista de usuarios filtrados
        }
    }
}