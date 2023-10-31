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
        public float precio_detalle_venta { get; set; }
        public float subtotal_detalle_venta { get; set; }
        public DateTime fecha_creacion_detalle_venta { get; set; }
        public int id_producto { get; set; }
        public int id_venta { get; set; }
       
      


    }
}
