using CapaDatos;
using capaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_DashBoard
    {
        CD_DashBoard obj_CD_DashBoard = new CD_DashBoard();
        public (ArrayList productos, ArrayList cantidadVen) obtenerProductosMasVendidos() //llamo a mi metodo obtenerProductosMasVendidos de mi BD
        {
            return obj_CD_DashBoard.obtenerProductosMasVendidos();
        }

        public negocioEstadistica obtenerDatosNegocioEstadisticas(int mes)
        { 
            return obj_CD_DashBoard.obtenerDatosNegocioEstadisticas(mes);
        }
    }
}
