using CapaDatos;
using capaEntidad;
using CapaLogica;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace CapaPresentacion.Formularios.Admin.Producto
{
    public partial class FrmRegistrarProducto : Form
    {
        private FrmGestionarProducto instancia_FrmGestionarProducto; // creamos una varibale llamada instancia_FrmGestionarProducto en FrmRegistrarProducto para almacenar una referencia al formulario FrmGestionarProducto. Esto es esencial para que FrmRegistrarProducto sepa a qué formulario debe comunicarse.
        private string? nombreDeImg; //creo una var para almacenar el nombre de mi img y luego poder validar ese campo es decir para poder guardar su valor en una var global y usarl;o a lo largo del progra
        private string? fileSavePath;
        private string? fileActualPath;

        //constructor
        public FrmRegistrarProducto(FrmGestionarProducto p_FrmGestionarProducto) // le paso como parametro un obj de tipo FrmGestionarProducto que me viene como referencia al momento de llamar a este formulario 
        {
            InitializeComponent();
            this.instancia_FrmGestionarProducto = p_FrmGestionarProducto; //asigno la refencia del ormulario FrmGestionarProducto proporcionada como argumento al campo instancia_FrmGestionarProducto. Esto establece una conexión entre los dos formularios, permitiendo que FrmRegistrarProducto acceda a los miembros públicos y métodos de FrmGestionarProducto
        }
        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {

            //carga el combobox de marca  Uso de la función con una lista de marcas y el combo de marca
            CL_Marca obj_CL_Marca = new CL_Marca();
            List<marca> listaMarca = obj_CL_Marca.listarMarcas(); //con esta funcion obtenemos una lista de  marcas que estan cargadas en la BD
            CargarComboBox(listaMarca, comboBoxMarca, marca => marca.nombre_marca);

            //carga el combobox de categoria  Uso de la función con una lista de categorias y el combo de categorias
            CL_Categoria obj_CL_Categoria = new CL_Categoria();
            List<categoria> listaCategorias = obj_CL_Categoria.listarCategorias(); //con esta funcion obtenemos una lista de  marcas que estan cargadas en la BD
            CargarComboBox(listaCategorias, comboBoxCateg, categoria => categoria.nombre_categoria);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaxPantalla.Visible = true;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMaxPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaxPantalla.Visible = false;
            picRestaurar.Visible = true;
        }

        //metodo para cargar combobox generico ,este metodo toma un obj de tipo T( tipo generico) y carga el combo box (para distintos objetos y distintos campo que quiero que se cargue dentro del cambo
        //T=tipodeObj representa el tipo de dato con el que trabajara,List<T> es una lista genérica que contiene elementos de tipo T,p_comboBox=es el combo al que quiero cargar,es un delegado funcional que toma un objeto de tipo T y devuelve una cadena.(ej si quiero obtener el nombre de cada rol le pasaria esto rol => rol.Nombre)
        //Esto permite personalizar cómo se extrae el texto de los elementos de la lista de tipo T para mostrarlos en el ComboBox.
        private void CargarComboBox<T>(List<T> lista, ComboBox p_comboBox, Func<T, string> obtenerTexto)
        {
            p_comboBox.Items.Clear(); // Limpia los elementos existentes en el ComboBox.

            foreach (T item in lista)
            {
                string texto = obtenerTexto(item);
                p_comboBox.Items.Add(texto);
            }
        }

        /****registrar mi producto al darle a guardar **/
        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int id_producto_generado;

            if (validarCampos())
            {
                capaEntidad.producto obj_producto = new capaEntidad.producto()
                {
                    cod_barra_producto = Convert.ToInt32(txtCodBarra.Text),
                    nombre_producto = txtNombre.Text,
                    descripcion_producto = txtDescripcion.Text,
                    precio_compra = decimal.Parse(txtPrecioCompra.Text),
                    precio_venta = decimal.Parse(txtPrecioVenta.Text),
                    stock_producto = Convert.ToInt32(txtStock.Text),
                    imagen = nombreDeImg!,//le paso la url de la img que subi al momento de registrar
                    estado_producto = 1,

                    obj_marca = new marca()
                    {
                        id_marca = obtenerIDMarcaSeleccionada() //tengo que validar esto en el metodo validar campo ya que si es =0 significa que el usuario no seleccionada
                    },
                    obj_categoria = new categoria()
                    {
                        id_categoria = obtenerIDCategoriaSeleccionada()
                    }
                };

                id_producto_generado = new CL_Producto().registrarProducto(obj_producto, out mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }

                if (id_producto_generado != 0)
                {
                    //como anteriormete extableci una referencia al formulario FrmGestionProducto puedo acceder a sus metodos y atributos publicos en este caso accedo al metodo de actulizar datagrid para que cuando se isnrete un producto lo haga
                    instancia_FrmGestionarProducto.actualizarDataGrid();
                }

                File.Copy(fileActualPath!, fileSavePath!);//aca guardo la coipa de la imagen en la ruta que especifique mas abajo

            }
        }

        //metodo que obitne el id_Categoria dependiendo del nombre que haya elegido el usuario dentro del comboBox y asi poder pasarle el id_Categoria que selecciono 
        private int obtenerIDCategoriaSeleccionada()
        {
            int id_CategoriaObtenido = 0;
            //aca pregunto que si selecciono un item en el combobox categoria que entre al if
            if (comboBoxCateg.SelectedItem != null)
            {
                CL_Categoria obj_CL_Categoria = new CL_Categoria();
                string? nombre_categoria = comboBoxCateg.SelectedItem.ToString(); //aca convierto a string el nombre de la categoria que selecciono en el combo box

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(nombre_categoria))
                {
                    //llamo al metodo obtenerIDCategoriaSeleccionada el cual busca en la base de datos apartir del nombre de la categoria y si cocindice trae su id_categoria 
                    id_CategoriaObtenido = obj_CL_Categoria.obtenerIDCategoriaSeleccionada(nombre_categoria);
                }
            }
            return id_CategoriaObtenido;//si encontro va a retorna el id encontrado y sino retorna 0
        }

        //metodo que obitne el id_marca dependiendo del nombre que haya elegido el usuario dentro del comboBox y asi poder pasarle el id_marca que selecciono 
        private int obtenerIDMarcaSeleccionada()
        {
            int id_MarcaObtenido = 0;// Opción por defecto si no se selecciono nada ningun valor en el combo box o existe ese nombre en la BD

            //aca pregunto que si selecciono un item en el combobox categoria que entre al if
            if (comboBoxMarca.SelectedItem != null)
            {
                CL_Marca obj_CL_Marca = new CL_Marca();
                string? nombre_marca = comboBoxMarca.SelectedItem.ToString(); //aca convierto a string el nombre de la categoria que selecciono en el combo box

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
            string codBarra = txtCodBarra.Text;
            string nombreProduc = txtNombre.Text;
            string precioCompra = txtPrecioCompra.Text;
            string precioVenta = txtPrecioVenta.Text;
            string stock = txtStock.Text;
            string descripProduc = txtDescripcion.Text;
            string validarNombreDeImg = nombreDeImg;

            int numero = 0;
            decimal valorDecimal;


            if (string.IsNullOrEmpty(codBarra) || string.IsNullOrEmpty(nombreProduc) || string.IsNullOrEmpty(precioCompra) || string.IsNullOrEmpty(precioVenta)
                || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(descripProduc) || string.IsNullOrEmpty(validarNombreDeImg))
            {
                MessageBox.Show("Por favor, Rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            //recordar que para todas estas validaciones uso su negacion para que entre al if

            //validar que el campos codbarra solo se ingresen numeros
            if (!int.TryParse(codBarra, out numero))
            {
                errorProvider1.SetError(lblCodProduc, "Codigo de barra erroneo");
                MessageBox.Show("Ingrese solo numeros en el cod de barras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos  nombreProduc contengan solo letras
            if (!EsAlfabetico(nombreProduc))
            {
                errorProvider1.SetError(lblNombre, "Ingrese el nombre del producto correctamente");
                MessageBox.Show(" El nombre debe de contener solamente letras y un solo espacio de separacion entre nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el campos precioCompra y precioVenta solo se ingresen numeros (y que sean tipo decimal
            if (!decimal.TryParse(precioCompra, out valorDecimal))
            {
                errorProvider1.SetError(lblPrecioCompra, "Precio Compra Erroneo");
                MessageBox.Show(" El Valor de Precio compra debe de ser un decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }


            if (!decimal.TryParse(precioVenta, out valorDecimal))
            {
                errorProvider1.SetError(lblPrecioVenta, "Precio Venta Erroneo");
                MessageBox.Show(" El Valor de Precio Venta debe de ser un decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el campos codbarra solo se ingresen numeros (y que sean tipo int
            if (!int.TryParse(stock, out numero))
            {
                errorProvider1.SetError(lblStock, "stockerroneo");
                MessageBox.Show("Ingrese solo numeros en el stock ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el stock sea mayor a 0 si el stock no es mayor que 0 entra al if ya que estoy ! negando
            if (!(Convert.ToInt32(stock.ToString()) > 0))
            {
                errorProvider1.SetError(lblStock, "stockerroneo");
                MessageBox.Show("El stock minimo en 1 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el stock sea menor a 100 si el stock no es menor que 0 entra al if ya que estoy ! negando
            if (!(Convert.ToInt32(stock.ToString()) <= 100))
            {
                errorProvider1.SetError(lblStock, "stockerroneo");
                MessageBox.Show("El stock maximo es de 100 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos  descripProduc contengan solo letras
            if (!EsAlfabetico(descripProduc))
            {
                errorProvider1.SetError(lblDescripcion, "Ingrese la descripcion del producto correctamente");
                MessageBox.Show(" El nombre debe de contener solamente letras y un solo espacio de separacion entre palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
        }

        //metodo para subir y posteriormente registrar la imagen
        private void picBoxIMGProducto_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog abrirImagen = new()
            {
                Filter = "Archivos de imagen (*.png) | *.png", //aca aplico el filtro de las imagenes o archivos que puede seleciconar el usuario en la ventana
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), // con esto le digo qeu el cuadro de dialogo o ventana se abra en la carpeta myPictures
                Multiselect = false, //aca hago para que seleccione una sola imagen a la vez
                Title = "Seleccione una Imagen", //titulo de mi ventana
            };

            //si el usuario selecciono una img y dio a ok entra a este if
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    nombreDeImg = Guid.NewGuid().ToString() + ".png"; //genero un nombre unico para la imgen y ke agrego la extension.png
                    string nombreActualImg = abrirImagen.SafeFileName;//almacena el nombre original del archivo seleccionado por el usuario.
                    fileSavePath = Path.Combine("..", "..", "..", "..", "CapaPresentacion/Fotos/Admin/Producto/images", nombreDeImg);//construyo una ruta donde se guardara la imagen 

                    // Asegurarse de que la carpeta "Images" exista
                    /*
                    if (!Directory.Exists(fileSavePath))
                    {
                        Directory.CreateDirectory(fileSavePath);
                    }
                    */
                    string selectedImagePath = abrirImagen.FileName; // guarda la ruta completa del archivo seleccionado para su uso posterior.
                    fileActualPath = selectedImagePath;

                    // Intenta cargar la imagen desde el archivo
                    picBoxIMGProducto.Image = Image.FromFile(fileActualPath); //Se carga la imagen seleccionada desde el archivo (fileActualPath) Esto permitirá mostrar la imagen en el formulario.

                    // Mostrar la ruta del archivo en el TextBox
                    lblNomImg.Text = nombreActualImg;
                }
                catch (Exception ex)
                {
                    // Manejar la excepción aquí, puedes mostrar un mensaje de error
                    MessageBox.Show("No se pudo agregar la imagen en el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Función para verificar si una cadena contiene solo letras y un sol oespacio por palabra
        private bool EsAlfabetico(string texto)
        {
            bool espacioEncontrado = false;
            foreach (char c in texto)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (espacioEncontrado)
                    {
                        // Se encontró un espacio en blanco después de otro espacio en blanco
                        return false;
                    }
                    espacioEncontrado = true;
                }
                else if (!char.IsLetter(c))
                {
                    // El carácter no es una letra
                    return false;
                }
                else
                {
                    // Reiniciar el indicador de espacio si se encuentra una letra
                    espacioEncontrado = false;
                }
            }
            return true;
        }
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar el registro del producto?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {//si cancela se borra todo el contenido del form sin editar lo que el usuario haya modficado o cambiado ya que no el dio a confirmar
                limpiarCamposDato();//limpio todos los datos del panel dato

            }
        }

        private void limpiarCamposDato()
        {
            txtCodBarra.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

            // Liberar los recursos asociados con la imagen actual
            if (picBoxIMGProducto.Image != null)
            {
                picBoxIMGProducto.Image.Dispose();
                // Limpiar el contenido del PictureBox
                picBoxIMGProducto.Image = null;
                lblNomImg.Text = string.Empty;
            }

            // Limpiar el ComboBox Marca Eliminando todos los elementos ya que una vez que el usuario selecciona un item queda ese y no puedo vovler a ver el msj predeterminado
            comboBoxCateg.Items.Clear();
            comboBoxCateg.Text = "Seleccione una Categoria"; // aca le paso el texto predeterminado que quiero que tenga el combo

            comboBoxMarca.Items.Clear();
            comboBoxMarca.Text = "Seleccione una Marca"; // aca le paso el texto predeterminado que quiero que tenga el combo

            //vuelvo a cargar los combo box que recien limpie 
            FrmRegistrarProducto_Load(this, EventArgs.Empty);
        }
    }
}
