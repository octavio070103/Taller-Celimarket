using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Admin.Producto
{
    public partial class FrmGestionarProducto : Form
    {
        private MenuAdministrador instancia_menuAdmin;
        public FrmGestionarProducto(MenuAdministrador p_menuAdmin)
        {
            InitializeComponent();
            this.instancia_menuAdmin = p_menuAdmin;
        }

        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto formularioAddProduc = new FrmRegistrarProducto();
            formularioAddProduc.Show();

        }

        private void iconBtnHistorial_Click(object sender, EventArgs e)
        {
            //  instancia_menuAdmin.OpenChildForm()
        }
    }
}
