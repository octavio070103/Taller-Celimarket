using CapaLogica;
using ClosedXML.Excel;
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
            DataGridDisenio.Formato(dataGridCategoria, 1); //llamo a la clase datagrid disenio que le da el formato 1 a ese data grid 

            // Crear una instancia de la capa de lógica para hacer uso de los metodos que tiene esa clase CL_categoria que esta en la capa logica
            CL_Categoria obj_CL_Categoria = new CL_Categoria();

            List<capaEntidad.categoria> listaCategorias = obj_CL_Categoria.listarCategorias();// Obtener la lista de categorias desde la capa de lógica

            // llamo al metodo Mostrar la lista de categorias en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarCategoriasEnDataGridView(listaCategorias);

            ReadOnlyCamposDatoCategoria(true);//configuro que el panel de datos de la categoria sea en lectura uniucamente es decir le digo que se active esa propiedad
        }

        private void mostrarCategoriasEnDataGridView(List<capaEntidad.categoria> p_listaCategoria)
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
            comboEstadoDato.Text = "Seleccione un Estado"; // aca le paso el texto predeterminado que quiero que tenga el combo
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
            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
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

        /************************************* Guardar MODIFICACION*************************************/
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

                ask = MessageBox.Show("Seguro que desea Editar la Categoria ?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes)
                {
                    capaEntidad.categoria obj_categoria = new capaEntidad.categoria()
                    {
                        id_categoria = Convert.ToInt32(txtIdDato.Text),
                        nombre_categoria = txtNombreDato.Text,
                        descripcion_categoria = txtDescripDato.Text,
                        //usamos un operador ternario o condicional para obtener el valor del estado ya que como es numerico y yo anteriroemnte l oconverti a string lo debo de volver a convertir a int dependiendo de la seleccion del usuario del estado
                        estado_categoria = (comboEstadoDato.SelectedItem as string == "Activo") ? 1 : 0  // esto seria como un if pero en una sola linea estructura :result = (condición) ? valorSiCierto : valorSiFalso;
                    };
                    bool resultaldoEditarCategoria = new CL_Categoria().editarCategoria(obj_categoria, out mensaje); // lamo al metodoeditar y le paso el objeto que recien cree y cargue sus atributos y una var de saldia mensaje

                    if (resultaldoEditarCategoria == true)
                    {
                        MessageBox.Show("La categoria " + obj_categoria.nombre_categoria + " Se edito Corretamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = false;
                        iconBtnCancelar.Visible = false;
                        iconBtnModif.Visible = true;

                        //listo los usuarios aca porque en teoria se actualizo la lista de los usuario es decir que se modifco esa lista entonces la actualizo
                        //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
                        List<capaEntidad.categoria> listaCategorias = obj_CL_Categoria.listarCategorias(); // Obtener la lista de usuarios desde la capa de lógica

                        // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica con esto logro hacer un REFRESH EN EL DATAGRID con los datos nuevos
                        mostrarCategoriasEnDataGridView(listaCategorias);
                        limpiarCamposDato();//limpio los campos del panel de datos 
                    }
                    else
                    {
                        MessageBox.Show("La categoria " + obj_categoria.nombre_categoria + " No se edito Corretamente,Intentelo de nuevo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = true;
                        iconBtnCancelar.Visible = true;
                        iconBtnModif.Visible = false;

                        limpiarCamposDato();//limpio los campos del panel de datos 
                    }

                    //aca muestro en caso de que haya habido algun error en el metodo resultadoEditarUsuario el error del mensaje o en caso de exito tmabien muestro el mensaje proveniente de mi proceso alamcenado
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                    }

                }

            }

        }

        private bool validarCampos()
        {
            bool validacion = true;


            return validacion;
        }
        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
        }

        /************************************* DAR DE BAJA *************************************/
        private void iconBtnDarBaja_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CL_Categoria obj_CL_Categoria = new CL_Categoria();

            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridCategoria.SelectedRows.Count > 0 && Convert.ToInt32(txtIdDato.Text) > 0)
            {

                DialogResult consulta = MessageBox.Show("¿Desea Dar de baja la Categoria " + txtNombreDato.Text + "?", "Dar de Baja Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    //creo un obj_categoria que va a contener el id_ de la categoria a dar de abaj
                    capaEntidad.categoria obj_categoria = new capaEntidad.categoria
                    {
                        id_categoria = Convert.ToInt32(txtIdDato.Text) //aca le paso el id_categoria que necesito para poder hace uso del metodo de dar de baja categoria

                    };


                    obj_CL_Categoria.darBajaCategoriaLogico(obj_categoria, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmGestionarCategorias_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                    //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para poder darlo de baja ", "Dar de Baja Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //aca muestro en caso de que haya habido algun error en el metodo DarDeBaja o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
        }

        /************************************* DAR DE ALTA *************************************/
        private void iconBtnDarAlta_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CL_Categoria obj_CL_Categoria = new CL_Categoria();

            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridCategoria.SelectedRows.Count > 0 && Convert.ToInt32(txtIdDato.Text) > 0)
            {

                DialogResult consulta = MessageBox.Show("¿Desea Dar de Alta la Categoria " + txtNombreDato.Text + "?", "Dar de Alta Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    //creo un obj_categoria que va a contener el id_ de la categoria a dar de abaj
                    capaEntidad.categoria obj_categoria = new capaEntidad.categoria
                    {
                        id_categoria = Convert.ToInt32(txtIdDato.Text) //aca le paso el id_categoria que necesito para poder hace uso del metodo de dar de baja categoria

                    };


                    obj_CL_Categoria.darDeAltaCategoria(obj_categoria, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmGestionarCategorias_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                    //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para poder darlo de Alta ", "Dar de Alta Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //aca muestro en caso de que haya habido algun error en el metodo DarDeBaja o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            //aca digo que me permita imprimir el excel solo si posee alguna fila el datagrid 
            if (dataGridCategoria.Rows.Count > 0)
            {
                DataTable datatableExcel = new DataTable(); //aca creo un obj datatable "datatableExcel" para poder guardar el encabezado de cada columna

                foreach (DataGridViewColumn columna in dataGridCategoria.Columns) //aca digo que recorra las columns de mi datagrid categoria
                {
                    datatableExcel.Columns.Add(columna.HeaderText, typeof(string)); //aca agrego el headertext de mi columna que se esta recorriendo en ese momento al datatableExcel  es decir inserto todas las cabceras en mi datagridexcel
                }

                //recorro y inserto todas mis filas de mi datagrid categoria en mi datatableexcel que es de tipo datatable
                foreach (DataGridViewRow filas in dataGridCategoria.Rows) //aca digo que recorra las columns de mi datagrid categoria
                {
                    //aca digo que se guarden en el excel solo las filas que estan visibles en ese momento ej.si aplico un filtro de que filas mostrar que solo guarden esas filas visibles unicamente en el excel
                    if (filas.Visible)
                    {
                        //aca creo un nuevo objeto array y accedo a una fila y en esa fila que accedi que se guarden lso valores de cada cells o celda de cada columna , y asi haria con cada fila de mi datagridpwemiso
                        datatableExcel.Rows.Add(new object[]
                        {//aca guardo los valores de las columnas de esa fila que accedi puedo guardar todas las columnsa o puedo poner solo las columnas que quiero el valor pero debe de coincidir con la cabecera que guarde
                            filas.Cells[0].Value.ToString(),
                            filas.Cells[1].Value.ToString(),
                            filas.Cells[2].Value.ToString(),
                            filas.Cells[3].Value.ToString(),

                        });
                    }
                }

                //aca le pregunto al usuario en que parte quiere guardar al archivo excel a este obj lo llamare saveFile
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteCategoria{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss")); //aca le asigno el nobre predetemrinado que tendra mi archivo y con format obtengo un mayor control sobre el texto luego al nombre le concateno la fecha y hora
                saveFile.Filter = "Excel Files | *.xlsx"; //aca estoy agregando un filtro a la ventana de donde quiero que se guarden para que al momento de mostrarse solo se muestren ese tipo de archivos con esa extension

                //aca digo si en el evento showdialog de la ventana de savefile se dio al evento ok que entre al if
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //aca comienzo a manipular el nugget de excel que instale para poder crear y exportar el mismo 
                        XLWorkbook wb = new XLWorkbook(); //aca creo el archivo excel
                        var hoja = wb.Worksheets.Add(datatableExcel, "Informe Categoria"); //aca creo una variable que sera la hoja de mi excel
                        hoja.ColumnsUsed().AdjustToContents(); //aca le decimo que se ajuste el contenido al ancho de las columnnas que tienen contenidos unicamente
                        wb.SaveAs(saveFile.FileName); //aca con el saveas (guardar como) guardo mi excel en la ruta que le paso como parametro que determine anteriormente en savefile.filename
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo Generar el Reporte, ocurrio un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
