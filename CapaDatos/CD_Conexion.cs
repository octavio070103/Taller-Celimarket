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
    public class CD_conexion
    {
        /*2da forma de conexion debo de instalar el ensabladoi en dependecias System.Configuration , osino aparece el nugget en esta clase :system.configuration.con con ellos podre hacer uso de los emtodos y calse de configursation */
        //aca llammos al meotodo que tiene esa clase configuration para realizar la cadnea de conexion
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
    }
}
