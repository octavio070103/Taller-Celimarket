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

namespace CapaPresentacion.Formularios.Admin.Categoria
{
    public partial class FrmGestionarCategorias : Form
    {
        private MenuAdministrador obj_intancia_menuAdmin;
        public FrmGestionarCategorias(MenuAdministrador p_menuAdmin)
        {
            InitializeComponent();
            obj_intancia_menuAdmin = p_menuAdmin;
        }
        private void FrmGestionarCategorias_Load(object sender, EventArgs e)
        {
            CL_Categoria obj_CL_Categoria = new CL_Categoria();


            dataGridCategoria.DataSource = obj_CL_Categoria.listarCategorias();
        }

        private void iconBtnAgregarCateg_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategoria formCatego = new FrmRegistrarCategoria();
            formCatego.Show();
        }


    }
}
