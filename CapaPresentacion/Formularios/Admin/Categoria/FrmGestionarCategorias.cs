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


            //  dataGridCategoria.DataSource = obj_CL_Categoria.listarCategorias();
            List<capaEntidad.categoria> listaCategorias = obj_CL_Categoria.listarCategorias();
            mostrarUsuariosEnDataGridView(listaCategorias);
        }

        private void mostrarUsuariosEnDataGridView(List<capaEntidad.categoria> p_listaCategoria)
        {
            dataGridCategoria.Rows.Clear(); // Limpiar filas existentes

            foreach (capaEntidad.categoria item in p_listaCategoria)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridCategoria.Rows.Add(
                    new object[]
                    { //items de la categoria
                      item.id_categoria,
                      item.nombre_categoria,
                      item.descripcion_categoria,
                      item.estado_categoria == 1 ? "Activo" : "No activo" // Determinar el estado del usuario si es 1=activo
                      }
                 );

            }
            dataGridCategoria.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid
            // Ocultar los botones
            iconbtnGuardar.Visible = false;
            iconBtnCancelar.Visible = false;
        }


        private void iconBtnAgregarCateg_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria formCatego = new FrmRegistrarCategoria();
            formCatego.Show();
        }

        private void iconBtnProducto_Click(object sender, EventArgs e)
        {
            this.obj_intancia_menuAdmin.OpenChildForm(new Producto.FrmGestionarProducto(this.obj_intancia_menuAdmin));
        }

        private void dataGridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
