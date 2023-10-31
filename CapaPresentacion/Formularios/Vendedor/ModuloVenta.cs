using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Vendedor;
using Proyecto_Taller.Presentacion.Formularios.Login;

namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class frmModuloVenta : Form
    {
        private static capaEntidad.usuario usuarioActual;
        private Form formularioActivo = null;

        public frmModuloVenta(capaEntidad.usuario objUsuario)
        {
            InitializeComponent();

            /** Permite personalizar los campos de Nombre de usuario y Rol cuando el usuario inicia sesion.
             */

            usuarioActual = objUsuario;
        }


        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo == null) // cambiar por !=
            {

                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                pnlModuloVenta.Controls.Add(formHijo);
                pnlModuloVenta.Tag = formHijo;

                formHijo.Location = new Point((pnlModuloVenta.Width - formHijo.Width) / 2,
                         (pnlModuloVenta.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                pnlModuloVenta.Controls.Add(formHijo);
                pnlModuloVenta.Tag = formHijo;

                formHijo.Location = new Point((pnlModuloVenta.Width - formHijo.Width) / 2,
                (pnlModuloVenta.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }

        }

        /** Permite validar que solo se ingresen caracteres de letras
        */
        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxLetras = new Auxiliares();
            auxLetras.soloLetras_KeyPress(sender, e);
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxNumeros = new Auxiliares();
            auxNumeros.soloNumeros_KeyPress(sender, e);
        }


        /** Evita que se modifiquen campos no permitidos.
         */
        private void desactivarModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        /** Permite rellenar los campos de texto automaticamente al seleccionar un producto
         * de la lista de productos disponibles
         */
        private void dtgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            btnQuitarCarrito.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;

            // *** Verifica si hay al menos una fila seleccionada en el datagridview ***

            if (dtgvProductos.SelectedRows.Count > 0)
            {
                // *** Se obtiene la fila seleccionada en el datagridview ***

                DataGridViewRow filaElegida = dtgvProductos.CurrentRow;

                // Asigna los valores de las celdas de la fila a los textbox 

                txtNombre.Text = filaElegida.Cells[3].Value.ToString();
                txtCategoria.Text = filaElegida.Cells[10].Value.ToString();
                txtPrecio.Text = filaElegida.Cells[5].Value.ToString();

            }
        }


        /** Permite rellenar los campos de texto automaticamente al seleccionar un producto
        * de la lista de productos disponibles
        */
        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProductos.Rows.Count > 0)
            {

                txtNombre.Text = dtgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtCategoria.Text = dtgvProductos.CurrentRow.Cells[10].Value.ToString();
                txtPrecio.Text = dtgvProductos.CurrentRow.Cells[5].Value.ToString(); ;
            }
        }


        /** Permite agregar productos al carrito de compras
        */
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (validarCampos() == true)
            {
                float subtotal = int.Parse(txtCantidad.Text) * float.Parse(txtPrecio.Text);
                int idProducto = int.Parse(dtgvProductos.CurrentRow.Cells[0].Value.ToString());

                dtgvListaCompra.Rows.Add(txtNombre.Text, txtCantidad.Text, txtPrecio.Text, txtCategoria.Text, subtotal, idProducto);

                // *** Calcula el total a pagar del carrito de compras
                calcularTotal();

                limpiarCampos();

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /** Permite limpiar los campos de texto
        */

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        /** Permite rellenar los campos de texto al seleccionar una fila de la lista del carrito de compras
         */
        private void dtgvListaCompra_SelectionChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;

            if (dtgvListaCompra.SelectedRows.Count > 0)
            {
                btnModificar.Enabled = true;
                btnQuitarCarrito.Enabled = true;

                // *** Se obtiene la fila seleccionada en el datagridview ***

                DataGridViewRow filaElegida = dtgvListaCompra.CurrentRow;

                // Asigna los valores de las celdas de la fila a los textbox 

                txtNombre.Text = filaElegida.Cells["nombre_producto_carrito"].Value.ToString();
                txtCantidad.Text = filaElegida.Cells["cantidad_producto_carrito"].Value.ToString();
                txtPrecio.Text = filaElegida.Cells["precio_producto_carrito"].Value.ToString();
                txtCategoria.Text = filaElegida.Cells["categoria_producto_carrito"].Value.ToString();
            }
        }

        /** Permite rellenar los campos de texto al seleccionar una fila del carrito
        */
        private void dtgvListaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListaCompra.Rows.Count > 0)
            {

                btnModificar.Enabled = true;
                btnQuitarCarrito.Enabled = true;

                txtNombre.Text = dtgvListaCompra.CurrentRow.Cells[0].Value.ToString();
                txtCantidad.Text = dtgvListaCompra.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dtgvListaCompra.CurrentRow.Cells[2].Value.ToString();
                txtCategoria.Text = dtgvListaCompra.CurrentRow.Cells[3].Value.ToString();
            }
        }


        /** Permite modificar la cantidad de cada producto del carrito de compras
        */
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (validarCampos() == true)
            {
                dtgvListaCompra.CurrentRow.Cells[1].Value = txtCantidad.Text;

                //
                float subtotal = int.Parse(txtCantidad.Text) * float.Parse(txtPrecio.Text);
                dtgvListaCompra.CurrentRow.Cells["subtotal_producto_carrito"].Value = subtotal;
                calcularTotal();

                limpiarCampos();

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /** Modifica el label del cliente para indicar quien es quien realiza la compra
        */
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            lblModificarCliente.Text = txtCliente.Text;
        }


        /** Modifica el label de metodo de pago para indicar el metodo de pago
        */
        private void cboMetodoPago_TextChanged(object sender, EventArgs e)
        {
            lblModificarMetodo.Text = cboMetodoPago.Text;
        }

        private void lblModificarCliente_Click(object sender, EventArgs e)
        {

        }


        /** Permite eliminar productos de la lista del carrito de compras
        */
        private void btnQuitarCarrito_Click(object sender, EventArgs e)
        {
            if (dtgvListaCompra.Rows.Count > 0)
            {
                dtgvListaCompra.Rows.Remove(dtgvListaCompra.CurrentRow);

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun producto del carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            calcularTotal();

            limpiarCampos();
        }

        /** Permite validar que los campos de texto no esten vacios
        */
        private bool validarCampos()
        {
            bool validacion = true;

            if (txtNombre.Text == "" || txtPrecio.Text == "" || txtCategoria.Text == "" || txtCantidad.Text == ""
                || txtCliente.Text == "" || cboMetodoPago.SelectedItem == null)
            {

                validacion = false;
            }

            return validacion;
        }


        /** Abre el formulario necesario para elegir el cliente dentro de la lista de clientes
        */
        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmSeleccionarCliente(this));
        }


        /** Rellena los campos de texto indicando qué clientes esta comprando
        */
        public void seleccionarCliente(string[] pDatosCliente)
        {
            txtIdCliente.Text = pDatosCliente[0];
            txtCliente.Text = pDatosCliente[1];
        }


        /** Permite abrir el formulario para ver el resumen de la venta
        */
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dtgvListaCompra.Rows.Count > 0)
            {
                // **** Se rellenan los datos del resumen de venta para pasarlos como parametro

                string[] auxDatosResumen = { lblModificarCliente.Text, lblModificarMetodo.Text,
                                             lblCalculoTotal.Text, txtIdVendedor.Text, txtIdCliente.Text,
                                             cboMetodoPago.SelectedValue.ToString()};
                abrirFormularioHijo(new frmResumenVenta(dtgvListaCompra, auxDatosResumen));
            }
            else
            {
                MessageBox.Show("No hay productos agregados al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /** Calcula el total a pagar de la lista de compra
         */
        private void calcularTotal()
        {
            int i = 0;
            float total = 0;

            if (dtgvListaCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dtgvListaCompra.Rows)
                {
                    total = total + float.Parse(fila.Cells["subtotal_producto_carrito"].Value.ToString());

                    lblCalculoTotal.Text = "$" + Convert.ToString(total);
                }
            }
            else
            {
                lblCalculoTotal.Text = "$0";
            }
        }

        private void frmModuloVenta_Load(object sender, EventArgs e)
        {
            txtIdVendedor.Text = usuarioActual.id_usuario.ToString();
            txtNombreVendedor.Text = usuarioActual.obj_persona.apellido + " " + usuarioActual.obj_persona.nombre;

            cargarListaProductos();
            cargarMetodosPago();

            // Columnas no visibles
            dtgvProductos.Columns[0].Visible = false; // 0 - Id producto
            dtgvProductos.Columns[3].Visible = false; // 3 - Descripcion producto
            dtgvProductos.Columns[4].Visible = false; // 4 - Precio compra
            dtgvProductos.Columns[7].Visible = false; // 7 - Imagen
            dtgvProductos.Columns[9].Visible = false; // 9 - Marca
            dtgvProductos.Columns[10].Visible = true; // 10 - Categoria
            dtgvProductos.Columns[11].Visible = false; // 11 - Fecha creacion

            // Cambio de los nombres de las columnas
            dtgvProductos.Columns[1].HeaderText = "Codigo de barras";
            dtgvProductos.Columns[2].HeaderText = "Nombre";
            dtgvProductos.Columns[5].HeaderText = "Precio";
            dtgvProductos.Columns[6].HeaderText = "Stock";
            dtgvProductos.Columns[8].HeaderText = "Estado";


            dtgvProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void cargarListaProductos()
        {
            CL_Producto auxListaProd = new CL_Producto();
            List<producto> listaProductos = auxListaProd.listarProductos();

            dtgvProductos.DataSource = listaProductos;
        }

        private void cargarMetodosPago()
        {
            CL_Venta auxVenta = new CL_Venta();
            cboMetodoPago.DataSource = auxVenta.obtenerMetodosPago();
            cboMetodoPago.DisplayMember = "nombre_tipo_pago";
            cboMetodoPago.ValueMember = "id_tipo_metodo_pago";
        }

    }
}
