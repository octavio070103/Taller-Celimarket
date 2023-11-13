using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    /********metodo usados para traer datos de la venta por caja*****/
    public class ventaCaja
    {
        public int id_venta { get; set; }
        public usuario obj_usuario { get; set; }
        public cliente obj_cliente { get; set; }
        public metodo_pago obj_metodo_pago { get; set; }
        public DateTime fecha_venta { get; set; }
        public DateTime fecha_creacion_venta { get; set; }
        public caja_apertura obj_caja_apertura { get; set; }
        public producto obj_producto { get; set; }
        public int cantidad_venta { get; set; }
        public decimal subtotal {  get; set; }
    }

    public class MetPagoDeVentas
    {
        public int id_tipo_metPago { get; set; }
        public int cant_vent_tipo_tipo_metPago { get; set; }
        public decimal total_vent_tipo_tipo_metPago { get; set; }
    }
}
