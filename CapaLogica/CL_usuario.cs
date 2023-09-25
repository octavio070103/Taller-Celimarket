using CapaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaLogica
{
    public class CL_usuario
    {
        private CD_usuario obj_cd_usuario = new CD_usuario();
        //retorna la lista que esta en nuestra caaps de datos de ususarios
        public List<usuario> listarUsuarios()
        {

            return obj_cd_usuario.listarUsuarios();
      
        }
        
        //para listar los usuarios filtrados reutilizamo el metodo listarUsuario utilizando el meotodo where le pasamos la condicion de busqueda que en este caso es que 
        // no sea nulo el ttxBox que me viene con el dato del filtro y que si ese usuario que se esta por listar en su atributo  es igual al texto del filtro
        public List<usuario> listarUsuarioFiltrados(string p_txtFIltro ,string atributo)
        {
            
            return obj_cd_usuario.listarUsuarios()//retorna la lista que esta en nuestra caaps de datos de ususarios pero le paso una operacion where la cual me permitre filtrar los usuarios dependiendo del filtro escrito
                 
                .Where(usuario =>
                      (string.IsNullOrEmpty(p_txtFIltro)) ||
                      (atributo == "dni" && usuario?.obj_persona.dni?.ToLower()?.Contains(p_txtFIltro) == true)||                   //cuando el usuario ingresa un valor nulo o vacío en el filtro, obtendrás todos los elementos sin filtrar. Si el usuario ingresa un valor válido en el filtro, obtendrás solo los elementos que cumplan con ese filtro.
                      (atributo == "nombre" && usuario?.obj_persona.nombre?.ToLower()?.Contains(p_txtFIltro) == true) ||
                      (atributo == "apellido" && usuario?.obj_persona.apellido?.ToLower()?.Contains(p_txtFIltro) == true) ||
                      (atributo == "rol" && usuario?.obj_rol.descripcion_rol == p_txtFIltro) 
                    // || (p_txtFIltro == "Estado del usuario" || usuario?.estado_usuario == Convert.ToInt32(p_txtFIltro)) 
                      )
                .ToList(); //aca decimos que si el txt del filtro es null o vacia significa que no se ha proporcionado un filtro por lo que nose aplica ningun filtro en la busqueda ,esto me permite obtener la lista de usuarios sin filtros cuando el txt es null o vacio
             
            // aca convierto el conenitdo del atributo en minuscula y con el ? es un operador seguro el cual si es nulo no se evaluara mas 
            //luego con cotanins lo que hago es verficiar el contenido del atributo dni que contenga la cadena de texto especificada o igual valor a el filtro que le paso como parametro


        }

        public usuario AutenticarUsuario(string dni, string password)
        {
            // Llamamos al método de autenticación en la capa de datos
            return  obj_cd_usuario.AutenticarUsuario(dni, password);
        }

        public usuario buscarUsuario(int id_usuario)
        {
            return obj_cd_usuario.buscarUsuario(id_usuario);
        }

        public int registrarUsuario(usuario obj_usuario, out string mensaje)
        {
            //si pasa las reglas de validacion que cree que se llame al metodo registrar y sino que se retorne 0 que es como un null
            if (validacionUsuario(obj_usuario, out mensaje))
            {
                /* Generar el hash de la contraseña*/
                // obj_usuario.password = hashContrasena;
                /* string hashContrasena = BCrypt.Net.BCrypt.EnhancedHashPassword(obj_usuario.password, 13);
                  obj_usuario.password = hashContrasena;*/

                obj_usuario.password = BCrypt.Net.BCrypt.HashPassword(obj_usuario.password);
  
                return obj_cd_usuario.registrarUsuario(obj_usuario, out mensaje);//le pasamos los parametros 
            }
            else
            {
                return 0;
            }

        }


        public bool editarUsuario(usuario obj_usuario, out string mensaje)
        {
            return obj_cd_usuario.editarUsuario(obj_usuario, out mensaje);//le pasamos los parametros 
        }

        public bool eliminarUsuarioFisica(usuario obj_usuario, out string mensaje)
        {
            return obj_cd_usuario.eliminarUsuarioFisica(obj_usuario, out mensaje);//le pasamos los parametros ,en out mensaje le digo que este parametro se utiliza para pasar info al emtodo y para recibir informacion desde el metodo le indico que es un paramemtro de salida
        }
        public bool eliminarUsuarioLogico(usuario obj_usuario,out string mensaje)
        {
            return obj_cd_usuario.eliminarUsuarioLogico(obj_usuario,out mensaje);
        }

        public bool darDeAltaUsuario(usuario obj_usuario, out string mensaje)
        {
            return obj_cd_usuario.darDeAltaUsuario(obj_usuario, out mensaje);
        }



        /*aca pueddo crear un metodo llamado validar que me valide que no venga vacio algunos campos de la capa de presnetacion tambien ,debo de agregar mas reglas mas adelante*/
        public bool validacionUsuario(usuario obj_usuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool validacion = true;
            
            if (obj_usuario.obj_persona.dni == "")
            {
                mensaje += "es necesario el documento del usuario";
                validacion = false;
            }

            if (obj_usuario.obj_persona.nombre == "")
            {
                mensaje += "es necesario el nombrre del usuario";
                validacion = false;
            }

            if (obj_usuario.obj_persona.apellido == "")
            {
                mensaje += "es necesario el apellido del usuario";
                validacion = false;
            }

            if (obj_usuario.password == "")
            {
                mensaje += "es necesario la contraseña del usuario";
                validacion = false;
            }

            return validacion;
        }

        
    }
}
