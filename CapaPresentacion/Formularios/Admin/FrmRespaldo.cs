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
    public partial class FrmRespaldo : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public FrmRespaldo(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void iconBtnImportar_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnRespaldar_Click(object sender, EventArgs e)
        {

        }
    }
}
