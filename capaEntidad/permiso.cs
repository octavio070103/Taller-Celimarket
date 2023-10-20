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
        public string estado_aprobacion { get; set; }//este atributo me permite saber si la solicutd de permiso fue aceptada o rechazada por el administrador  puede ser pendiente,aprobada,rechazada
        public int estado_permiso { get; set; }
        public usuario obj_usuario { get; set; }


    }
}
