using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class compra
    {
        public int id_compra {  get; set; }
        public DateTime fecha_registro { get; set; }
        public proveedor obj_proveedor {  get; set; }
        public usuario obj_usuario { get; set;}
        
    }
}
