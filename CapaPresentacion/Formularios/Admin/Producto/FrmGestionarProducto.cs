using CapaDatos;
using capaEntidad;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.Producto
{
    public partial class FrmGestionarProducto : Form
    {
        private MenuAdministrador instancia_menuAdmin;
        public FrmGestionarProducto(MenuAdministrador p_menuAdmin)
        {
            InitializeComponent();
            this.instancia_menuAdmin = p_menuAdmin;

            DetallesProducto(false);//oculto el detallesProducto el panel
            iconBtnDarBaja.Visible = false;//oculto uno de los botones de dar baja o atla
        }
        private void FrmGestionarProducto_Load(object sender, EventArgs e)
        {
            DataGridDisenio.Formato(dataGridProducto, 1); //llamo a la clase datagrid disenio que le da el formato 1 a ese data grid 

            // Crear una instancia de la capa de lógica
            CL_Producto obj_CL_Producto = new CL_Producto();

            List<capaEntidad.producto> listaProductos = obj_CL_Producto.listarProductos(); // Obtener la lista de productos desde la capa de lógica

            // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarProductosEnDataGridView(listaProductos);

            ReadOnlyCamposDatoProducto(true);//configuro que el panel de datos de la producto sea en lectura uniucamente es decir le digo que se active esa propiedad
        }
        private void mostrarProductosEnDataGridView(List<capaEntidad.producto> p_listaProductos)
        {
            dataGridProducto.Rows.Clear(); // Limpiar filas existentes

            foreach (capaEntidad.producto item in p_listaProductos)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridProducto.Rows.Add(
                    new object[]
                    { //items del producto
                      item.Idproducto,item.cod_barra_producto,item.nombre_producto,item.descripcion_producto,item.precio_compra,item.precio_venta,item.stock_producto,
                       //item de la tabla marca
                      item.obj_marca.nombre_marca,
                      // item de la tabla categoria
                       item.obj_categoria.nombre_categoria,

                       item.estado_producto== 1 ? "Activo" : "No activo",
                       item.imagen //muestor ultimo la imagen
                     }
                 );

            }
            dataGridProducto.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid
            // Ocultar los botones
            iconbtnGuardar.Visible = false;
            iconBtnCancelar.Visible = false;
        }

        /***Evento de Seleccion de un producto en el data grid ***/
        private void dataGridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; //con esta sentencia  obtengo la fila seleccionada su indice
                                     //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                DetallesProducto(true);
                limpiarCamposDato(); //limpio los campos del panel de datos categoria

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridProducto.Rows[indice];

                // Obtener los datos necesarios de la fila  obteniuendo de esa fila selecciona su id_categoria(cells [0] y el valor de este(suponiendo que la columna 0 contiene la columna ID)
                int id_producto = Convert.ToInt32(selectedRow.Cells[0].Value);//toma el valor alamcenadoi en la 1ra celda de la fila seleccionada y lo asigna a esa var

                CL_Producto obj_CL_Producto = new CL_Producto();

                capaEntidad.producto obj_producto = obj_CL_Producto.buscarProducto(id_producto);

                //si el obj_producto que contiene la categoria que se selecciono o que se busco es != null significa que se encontro entronces entra al id para mostrar sus data en el panel de datos
                if (obj_producto != null)
                {
                    txtIdProducto.Text = obj_producto.Idproducto.ToString();

                    //carga el combobox de categoria  Uso de la función con una lista de categorias y el combo de categorias
                    CL_Categoria obj_CL_Categoria = new CL_Categoria();
                    List<categoria> listaCategorias = obj_CL_Categoria.listarCategorias(); //con esta funcion obtenemos una lista de  marcas que estan cargadas en la BD
                    CargarComboBox(listaCategorias, comboCategDato, categoria => categoria.nombre_categoria);

                    //buscamos el índice del categoria del producto en la lista de categoria(de la BD) utilizando FindIndex(traigo el 1er elemenot que cumple la condicion) y una expresión lambda(Las expresiones lambda permiten definir funciones pequeñas y simples en línea, sin la necesidad de declarar un método completo.) que compara el id_rol
                    int indiceCategoria = listaCategorias.FindIndex(c => c.id_categoria == obj_producto.obj_categoria.id_categoria);//a parte c => ... significa que estás definiendo un parámetro r que representa cada elemento de la lista (rol) y, a continuación, especificas una condición. En este caso, la condición es que el id_rol del elemento r sea igual al id_rol del rol asociado al usuario (objUsuario.obj_rol.id_rol).

                    // Si se encontró el índice, selecciona el rol en el ComboBox
                    if (indiceCategoria >= 0)
                    {
                        comboCategDato.SelectedIndex = indiceCategoria;
                    }


                    //carga el combobox de marca  Uso de la función con una lista de marcas y el combo de marca
                    CL_Marca obj_CL_Marca = new CL_Marca();
                    List<marca> listaMarca = obj_CL_Marca.listarMarcas(); //con esta funcion obtenemos una lista de  marcas que estan cargadas en la BD
                    CargarComboBox(listaMarca, comboMarcaDato, marca => marca.nombre_marca);

                    //buscamos el índice del marca del producto en la lista de marcas(de la BD) utilizando FindIndex(traigo el 1er elemenot que cumple la condicion) y una expresión lambda(Las expresiones lambda permiten definir funciones pequeñas y simples en línea, sin la necesidad de declarar un método completo.) que compara el id_rol
                    int indiceMarca = listaMarca.FindIndex(m => m.id_marca == obj_producto.obj_marca.id_marca);//a parte m => ... significa que estás definiendo un parámetro r que representa cada elemento de la lista (rol) y, a continuación, especificas una condición. En este caso, la condición es que el id_rol del elemento r sea igual al id_rol del rol asociado al usuario (objUsuario.obj_rol.id_rol).

                    // Si se encontró el índice, selecciona el rol en el ComboBox
                    if (indiceMarca >= 0)
                    {
                        comboMarcaDato.SelectedIndex = indiceMarca;
                    }

                    txtNombreDato.Text = obj_producto.nombre_producto.ToString();
                    txtStockDato.Text = obj_producto.stock_producto.ToString();
                    txtDescripcionDato.Text = obj_producto.descripcion_producto.ToString();
                    txtPrecioCompraDato.Text = obj_producto.precio_compra.ToString();
                    txtPrecioVenta.Text = obj_producto.precio_venta.ToString();


                    //cargo el comnbo estado del producto añadimos las opciones al comboBox  y luego decimos que dependiendo del estado_usuario que tiene que se seleccione esa opcion como predeterminada
                    comboEstadoDato.Items.Add("Activo");
                    comboEstadoDato.Items.Add("No activo");
                    if (obj_producto.estado_producto == 1)
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
        //si el usuario selecciona una fila para ver su detalles se redimensionan los paneles y se hace visible el editar,redimensiona los botones los cambia de posicion
        private void DetallesProducto(bool valor)
        {
            //si el valor del parametro valor es true significa que se debe de mostrar el panel de datos de usuario
            if (valor == true)
            {
                panelDatosProducto.Visible = true;
                // Establecer el tamaño del data grid es decir lo redimienciono cuando se muestran los detalles del uusario 
                dataGridProducto.Location = new System.Drawing.Point(12, 98);
                dataGridProducto.Size = new System.Drawing.Size(700, 349); // ancho y alto en píxeles

                //reubico los botones
                iconBtnAgregar.Location = new System.Drawing.Point(45, 24);
                iconBtnDarAlta.Location = new System.Drawing.Point(176, 24);
                iconBtnDarBaja.Location = new System.Drawing.Point(176, 24);
                iconBtnCategorias.Location = new System.Drawing.Point(306, 24);
                iconBtnMarca.Location = new System.Drawing.Point(450, 23);
            }
            else //se oculta el panel de detalles de usuario si el valor es false ya que sifnigca que se quiere ocultar el mismo 
            {
                panelDatosProducto.Visible = false;
                // Establecer el tamaño del data grid es decir lo redimienciono cuando se muestran los detalles del uusario 
                dataGridProducto.Location = new System.Drawing.Point(12, 98);
                dataGridProducto.Size = new System.Drawing.Size(800, 349); // ancho y alto en píxeles

                //reubico los botones
                iconBtnAgregar.Location = new System.Drawing.Point(45, 24);
                iconBtnDarAlta.Location = new System.Drawing.Point(176, 24);
                iconBtnDarBaja.Location = new System.Drawing.Point(176, 24);
                iconBtnCategorias.Location = new System.Drawing.Point(306, 24);
                iconBtnMarca.Location = new System.Drawing.Point(450, 23);
            }
        }

        private void limpiarCamposDato()
        {

        }

        //metodo para cargar combobox generico ,este metodo toma un obj de tipo T( tipo generico) y carga el combo box (para distintos objetos y distintos campo que quiero que se cargue dentro del cambo
        //T=tipodeObj representa el tipo de dato con el que trabajara,List<T> es una lista genérica que contiene elementos de tipo T,p_comboBox=es el combo al que quiero cargar,es un delegado funcional que toma un objeto de tipo T y devuelve una cadena.(ej si quiero obtener el nombre de cada rol le pasaria esto rol => rol.Nombre)
        //Esto permite personalizar cómo se extrae el texto de los elementos de la lista de tipo T para mostrarlos en el ComboBox.
        private void CargarComboBox<T>(List<T> lista, System.Windows.Forms.ComboBox p_comboBox, Func<T, string> obtenerTexto) //aca  System.Windows.Forms.ComboBox especifico claramente cual comboBox estoy utilizando en este caso el que es para windows forms hago esto para evitar ambiguedad
        {
            p_comboBox.Items.Clear(); // Limpia los elementos existentes en el ComboBox.

            foreach (T item in lista)
            {
                string texto = obtenerTexto(item);
                p_comboBox.Items.Add(texto);
            }

        }

        private void ReadOnlyCamposDatoProducto(bool valor)
        {
            //el parametro valor contiene el valor True o False dependiendo si quiero que este en modo lectura(true) o en modo edicion los campos (false)
            txtIdProducto.ReadOnly = valor;
            txtNombreDato.ReadOnly = valor;
            txtStockDato.ReadOnly = valor;
            txtDescripcionDato.ReadOnly = valor;
            txtPrecioCompraDato.ReadOnly = valor;
            txtPrecioVenta.ReadOnly = valor;

            //usamos la propeidad enable para que parezca esatr en modo lectura(para el comoboBox) y evitar cambios por parte del usuario que intereactua o que se pueda editar dependiendo del valor,como esta propiedad usa el valor contrario al readOnly para ponerse en modo lectura le agrgamos el ! operador de negacion esto cambiara el valor y asi podremos hacer uso de esa propeidad
            comboEstadoDato.Enabled = !valor;
            comboCategDato.Enabled = !valor;
            comboMarcaDato.Enabled = !valor;
            picImgEditarProducts.Enabled = !valor;
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto formularioAddProduc = new FrmRegistrarProducto(this);
            formularioAddProduc.Show();

        }
        private void iconBtnCategorias_Click(object sender, EventArgs e)
        {
            instancia_menuAdmin.OpenChildForm(new Admin.Categoria.FrmGestionarCategorias(this.instancia_menuAdmin));
        }

        private void iconBtnMarca_Click(object sender, EventArgs e)
        {
            FrmRegistrarMarca formularioRegisMarca = new FrmRegistrarMarca();
            formularioRegisMarca.Show();
        }

        /************************************* DAR DE BAJA *************************************/
        private void iconBtnDarBaja_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CL_Producto obj_CL_Producto = new CL_Producto();

            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridProducto.SelectedRows.Count > 0 && Convert.ToInt32(txtIdProducto.Text) > 0)
            {

                DialogResult consulta = MessageBox.Show("¿Desea Dar de baja el Producto " + txtNombreDato.Text + "?", "Dar de Baja Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    //creo un obj_categoria que va a contener el id_ de la categoria a dar de abaj
                    capaEntidad.producto obj_producto = new capaEntidad.producto
                    {
                        Idproducto = Convert.ToInt32(txtIdProducto.Text) //aca le paso el id_categoria que necesito para poder hace uso del metodo de dar de baja categoria

                    };


                    obj_CL_Producto.darDeBajaProducto(obj_producto, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmGestionarProducto_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                    //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para poder darlo de baja ", "Dar de Baja Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CL_Producto obj_CL_Producto = new CL_Producto();

            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridProducto.SelectedRows.Count > 0 && Convert.ToInt32(txtIdProducto.Text) > 0)
            {

                DialogResult consulta = MessageBox.Show("¿Desea Dar de Alta el Producto " + txtNombreDato.Text + "?", "Dar de Alta Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    //creo un obj_producto que va a contener el id_ de la categoria a dar de abaj
                    capaEntidad.producto obj_producto = new capaEntidad.producto
                    {
                        Idproducto = Convert.ToInt32(txtIdProducto.Text) //aca le paso el id_categoria que necesito para poder hace uso del metodo de dar de baja categoria

                    };


                    obj_CL_Producto.darDeAltaProducto(obj_producto, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmGestionarProducto_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                    //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Producto para poder darlo de Alta ", "Dar de Alta Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //aca muestro en caso de que haya habido algun error en el metodo DarDeBaja o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
        }
        /************************************* MODIFICACION*************************************/
        private void iconBtnModif_Click(object sender, EventArgs e)
        {
            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridProducto.SelectedRows.Count > 0 && Convert.ToInt32(txtIdProducto.Text) > 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Editar los datos Del Producto?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (consulta == DialogResult.OK)
                {

                    iconbtnGuardar.Visible = true;
                    iconBtnCancelar.Visible = true;
                    iconBtnModif.Visible = false;
                    ReadOnlyCamposDatoProducto(false);//configuro el panel del usuario en modo edicion deshabilitando la funcion ReadOnly es decir ahora si se pdora editar esos campos
                }
                //hago para que los text pasen de modo lectura a poder escrbirse sobre ellos 
            }
            else
            {
                MessageBox.Show("Seleccione un Producto para poder editarlo ", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /************************************* Guardar MODIFICACION*************************************/
        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            //crear una instancia de la capa de logica de la clase CL_categoria
            CL_Producto obj_CL_Producto = new CL_Producto();

            if (validarCampos())
            {
                // // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                                 //     borrarMensajeError();//borro los mensjaes de error en caso que lo haya

                ask = MessageBox.Show("Seguro que desea Guardar La edicion del Producto ?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes)
                {
                    capaEntidad.producto obj_producto = new capaEntidad.producto()
                    {
                        Idproducto = Convert.ToInt32(txtIdProducto.Text),
                        cod_barra_producto = 112,
                        nombre_producto = txtNombreDato.Text,
                        descripcion_producto = txtDescripcionDato.Text,
                        precio_compra = Convert.ToDecimal(txtPrecioCompraDato.Text),
                        precio_venta = Convert.ToDecimal(txtPrecioVenta.Text),
                        stock_producto = Convert.ToInt32(txtStockDato.Text),
                        imagen = "prueba.png",//cambiar por la url de la img
                        //usamos un operador ternario o condicional para obtener el valor del estado ya que como es numerico y yo anteriroemnte l oconverti a string lo debo de volver a convertir a int dependiendo de la seleccion del usuario del estado
                        estado_producto = (comboEstadoDato.SelectedItem as string == "Activo") ? 1 : 0,  // esto seria como un if pero en una sola linea estructura :result = (condición) ? valorSiCierto : valorSiFalso;
                        obj_marca = new marca()
                        {
                            id_marca = obtenerIDMarcaSeleccionada() //llamo al metodo que obtien el id_marca dependiendo de la marca que selecciono el usuario dentro del comboBox
                        },
                        obj_categoria = new categoria()
                        {
                            id_categoria = obtenerIDCategoriaSeleccionada()//llamo al metodo que obtiene el id_Categoria dependiendo de la marca que selecciono el usuario dentro del comboBox
                        }
                    };

                    bool resultaldoEditarProducto = new CL_Producto().editarProducto(obj_producto, out mensaje); // lamo al metodoeditar y le paso el objeto que recien cree y cargue sus atributos y una var de saldia mensaje

                    if (resultaldoEditarProducto == true)
                    {
                        MessageBox.Show("El producto " + obj_producto.nombre_producto + " Se edito Corretamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = false;
                        iconBtnCancelar.Visible = false;
                        iconBtnModif.Visible = true;

                        //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                        FrmGestionarProducto_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                        //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva

                        limpiarCamposDato();//limpio los campos del panel de datos 
                    }
                    else
                    {
                        MessageBox.Show("El producto " + obj_producto.nombre_producto + " No se edito Corretamente,Intentelo de nuevo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        //metodo que obitne el id_Categoria dependiendo del nombre que haya elegido el usuario dentro del comboBox y asi poder pasarle el id_Categoria que selecciono
        private int obtenerIDCategoriaSeleccionada()
        {
            int id_CategoriaObtenido = 0;
            //aca pregunto que si selecciono un item en el combobox categoria que entre al if
            if (comboCategDato.SelectedItem != null)
            {
                CL_Categoria obj_CL_Categoria = new CL_Categoria();
                string? nombre_categoria = comboCategDato.SelectedItem.ToString(); //aca convierto a string el nombre de la categoria que selecciono en el combo box

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(nombre_categoria))
                {
                    //llamo al metodo obtenerIDCategoriaSeleccionada el cual busca en la base de datos apartir del nombre de la categoria y si cocindice trae su id_categoria 
                    id_CategoriaObtenido = obj_CL_Categoria.obtenerIDCategoriaSeleccionada(nombre_categoria);
                }
            }
            return id_CategoriaObtenido;// Opción por defecto si no se selecciono nada ningun valor en el combo box o existe ese nombre en la BD
        }

        //metodo que obitne el IDMarca dependiendo del nombre que haya elegido el usuario dentro del comboBox y asi poder pasarle el IDMarca que selecciono
        private int obtenerIDMarcaSeleccionada()
        {
            int id_MarcaObtenido = 0;// Opción por defecto si no se selecciono nada ningun valor en el combo box o existe ese nombre en la BD

            //aca pregunto que si selecciono un item en el combobox categoria que entre al if
            if (comboMarcaDato.SelectedItem != null)
            {
                CL_Marca obj_CL_Marca = new CL_Marca();
                string? nombre_marca = comboMarcaDato.SelectedItem.ToString(); //aca convierto a string el nombre de la categoria que selecciono en el combo box

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(nombre_marca))
                {
                    //llamo al metodo obtenerIDCategoriaSeleccionada el cual busca en la base de datos apartir del nombre de la categoria y si cocindice trae su id_categoria 
                    id_MarcaObtenido = obj_CL_Marca.obtenerIDMarcaSeleccionada(nombre_marca);
                }
            }
            return id_MarcaObtenido; //si encontro va a retorna el id encontrado y sino retorna 0
        }
        private bool validarCampos()
        {
            bool validacion = true;

            return validacion;
        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            //aca digo que me permita imprimir el excel solo si posee alguna fila el datagrid
            if (dataGridProducto.Rows.Count > 0)
            {
                DataTable datatableExcel = new DataTable(); //aca creo un obj datatable para poder guardar el encabezado de cada columna

                foreach (DataGridViewColumn columna in dataGridProducto.Columns) //aca digo que recorra las columns de mi datagrid producto
                {

                    datatableExcel.Columns.Add(columna.HeaderText, typeof(string)); //aca agrego el headertext de mi columna que se esta recorriendo en ese momento al datatableExcel  es decir inserto todas las cabceras en mi datagridexcel
                }

                //recorro y inserto todas mis filas de mi datagrid producto en mi datatableexcel
                foreach (DataGridViewRow filas in dataGridProducto.Rows) //aca digo que recorra las columns de mi datagrid producto
                {
                    //aca digo que se guarden en el excel solo las filas que estan visibles en ese momento ej.si aplico un filtro de que filas mostrar que solo guarden esas filas visibles unicamente en el excel
                    if (filas.Visible)
                    {
                        //aca creo un nuevo objeto array y accedo a una fila y en esa fila que accedi que se guarden lso valores de cada cells o celda de cada columna , y asi haria con cada fila de mi datagridproduc
                        datatableExcel.Rows.Add(new object[]
                        {
                            filas.Cells[0].Value.ToString(),
                            filas.Cells[1].Value.ToString(),
                            filas.Cells[2].Value.ToString(),
                            filas.Cells[3].Value.ToString(),
                            filas.Cells[3].Value.ToString(),
                            filas.Cells[4].Value.ToString(),
                            filas.Cells[5].Value.ToString(),
                            filas.Cells[6].Value.ToString(),
                           filas.Cells[7].Value.ToString(),
                            filas.Cells[8].Value.ToString(),
                            filas.Cells[9].Value.ToString(),

                        });
                    }
                }

                //aca le pregunto al usuario en que parte quiere guardar al archivo excel a este obj lo llamare saveFile
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss")); //aca le asigno el nobre predetemrinado que tendra mi archivo y con format obtengo un mayor control sobre el texto luego al nombre le concateno la fecha y hora
                saveFile.Filter = "Excel Files | *.xlsx"; //aca estoy agregando un filtro a la ventana de donde quiero que se guarden para que al momento de mostrarse solo se muestren ese tipo de archivos con esa extension

                //aca digo si en el evento showdialog de la ventana de savefile se dio al evento ok que entre al if
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //aca comienzo a manipular el nugget de excel que instale para poder crear y exportar el mismo 
                        XLWorkbook wb = new XLWorkbook(); //aca creo el archivo excel
                        var hoja = wb.Worksheets.Add(datatableExcel, "Informe Productos"); //aca creo una variable que sera la hoja de mi excel
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

        public void actualizarDataGrid()
        {
            //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
            FrmGestionarProducto_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
            //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva

        }
    }
}
