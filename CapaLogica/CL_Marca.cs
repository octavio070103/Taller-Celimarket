using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Marca
    {
        private CD_Marca obj_CD_Marca = new CD_Marca();

        public List<marca> listarMarcas()
        {
            return obj_CD_Marca.listarMarcas();
        }
        //con este metodo obtengo el id_marca atraves del nombre_marca que lo recibo como parametro
        public int obtenerIDMarcaSeleccionada(string nombre_marca)
        {
            return obj_CD_Marca.obtenerIDMarcaSeleccionada(nombre_marca);
        }
    }
}
