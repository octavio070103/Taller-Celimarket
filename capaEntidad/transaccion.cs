using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class transaccion
    {
        public DateTime fecha_hora {  get; set; }
        public int numero_transaccion {  get; set; }
        public string tipo_transacion {  get; set; }
        public string vendedor {  get; set; }
        public string cliente {  get; set; }
        public string metodo_pago_transacion { get; set; }

        public List<producto> productos_transaccion { get; set; } //con este atributo guardaria los productos relacionados con esa transacion

        /*inicialiazmos el atributo productos_transaccion como una nueva lista vacia cuando se cree una instancia de transaccion asi nos aseguramos que cuando se cree la lista este vacia  y no sea nula*/
        public transaccion()
        {
            productos_transaccion = new List<producto>();
        }

    }
}
