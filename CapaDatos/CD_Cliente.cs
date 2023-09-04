//Estos espacios de nombres proporcionan acceso a clases y métodos que son necesarios para trabajar con bases de datos SQL Server y otros objetos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    //Se define una clase llamada CD_Cliente CD= capaDatos
    public class CD_Cliente
    {
        //Se crea una instancia privada de la clase CD_Conexion llamada conexion. Esto permite encapsular la lógica de conexión a la base de datos en la clase 
        private CD_Conexion conexion = new CD_Conexion();

        //se declara la variable leer que es Un objeto SqlDataReader que se utilizará para leer registros de la base de datos.
        SqlDataReader leer;

        //se declara la variable tabla que es Un objeto DataTable que se utilizará para almacenar los resultados de las consultas.
        DataTable tabla = new DataTable();
        //e declara la variable tabla que es Un objeto SqlCommand que se utilizará para ejecutar consultas SQL en la base de datos.
        SqlCommand comando = new SqlCommand();

        //creamos una metodoo de tipo datatable apra mostrar los clientes de al BD,tiene como objetivo recuperar registros de la tabla cliente en la base de datos.  
        //Este método devuelve un objeto DataTable que contendrá los datos recuperados.
        public DataTable MostrarCliente()
        {
            //Tansact SQL

            //Se establece la conexión con la base de datos mediante conexion.AbrirConexion(), que es una instancia de la clase CD_Conexion. Esto abre una conexión a la base de datos.
            comando.Connection = conexion.AbrirConexion();
            
            //Se establece el comando SQL mediante comando.CommandText, que contiene la consulta SQL para seleccionar todos los registros de la tabla cliente.
            comando.CommandText = "Select *from cliente";
            
            //Se ejecuta la consulta SQL mediante leer = comando.ExecuteReader(). Esto ejecuta la consulta SQL y devuelve un objeto SqlDataReader llamado leer que contiene los resultados.
            leer = comando.ExecuteReader(); //aca le digo que la variable leer va a ser igual al resultado de exexuteREader que devuelve filas 

            //Los resultados se cargan en un objeto DataTable llamado tabla mediante tabla.Load(leer). Esto convierte los resultados de la consulta en un formato tabular que se puede utilizar en la aplicación.
            tabla.Load(leer);
            conexion.CerrarConexion();//cierro la conexion

            return tabla; //retornamos la tabla con los registros cargados
            //PROCEDIMIENTO
        }
    }
}
