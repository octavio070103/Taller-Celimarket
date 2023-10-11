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

namespace CapaPresentacion.Formularios.Admin.Categoria
{
    public partial class FrmGestionarCategorias : Form
    {
        private MenuAdministrador obj_intancia_menuAdmin;
        public FrmGestionarCategorias(MenuAdministrador p_menuAdmin)
        {
            InitializeComponent();
           this.obj_intancia_menuAdmin = p_menuAdmin;
        }
        private void FrmGestionarCategorias_Load(object sender, EventArgs e)
        {
            CL_Categoria obj_CL_Categoria = new CL_Categoria();


            dataGridCategoria.DataSource = obj_CL_Categoria.listarCategorias();
        }
        /*
        private void mostrarUsuariosEnDataGridView(List<capaEntidad.usuario> p_listaUsuarios)
        {
            dataGridCategoria.Rows.Clear(); // Limpiar filas existentes

            // Asigna la lista de usuarios al DataGridView (como fuente de datos)
            // dataGridCategoria.DataSource = listaUsuarios;

            foreach (capaEntidad.usuario item in p_listaUsuarios)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridCategoria.Rows.Add(
                    new object[]
                    { //items del usuario
                      item.id_usuario, item.obj_persona.dni,item.obj_persona.nombre,item.obj_persona.apellido,item.email,item.password,item.obj_persona.telefono,
                       //item rol
                       item.obj_rol.id_rol,item.obj_rol.descripcion_rol,
                       item.obj_domicilio.id_domicilio,item.obj_domicilio.calle,item.obj_domicilio.numero,item.obj_domicilio.provincia,
                      // item.estado_usuario==true ? 1 : 0,item.estado_usuario==true ? "Activo" : "NO activo"
                       item.estado_usuario,
                       item.estado_usuario == 1 ? "Activo" : "No activo" // Determinar el estado del usuario si es 1=activo
                      }
                 );

            }
            dataGridUsuarios.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid
            // Ocultar los botones
            iconbtnGuardar.Visible = false;
            iconBtnCancelar.Visible = false;
        }
        */

        private void iconBtnAgregarCateg_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria formCatego = new FrmRegistrarCategoria();
            formCatego.Show();
        }

        private void iconBtnProducto_Click(object sender, EventArgs e)
        {
            this.obj_intancia_menuAdmin.OpenChildForm(new Producto.FrmGestionarProducto(this.obj_intancia_menuAdmin));
        }
    }
}
