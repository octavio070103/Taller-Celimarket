using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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


    }
}
