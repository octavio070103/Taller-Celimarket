using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Caja
    {
        private CD_Caja obj_CD_Caja = new CD_Caja();

        public int RegistrarAperturaDeCaja(caja_apertura obj_caja_apertura, out string mensaje)
        {
            return obj_CD_Caja.RegistrarAperturaDeCaja(obj_caja_apertura, out mensaje);
        }

        public caja_apertura obtenerCajaAperturaPorFecha(DateTime fecha_apertura)
        {
            return obj_CD_Caja.obtenerCajaAperturaPorFecha(fecha_apertura);
        }
        public List<ventaCaja> listarVentasPorAperturaCaja(int id_apertura_Caja)
        {
            return obj_CD_Caja.listarVentasPorAperturaCaja(id_apertura_Caja);
        }
        /*************cierre de caja*************/
        public int RegistrarCierreDeCaja(caja_cierre obj_caja_cierre, out string mensaje)
        {
            return obj_CD_Caja.RegistrarCierreDeCaja(obj_caja_cierre, out mensaje);
        }

        //listo todas aquellas caja que se cerraron correctemtne,es decir que tuvieron una apertura_caja  y un cierre_caja
        public List<caja_cierre> listarCajasCerradas()
        {
            return obj_CD_Caja.listarCajasCerradas();
        }
        public caja_cierre obtenerCajaCierrePorFecha(DateTime fecha_cierre)
        {
            return obj_CD_Caja.obtenerCajaCierrePorFecha(fecha_cierre);
        }

        //obtiene datos de las ventas atraves del id_apertura caja
        public List<MetPagoDeVentas> obtenerTipoMetPagoDeVentasCajaAper(int id_apertura_caja)
        {
           return  obj_CD_Caja.obtenerTipoMetPagoDeVentasCajaAper(id_apertura_caja);
        }

    }
}
