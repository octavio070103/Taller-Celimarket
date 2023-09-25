using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class permiso
    {
        public int id_permiso { get; set; }
        public string tipo_permiso { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_finalizacion {  get; set; }
        public string comentario_justifiacion {  get; set; }
        public int estado_permiso { get; set; }
        public usuario obj_usuario { get; set; }


    }
}
