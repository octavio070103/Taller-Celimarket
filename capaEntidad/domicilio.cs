using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class domicilio
    {
        public int id_domicilio {  get; set; }
        public string calle { get; set; }
        public int codigo_postal { get; set; }
        public int numero { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
        public string descripcion {  get; set; }
        public int estado_domicilio { get; set; }

        public DateTime fecha_creacion_domicilio { get; set; }
    }
}
