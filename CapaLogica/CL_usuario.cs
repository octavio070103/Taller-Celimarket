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

        public usuario AutenticarUsuario(string dni, string password)
        {
            // Llamamos al método de autenticación en la capa de datos
            return  obj_cd_usuario.AutenticarUsuario(dni, password);
        }

        public usuario buscarUsuario(int id_usuario)
        {
            return obj_cd_usuario.buscarUsuario(id_usuario);
        }

        public int registrarUsuario(usuario obj_usuario,out string mensaje)
        {
            //si pasa las reglas de validacion que cree que se llame al metodo registrar y sino que se retorne 0 que es como un null
            if (validacionUsuario(obj_usuario, out mensaje))
            {
                /* Generar el hash de la contraseña
                string hashContrasena = BCrypt.Net.BCrypt.HashPassword(obj_usuario.password);
                 obj_usuario.password = hashContrasena;
               string hashContrasena = BCrypt.Net.BCrypt.EnhancedHashPassword(obj_usuario.password, 13);
                obj_usuario.password = hashContrasena;*/

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
        /*aca pueddo crear un metodo llamado validar que me valide que no venga vacio algunos campos de la capa de presnetacion tambien ,debo de agregar mas reglas mas adelante*/
        public bool validacionUsuario(usuario obj_usuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool validacion = true;

            if (obj_usuario.dni == "")
            {
                mensaje += "es necesario el documento del usuario";
                validacion = false;
            }

            if (obj_usuario.nombre == "")
            {
                mensaje += "es necesario el nombrre del usuario";
                validacion = false;
            }

            if (obj_usuario.apellido == "")
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
