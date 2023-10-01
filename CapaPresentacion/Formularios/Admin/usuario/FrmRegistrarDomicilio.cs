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
       

        public  int id_domicilio_registrado;
        public FrmRegistrarDomicilio()
        {
            InitializeComponent();
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;// creo mi varibale para pdoer retorna el mensaje proveniente de mi capa de datos del proc almac

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
}
