using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class frmModuloVenta : Form
    {
        private Form formularioActivo = null;

        public frmModuloVenta()
        {
            InitializeComponent();
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

        private void desactivarModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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

                txtNombre.Text = filaElegida.Cells["nombre_producto"].Value.ToString();
                txtCategoria.Text = filaElegida.Cells["categoria_producto"].Value.ToString();
                txtPrecio.Text = filaElegida.Cells["precio_producto"].Value.ToString();

            }
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProductos.Rows.Count > 0)
            {

                txtNombre.Text = dtgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtCategoria.Text = dtgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dtgvProductos.CurrentRow.Cells[3].Value.ToString(); ;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (validarCampos() == true)
            {
                dtgvListaCompra.Rows.Add(txtNombre.Text, txtCantidad.Text, txtPrecio.Text, txtCategoria.Text);
                limpiarCampos();

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }



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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //txtNombre.Text = dtgvListaCompra.CurrentRow.Cells[0].Value.ToString();
            dtgvListaCompra.CurrentRow.Cells[1].Value = txtCantidad.Text;
            //dtgvListaCompra.CurrentRow.Cells[2].Value = txtPrecio.Text;
            //dtgvListaCompra.CurrentRow.Cells[3].Value = txtCategoria.Text;
            limpiarCampos();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            lblModificarCliente.Text = txtCliente.Text;
        }

        private void cboMetodoPago_TextChanged(object sender, EventArgs e)
        {
            lblModificarMetodo.Text = cboMetodoPago.Text;
        }

        private void lblModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarCarrito_Click(object sender, EventArgs e)
        {
            dtgvListaCompra.Rows.Remove(dtgvListaCompra.CurrentRow);
            limpiarCampos();
        }


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

        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmSeleccionarCliente(this));
        }


        public void seleccionarCliente(string[] pDatosCliente)
        {
            txtIdCliente.Text = pDatosCliente[0];
            txtCliente.Text = pDatosCliente[1];
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
