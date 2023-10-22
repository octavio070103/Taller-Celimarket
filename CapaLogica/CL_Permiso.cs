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

        /**********************************metodos para La tabla Permiso *******************************************/
        public int registrarPermiso(permiso obj_permiso,out string mensaje)
        {
            return obj_cd_permiso.registrarPermiso(obj_permiso,out mensaje);
        }

        public List<permiso> listarPermisos()
        {
            return obj_cd_permiso.listarPermisos();
        }

        /**********************************metodos para La tabla Motivo Permiso *******************************************/
        public List<motivo_permiso> listarMotivoPermiso()
        {
            return obj_cd_permiso.listaMotivosPermisos();
        }

        public int obtenerIDMotivoPermisoSeleccionada(string nombre_motivo_permiso)
        {
            return obj_cd_permiso.obtenerIDMotivoPermisoSeleccionada(nombre_motivo_permiso);
        }
    }
}
