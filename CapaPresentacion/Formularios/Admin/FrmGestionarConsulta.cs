using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class FrmGestionarConsulta : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public FrmGestionarConsulta(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            this.instanciaMenuAdministrador.OpenChildForm( new Admin.consulta_reclamo.FrmResponderConsulta(this.instanciaMenuAdministrador));
        }
    }
}
