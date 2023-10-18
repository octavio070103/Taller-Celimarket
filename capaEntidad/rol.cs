using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class rol
    {
        public int id_rol {  get; set; }
        public string nombre_rol {  get; set; }
        public int estado_rol { get; set; }
        public DateTime fecha_creacion_rol { get; set; }
    }
}
