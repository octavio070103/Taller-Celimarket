using capaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();   //creo este obj para guardar en memeoria mi array
            ms.Write(imageBytes, 0, imageBytes.Length); //aca leo ese array
            Image image = new Bitmap(ms);//cremaos nuestra imagen de tipo image

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
}
