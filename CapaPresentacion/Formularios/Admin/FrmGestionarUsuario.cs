using Proyecto_Taller.Presentacion.Formularios.Vendedor;
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

    public partial class FrmGestionarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;

        public FrmGestionarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnModif_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnElim_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnPermiso_Click(object sender, EventArgs e)
        {

        }
    }
}
