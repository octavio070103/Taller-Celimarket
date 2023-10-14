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
            // Crear una instancia de la capa de lógica para hacer uso de los metodos que tiene esa clase CL_categoria que esta en la capa logica
            CL_Categoria obj_CL_Categoria = new CL_Categoria();

            List<capaEntidad.categoria> listaCategorias = obj_CL_Categoria.listarCategorias();// Obtener la lista de categorias desde la capa de lógica

            // llamo al metodo Mostrar la lista de categorias en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarUsuariosEnDataGridView(listaCategorias);

            ReadOnlyCamposDatoCategoria(true);//configuro que el panel de datos de la categoria sea en lectura uniucamente es decir le digo que se active esa propiedad
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

        private void dataGridCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; //con esta sentencia  obtengo la fila seleccionada su indice
                                     //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                limpiarCamposDato(); //limpio los campos del panel de datos categoria

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridCategoria.Rows[indice];

                // Obtener los datos necesarios de la fila  obteniuendo de esa fila selecciona su id_categoria(cells [0] y el valor de este(suponiendo que la columna 0 contiene la columna ID)
                int id_categoria = Convert.ToInt32(selectedRow.Cells[0].Value);//toma el valor alamcenadoi en la 1ra celda de la fila seleccionada y lo asigna a esa var

                CL_Categoria obj_CL_Categoria = new CL_Categoria();

                capaEntidad.categoria obj_categoria = obj_CL_Categoria.buscarCategoriaId(id_categoria);

                //si el obj_categoria que contiene la categoria que se selecciono o que se busco es != null significa que se encontro entronces entra al id para mostrar sus data en el panel de datos
                if (obj_categoria != null)
                {
                    txtIdDato.Text = obj_categoria.id_categoria.ToString();
                    txtNombreDato.Text = obj_categoria.nombre_categoria;
                    txtDescripDato.Text = obj_categoria.descripcion_categoria;

                    //cargo el comnbo estado del usuario añadimos las opciones al comboBox  y luego decimos que dependiendo del estado_usuario que tiene que se seleccione esa opcion como predeterminada
                    comboEstadoDato.Items.Add("Activo");
                    comboEstadoDato.Items.Add("No activo");
                    if (obj_categoria.estado_categoria == 1)
                    {
                        comboEstadoDato.SelectedIndex = 0;

                        //me permitira determinar que boton mostrarse si el de dar de alta o el de dar de baja depnediendo del estado del usuario que se seleccion
                        iconBtnDarBaja.Visible = true;
                        iconBtnDarAlta.Visible = false;
                    }
                    else
                    {
                        comboEstadoDato.SelectedIndex = 1;
                        //me permitira determinar que boton mostrarse si el de dar de alta o el de dar de baja depnediendo del estado del usuario que se seleccion
                        iconBtnDarBaja.Visible = false;
                        iconBtnDarAlta.Visible = true;
                    }

                }
            }
        }
        private void ReadOnlyCamposDatoCategoria(bool valor)
        {
            //el parametro valor contiene el valor True o False dependiendo si quiero que este en modo lectura(true) o en modo edicion los campos (false)
            txtIdDato.ReadOnly = valor;
            txtNombreDato.ReadOnly = valor;
            txtDescripDato.ReadOnly = valor;

            //usamos la propeidad enable para que parezca esatr en modo lectura(para el comoboBox) y evitar cambios por parte del usuario que intereactua o que se pueda editar dependiendo del valor,como esta propiedad usa el valor contrario al readOnly para ponerse en modo lectura le agrgamos el ! operador de negacion esto cambiara el valor y asi podremos hacer uso de esa propeidad
            comboEstadoDato.Enabled = !valor;
        }

        private void limpiarCamposDato()
        {
            txtIdDato.Text = "";
            txtNombreDato.Text = "";
            txtDescripDato.Text = "";

            // Limpiar el ComboBox Roles Eliminando todos los elementos ya que una vez que el usuario selecciona otros datos o slae del panel de datos del usuario debo de limpiarlo para que nose cargue siempre el combobox
            comboEstadoDato.Items.Clear();
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

        /************************************* MODIFICAR *************************************/
        private void iconBtnModif_Click(object sender, EventArgs e)
        {
            //aca digo que si el usuario selecciono una columna en el data grid y ademas el txtid que se encarga de guardar el id del uusario selecionado es disitinto de 0 que entre al if
            //esto lo hago ay que asi me aseguro de que el usuario selecciono una columna en el data grid y que ademas es un usuario valido pq su id es distinto de 0
            if (dataGridCategoria.SelectedRows.Count > 0 && Convert.ToInt32(txtIdDato.Text) > 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Editar los datos De la categoria?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (consulta == DialogResult.OK)
                {

                    iconbtnGuardar.Visible = true;
                    iconBtnCancelar.Visible = true;
                    iconBtnModif.Visible = false;
                    ReadOnlyCamposDatoCategoria(false);//configuro el panel del usuario en modo edicion deshabilit ando la funcion ReadOnly
                }
                //hago para que los text pasen de modo lectura a poder escrbirse sobre ellos 
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para poder editarlo ", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            //crear una instancia de la capa de logica de la clase CL_categoria
            CL_Categoria obj_CL_Categoria = new CL_Categoria();

            if (validarCampos())
            {
                // // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
           //     borrarMensajeError();//borro los mensjaes de error en caso que lo haya

                ask = MessageBox.Show("Seguro que desea Editar la Categoria ?","Confirmar Insercion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes)
                {

                }
            }
            
        }

        private bool validarCampos()
        {
            bool validacion = true;


            return validacion;
        }
    }
}
