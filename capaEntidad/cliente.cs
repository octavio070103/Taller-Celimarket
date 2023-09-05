using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class cliente
    {
        public int id_cliente {  get; set; }
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public int dni {  get; set; }
        public int telefono { get; set; }
        public string direccion {  get; set; }
        public bool estado { get; set; }

    }
}
