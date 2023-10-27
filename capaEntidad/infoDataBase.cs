using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class infoDataBase
    {
        public string ruta_DB_Backup { get; set; }
        public DateTime fecha_DB_Backup { get; set }
        public string tipo_Backup { get; set; }
        public int totalTablas {get;set;}
        public string NombresTablas { get; set;}
        public int size_DB {  get; set; }
    }
}
