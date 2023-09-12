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
    public partial class RegistrarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public RegistrarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
