using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.usuario
{
    public partial class FrmPermisoUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public FrmPermisoUsuario(MenuAdministrador p_menuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_menuAdministrador;
        }

        private void FrmPermisoUsuario_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la capa de lógica
            CL_Permiso obj_CL_Permiso = new CL_Permiso();

            List<capaEntidad.permiso> listaPermisos = obj_CL_Permiso.listarPermisos();

            // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarPermisosEnDataGridView(listaPermisos);
        }

        private void mostrarPermisosEnDataGridView(List<capaEntidad.permiso> p_listaPermisos)
        {
            dataGridPermisos.Rows.Clear(); // Limpiar filas existentes

            foreach (capaEntidad.permiso item in p_listaPermisos)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridPermisos.Rows.Add(
                    new object[]
                    { //items de permisos,
                      item.id_permiso,item.fecha_inicio.Date,item.fecha_finalizacion.Date,item.comentario_justificacion,item.estado_aprobacion, //aca tambien casteo mi atributo fecha que es de tipo datetime a date
                       //item de la tabla usuario
                      item.obj_usuario.id_usuario,
                      // item de la tabla rol
                      item.obj_usuario.obj_rol.id_rol,item.obj_usuario.obj_rol.nombre_rol,
                      // item de la tabla persona
                       item.obj_usuario.obj_persona.id_persona,item.obj_usuario.obj_persona.dni,item.obj_usuario.obj_persona.nombre,item.obj_usuario.obj_persona.apellido,item.obj_usuario.obj_persona.telefono,
                       // item de la tabla domicilio
                       item.obj_usuario.obj_domicilio.id_domicilio,item.obj_usuario.obj_domicilio.numero,item.obj_usuario.obj_domicilio.calle,

                       item.estado_permiso== 1 ? "Activo" : "No activo"//este item es de la tabla permiso y me permiute mostrar si el permiso se encuentra activo o no 
                     }
                 );

            }
            dataGridPermisos.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid
           
        }
    }
}
