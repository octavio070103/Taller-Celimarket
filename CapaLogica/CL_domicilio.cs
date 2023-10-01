using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_domicilio
    {
        //creo o instancio un objeto private de tipo o de la clase CD_usuario para poder acceder a esos metodos atraves de esa instancia
        private CD_domicilio obj_cd_domicilio = new CD_domicilio();

        public int registrarDomicilio( domicilio obj_domicilio,out string mensaje)
        {
            return obj_cd_domicilio.registrarDomicilio(obj_domicilio,out mensaje);
        }

        public domicilio buscarDomicilioID(int id_domicilio)
        {
            return obj_cd_domicilio.buscarDomicilioID(id_domicilio);
        }
    }
}
