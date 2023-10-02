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
            DataTable tablaVentas = new DataTable();

            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            SqlCommand cmd = new SqlCommand("SP_ListarVentas", Obj_conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            Obj_conexion.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            tablaVentas.Load(dataReader);

            dataReader.Close();
            Obj_conexion.Close();

            return tablaVentas;
        }

    }



}
