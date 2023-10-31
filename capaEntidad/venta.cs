using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class venta
    {
        public int id_venta {  get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }
        public int id_metodo_pago { get; set; }
        public DateTime fecha_venta { get; set; }
        public DateTime fecha_creacion_venta { get; set; }
    }
}
