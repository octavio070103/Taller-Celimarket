using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.Categoria
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();

            int y = 40; // Posición vertical inicial de los controles
            int x = 3;//posicion x de los controles
            int labelWidth = 70; // Ancho de las etiquetas
            int textboxWidth = 200; // Ancho de los cuadros de texto


            // Crear un nuevo Label
            Label id_permiso = new Label()
            {
                Text = "prueba",
                Location = new Point(y, x),
                Width = labelWidth,
                ForeColor = Color.Black,

            };
            Label label = new Label()
            {
                Text = "prueba",
                Location = new Point(426, 100),
                Width = labelWidth
            };

            this.Controls.Add(id_permiso);
            this.Controls.Add(label);

        }
    }
}
