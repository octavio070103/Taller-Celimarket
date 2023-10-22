using capaEntidad;
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

namespace CapaPresentacion.Formularios.Admin.Producto
{
    public partial class FrmRegistrarProducto : Form
    {


        public FrmRegistrarProducto()
        {
            InitializeComponent();

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
            int id_producto_generado ;

            if (validarCampos())
            {
                capaEntidad.producto obj_producto = new capaEntidad.producto()
                {
                    cod_barra_producto = Convert.ToInt32(txtCodBarra.Text),
                    nombre_producto = txtNombre.Text,
                    descripcion_producto = txtDescripcion.Text,
                    precio_compra = Convert.ToInt32(txtPrecioCompra.Text),
                    precio_venta = Convert.ToInt32(txtPrecioVenta.Text),
                    stock_producto = Convert.ToInt32(txtStock.Text),
                    imagen= "prueba.png",//cambiar por la url de la img
                    estado_producto = 1,

                    obj_marca = new marca()
                    {
                        id_marca= obtenerIDMarcaSeleccionada() //tengo que validar esto en el metodo validar campo ya que si es =0 significa que el usuario no seleccionada
                    },
                    obj_categoria= new categoria(){
                        id_categoria=obtenerIDCategoriaSeleccionada() 
                    }
                };

                id_producto_generado = new CL_Producto().registrarProducto(obj_producto, out mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
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

            return validacion;
        }
    }
}
