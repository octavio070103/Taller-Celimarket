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
    public class CD_Caja
    {
        /************************************************** APERTURA DE CAJA **************************************************/
        public int RegistrarAperturaDeCaja(caja_apertura obj_caja_apertura, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            int id_caja_apertura_registrado = 0;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca

            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARAPERTURACAJA", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARDOMICILIO) que defini en mi BD para registrar el domicilio y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@fecha_apertura", obj_caja_apertura.fecha_apertura);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@monto_inicial", obj_caja_apertura.monto_inicial_apertura);
                        cmd.Parameters.AddWithValue("@id_usuario",obj_caja_apertura.obj_usuario.id_usuario);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@estado_apertura", obj_caja_apertura.estado_apertura);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro


                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi variable de salidad de mi procedimiento almacenado resultado me trae el id_resultado
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_domicilio_registrado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_caja_apertura_registrado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);

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
                id_caja_apertura_registrado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }

            return id_caja_apertura_registrado;
        }
        public caja_apertura VerificarCajaAbiertaNoCerradaPasadoDia(DateTime fecha_actual)
        {
            //le paso cadena de la clase conexion , con using me garantizo la liberacion adecuada de los recursos que ya no son necesarios
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de excepeciones que peude ocurrir al momento de usar la Base de datos
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("select TOP 1 ap.id_apertura_caja,ap.fecha_apertura,ap.monto_inicial,ap.id_usuario,ap.estado_apertura");
                    query.AppendLine("From AperturaCaja ap");   // aca le doy el alias u a la tabla de categoria y con from defino la fuente de datos sobre la cual se realizarán las operaciones de consulta
                    query.AppendLine("WHERE CAST(ap.fecha_apertura AS date) < CAST(@fecha_actual AS date) AND ap.estado_apertura =1");//esta consulta se utiliza para filtrar(buscar) la fila en la tabla categoria  y solo realice esas operacion en aquel registro que su campo id_categoria coinidice con el parametro @id_categoria

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
                    cmd.Parameters.AddWithValue("@fecha_actual", fecha_actual);

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
                            return new caja_apertura
                            {

                                id_apertura_caja = Convert.ToInt32(dr["id_apertura_caja"]),
                                fecha_apertura = Convert.ToDateTime(dr["fecha_apertura"]),
                                monto_inicial_apertura = Convert.ToDecimal(dr["monto_inicial"]),
                                obj_usuario = new usuario
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                },
                                estado_apertura = Convert.ToInt32(dr["estado_apertura"])


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
            return null; // Devolvemos null si no se encontró la cajaApertura de esa fecha
        }

        public caja_apertura obtenerCajaAperturaPorFecha(DateTime fecha_apertura)
        {
            //le paso cadena de la clase conexion , con using me garantizo la liberacion adecuada de los recursos que ya no son necesarios
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de excepeciones que peude ocurrir al momento de usar la Base de datos
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("select ap.id_apertura_caja,ap.fecha_apertura,ap.monto_inicial,ap.id_usuario,ap.estado_apertura");
                    query.AppendLine("From AperturaCaja ap");   // aca le doy el alias u a la tabla de categoria y con from defino la fuente de datos sobre la cual se realizarán las operaciones de consulta
                    query.AppendLine("WHERE CAST(ap.fecha_apertura AS date)= CAST(@fecha_apertura AS date)");//esta consulta se utiliza para filtrar(buscar) la fila en la tabla categoria  y solo realice esas operacion en aquel registro que su campo id_categoria coinidice con el parametro @id_categoria

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
                    cmd.Parameters.AddWithValue("@fecha_apertura", fecha_apertura);

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
                            return new caja_apertura
                            {
                                
                                    id_apertura_caja = Convert.ToInt32(dr["id_apertura_caja"]),
                                    fecha_apertura = Convert.ToDateTime(dr["fecha_apertura"]),
                                    monto_inicial_apertura = Convert.ToDecimal(dr["monto_inicial"]),
                                    obj_usuario = new usuario
                                    {
                                        id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    },
                                    estado_apertura = Convert.ToInt32(dr["estado_apertura"])
                               

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
            return null; // Devolvemos null si no se encontró la cajaApertura de esa fecha
        }

        //tuve que rear un entidad nuevo porque nose uso obj en la entidad venta y para  no estar modificando l ohago asi y talvez despues lo modifique 
        public List<ventaCaja> listarVentasPorAperturaCaja(int id_apertura_Caja)
        {

            List<ventaCaja> listaVentasPorIdAPertura= new List<ventaCaja>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT v.id_venta,v.venta_fecha,v.fecha_creacion_venta," +
                        "c.id_cliente,pCli.nombre as nomCli,pCli.apellido as apellClien,pCli.dni as dniCli,pCli.telefono as telCli," +
                        "u.id_usuario,pUsu.nombre as nomUsu,pUsu.apellido as apeUsu,pUsu.dni as dniUsu,pUsu.telefono as telUsu," +
                        "v.id_apertura_caja," +
                        "produc.id_producto,produc.nombre_producto," +
                        "dt.subtotal_detalle_venta,dt.cantidad_detalle_venta");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM venta v");// aca le doy el alias cr a la tabla de CierreCaja y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN cliente c ON c.id_cliente = v.id_cliente");
                    query.AppendLine("INNER JOIN persona pCli ON pCli.id_persona = c.id_persona");
                    query.AppendLine("INNER JOIN metodo_pago mp ON mp.id_metodo_pago = v.id_metodo_pago");
                    query.AppendLine("INNER JOIN usuario u ON  u.id_usuario=v.id_usuario");
                    query.AppendLine("INNER JOIN persona pUsu ON pUsu.id_persona = u.id_persona");
                    query.AppendLine("INNER JOIN detalle_venta dt ON dt.id_venta = v.id_venta");
                    query.AppendLine("INNER JOIN producto produc ON dt.id_producto=produc.id_producto");
                    query.AppendLine("WHERE v.id_apertura_caja = @id_apertura_caja;");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
                    cmd.Parameters.AddWithValue("@id_apertura_caja", id_apertura_Caja);
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //aca se lectura a la consulta que realize con qeury
                        while (dr.Read())//read obitene valores de las columnas devuelve true si hay rregistross para leer y F sino lo hay,como con el while reocrro las filas devuletas por las consultas con read verifico que tengas registros para leer
                        {
                            //a mi lista de usuario le estoy agregrando un usaurio
                            listaVentasPorIdAPertura.Add(new ventaCaja
                            {
                                id_venta = Convert.ToInt32(dr["id_venta"]),
                                fecha_venta = Convert.ToDateTime(dr["venta_fecha"]),
                                fecha_creacion_venta=Convert.ToDateTime(dr["fecha_creacion_venta"]),
                                obj_cliente = new cliente
                                {
                                    id_cliente= Convert.ToInt32(dr["id_cliente"]),
                                    obj_persona=new persona
                                    {
                                        nombre= dr["nomCli"].ToString(),
                                        apellido = dr["apellClien"].ToString(),
                                        dni= dr["dniCli"].ToString(),
                                        telefono = dr["telCli"].ToString(),
                                    }
                                },
                                obj_usuario = new usuario
                                {
                                    id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                    obj_persona = new persona
                                    {
                                        nombre = dr["nomUsu"].ToString(),
                                        apellido = dr["apeUsu"].ToString(),
                                        dni = dr["dniUsu"].ToString(),
                                        telefono = dr["telUsu"].ToString(),
                                    }
                                },                   
                           
                              
                                obj_caja_apertura = new caja_apertura
                                {
                                    id_apertura_caja = Convert.ToInt32(dr["id_apertura_caja"]),
                                   
                                },
                                obj_producto = new producto
                                {
                                    Idproducto= Convert.ToInt32(dr["id_producto"]),
                                    nombre_producto = dr["nombre_producto"].ToString(),
                                },
                                cantidad_venta = Convert.ToInt32(dr["cantidad_detalle_venta"]),
                                subtotal = Convert.ToDecimal(dr["subtotal_detalle_venta"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return listaVentasPorIdAPertura; // Devolvemos la lista de cierreCaja
        }

        /************************************************** CIERRE DE CAJA **************************************************/
        public int RegistrarCierreDeCaja(caja_cierre obj_caja_cierre, out string mensaje)//mi obj usuario funcvionaria como un parametro de entrada y el mesnaje como uno de slida como en el procedimiento de laBD(proporciona informacion sobre la oepracion que se realiza con las var de entrada y el metodo)
        {
            int id_caja_cierre_registrado = 0;
            mensaje = string.Empty;//aca le asigno un var a mi msj es decir setteo mis vribales que voy a usar aca

            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARCIERRECAJA", Obj_conexion);

                        //le paso los parametros que necesita mi procedimiento almacenado(SP_REGISTRARDOMICILIO) que defini en mi BD para registrar el domicilio y asi evitar la inyeccion de SQL
                        cmd.Parameters.AddWithValue("@id_apertura_caja", obj_caja_cierre.obj_caja_apertura.id_apertura_caja);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@fecha_cierre", obj_caja_cierre.fecha_cierre_caja);
                        cmd.Parameters.AddWithValue("@id_usuario", obj_caja_cierre.obj_usuario.id_usuario);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@monto_final", obj_caja_cierre.monto_final);//AddWithValue nos permite agrgar un parametro a la consulta sQL y agregarle un valor,el primer arguemnto es el parametro que se utiliza en la conuslta SQL y el segundo es el valor que tendra ese parametro
                        cmd.Parameters.AddWithValue("@diferencia", obj_caja_cierre.diferencia_cierre_Caja);
                        cmd.Parameters.AddWithValue("@estado_cierre", obj_caja_cierre.estado_cierre);

                        //ya que declaramos la entradas de procedimiento almacenado nos faltaria la salida que tiene este procedimiento es decir el resultado de esa operacon
                        cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi variable de salidad de mi procedimiento almacenado resultado me trae el id_resultado
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();

                        //asignamos el valor del id_domicilio_registrado que es un var output en mi proced. alm en mi BD en mi var id_usuario_generado y l oconvertimos en entero
                        id_caja_cierre_registrado = Convert.ToInt32(cmd.Parameters["@Resultado"].Value);

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
                id_caja_cierre_registrado = 0;
                mensaje = ex.Message; //aca le paso el mensaje de error que capturo el try catch esa excepcion
            }

            return id_caja_cierre_registrado;
        }

        //listo todas aquellas caja que se cerraron correctemtne,es decir que tuvieron una apertura_caja  y un cierre_caja
        public List<caja_cierre> listarCajasCerradas()
        {
            List<caja_cierre> listaCierreCaja = new List<caja_cierre>();

            //le paso cadena de la clase conexion 
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de errores por si tengo porblemas al coenctar con la BD
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla usuarios y que me traiga esos datos que le especifique
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("Select cr.id_cierre_caja,cr.fecha_cierre,cr.monto_final,cr.diferencia,cr.estado_cierre," +
                        "cr.id_usuario as CierrIdUsu,persCierr.dni as CierrDniUsu,persCierr.nombre as CierrNomUsu,persCierr.apellido as CierrApellUsu,"+
                        "ap.id_apertura_caja,ap.fecha_apertura,ap.monto_inicial,ap.estado_apertura,"+
                        "usuAper.id_usuario as AperIdUsu,persAper.dni as AperDniUsu,persAper.nombre as AperNomUsu,persAper.apellido as AperApellUsu");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM CierreCaja cr");// aca le doy el alias cr a la tabla de CierreCaja y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN AperturaCaja ap ON cr.id_apertura_caja=ap.id_apertura_caja");
                    query.AppendLine("INNER JOIN usuario usuAper ON ap.id_usuario=usuAper.id_usuario");
                    query.AppendLine("INNER JOIN persona persAper ON usuAper.id_persona=persAper.id_persona");
                    query.AppendLine("INNER JOIN usuario usuCierr ON cr.id_usuario=usuCierr.id_usuario");
                    query.AppendLine("INNER JOIN persona persCierr ON usuCierr.id_persona=persCierr.id_persona");

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
                            listaCierreCaja.Add(new caja_cierre
                            {
                                id_cierre_caja = Convert.ToInt32(dr["id_cierre_caja"]),
                                fecha_cierre_caja = Convert.ToDateTime(dr["fecha_cierre"]),
                                monto_final = Convert.ToDecimal(dr["monto_final"]),
                                diferencia_cierre_Caja = Convert.ToDecimal(dr["diferencia"]),
                                estado_cierre = Convert.ToInt32(dr["estado_cierre"]),
                                //aca cargo los datos del usuario que  cerro la caja 
                                obj_usuario = new usuario 
                                {
                                    id_usuario = Convert.ToInt32(dr["CierrIdUsu"]),
                                    obj_persona = new persona
                                    {
                                        nombre = dr["CierrNomUsu"].ToString(),
                                        apellido = dr["CierrApellUsu"].ToString(),
                                        dni = dr["CierrDniUsu"].ToString(),
                                    }
                                },
                                //creo mi obj_apertura que esta relacionado por fk al cierre_caja y traigo los datos
                                obj_caja_apertura = new caja_apertura
                                {
                                    id_apertura_caja = Convert.ToInt32(dr["id_apertura_caja"]),
                                    fecha_apertura = Convert.ToDateTime(dr["fecha_apertura"]),
                                    monto_inicial_apertura = Convert.ToDecimal(dr["monto_inicial"]),
                                    obj_usuario=new usuario
                                    {
                                        id_usuario = Convert.ToInt32(dr["AperIdUsu"]),
                                        obj_persona = new persona
                                        {
                                            nombre = dr["AperNomUsu"].ToString(),
                                            apellido = dr["AperApellUsu"].ToString(),
                                            dni = dr["AperDniUsu"].ToString(),
                                        }
                                    },
                                    estado_apertura = Convert.ToInt32(dr["estado_apertura"])
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
            return listaCierreCaja; // Devolvemos la lista de cierreCaja
        }

        public caja_cierre obtenerCajaCierrePorFecha(DateTime fecha_cierre)
        {
            //le paso cadena de la clase conexion , con using me garantizo la liberacion adecuada de los recursos que ya no son necesarios
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
                //hago un capturador de excepeciones que peude ocurrir al momento de usar la Base de datos
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("Select cr.id_cierre_caja,cr.fecha_cierre,cr.monto_final,cr.diferencia,cr.estado_cierre," +
                        "cr.id_usuario as CierrIdUsu,persCierr.dni as CierrDniUsu,persCierr.nombre as CierrNomUsu,persCierr.apellido as CierrApellUsu," +
                        "ap.id_apertura_caja,ap.fecha_apertura,ap.monto_inicial,ap.estado_apertura," +
                        "usuAper.id_usuario as AperIdUsu,persAper.dni as AperDniUsu,persAper.nombre as AperNomUsu,persAper.apellido as AperApellUsu");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("FROM CierreCaja cr");// aca le doy el alias cr a la tabla de CierreCaja y con from defino la fuente de datos sobre la cual se realizarán las operaciones de selección, filtrado y combinación.
                    query.AppendLine("INNER JOIN AperturaCaja ap ON cr.id_apertura_caja=ap.id_apertura_caja");
                    query.AppendLine("INNER JOIN usuario usuAper ON ap.id_usuario=usuAper.id_usuario");
                    query.AppendLine("INNER JOIN persona persAper ON usuAper.id_persona=persAper.id_persona");
                    query.AppendLine("INNER JOIN usuario usuCierr ON cr.id_usuario=usuCierr.id_usuario");
                    query.AppendLine("INNER JOIN persona persCierr ON usuCierr.id_persona=persCierr.id_persona");
                    query.AppendLine("WHERE CAST(cr.fecha_cierre as date) = CAST(@fecha_cierre AS date);");

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
                    cmd.Parameters.AddWithValue("@fecha_cierre", fecha_cierre);

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
                            return new caja_cierre
                            {

                                id_cierre_caja = Convert.ToInt32(dr["id_cierre_caja"]),
                                fecha_cierre_caja = Convert.ToDateTime(dr["fecha_cierre"]),
                                monto_final = Convert.ToDecimal(dr["monto_final"]),
                                diferencia_cierre_Caja = Convert.ToDecimal(dr["diferencia"]),
                                estado_cierre = Convert.ToInt32(dr["estado_cierre"]),
                                //aca cargo los datos del usuario que  cerro la caja 
                                obj_usuario = new usuario
                                {
                                    id_usuario = Convert.ToInt32(dr["CierrIdUsu"]),
                                    obj_persona = new persona
                                    {
                                        nombre = dr["CierrNomUsu"].ToString(),
                                        apellido = dr["CierrApellUsu"].ToString(),
                                        dni = dr["CierrDniUsu"].ToString(),
                                    }
                                },
                                //creo mi obj_apertura que esta relacionado por fk al cierre_caja y traigo los datos
                                obj_caja_apertura = new caja_apertura
                                {
                                    id_apertura_caja = Convert.ToInt32(dr["id_apertura_caja"]),
                                    fecha_apertura = Convert.ToDateTime(dr["fecha_apertura"]),
                                    monto_inicial_apertura = Convert.ToDecimal(dr["monto_inicial"]),
                                    obj_usuario = new usuario
                                    {
                                        id_usuario = Convert.ToInt32(dr["AperIdUsu"]),
                                        obj_persona = new persona
                                        {
                                            nombre = dr["AperNomUsu"].ToString(),
                                            apellido = dr["AperApellUsu"].ToString(),
                                            dni = dr["AperDniUsu"].ToString(),
                                        }
                                    },
                                    estado_apertura = Convert.ToInt32(dr["estado_apertura"])
                                },


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


        /***************metodo para obtener los datos del ticket*****/
        public List<MetPagoDeVentas> obtenerTipoMetPagoDeVentasCajaAper(int id_apertura_caja)
        {
            List<MetPagoDeVentas> listaDeVentasPorTipMetPago = new List<MetPagoDeVentas>();

            //le paso cadena de la clase conexion , con using me garantizo la liberacion adecuada de los recursos que ya no son necesarios
            using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
            {
               
                //hago un capturador de excepeciones que peude ocurrir al momento de usar la Base de datos
                try
                {
                    //hago una consulta a la BD mas precesimanete a la tabla caja_apertura y que me realice la consulta que le especifico
                    StringBuilder query = new StringBuilder();

                    //se seleccionan columnas específicas utilizando sus nombres calificados con el alias de tabla correspondiente (u para usuario,d para domicilio y r para rol). Esto permite un mayor control sobre las columnas que  se incluyen en el resultado y evita conflictos de nombres si ambas tablas tienen columnas con el mismo nombre.
                    query.AppendLine("SELECT tpMp.id_tipo_metodo_pago,");//con el appendline me permite dar un salto de linea,basicamente lo que hago aca es crear la consulta(query) que le enviare a mi BD
                    query.AppendLine("COUNT(v.id_venta) AS cantidad_ventas_tpMetPago,");//con esta funcion peudo obtener la cantidad de venta que se realizaron con ese met de pago ya que con el gropuby agrupo por metPago y a esa agruapcion le aplico esta op para obtener la cant de venta que se hicieron con dicho met
                    query.AppendLine("SUM(dt.subtotal_detalle_venta) AS total_ventas_tpMetPago");//con esta funcion obtengo el total de esa agrupacion que realizo con el group by es decir aca tendria ele total_venta de esa ventas que se realizaron con un determinado met_pago con el que se agrupo la op se aplica sobre ese grupo para obt el total_venta
                    query.AppendLine("FROM tipo_metodo_pago tpMp");
                    query.AppendLine("INNER JOIN metodo_pago mp ON mp.id_metodo_pago=tpMp.id_tipo_metodo_pago");
                    query.AppendLine("INNER JOIN venta v ON v.id_metodo_pago=mp.id_metodo_pago");
                    query.AppendLine("INNER JOIN detalle_venta dt ON dt.id_venta=v.id_venta");
                    query.AppendLine("INNER JOIN AperturaCaja ap ON v.id_apertura_caja=ap.id_apertura_caja");
                    query.AppendLine("WHERE v.id_apertura_caja = @id_apertura_caja");
                    query.AppendLine("GROUP BY tpMp.id_tipo_metodo_pago;"); //consulta el group by agrupo los registros obtenido en el where segun su  id_tipo_metodo_pago y leugo aplciaco las funciones count y sum

                    //creo un nuevo sqlcommand que me pide 2 cosass el query o consulta nueva y la conexion que abrimos es decir el objConexion 
                    SqlCommand cmd = new SqlCommand(query.ToString(), Obj_conexion);
                    //le paso un valor al paraemtro @id_usuario para realizar la consulta
                    cmd.Parameters.AddWithValue("@id_apertura_caja", id_apertura_caja);

                    // Establece el tipo de comando a CommandType.Text, lo que significa que la consulta es una instrucción SQL textual.
                    cmd.CommandType = CommandType.Text;
                    Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                    //using garantiza la liberación adecuada de los recursos cuando ya no son necesarios.
                    using (SqlDataReader reader = cmd.ExecuteReader())//Crea y abre un SqlDataReader llamado dr para ejecutar la consulta SQL que se definió anteriormente en cmd. Este objeto dr se utiliza para leer los resultados de la consulta.
                    {
                        //Este condicional verifica si hay al menos una fila de resultados en el SqlDataReader.
                        //Si es así, significa que se encontró un usuario con el dni y password proporcionados que coinciden en la base de datos.
                        while (reader.Read())
                        {
                            listaDeVentasPorTipMetPago.Add(new MetPagoDeVentas
                            {    
                                id_tipo_metPago= Convert.ToInt32(reader["id_tipo_metodo_pago"]),
                                cant_vent_tipo_tipo_metPago = Convert.ToInt32(reader["cantidad_ventas_tpMetPago"]),
                                total_vent_tipo_tipo_metPago =Convert.ToDecimal(reader["total_ventas_tpMetPago"]),
                            });
                           
                        }

                    }// Al salir de este bloque, la conexión se cerrará automáticamente.

                }
                catch (Exception ex)
                {
                    // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }
            return listaDeVentasPorTipMetPago;
        }
    }
}
