using CapaDatos;
using capaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Consulta
    {
        CD_Consulta obj_CD_Consulta = new CD_Consulta();

        /**********************************metodos para La tabla Consulta *******************************************/
        public int registrarConsulta(consulta obj_consulta,out string mensaje)
        {
            return obj_CD_Consulta.registrarConsulta(obj_consulta,out mensaje);
        }

        public List<consulta> listarConsulta()
        {
            return obj_CD_Consulta.listarConsulta();
        }

        public List<consulta> listarConsultaFiltrado(string p_txtFIltro, string atributo)
        {
            List<consulta> listaConsultaFiltrado = new List<consulta>();
            //aca hago una validacion de que los valores que me llegan no sean nulos o me lleguen vacios,sino son vacio o nulos entra al if
            if (!string.IsNullOrWhiteSpace(p_txtFIltro) && !string.IsNullOrWhiteSpace(atributo))
            {
                listaConsultaFiltrado = obj_CD_Consulta.listarConsultaFiltrado(p_txtFIltro, atributo);
            }
            else//si es vacio o nulo que me lista los permisos completos sin ningun filtro aplicado
            {
                listaConsultaFiltrado = obj_CD_Consulta.listarConsulta(); //aca no estarian filtrado estarian completos estos me ayudaria a que si el usuario ingresa vacio o un null ,no me filtre sino que me muestre la lista completa sin filtros
            }

            return listaConsultaFiltrado; //si paso el anterior if me devuvle la lista cargada sino me devuelve la lista vacia
        }

        public consulta buscarPermisoPorIdConsulta(int id_consulta)
        {
            return obj_CD_Consulta.buscarPermisoPorIdConsulta(id_consulta);
        }

        //busco el consulta katraves del id_usuario y selecciono las consultas echas por ese usuario ya que un usuario puede tener varias cosnultas
        public List<consulta> buscarConsultasPorIdUsuario(int id_usuario)
        {
            return obj_CD_Consulta.buscarConsultasPorIdUsuario(id_usuario);
        }
        public bool cambiarEstadoConsulta(consulta obj_consulta, out string mensaje)
        {
            return obj_CD_Consulta.cambiarEstadoConsulta(obj_consulta, out mensaje);
        }

        /**********************************metodos para La tabla Motivo consulta *******************************************/
        public List<motivo_consulta> listaMotivosConsulta() { 
            return obj_CD_Consulta.listaMotivosConsulta();
        }

        //obtengo el id_motivo atraves del nombre_motivo_permiso este metodo me permite al momento de crear un obj_permiso pasarle el id_motivo_permiso 
        public int obtenerIDMotivoConsultaSeleccionada(string nombre_motivo_permiso)
        {
            return obj_CD_Consulta.obtenerIDMotivoConsultaSeleccionada(nombre_motivo_permiso);
        }
    }
}
