using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace CapaDatos
{
    public class CD_Categoria
    {

        public int RegistrarCategoria(categoria obj_categoria, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            int id_categoria_registrado = 0;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca

            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARDOMICILIO) que defini en mi BD para registrar el domicilio y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@Nombre_categoria", obj_categoria.nombre_categoria);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@Descripcion_categoria", obj_categoria.descripcion_categoria);
                        cmd.Parameters.AddWithValue("@Estado_categoria", obj_categoria.estado_categoria);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro


                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi variable de salidad de mi procedimiento almacenado resultado me trae el id_resultado
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_domicilio_registrado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_categoria_registrado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);

                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
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
                id_categoria_registrado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }

            return id_categoria_registrado;
        }

        public List<categoria> listarCategorias()
        {
            List<categoria> lista = new List<categoria>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT c.id_categoria,c.nombre_categoria,c.descripcion_categoria,c.estado_categoria");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM categoria c");// aca le doy el alias u a la tabla de usuario y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                
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
                            lista.Add(new categoria
                            {
                                id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                nombre_categoria = dr["nombre_categoria"].ToString(),
                                descripcion_categoria = dr["descripcion_categoria"].ToString(),
                                estado_categoria = Convert.ToInt32(dr["estado_categoria"]),

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

        public bool editarCategoria(categoria obj_categoria, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {


                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@Id_Categoria", obj_categoria.id_categoria);
                    cmd.Parameters.AddWithValue("@Nombre_categoria", obj_categoria.nombre_categoria);
                    cmd.Parameters.AddWithValue("@Descripcion_categoria", obj_categoria.descripcion_categoria);
                    cmd.Parameters.AddWithValue("@Estado_categoria", obj_categoria.estado_categoria);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro

                    //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // le paso el tamnio del parametro mensaje como en mi proc lo def asi

                    // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //ejcutamos nuestro comando
                    cmd.ExecuteNonQuery();

                    //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);

                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();//aca se guarda el msj de error que nos da el proc almacenado 

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

        public bool darBajaCategoriaLogico(categoria obj_categoria, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {

            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_DARBAJACATEGORIA", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@Id_Categoria", obj_categoria.id_categoria);


                    //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // le paso el tamnio del parametro mensaje como en mi proc lo def asi

                    // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //ejcutamos nuestro comando
                    cmd.ExecuteNonQuery();

                    //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);

                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();//aca se guarda el msj de error que nos da el proc almacenado 

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;

        }

        public bool darDeAltaCategoria(categoria obj_Categoria, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_DARALTACATEGORIA", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARUSUARIO) que defini en mi BD para registrar el usuario y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@Id_Categoria", obj_Categoria.id_categoria);


                    //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // le paso el tamnio del parametro mensaje como en mi proc lo def asi

                    // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                    cmd.CommandType = CommandType.StoredProcedure;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //ejcutamos nuestro comando
                    cmd.ExecuteNonQuery();

                    //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                    respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);

                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();//aca se guarda el msj de error que nos da el proc almacenado 

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return respuesta;
        }

        public categoria buscarCategoriaId(int id_categoria)
        {
            //le paso cadena de la clase conexion , con using me garantizo la liberacion adecuada de los recursos que ya no son necesarios
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de excepeciones que peude ocurrir al momento de usar la Base de datos
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla categorias y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("SELECT c.id_categoria,c.nombre_categoria,c.descripcion_categoria,c.estado_categoria");
                    query.AppendLine("FROM categoria c");   // aca le doy el alias u a la tabla de categoria y con from defino la fuente de datos sobre la cual se realizarán las operaciones de consulta
                    query.AppendLine("WHERE c.id_categoria = @id_categoria;");//esta consulta se utiliza para filtrar(buscar) la fila en la tabla categoria  y solo realice esas operacion en aquel registro que su campo id_categoria coinidice con el parametro @id_categoria

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);

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
                            //creo un objeto categoria y cargo en cada atributo del objeto usuario los datos recuperados de la consulta dr.read()
                            return new categoria
                            {
                                id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                nombre_categoria = dr["nombre_categoria"].ToString(),
                                descripcion_categoria = dr["descripcion_categoria"].ToString(),
                                estado_categoria = Convert.ToInt32(dr["estado_categoria"]),
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
            return null; // Devolvemos null si no se encontró la categoria
        }

        public int obtenerIDCategoriaSeleccionada(string nombre_categoria)
        {
            int id_categoriaObtenido = 0; // Inicializa la variable a devolver

            using (SqlConnection obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    // Consulta SQL parametrizada
                    string query = "SELECT c.id_categoria FROM categoria c WHERE c.nombre_categoria = @nombre_categoria";

                    using (SqlCommand cmd = new SqlCommand(query, obj_conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_categoria", nombre_categoria);
                        obj_conexion.Open();


                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id_categoriaObtenido = dr.GetInt32(0); // Lee el valor del primer campo (en este caso, id_categoria)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }

            return id_categoriaObtenido;
        }
    }
}
