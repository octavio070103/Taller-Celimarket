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

        //listar permisos pero filtrados
        public List<permiso> listarPermisoFiltrado(string p_txtFIltro, string atributo)
        {
            List<permiso> listaPermisoFiltrado = new List<permiso>();
            //aca hago una validacion de que los valores que me llegan no sean nulos o me lleguen vacios,sino son vacio o nulos entra al if
            if (!string.IsNullOrWhiteSpace(p_txtFIltro) && !string.IsNullOrWhiteSpace(atributo))
            {
                listaPermisoFiltrado = obj_cd_permiso.listarPermisoFiltrado(p_txtFIltro, atributo);
            }
            else//si es vacio o nulo que me lista los permisos completos sin ningun filtro aplicado
            {
                listaPermisoFiltrado=obj_cd_permiso.listarPermisos(); //aca no estarian filtrado estarian completos estos me ayudaria a que si el usuario ingresa vacio o un null ,no me filtre sino que me muestre la lista completa sin filtros
            }

            return listaPermisoFiltrado; //si paso el anterior if me devuvle la lista cargada sino me devuelve la lista vacia
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
