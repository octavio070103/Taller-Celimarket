using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class producto
    {
        public int Idproducto { get; set; }
        public categoria obj_categoria { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public decimal precio_compra {  get; set; }
        public decimal precio_venta { get; set; }
        public int producto_stock { get; set; }
        
        //aca establesco el atributo fotoUSUario qeu va a ser un arreglo byte para guardar la foto de mis empleados,encapsulo a ese atributo con el get y set
        public byte[] imagen { get; set; }
        public bool estado_producto { get; set; }

    }
}
