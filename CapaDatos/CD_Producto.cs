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
    public class CD_Producto
    {
        public int registrarProducto(producto obj_producto, out string mensaje)//mi obj categoria funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            int id_producto_generado = 0;
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
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARPRODUCTO) que defini en mi BD para registrar el producto y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@nombre_producto", obj_producto.nombre_producto);
                        cmd.Parameters.AddWithValue("@cod_barra_producto", obj_producto.cod_barra_producto);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@descripcion_producto", obj_producto.descripcion_producto);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@precio_compra", obj_producto.precio_compra);
                        cmd.Parameters.AddWithValue("@precio_venta", obj_producto.precio_venta);
                        cmd.Parameters.AddWithValue("@imagen_producto", obj_producto.imagen);
                        cmd.Parameters.AddWithValue("@stock_producto", obj_producto.stock_producto);
                        cmd.Parameters.AddWithValue("@estado_producto", obj_producto.estado_producto);
                        cmd.Parameters.AddWithValue("@Id_Marca", obj_producto.obj_marca.id_marca);
                        cmd.Parameters.AddWithValue("@Id_Categoria", obj_producto.obj_categoria.id_categoria);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@Id_Producto_Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi var de saldad de mi proced alm
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_uusario_resultado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_producto_generado = Convert.ToInt32(cmd.Parameters["@Id_Producto_Resultado"].Value);

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
                id_producto_generado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }
            return id_producto_generado;

        }
        public bool editarProducto(producto obj_producto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {


                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARPRODUCTO) que defini en mi BD para registrar el producto y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_producto", obj_producto.Idproducto);
                    cmd.Parameters.AddWithValue("@nombre_producto", obj_producto.nombre_producto);
                    cmd.Parameters.AddWithValue("@cod_barra_producto", obj_producto.cod_barra_producto);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                    cmd.Parameters.AddWithValue("@descripcion_producto", obj_producto.descripcion_producto);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                    cmd.Parameters.AddWithValue("@precio_compra", obj_producto.precio_compra);
                    cmd.Parameters.AddWithValue("@precio_venta", obj_producto.precio_venta);
                    cmd.Parameters.AddWithValue("@imagen_producto", obj_producto.imagen);
                    cmd.Parameters.AddWithValue("@stock_producto", obj_producto.stock_producto);
                    cmd.Parameters.AddWithValue("@estado_producto", obj_producto.estado_producto);
                    cmd.Parameters.AddWithValue("@Id_Marca", obj_producto.obj_marca.id_marca);
                    cmd.Parameters.AddWithValue("@Id_Categoria", obj_producto.obj_categoria.id_categoria);

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

        public bool darDeBajaProducto(producto obj_producto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_DARBAJAPRODUCTO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_DARBAJAPRODUCTO) que defini en mi BD para dar de baja el producto y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_producto", obj_producto.Idproducto);


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

        public bool darDeAltaProducto(producto obj_producto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {

                    //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand("SP_DARALTAPRODUCTO", Obj_conexion);

                    //le paso los parametros que necesita mi procedimiento almacenado(SP_DARBAJAPRODUCTO) que defini en mi BD para dar de baja el producto y asi evitar la inyeccion de SQL
                    cmd.Parameters.AddWithValue("@id_producto", obj_producto.Idproducto);


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
        
        public List<producto> listarProductos()
        {
            List<producto> lista = new List<producto>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla producto y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (p para PRODUCTO,C para catgoria y m para amrca). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT p.id_producto,p.cod_barra_producto,p.nombre_producto,p.descripcion_producto,p.precio_compra,p.precio_venta,p.stock_producto,p.imagen_producto,p.estado_producto,p.fecha_creacion_producto," +
                        "m.id_marca,m.nombre," +
                        "c.id_categoria,c.nombre_Categoria,c.descripcion_categoria");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM producto p");// aca le doy el alias p a la tabla de producto y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN marca m ON p.Id_Marca=m.Id_Marca");//le doy el alias m a marca, y realizo el INNER JOIN entre la tabla producto y la tabla marca
                    query.AppendLine("INNER JOIN categoria c ON p.id_categoria=c.id_categoria");//le doy el alias c, y realizo el INNER JOIN entre la tabla producto y la tabla categoria
                    //query.AppendLine("WHERE stock_producto > 0");//

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    //using (){
                    SqlDataReader dr = cmd.ExecuteReader();

                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de producto le estoy agregrando un usaurio
                            lista.Add(new producto
                            {
                                Idproducto = Convert.ToInt32(dr["id_producto"]),
                                cod_barra_producto = Convert.ToInt32(dr["cod_barra_producto"]),
                                nombre_producto = dr["nombre_producto"].ToString(),
                                descripcion_producto = dr["descripcion_producto"].ToString(),
                                precio_compra = Convert.ToDecimal(dr["precio_compra"]),
                                precio_venta = Convert.ToDecimal(dr["precio_venta"]),
                                stock_producto= Convert.ToInt32(dr["stock_producto"]),
                                imagen = dr["imagen_producto"].ToString(),
                                estado_producto = Convert.ToInt32(dr["estado_producto"]),
                                fecha_creacion_producto = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_producto")),

                                //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo Marca los debo de alamcenar en ese tipo de obj marca que formara parte de mi atributo producto
                                obj_marca = new marca()
                                {
                                    id_marca= Convert.ToInt32(dr["id_marca"]),
                                    nombre_marca = dr["nombre"].ToString()
                                },
                                //como los campos del categoria que traigo con el INNER JOIN son de tipo categoria los almaceno en ese tipo de obj que forma parte de  mi atributo de mi producto
                                obj_categoria = new categoria()
                                {
                                    id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                    nombre_categoria = dr["nombre_Categoria"].ToString(),
                                    descripcion_categoria = dr["descripcion_categoria"].ToString()                               
                                }

                            });
                        }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return lista; // Devolvemos la lista de productos que obtuvimos en la consulta
        }


        public List<producto> listarProductosVenta()
        {
            List<producto> lista = new List<producto>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla producto y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (p para PRODUCTO,C para catgoria y m para amrca). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT p.id_producto,p.cod_barra_producto,p.nombre_producto,p.descripcion_producto,p.precio_compra,p.precio_venta,p.stock_producto,p.imagen_producto,p.estado_producto,p.fecha_creacion_producto," +
                        "m.id_marca,m.nombre," +
                        "c.id_categoria,c.nombre_Categoria,c.descripcion_categoria");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM producto p");// aca le doy el alias p a la tabla de producto y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN marca m ON p.Id_Marca=m.Id_Marca");//le doy el alias m a marca, y realizo el INNER JOIN entre la tabla producto y la tabla marca
                    query.AppendLine("INNER JOIN categoria c ON p.id_categoria=c.id_categoria");//le doy el alias c, y realizo el INNER JOIN entre la tabla producto y la tabla categoria
                    query.AppendLine("WHERE stock_producto > 0");//

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    //using (){
                    SqlDataReader dr = cmd.ExecuteReader();

                    //aca se lectura a la consulta que realize con qeury
                    while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                    {
                        //a mi lista de producto le estoy agregrando un usaurio
                        lista.Add(new producto
                        {
                            Idproducto = Convert.ToInt32(dr["id_producto"]),
                            cod_barra_producto = Convert.ToInt32(dr["cod_barra_producto"]),
                            nombre_producto = dr["nombre_producto"].ToString(),
                            descripcion_producto = dr["descripcion_producto"].ToString(),
                            precio_compra = Convert.ToDecimal(dr["precio_compra"]),
                            precio_venta = Convert.ToDecimal(dr["precio_venta"]),
                            stock_producto = Convert.ToInt32(dr["stock_producto"]),
                            imagen = dr["imagen_producto"].ToString(),
                            estado_producto = Convert.ToInt32(dr["estado_producto"]),
                            fecha_creacion_producto = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_producto")),

                            //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo Marca los debo de alamcenar en ese tipo de obj marca que formara parte de mi atributo producto
                            obj_marca = new marca()
                            {
                                id_marca = Convert.ToInt32(dr["id_marca"]),
                                nombre_marca = dr["nombre"].ToString()
                            },
                            //como los campos del categoria que traigo con el INNER JOIN son de tipo categoria los almaceno en ese tipo de obj que forma parte de  mi atributo de mi producto
                            obj_categoria = new categoria()
                            {
                                id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                nombre_categoria = dr["nombre_Categoria"].ToString(),
                                descripcion_categoria = dr["descripcion_categoria"].ToString()
                            }

                        });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return lista; // Devolvemos la lista de productos que obtuvimos en la consulta
        }

            public producto buscarProducto(int id_producto)
        {
            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla producto y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (p para PRODUCTO,C para catgoria y m para amrca). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.(evi tando la ambigueadad)
                    query.AppendLine("SELECT p.id_producto,p.cod_barra_producto,p.nombre_producto,p.descripcion_producto,p.precio_compra,p.precio_venta,p.stock_producto,p.estado_producto,p.fecha_creacion_producto," +
                        "m.id_marca,m.nombre," +
                        "c.id_categoria,c.nombre_Categoria,c.descripcion_categoria");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM producto p");// aca le doy el alias p a la tabla de producto y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN marca m ON p.Id_Marca=m.Id_Marca");//le doy el alias m a marca, y realizo el INNER JOIN entre la tabla producto y la tabla marca
                    query.AppendLine("INNER JOIN categoria c ON p.id_categoria=c.id_categoria");//le doy el alias c, y realizo el INNER JOIN entre la tabla producto y la tabla categoria
                    query.AppendLine("WHERE id_producto = @id_producto; ");//esta consulta se utiliza para filtrar(buscar) la fila en la tabla producto  y solo realice esas operacion en aquel registro que su campo id_producto coinidice con el parametro @id_producto

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor(id_producto que traigo como parametro) al paraemtro @id_producto de m iconsulta y asi para realizar el query
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader dr = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {
                        //Este condicional verifica si hay al menos una fila de resultados en el SqlDataReader.
                        //Si es así, significa que se encontró un producto con el id_producto que le pase como parametro.
                        if (dr.Read())
                        {
                            //creo un objeto producto y cargo en cada atributo del objeto producto los datos recuperados de la consulta dr.read()
                            return new producto
                            {

                                Idproducto = Convert.ToInt32(dr["id_producto"]),
                                cod_barra_producto = Convert.ToInt32(dr["cod_barra_producto"]),
                                nombre_producto = dr["nombre_producto"].ToString(),
                                descripcion_producto = dr["descripcion_producto"].ToString(),
                                precio_compra = Convert.ToDecimal(dr["precio_compra"]),
                                precio_venta = Convert.ToDecimal(dr["precio_venta"]),
                                stock_producto = Convert.ToInt32(dr["stock_producto"]),
                                estado_producto = Convert.ToInt32(dr["estado_producto"]),
                                fecha_creacion_producto = dr.GetDateTime(dr.GetOrdinal("fecha_creacion_producto")),

                                //como los campos de mi tabla persona que los triago al momento de hacer el INER son de tipo Marca los debo de alamcenar en ese tipo de obj marca que formara parte de mi atributo producto
                                obj_marca = new marca()
                                {
                                    id_marca = Convert.ToInt32(dr["id_marca"]),
                                    nombre_marca = dr["nombre"].ToString()
                                },
                                //como los campos del categoria que traigo con el INNER JOIN son de tipo categoria los almaceno en ese tipo de obj que forma parte de  mi atributo de mi producto
                                obj_categoria = new categoria()
                                {
                                    id_categoria = Convert.ToInt32(dr["id_categoria"]),
                                    nombre_categoria = dr["nombre_Categoria"].ToString(),
                                    descripcion_categoria = dr["descripcion_categoria"].ToString()
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
            return null; // Devolvemos null si no se encontró el producto con el id_producto que proporcionarmos
        }

        public int obtenerIDProductoSeleccionada(string nombre_producto)
        {
            int id_productoObtenido = 0; // Inicializa la variable a devolver

            using (SqlConnection obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    // Consulta SQL parametrizada
                    string query = "SELECT p.id_producto FROM producto p WHERE nombre_producto = @nombre_producto";

                    using (SqlCommand cmd = new SqlCommand(query, obj_conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                        obj_conexion.Open();

                        
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                id_productoObtenido = dr.GetInt32(0); // Lee el valor del primer campo (en este caso, id_producto)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);
                   
                }
            }

            return id_productoObtenido;
        }

    }
}
