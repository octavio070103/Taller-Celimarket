//Estos espacios de nombres proporcionan acceso a clases y métodos que son necesarios para trabajar con bases de datos SQL Server y otros objetos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;//proporcionan acceso a clases y métodos de la clase capaDatos
using capaEntidad;

namespace CapaLogica
{
    public class CL_Cliente
    {
        private D_cliente objCliente = new D_cliente();

        /*
        public DataTable MostrarClien()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCliente();
            return tabla;
        }*/

        // Este metodo permite obtener la lista de clientes registrados
        public DataTable obtenerListaClientes()
        {
            return objCliente.listarClientes();
        }

        // Este metodo permite registrar a un nuevo cliente
        public void registrarCliente( persona auxCliente, out string mensaje)
        {
            objCliente.registrarCliente(auxCliente, out mensaje);
        }

    }
}
