using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class detalle_compra
    {
        public int id_detalle_compra {  get; set; }
        public string nombre_producto {  get; set; }
        public float precio_compra { get; set; }
        public int cantidad {  get; set; }
        public float total {  get; set; }
        public compra obj_compra { get; set; }

    }
}
