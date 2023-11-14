using capaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.settings
{
    public partial class FrmNegocioConfiguracion : Form
    {
        private MenuAdministrador instanciaAdministrador;
        public FrmNegocioConfiguracion(MenuAdministrador p_menuAdmin)
        {
            InitializeComponent();
            this.instanciaAdministrador = p_menuAdmin;
        }

        //este metodo me va a permitir convertir mi arrat de bit que contiene mi iamgen a tipo Image para poder mostrar el logo
        public System.Drawing.Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();   //creo este obj para guardar en memeoria mi array
            ms.Write(imageBytes, 0, imageBytes.Length); //aca leo ese array
            System.Drawing.Image image = new Bitmap(ms);//cremaos nuestra imagen de tipo image

            return image;
        }

        private void FrmNegocioConfiguracion_Load(object sender, EventArgs e)
        {
            //obtengo la imagen o logo del negocio 

            bool obtenido = false; //esta var va a cotnener el valor retornado del meto obtenerLogo el cual devuvelve true si pudo obtener el logo
            byte[] byteimage = new CapaLogica.CL_Negocio().obtenerLogoNegocio(out obtenido);

            //aca pregunto que si obtenido es true que entre al if
            if (obtenido)
            {
                piclogo.Image = ByteToImage(byteimage); //aca digo que se cargue el piclogo con el resultado del metodo bytetoimage que me conveirte el array de byte en Image
            }

            //aca obtengos los datos del negocio y lo guardo en mi obj de tipo negocio
            capaEntidad.negocio obj_negocio = new CapaLogica.CL_Negocio().obtenerDatosNegocio();
            cargarDatosNegocio(obj_negocio);
        }

        public void cargarDatosNegocio(negocio p_obj_negocio)
        {
            txtNombreNegocio.Text = p_obj_negocio.nombre_negocio;
            txtCUITNegocio.Text = p_obj_negocio.CUIT;
            txtTelefNegocio.Text = p_obj_negocio.telefono_negocio;
            txtEmailNegocio.Text = p_obj_negocio.email_negocio;
            txtDireNegocio.Text = p_obj_negocio.direccion_negocio;


        }

        private void BtnSubirLogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog obj_openFileDialog = new OpenFileDialog();    //aca creo una ventana para que el usuario pueda elegir la imagen ene este caso el logo
            obj_openFileDialog.FileName = "Files|*.jpg;*.jpeg;**.png";//aca aplico un filtro para que solo pueda seleccionar esos tipos de archivos

            if (obj_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(obj_openFileDialog.FileName);//aca convertimos nuestra imagen en un array de bytes
                bool respuesta = new CapaLogica.CL_Negocio().ActualizarLogoNegocio(byteimage, out mensaje);//aca le paso el array de la img que se inserto de tipo byte y un par de salida que es el msj

                //si respeusta es true entonces se carga la img en el pic foto que inserto el usuario y sino me muestra un msj de error
                if (respuesta)
                {
                    piclogo.Image = ByteToImage(byteimage);
                }
                else
                {
                    MessageBox.Show(mensaje, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (validarCampos())
            {
                negocio obj_negocio = new negocio()
                {
                    nombre_negocio = txtNombreNegocio.Text,
                    CUIT = txtCUITNegocio.Text,
                    telefono_negocio = txtTelefNegocio.Text,
                    email_negocio = txtEmailNegocio.Text,
                    direccion_negocio = txtDireNegocio.Text

                };
                bool respuestaGuardadatos = new CapaLogica.CL_Negocio().guardarDatosNegocio(obj_negocio, out mensaje);

                if (respuestaGuardadatos)
                {
                    MessageBox.Show("Los cambios fueron guardados", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Los cambios No se pudieron guardar intentelo de nuevo", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool validarCampos()
        {
            bool validacion = true;

            string nombreNegocio = txtNombreNegocio.Text;
            string cuit = txtCUITNegocio.Text;
            string telefono = txtTelefNegocio.Text;
            string email = txtEmailNegocio.Text;
            string direccion = txtDireNegocio.Text;

            if (string.IsNullOrEmpty(nombreNegocio) || string.IsNullOrEmpty(cuit) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(email)
              || string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("Por favor, Rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            // Validar que los campos  nombreNegocio contengan solo letras
            if (!EsAlfabetico(nombreNegocio))
            {
                errorProvider1.SetError(lblNombreNego, "Ingrese el nombre del negocio correctamente");
                MessageBox.Show(" El nombre debe de contener solamente letras y un solo espacio de separacion entre nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // toma una cadena que representa un email y utiliza una expresión regular para verificar si se ajusta a un formato de email válido. 
        // Si el email cumple con este formato, la función ValidarEmail devuelve true; de lo contrario, devuelve false.
        public bool validarEmail(string email)
        {
            // Patrón de expresión regular para validar un email
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza la clase Regex para hacer la validación
            return Regex.IsMatch(email, patron);
        }

    }
}
