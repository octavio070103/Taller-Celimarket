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
//librerias importante 

namespace CapaDatos
{
    // se va a encargar de conectra con la base de datos, y pasarle la candena de conexion a las demas capas ,debo tener importadas las librerias de arriba
    public class CD_Conexion1ra
    {
        /*1ra forma de conexion  
         * cadena de conexion si no configure el app config con m icadena de conexion debo de escirbirla aca de esta forma*/
        private SqlConnection Conexion = new SqlConnection("Server =(local);DataBase=DbSistema;Integrated Security=true"); 


        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }

     

    }
}


