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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
