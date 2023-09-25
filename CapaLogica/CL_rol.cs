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
    }
}
