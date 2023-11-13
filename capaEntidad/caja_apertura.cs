using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class caja_apertura
    {
         public int id_apertura_caja {  get; set; }
         public DateTime fecha_apertura {  get; set; }
        public decimal monto_inicial_apertura {  get; set; }
        public usuario obj_usuario { get; set; }
        public int estado_apertura {  get; set; }
    }
}
