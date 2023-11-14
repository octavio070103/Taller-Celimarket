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
        public List<ProductosMasVendidosDelMes> obtenerProductosMasVendidos(int anio, int mes) //llamo a mi metodo obtenerProductosMasVendidos de mi BD
        {
            return obj_CD_DashBoard.obtenerProductosMasVendidos(anio, mes);
        }
        public (ArrayList DiaVenta, ArrayList cantidadVenPorDia) obtenerVentasDelMesPorDia(int anio, int mes) //llamo a mi metodo obtenerProductosMasVendidos de mi BD
        {
            return obj_CD_DashBoard.obtenerVentasDelMesPorDia(anio, mes);
        }
        public (ArrayList categoria, ArrayList stock) obtenerStockProducPorCategor() //llamo a mi metodo obtenerProductosMasVendidos de mi BD
        {
            return obj_CD_DashBoard.obtenerStockProducPorCategor();
        }

        public negocioEstadistica obtenerDatosNegocioEstadisticas(int mes)
        { 
            return obj_CD_DashBoard.obtenerDatosNegocioEstadisticas(mes);
        }
    }
}
