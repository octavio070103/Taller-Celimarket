using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using CapaLogica;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class RegistrarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public RegistrarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            List<rol> listaRol = new CL_rol().listarRol();

            //va a leer todos los items dentro de la lista
            foreach (rol item in listaRol)
            {
                comboRolUsu.Items.Add(item.descripcion_rol);
            }
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Obtener la descripción del rol seleccionado en el ComboBox
            string rolSeleccionadoDescripcion = comboRolUsu.SelectedItem as string;

            if (rolSeleccionadoDescripcion != null)
            {
                // Buscar el id_rol correspondiente a la descripción seleccionada
                int idRolSeleccionado = ObtenerIdRolPorDescripcion(rolSeleccionadoDescripcion);

                if (idRolSeleccionado != -1)
                {
                    if (validarCampos()) 
                    {
                            capaEntidad.usuario obj_usuario = new capaEntidad.usuario() //creo mi objeto obj_usuario que es de tipo usuario y con las llaves indiico que le pasare los valores a sus respetctivos atributos
                            {
                                nombre = txtNombreUsu.Text,
                                apellido = txtApelliUsu.Text,
                                dni = txtDniUsu.Text,
                                email = txtEmailUsu.Text,
                                password = txtPasswordUsu.Text,
                                telefono = txtTelefUsu.Text,
                                obj_rol = new rol()
                                {
                                    id_rol = idRolSeleccionado

                                },
                                obj_domicilio = new domicilio()
                                {
                                    id_domicilio = 1//aca debo de cambiar por el domicilio creado 
                                },
                                estado_usuario = 1

                            };

                            int id_usuario_generado = new CL_usuario().registrarUsuario(obj_usuario, out mensaje);
                            if (mensaje != "")
                            {
                                MessageBox.Show(mensaje);
                            }
                    }
  
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el ID del rol seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Método para buscar el id_rol por la descripción del rol
        private int ObtenerIdRolPorDescripcion(string descripcion)
        {
            List<rol> listaRol = new CL_rol().listarRol();

            foreach (rol item in listaRol)
            {
                if (item.descripcion_rol == descripcion)
                {
                    return item.id_rol;
                }
            }

            // Si no se encuentra la descripción, devuelve -1 para indicar un error.
            return -1;
        }

        private bool validarCampos()
        {
            bool validacion = true;
            string dni = txtDniUsu.Text;
            string nombre = txtNombreUsu.Text;
            string apellido = txtApelliUsu.Text;
            string email = txtEmailUsu.Text;
            string telefono = txtTelefUsu.Text;
            string password = txtPasswordUsu.Text;

            int numero = 0;

            string nombreCompleto = nombre + " " + apellido;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(password))
            {
                // MessageBox.Show("Debe de completar todos los campos");
                MessageBox.Show("Por favor, Rellene todos los campos para poder editar el Usuario", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(lblDni, "Ingrese su DNI correctamente");
                errorProvider1.SetError(lblNombre, "Ingrese su nombre correctamente");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(lblApellido, "Ingrese su Apellido correctamente");
                errorProvider1.SetError(lblEmail, "Ingrese su Email correctamente");
                errorProvider1.SetError(lblTelefono, "Ingrese su Telefono correctamente");
                errorProvider1.SetError(lblPassword, "Ingrese una contrasña valida");
                return validacion = false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dni, out numero))
            {
                errorProvider1.SetError(lblDni, "Ingrese su DNI correctamente");
                MessageBox.Show("El Dni debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos Apellido y Nombre contengan solo letras
            if (!EsAlfabetico(nombre))
            {
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");
                MessageBox.Show(" El nombre debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!EsAlfabetico(apellido))
            {
                errorProvider1.SetError(lblApellido, "Ingrese su apellido");
                MessageBox.Show(" El apellido debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!validarEmail(email))
            {
                errorProvider1.SetError(lblEmail, "Ingrese su email valido formato: correo@example.com");
                MessageBox.Show(" El email debe de seguir el formato correo@example.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
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

        // toma una cadena que representa un email y utiliza una expresión regular para verificar si se ajusta a un formato de email válido. El patrón de expresión regular ^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$ verifica que el email tenga el formato correcto, como "nombre@dominio.com".
        // Si el email cumple con este formato, la función ValidarEmail devuelve true; de lo contrario, devuelve false.
        public bool validarEmail(string email)
        {
            // Patrón de expresión regular para validar un email
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza la clase Regex para hacer la validación
            return Regex.IsMatch(email, patron);
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblDni, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblNombre, "");    // Limpiar mensaje de error
            errorProvider1.SetError(lblApellido, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblEmail, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblTelefono, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblPassword, ""); // Limpiar mensaje de error
        }

        private void iconBtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNombreUsu.Clear();
            txtApelliUsu.Clear();
            txtDniUsu.Clear();
            txtTelefUsu.Clear();
            txtEmailUsu.Clear();
            txtPasswordUsu.Clear();

        }
    }
}
