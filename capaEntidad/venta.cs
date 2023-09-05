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
        public usuario id_usuario { get; set; }
        public cliente id_cliente { get; set; }
        public metodo_pago id_metodo_pago { get; set; }
        public string fecha_venta { get; set; }
       

    }
}
