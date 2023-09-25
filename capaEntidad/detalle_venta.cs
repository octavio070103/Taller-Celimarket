using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class detalle_venta
    {
        public int id_detalle_venta {  get; set; }
        public int cantidad_detalle_venta { get; set; }
        public decimal precio_detalle_venta { get; set; }
        public decimal subtotal_detalle_venta { get; set; }
        public producto obj_id_producto { get; set; }
        public venta obj_id_venta { get; set; }
       
      


    }
}
