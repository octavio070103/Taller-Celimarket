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
        public string dni_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string fechaVenta { get; set; }
        public string nombreNegocio { get; set; }
        public string cuitNegocio { get; set; }
        public string direccionNegocio { get; set; }
        public string email_negocio { get; set; }
        public string telefono_negocio { get; set; }
        public string nombreVendedor { get; set; }
        public string dniVendedor { get; set; }
        public string nombre_metodo_pago { get; set; }
        public string nombre_tipo_pago { get; set; }
    }
}
