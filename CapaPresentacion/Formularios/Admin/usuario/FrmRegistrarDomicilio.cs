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

namespace CapaPresentacion.Formularios.Admin.usuario
{


    public partial class FrmRegistrarDomicilio : Form
    {


        public int id_domicilio_registrado;
        public FrmRegistrarDomicilio()
        {
            InitializeComponent();
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;// creo mi varibale para pdoer retorna el mensaje proveniente de mi capa de datos del proc almac
            if (validarCampos())
            {
                borrarMensajeError();//borro los erroProvider de lso label

                capaEntidad.domicilio obj_domicilio = new capaEntidad.domicilio()
                {
                    calle = txtCalleDomi.Text,
                    codigo_postal = Convert.ToInt32(txtCodPostalDomi.Text),
                    numero = Convert.ToInt32(txtNumDomi.Text),
                    localidad = txtLocalidadDomi.Text,
                    provincia = txtProvDomi.Text,
                    descripcion = txtDescripcion.Text,
                    estado_domicilio = 1
                };

                id_domicilio_registrado = new CL_domicilio().registrarDomicilio(obj_domicilio, out mensaje);
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
            string calleDomi = txtCalleDomi.Text;
            string codigoPostal = txtCodPostalDomi.Text;
            string numDomicilio = txtNumDomi.Text;
            string localidadDomi = txtLocalidadDomi.Text;
            string provinciaDomi = txtProvDomi.Text;
            string descripDomi = txtDescripcion.Text;

            int numero = 0; //variable que me devuelve el aprametro de salida del if para las valdiaciones de los nuemros

            if (string.IsNullOrWhiteSpace(calleDomi) || string.IsNullOrWhiteSpace(codigoPostal) || string.IsNullOrWhiteSpace(numDomicilio) || string.IsNullOrWhiteSpace(localidadDomi) || string.IsNullOrWhiteSpace(provinciaDomi))
            {
                MessageBox.Show("Por favor, Rellene todos los campos para poder Registrar el Domicilio", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProviderDomicilio.SetError(lblCalle, "Ingrese el nombre de su calle");
                errorProviderDomicilio.SetError(lblCodPostal, "Ingrese un cod postal valido");
                errorProviderDomicilio.SetError(lblNumero, "Ingrese el numero de domicilio");
                errorProviderDomicilio.SetError(lblLocalidad, "Ingrese su localidad");
                errorProviderDomicilio.SetError(lblProvincia, "Ingrese su provincia");
                validacion = false;
            }

            //vaidaciones individuales

            //aca valdio que el campo solo contenga letras y un solo espacio por palabra escrita 
            if (!EsAlfabetico(calleDomi))
            {
                errorProviderDomicilio.SetError(lblCalle, "Ingrese su Calle");
                MessageBox.Show(" El nombre de la calle debe de contener solo letras , y un espacio por palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //valdiar que en el campo codigopostal solo se ingrese numero
            if (!int.TryParse(codigoPostal, out numero))
            {
                errorProviderDomicilio.SetError(lblCodPostal, "Ingrese en valor numerico El codigo Postal");
                MessageBox.Show("E lCodigo postal debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //valdiar que en el campo numDomicilio solo se ingrese numero
            if (!int.TryParse(numDomicilio, out numero))
            {
                errorProviderDomicilio.SetError(lblCodPostal, "Ingrese en valor numerico El numero del domicilio");
                MessageBox.Show("El Numero de domicilio debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //aca valdio que el campo solo contenga letras y un solo espacio por palabra escrita
            if (!EsAlfabetico(provinciaDomi))
            {
                errorProviderDomicilio.SetError(lblProvincia, "Ingrese su Provincia");
                MessageBox.Show(" El nombre de la Provincia debe de contener solo letras , y un espacio por palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //aca valdio que el campo solo contenga letras y un solo espacio por palabra escrita
            if (!EsAlfabetico(localidadDomi))
            {
                errorProviderDomicilio.SetError(lblLocalidad, "Ingrese su Localidad");
                MessageBox.Show(" El nombre de la Localidad debe de contener solo letras , y un espacio por palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //aca valdio que el campo solo contenga letras y un solo espacio por palabra escrita, y si esa descripcion del domiclio es distinta de null ya que como es un campo opcional si meviene null no tendria que validar nada
            if (!string.IsNullOrWhiteSpace(descripDomi))
            {
                if (!EsAlfabetico(descripDomi))
                {
                    errorProviderDomicilio.SetError(lblDescripcion, "Ingrese su Calle");
                    MessageBox.Show(" El nombre de la calle debe de contener solo letras , y un espacio por palabra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validacion = false;
                }
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
            errorProviderDomicilio.SetError(lblCalle, "");
            errorProviderDomicilio.SetError(lblCodPostal, "");
            errorProviderDomicilio.SetError(lblNumero, "");
            errorProviderDomicilio.SetError(lblLocalidad, "");
            errorProviderDomicilio.SetError(lblProvincia, "");

        }
    }
}
