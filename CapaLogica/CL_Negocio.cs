using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Negocio
    {
        public CD_Negocio obj_CD_Negocio = new CD_Negocio();

        public negocio obtenerDatosNegocio()
        {
            return obj_CD_Negocio.obtenerDatosNegocio();
        }

        public bool guardarDatosNegocio(negocio obj_negocio, out string mensaje)
        {
            return obj_CD_Negocio.guardarDatosNegocio(obj_negocio,out mensaje);
        }
        //poner validaciones aca para el guardarDatos

        public byte[] obtenerLogoNegocio(out bool obtenido)
        {
            return obj_CD_Negocio.obtenerLogoNegocio(out obtenido);
        }

        public bool ActualizarLogoNegocio(byte[] imagenLogo, out string mensaje)
        {
            return obj_CD_Negocio.ActualizarLogoNegocio(imagenLogo,out mensaje);
        }
    }
}
