using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    //esta clase contendra los datos del negocio que obenemos del proc de estadisitcas  para el dashboard
    public class negocioEstadistica
    {
        public int nroVentas {  get; set; }
        public float totalRecaudado {  get; set; }
        public int nroClientes {  get; set; }
        public int nroEmpleado {  get; set; }
        public int nroProveedores {  get; set; }
        public int nroProductos {  get; set; }
        public int totalStock {  get; set; }
        public string estadoStock {  get; set; }

    }
}
