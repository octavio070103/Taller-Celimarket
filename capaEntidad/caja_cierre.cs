using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class caja_cierre
    {
        public int id_cierre_caja {  get; set; }
        public caja_apertura obj_caja_apertura {  get; set; }
        public DateTime fecha_cierre_caja { get; set; }
        public usuario obj_usuario { get; set;}
        public decimal monto_final {  get; set; }
        public decimal diferencia_cierre_Caja { get; set; }
        public int estado_cierre { get; set; }
    }
}
