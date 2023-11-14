using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using capaEntidad;

namespace CapaLogica
{
    public class CL_rol
    {
        private CD_Rol obj_cd_rol = new CD_Rol();
        //retorna la lista que esta en nuestra caaps de datos de roles
        public List<rol> listarRol()
        {

            return obj_cd_rol.ListarRol();
        }

        //con este metodo obtengo el id_rol atraves del nombre_rol que lo recibo como parametro
        public int obtenerIDRolSeleccionada(string nombre_rol)
        {
            return obj_cd_rol.obtenerIDRolSeleccionada(nombre_rol);
        }

    }
}
