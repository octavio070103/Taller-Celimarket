using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Categoria
    {
        private CD_Categoria obj_cd_categoria = new CD_Categoria();

        //retorna la lista que esta en nuestra caaps de datos de categorias
        public List<categoria> listarCategorias()
        {
            return obj_cd_categoria.listarCategorias();
        }

        public int registrarCategoria(categoria obj_categoria, out string mensaje)
        {
            return obj_cd_categoria.RegistrarCategoria(obj_categoria, out mensaje);
        }

        public bool editarCategoria(categoria obj_categoria,out string mensaje)
        {
            return obj_cd_categoria.editarCategoria(obj_categoria, out mensaje);//le pasamos los parametros 
        }

        public bool eliminarCategoriaLogico(categoria obj_categoria, out string mensaje)
        {
            return obj_cd_categoria.eliminarCategoriaLogico(obj_categoria, out mensaje);//le pasamos los parametros 
        }

        public bool darDeAltaCategoria(categoria obj_categoria, out string mensaje)
        {
            return obj_cd_categoria.darDeAltaCategoria(obj_categoria, out mensaje);
        }

        public categoria buscarCategoriaId(int id_categoria)
        {
            return obj_cd_categoria.buscarCategoriaId(id_categoria);
        }

        /*aca pueddo crear un metodo llamado validar que me valide que no venga vacio algunos campos de la capa de presnetacion tambien ,debo de agregar mas reglas mas adelante*/

    }
}
