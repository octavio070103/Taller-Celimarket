using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class productoMasVendido
    {
        public string nombreProducto { get; set; }
        public int cantidadVendida { get; set; }

    }

    public class categoriaMasVendida
    {
        public string nombreCategoria { get; set; }
        public int cantidadVendida { get; set; }
    }

    public class ProductosMasVendidosDelMes
    {
        public int id_producto { get; set; }
        public int cantProducVendido { get; set; }
        public string nombre_producto { get; set; }
    }


    public class vendedorMasVentas
    {
        public string nombreVendedor { get; set; }
        public int cantidadVentas { get; set; }
    }
}
