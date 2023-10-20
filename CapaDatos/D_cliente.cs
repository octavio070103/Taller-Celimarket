using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaEntidad;

namespace CapaDatos
{
    public class D_cliente
    {

        public DataTable listarClientes()
        {
            DataTable listaClientes = new DataTable();

            // Se instancia un objeto de la clase conexion que servira para conectarse con la base de datos
            using ( SqlConnection objConexion = new SqlConnection(CD_conexion.cadena) )
            {
                // Se establece un manejador de excepciones para manejar los errores que se puedan producir al
                // conectarse con la base de datos.
                try
                {
                    // Se instancia un objeto de la clase SqlCommand que servira para ejecutar comandos de la base 
                    // de datos
                    SqlCommand comando = new SqlCommand("SP_ListarClientes", objConexion);

                    // Se establece que el comando a ejecutar es un procediento ya almacenado en la base de datos
                    comando.CommandType = CommandType.StoredProcedure;

                    // Se abre la conexion con la base de datos, lo cual permitira ejecutar los comandos
                    objConexion.Open();

                    // Se instancia un objeto de la clase SqlDataReader que permitira leer los resultados de la ejecucion
                    // del procedimiento almacenado
                    SqlDataReader reader = comando.ExecuteReader();

                    // Se carga la lista de clientes con los resultados obtenidos de la base de datos.
                    listaClientes.Load( reader );

                }
                catch ( Exception excepcion )
                {
                    //Mensaje de error
                    Console.WriteLine( "Error al conectar con la base de datos: " + excepcion.Message );
                }
            }

            return listaClientes;
        }

        public void registrarCliente(persona objCliente, out string mensajeResultado)
        {
            using ( SqlConnection objConexion = new SqlConnection( CD_conexion.cadena ) )
            {
                //AVISO: Encerrar en try catch

                SqlCommand comando = new SqlCommand("SP_RegistrarCliente", objConexion);

                //*** PARAMETROS DE ENTRADA ***
                comando.Parameters.AddWithValue("@dni", objCliente.dni);
                comando.Parameters.AddWithValue("@nombre", objCliente.nombre);
                comando.Parameters.AddWithValue("@apellido", objCliente.apellido);
                comando.Parameters.AddWithValue("@fecha_nacimiento", objCliente.fecha_nacimiento);
                comando.Parameters.AddWithValue("@telefono", objCliente.telefono);
                // Asignamos el valor 1 al estado del cliente para establecer que esta dado de alta
                comando.Parameters.AddWithValue("@estado_cliente", 1);


                //*** PARAMETROS DE SALIDA ***
                // Parametros para las salidas generadas por el procedimiento almacenado
                SqlParameter mensajeSalida = comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500);

                // Se establece que la variable 'mensajeSalida' es un parametro de salida que almacenara el
                // resultado que genere el procedimiento almacenado
                mensajeSalida.Direction = ParameterDirection.Output;

                // Se establece que el comando a ejecutar es del tipo procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;

                // Se abre la conexion con la base de datos
                objConexion.Open();

                // Se ejecuta el procedimiento almacenado
                comando.ExecuteNonQuery();

                mensajeResultado = comando.Parameters["@mensaje"].Value.ToString();

            }

        }

        public void eliminarCliente( int idCliente, out int resultadoEjec )
        {
            resultadoEjec = 0;

            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SP_EliminarCliente", objConexion);

                    comando.Parameters.AddWithValue("@id_cliente", idCliente);

                    SqlParameter auxResultadoSalida = comando.Parameters.Add("@resultadoEjec", SqlDbType.Int);

                    auxResultadoSalida.Direction = ParameterDirection.Output;

                    comando.CommandType = CommandType.StoredProcedure;

                    objConexion.Open();

                    comando.ExecuteNonQuery();

                    resultadoEjec = (int)comando.Parameters["@resultadoEjec"].Value;

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }
            }
        }

        public void modificarDatosCliente(persona objCliente, out int resultadoEjec)
        {
            resultadoEjec = 0;
            
            using (SqlConnection objConexion = new SqlConnection(CD_conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SP_EditarDatosCliente", objConexion);

                    //*** PARAMETROS DE ENTRADA ***
                    comando.Parameters.AddWithValue("@dni", objCliente.dni);
                    comando.Parameters.AddWithValue("@nombre", objCliente.nombre);
                    comando.Parameters.AddWithValue("@apellido", objCliente.apellido);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", objCliente.fecha_nacimiento);
                    comando.Parameters.AddWithValue("@telefono", objCliente.telefono);


                    //*** PARAMETROS DE SALIDA ***
                    // Parametros para las salidas generadas por el procedimiento almacenado
                    SqlParameter auxResultadoSalida = comando.Parameters.Add("@resultadoEjec", SqlDbType.Int);

                    // Se establece que la variable 'auxResultadoSalida' es un parametro de salida que almacenara el
                    // resultado que genere el procedimiento almacenado
                    auxResultadoSalida.Direction = ParameterDirection.Output;

                    // Se establece que el comando a ejecutar es del tipo procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    // Se abre la conexion con la base de datos
                    objConexion.Open();

                    // Se ejecuta el comando
                    comando.ExecuteNonQuery();

                    // Se almacena el resultado de la ejecucion del procedimiento almacenado
                    resultadoEjec = (int)comando.Parameters["@resultadoEjec"].Value;

                }
                catch (Exception excepcion)
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine("Error al conectar con la base de datos: " + excepcion.Message);
                }

            }
        }

    }
}
