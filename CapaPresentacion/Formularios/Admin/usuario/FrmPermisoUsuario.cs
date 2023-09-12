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
    public partial class FrmPermisoUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public FrmPermisoUsuario(MenuAdministrador p_menuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_menuAdministrador;
        }
    }
}
