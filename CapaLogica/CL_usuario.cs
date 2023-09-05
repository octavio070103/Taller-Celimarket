using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_usuario
    {
        private CD_usuario obj_cd_usuario = new CD_usuario();
        //retorna la lista que esta en nuestra caaps de datos de ususarios
        public List<usuario> listar()
        {

            return obj_cd_usuario.listar();
        }
    }
}
