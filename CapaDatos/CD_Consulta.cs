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
    public class CD_Consulta
    {

        /**********************************metodos para La tabla Consulta *******************************************/
        public int registrarConsulta(consulta obj_consulta, out string mensaje)
        {
            int id_consulta_generado = 0;
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
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARCONSULTA", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARCONSULTA) que defini en mi BD para registrar la consulta y asi evitar la inyeccion de SQL
                        //no le peaso ni el estadop de la consulta ni la fecha porque tengo una cosntraint con valroes rpedeterminados ya 
                        cmd.Parameters.AddWithValue("@comentario_consulta", obj_consulta.comentario_consulta);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@id_usuario", obj_consulta.obj_usuario.id_usuario);
                        cmd.Parameters.AddWithValue("@id_motivo_consulta", obj_consulta.obj_motivo_consulta.id_motivo_consulta);
                    

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@id_resultado_consulta", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_consulta_generado = Convert.ToInt32(cmd.Parameters["@id_resultado_consulta"].Value); //como es un entero debo de convertir el valor que me devuelve a int

                        mensaje = cmd.Parameters["@mensaje"].Value.ToString(); //asignamos el valor de salida que me da el proc alm de @mensaje a mi var mensaje
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
                id_consulta_generado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return id_consulta_generado;
        }

        public bool editarConsulta(consulta obj_consulta, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {


                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_EDITARCONSULTA", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARCONSULTA) que defini en mi BD para registrar la consulta y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_consulta", obj_consulta.id_consulta);
                    cmd.Parameters.AddWithValue("@comentario_consulta", obj_consulta.comentario_consulta);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                    cmd.Parameters.AddWithValue("@estado_consulta", obj_consulta.estado_consulta);
                    cmd.Parameters.AddWithValue("@id_usuario", obj_consulta.obj_usuario.id_usuario);
                    cmd.Parameters.AddWithValue("@id_motivo_consulta", obj_consulta.obj_motivo_consulta.id_motivo_consulta);

                    //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacion
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


        public List<consulta> listarConsulta()
        {
            List<consulta> listaConsultas = new List<consulta>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla consulta y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (p para PRODUCTO,C para catgoria y m para amrca). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT c.id_consulta,c.comentario_consulta,c.estado_consulta,c.fecha_consulta," +
                        "m.id_motivo_consulta,m.nombre_motivo_consulta," +
                        "u.id_usuario,u.email," +
                        "r.id_rol,r.nombre_rol," +
                       "pers.id_persona,pers.dni,pers.nombre,pers.apellido,pers.telefono," +
                       "d.id_domicilio,d.numero,d.calle");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM consulta c");// aca le doy el alias c a la tabla de consulta y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN motivo_consulta m ON c.id_motivo_consulta = m.id_motivo_consulta");//le doy el alias m, y realizo el INNER JOIN entre la tabla consulta y la tabla Motivo_consulta
                    query.AppendLine("INNER JOIN usuario u ON c.id_usuario = u.id_usuario");//le doy el alias u a usuario, y realizo el INNER JOIN entre la tabla consulta y la tabla usuario (que la usare para realizar un jopin y traer los demas datos que encesito mostrar)
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
                            //a mi lista de consulta le estoy agregrando una consulta
                            listaConsultas.Add(new consulta
                            {
                                id_consulta = Convert.ToInt32(dr["id_consulta"]),
                                comentario_consulta = dr["comentario_consulta"].ToString(),
                                estado_consulta = dr["estado_consulta"].ToString(),
                                fecha_consulta = Convert.ToDateTime(dr["fecha_consulta"]),

                                //como los datos del usuario que debo de traer al momento de hacer el INNER JOIN son de tipo usuario edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_permiso
                                obj_usuario = new usuario()
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    email = dr["email"].ToString(),
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
                                        dni = dr["dni"].ToString(),
                                        nombre = dr["nombre"].ToString(),
                                        apellido = dr["apellido"].ToString(),
                                        telefono = dr["telefono"].ToString()
                                    },
                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo obj_domicilio edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_domicilio = new domicilio()
                                    {
                                        id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                        numero = Convert.ToInt32(dr["numero"]),
                                        calle = dr["calle"].ToString()
                                    }

                                },
                                obj_motivo_consulta = new motivo_consulta{
                                    id_motivo_consulta= Convert.ToInt32(dr["id_motivo_consulta"]),
                                    nombre_motivo_consulta = dr["nombre_motivo_consulta"].ToString()

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
            return listaConsultas; // Devolvemos la lista de consultas que obtuvimos en la consulta(query) que hicimos
        }


        //obtengo una lista de usuario que depende del tipo de filtro(atributo) y del valor que tiene el mismo (p_txtFIltro)
        public List<consulta> listarConsultaFiltrado(string p_txtFIltro, string atributo)
        {
            List<consulta> listafiltrada = new List<consulta>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (c=consulta,u=usuario,r=rol,p=persona,d=domicilio,m=motivo_consulta). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT c.id_consulta,c.comentario_consulta,c.estado_consulta,c.fecha_consulta," +
                        "m.id_motivo_consulta,m.nombre_motivo_consulta," +
                        "u.id_usuario,u.email," +
                        "r.id_rol,r.nombre_rol," +
                       "pers.id_persona,pers.dni,pers.nombre,pers.apellido,pers.telefono," +
                       "d.id_domicilio,d.numero,d.calle");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM consulta c");// aca le doy el alias c a la tabla de consulta y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN motivo_consulta m ON c.id_motivo_consulta = m.id_motivo_consulta");//le doy el alias m, y realizo el INNER JOIN entre la tabla consulta y la tabla Motivo_consulta
                    query.AppendLine("INNER JOIN usuario u ON c.id_usuario = u.id_usuario");//le doy el alias u a usuario, y realizo el INNER JOIN entre la tabla consulta y la tabla usuario (que la usare para realizar un jopin y traer los demas datos que encesito mostrar)
                    query.AppendLine("INNER JOIN rol r ON u.id_rol=r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN persona pers ON u.id_persona = pers.id_persona");//le doy el alias pers, y realizo el INNER JOIN entre la tabla usuario y la tabla persona
                    query.AppendLine("INNER JOIN domicilio d ON u.id_domicilio= d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio

                    //con este if verifico que no sea null el filtro 
                    if (!string.IsNullOrEmpty(p_txtFIltro) && !string.IsNullOrEmpty(atributo))
                    {
                        // Añade la condición de filtrado según el atributo
                        switch (atributo)
                        {
                            case "dni del empleado":
                                query.Append("WHERE pers.dni LIKE @filtro");
                                break;
                            case "tipo de permiso":
                                query.Append("WHERE m.nombre_motivo_permiso LIKE @filtro");
                                break;
                            case "fecha filtro":
                                query.Append("WHERE p.fecha_inicio LIKE @filtro"); break;
                            default:
                                // Manejar un atributo desconocido si es necesario.
                                break;
                        }
                    }

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;

                    // creo un parametro llamado filtro y le asigno el valor por el que quiero filtrar,rodeada por símbolos %, lo que significa que la consulta buscará todas las filas en las que el valor de la columna cumple con la condición "contiene" el valor de p_txtFIltro
                    if (!string.IsNullOrEmpty(p_txtFIltro))
                    {
                        cmd.Parameters.Add(new SqlParameter("@filtro", "%" + p_txtFIltro + "%")); //aca le paso el valor a mi parametro  @filtro que cree
                    }

                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de consulta le estoy agregrando una consulta
                            listafiltrada.Add(new consulta
                            {
                                id_consulta = Convert.ToInt32(dr["id_consulta"]),
                                comentario_consulta = dr["comentario_consulta"].ToString(),
                                estado_consulta = dr["estado_consulta"].ToString(),
                                fecha_consulta = Convert.ToDateTime(dr["fecha_consulta"]),

                                //como los datos del usuario que debo de traer al momento de hacer el INNER JOIN son de tipo usuario edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_permiso
                                obj_usuario = new usuario()
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    email = dr["email"].ToString(),
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
                                        dni = dr["dni"].ToString(),
                                        nombre = dr["nombre"].ToString(),
                                        apellido = dr["apellido"].ToString(),
                                        telefono = dr["telefono"].ToString()
                                    },
                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo obj_domicilio edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_domicilio = new domicilio()
                                    {
                                        id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                        numero = Convert.ToInt32(dr["numero"]),
                                        calle = dr["calle"].ToString()
                                    }

                                },
                                obj_motivo_consulta = new motivo_consulta
                                {
                                    id_motivo_consulta = Convert.ToInt32(dr["id_motivo_consulta"]),
                                    nombre_motivo_consulta = dr["nombre_motivo_consulta"].ToString()

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

        //buscamos la consulta atraves del id_consulta
        public consulta buscarPermisoPorIdConsulta(int id_consulta)
        {

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla consulta y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (c=consulta,u=usuario,r=rol,p=persona,d=domicilio,m=motivo_consulta). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT c.id_consulta,c.comentario_consulta,c.estado_consulta,c.fecha_consulta," +
                        "m.id_motivo_consulta,m.nombre_motivo_consulta," +
                        "u.id_usuario,u.email," +
                        "r.id_rol,r.nombre_rol," +
                       "pers.id_persona,pers.dni,pers.nombre,pers.apellido,pers.telefono," +
                       "d.id_domicilio,d.numero,d.calle");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM consulta c");// aca le doy el alias c a la tabla de consulta y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN motivo_consulta m ON c.id_motivo_consulta = m.id_motivo_consulta");//le doy el alias m, y realizo el INNER JOIN entre la tabla consulta y la tabla Motivo_consulta
                    query.AppendLine("INNER JOIN usuario u ON c.id_usuario = u.id_usuario");//le doy el alias u a usuario, y realizo el INNER JOIN entre la tabla consulta y la tabla usuario (que la usare para realizar un jopin y traer los demas datos que encesito mostrar)
                    query.AppendLine("INNER JOIN rol r ON u.id_rol=r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN persona pers ON u.id_persona = pers.id_persona");//le doy el alias pers, y realizo el INNER JOIN entre la tabla usuario y la tabla persona
                    query.AppendLine("INNER JOIN domicilio d ON u.id_domicilio= d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio
                    query.AppendLine("WHERE id_consulta=@id_consulta;");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor(id_producto que traigo como parametro) al paraemtro @id_producto de m iconsulta y asi para realizar el query
                    cmd.Parameters.AddWithValue("@id_consulta", id_consulta);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {            
                            //retorno mi consulta que lo obtnego por el id
                            return new consulta
                            {
                                id_consulta = Convert.ToInt32(dr["id_consulta"]),
                                comentario_consulta = dr["comentario_consulta"].ToString(),
                                estado_consulta = dr["estado_consulta"].ToString(),
                                fecha_consulta = Convert.ToDateTime(dr["fecha_consulta"]),

                                //como los datos del usuario que debo de traer al momento de hacer el INNER JOIN son de tipo usuario edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_permiso
                                obj_usuario = new usuario()
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    email = dr["email"].ToString(),
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
                                        dni = dr["dni"].ToString(),
                                        nombre = dr["nombre"].ToString(),
                                        apellido = dr["apellido"].ToString(),
                                        telefono = dr["telefono"].ToString()
                                    },
                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo obj_domicilio edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_domicilio = new domicilio()
                                    {
                                        id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                        numero = Convert.ToInt32(dr["numero"]),
                                        calle = dr["calle"].ToString()
                                    }

                                },
                                obj_motivo_consulta = new motivo_consulta
                                {
                                    id_motivo_consulta = Convert.ToInt32(dr["id_motivo_consulta"]),
                                    nombre_motivo_consulta = dr["nombre_motivo_consulta"].ToString()

                                }
                            };
                        }
                    }// Al salir de este bloque, la conexión se cerrará automáticamente.
                }
                catch (Exception ex)
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return null; // Devolvemos null si no se encontró la consulta con el id_consulta que proporcionarmos
        }

        //busco el consulta katraves del id_usuario y selecciono las consultas echas por ese usuario ya que un usuario puede tener varias cosnultas
        public List<consulta> buscarConsultasPorIdUsuario(int id_usuario)
        {
            List<consulta> listaConsulPorIdUsuario = new List<consulta>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla consulta y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (p para PRODUCTO,C para catgoria y m para amrca). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT c.id_consulta,c.comentario_consulta,c.estado_consulta,c.fecha_consulta," +
                        "m.id_motivo_consulta,m.nombre_motivo_consulta," +
                        "u.id_usuario,u.email," +
                        "r.id_rol,r.nombre_rol," +
                       "pers.id_persona,pers.dni,pers.nombre,pers.apellido,pers.telefono," +
                       "d.id_domicilio,d.numero,d.calle");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM consulta c");// aca le doy el alias c a la tabla de consulta y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN motivo_consulta m ON c.id_motivo_consulta = m.id_motivo_consulta");//le doy el alias m, y realizo el INNER JOIN entre la tabla consulta y la tabla Motivo_consulta
                    query.AppendLine("INNER JOIN usuario u ON c.id_usuario = u.id_usuario");//le doy el alias u a usuario, y realizo el INNER JOIN entre la tabla consulta y la tabla usuario (que la usare para realizar un jopin y traer los demas datos que encesito mostrar)
                    query.AppendLine("INNER JOIN rol r ON u.id_rol=r.id_rol");//le doy el alias r, y realizo el INNER JOIN entre la tabla usuario y la tabla rol
                    query.AppendLine("INNER JOIN persona pers ON u.id_persona = pers.id_persona");//le doy el alias pers, y realizo el INNER JOIN entre la tabla usuario y la tabla persona
                    query.AppendLine("INNER JOIN domicilio d ON u.id_domicilio= d.id_domicilio");//le doy el alias d, y realizo el INNER JOIN entre la tabla usuario y la tabla domicilio
                    query.AppendLine("WHERE c.id_usuario=@id_usuario;");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor(id_producto que traigo como parametro) al paraemtro @id_producto de m iconsulta y asi para realizar el query
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de consulta le estoy agregrando una consulta obtneida por el id_usuario
                            listaConsulPorIdUsuario.Add(new consulta
                            {
                                id_consulta = Convert.ToInt32(dr["id_consulta"]),
                                comentario_consulta = dr["comentario_consulta"].ToString(),
                                estado_consulta = dr["estado_consulta"].ToString(),
                                fecha_consulta = Convert.ToDateTime(dr["fecha_consulta"]),

                                //como los datos del usuario que debo de traer al momento de hacer el INNER JOIN son de tipo usuario edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_permiso
                                obj_usuario = new usuario()
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    email = dr["email"].ToString(),
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
                                        dni = dr["dni"].ToString(),
                                        nombre = dr["nombre"].ToString(),
                                        apellido = dr["apellido"].ToString(),
                                        telefono = dr["telefono"].ToString()
                                    },
                                    //como los datos del rol que debo de traer al momento de hacer el INNER JOIN son de tipo obj_domicilio edebo de alamcenar en ese tipo de objeto donde este obj formara parte de mi obj_usuario
                                    obj_domicilio = new domicilio()
                                    {
                                        id_domicilio = Convert.ToInt32(dr["id_domicilio"]),
                                        numero = Convert.ToInt32(dr["numero"]),
                                        calle = dr["calle"].ToString()
                                    }

                                },
                                obj_motivo_consulta = new motivo_consulta
                                {
                                    id_motivo_consulta = Convert.ToInt32(dr["id_motivo_consulta"]),
                                    nombre_motivo_consulta = dr["nombre_motivo_consulta"].ToString()
                                }
                            });
                        }
                    }// Al salir de este bloque, la conexión se cerrará automáticamente.
                }
                catch (Exception ex)
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return listaConsulPorIdUsuario; // Devolvemos null si no se encontró la o las cosultas con el id_usuario que proporcionarmos
        }
        /*********************************************CAMBIAR EL ESTADO DE LA CONSULTA A LEIDO DEPENDIENTO ****************************/
        public bool cambiarEstadoConsulta(consulta obj_consulta, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_ACTUALIZARESTADOCONSULTA", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_DARBAJAPRODUCTO) que defini en mi BD para dar de baja el producto y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_consulta", obj_consulta.id_consulta);
                    cmd.Parameters.AddWithValue("@estado_consulta", obj_consulta.estado_consulta);

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


        /**********************************metodos para La tabla Motivo Consulta *******************************************/
        public List<motivo_consulta> listaMotivosConsulta()
        {
            List<motivo_consulta> lista = new List<motivo_consulta>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT m.id_motivo_consulta, m.nombre_motivo_consulta ");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM Motivo_consulta m");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.

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
                            lista.Add(new motivo_consulta
                            {
                                id_motivo_consulta = Convert.ToInt32(dr["id_motivo_consulta"]),
                                nombre_motivo_consulta = dr["nombre_motivo_consulta"].ToString(),


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

        //aca obtengo el id del motiov_cosnulta atraves del nombre asi al momento de querer registrar una cosulta atgraves del nombre puedo obtener su id_motvio_consulta
        public int obtenerIDMotivoConsultaSeleccionada(string nombre_motivo_consulta)
        {
            int id_motivoConsultaObtenido = 0; // Inicializa la variable a devolver

            using (SqlConnection obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    // Consulta SQL parametrizada
                    string query = "SELECT m.id_motivo_consulta FROM Motivo_consulta m WHERE nombre_motivo_consulta = @nombre_motivo_consulta";

                    using (SqlCommand cmd = new SqlCommand(query, obj_conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_motivo_consulta", nombre_motivo_consulta);
                        obj_conexion.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id_motivoConsultaObtenido = dr.GetInt32(0); // Lee el valor del primer campo (en este caso, id_producto)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);

                }
            }

            return id_motivoConsultaObtenido; //aca devuelvop el id obtenido de la consulta a la BD
        }
    }
}
