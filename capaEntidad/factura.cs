using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class factura
    {
        public int nroFactura { get; set; }
        public string nombreCliente { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string fechaVenta { get; set; }
        public string nombreNegocio { get; set; }
        public string cuitNegocio { get; set; }
        public string direccionNegocio { get; set; }
    }
}
