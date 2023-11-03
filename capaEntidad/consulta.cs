using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class consulta
    {
        public int id_consulta {  get; set; }
        public string comentario_consulta { get; set; }
        public string estado_consulta { get; set;}
        public DateTime fecha_consulta { get; set;}
        public usuario obj_usuario { get; set; }
        public motivo_consulta obj_motivo_consulta { get; set;}
    }
}
