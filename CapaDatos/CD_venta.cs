using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_venta
    {
        public DataTable listarVentas()
        {
            DataTable tablaVentas = new DataTable();  // Crea una variable auxiliar de la clase DataTable

            // Se instancia un objeto de la clase conexion que servira para conectarse a la base de datos
            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            // Se instancia un objeto de la clase SqlCommand que permitira ejecutar comandos de la base de datos
            SqlCommand cmd = new SqlCommand("SP_ListarVentas", Obj_conexion);

            // Se establece que el comando a ejecutar es un procediento ya almacenado en la base de datos
            cmd.CommandType = CommandType.StoredProcedure; 

            // Se abre la conexion con la base de datos, lo cual permitira ejecutar los comandos
            Obj_conexion.Open();

            // Se instancia un objeto de la clase SqlDataReader que permitira leer los resultados de la ejecucion
            // del procedimiento almacenado
            SqlDataReader dataReader = cmd.ExecuteReader();

            tablaVentas.Load(dataReader); // Se cargan los resultados de la ejecucion del procedimiento en la 
                                          // variable tablaVentas

            dataReader.Close();  // Se cierra el dataReader despues de cargar los datos
            Obj_conexion.Close(); // Se cierra la conexion con la base de datos

            return tablaVentas;
        }

    }

}
