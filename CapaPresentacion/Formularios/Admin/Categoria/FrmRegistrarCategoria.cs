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
using static ClosedXML.Excel.XLPredefinedFormat;

namespace CapaPresentacion.Formularios.Admin.Categoria
{
    public partial class FrmRegistrarCategoria : Form
    {
        public int id_categoria_registrada;
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaxPantalla.Visible = true;
        }

        private void picMaxPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMaxPantalla.Visible = false;
            picRestaurar.Visible = true;
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;// creo mi varibale para pdoer retorna el mensaje proveniente de mi capa de datos del proc almac
            if (validarCampos())
            {
                borrarMensajeError();//borro los erroProvider de lso label

                capaEntidad.categoria obj_categoria = new capaEntidad.categoria()
                {
                    nombre_categoria = txtNombreCate.Text,
                    descripcion_categoria = txtDescripcionCate.Text,
                    estado_categoria = 1
                };

                id_categoria_registrada = new CL_Categoria().registrarCategoria(obj_categoria, out mensaje);

                //muestra el mensaje de salida del procedimiento almcenado
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }

                // Establece el resultado como OK y luego cierra el formulario
                this.DialogResult = DialogResult.OK;

                // Cierra el formulario
                this.Close();
            }
        }

        private bool validarCampos()
        {
            bool validacion = true;
            string nombreCateg = txtNombreCate.Text;
            string descripCateg = txtDescripcionCate.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombreCateg) || string.IsNullOrWhiteSpace(descripCateg))
            {
                MessageBox.Show("Por favor, Rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            //aca valdio que el campo solo contenga letras y un solo espacio por palabra escrita 
            if (!EsAlfabetico(nombreCateg))
            {
                errorProviderCategoria.SetError(lblNombreCate, "Ingrese un nombre valido solo con letras");
                MessageBox.Show(" El nombre de la categoria debe de contener solo letras , y un espacio por palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //aca valdio que el campo solo contenga letras y un solo espacio por palabra escrita 
            if (!EsAlfabetico(descripCateg))
            {
                errorProviderCategoria.SetError(lblDescripcionCate, "Ingrese una descripcion valdiad solo con letras");
                MessageBox.Show(" La descripcion debe de contener solo letras , y un espacio por palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
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

        private void borrarMensajeError()
        {
            errorProviderCategoria.SetError(lblNombreCate, "");
            errorProviderCategoria.SetError(lblDescripcionCate, "");

        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {//si cancela se borra todo el contenido del form
                txtNombreCate.Text = "";
                txtDescripcionCate.Text = "";
            }
        }


    }
}
