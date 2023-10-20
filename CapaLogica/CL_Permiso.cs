using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Permiso
    {
        CD_Permiso obj_cd_permiso = new CD_Permiso();

        public List<motivo_permiso> listarMotivoPermiso()
        {
            return obj_cd_permiso.listaMotivosPermisos();
        }


    }
}
