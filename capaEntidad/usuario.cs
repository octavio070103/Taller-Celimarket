using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class usuario
    {
        public int id_usuario {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni {  get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string telefono { get; set; }
        public rol obj_rol { get; set; }
        public domicilio obj_domicilio { get; set; }
        public bool estado_usuario { get; set; }
    }
}
