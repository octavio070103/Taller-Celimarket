using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.administrar_acceso
{
    public partial class FrmAdministrarAcceso : Form
    {
        private MenuAdministrador instanciaAdministrador;
        public FrmAdministrarAcceso(MenuAdministrador p_administrador)
        {
            InitializeComponent();
            instanciaAdministrador = p_administrador;
        }

        private void FrmAdministrarAcceso_Load(object sender, EventArgs e)
        {

        }

        private bool validarFiltros()
        {
            bool validacion = true;
            string funcionalidad = txtFuncionalidadFiltro.Text;

            //verficio que el campo funcuionalidad no sea null o tenga espacio en blanco 
            if (string.IsNullOrWhiteSpace(funcionalidad))
            {
                MessageBox.Show("Por favor, Rellene todos los campos para poder filtrar las funcionalidades", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(lblFuncionalidadFiltro, "Ingrese un texto para poder buscar correctamente");
                validacion = false;
            }

            // Validar que el campo funcionalidad contiene solo letras
            if (!EsAlfabetico(funcionalidad))
            {
                errorProvider1.SetError(lblFuncionalidadFiltro, "Ingrese su nombre");
                MessageBox.Show(" El nombre debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar comobo box de estado
            if (comboEstadoFiltro.SelectedIndex == -1)//aca digo quesi el indiice esta en -1 es decir que nose elijio ningu estado o item del combo que me salga un error
            {
                MessageBox.Show("Por favor, seleccione una opción válida en el ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false; // Detener la acción si la validación falla

            }

            return validacion;
        }

        // Función para verificar si una cadena contiene solo letras
        private bool EsAlfabetico(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblFuncionalidadFiltro, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblEstadoFiltro, "");    // Limpiar mensaje de error
        }

        private void comboEstadoFiltro_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtFuncionalidadFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
