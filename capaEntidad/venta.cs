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
        public usuario obj_usuario { get; set; }
        public cliente obj_cliente { get; set; }
        public metodo_pago obj_metodo_pago { get; set; }
        public string fecha_venta { get; set; }

        public DateTime fecha_creacion_venta { get; set; }
    }
}
