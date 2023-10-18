using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using capaEntidad;

namespace CapaLogica
{
    public class CL_Producto
    {
        private CD_Producto obj_cd_producto = new CD_Producto();//instancio un obj  obj_cd_producto de tipo CD_producto

        //retorna la lista de productos que esta en nuestra capas de datos 
        public List<producto> listarProductos()
        {
            return obj_cd_producto.listarProductos();
        }

        public producto buscarProducto(int id_producto)
        {
            return obj_cd_producto.buscarProducto(id_producto);
        }

        public int registrarProducto(producto obj_producto, out string mensaje)
        {
            //si pasa las reglas de validacion que cree que se llame al metodo registrar y sino que se retorne 0 que es como un null
            if (validacionUsuario(obj_producto, out mensaje))
            {
                return obj_cd_producto.registrarProducto(obj_producto, out mensaje);//le pasamos los parametros 
            }
            else
            {
                return 0;
            }
        }

        public bool editarProducto(producto obj_producto, out string mensaje)
        {
            return obj_cd_producto.editarProducto(obj_producto, out mensaje);//le pasamos los parametros 
        }

        public bool darDeBajaProducto(producto obj_producto, out string mensaje)
        {
            return obj_cd_producto.darDeBajaProducto(obj_producto,out mensaje);//le pasamos los parametros 
        }
        public bool darDeAltaProducto(producto obj_producto, out string mensaje)
        {
            return obj_cd_producto.darDeAltaProducto(obj_producto, out mensaje);//le pasamos los parametros 
        }
        //con este metodo obtengo el id_producto atraves del nombre_producto que lo recibo como parametro
        public int obtenerIDProductoSeleccionada(string nombre_producto)
        {
            return obj_cd_producto.obtenerIDProductoSeleccionada(nombre_producto);
        }

        /*aca pueddo crear un metodo llamado validar que me valide que no venga vacio algunos campos de la capa de presnetacion tambien ,debo de agregar mas reglas mas adelante*/
        public bool validacionUsuario(producto obj_productoo, out string mensaje)
        {
            mensaje = string.Empty;
            bool validacion = true;

            return validacion;
        }
    }
}
