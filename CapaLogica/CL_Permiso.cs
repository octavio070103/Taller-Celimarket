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
        public permiso buscarPermiso(int id_permiso)
        {
            return obj_cd_permiso.buscarPermiso(id_permiso);
        }

        //aca busco el obj_permiso perteneciente a ese id_usuario
        public permiso buscarPermisoPorIdUsuario(int id_usuario)
        {
            return obj_cd_permiso.buscarPermisoPorIdUsuario(id_usuario);
        }

        public bool cambiarEstadoPermiso(permiso obj_permiso, out string mensaje)
        {
            return obj_cd_permiso.cambiarEstadoPermiso(obj_permiso, out mensaje);
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
