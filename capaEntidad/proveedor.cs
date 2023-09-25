using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class proveedor
    {
        public int id_proveedor {  get; set; }
        public int dni {  get; set; }

        public string nombre { get; set; }
        public string email {  get; set; }
        public int telefono { get; set; }
        public bool estado_proveedor { get; set; }

    }
}
