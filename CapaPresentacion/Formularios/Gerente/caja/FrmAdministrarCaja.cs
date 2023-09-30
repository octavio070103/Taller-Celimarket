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

namespace CapaPresentacion.Formularios.Gerente.caja
{
    public partial class FrmAdministrarCaja : Form
    {
        private MenuGerente instancia_gerente;
        public FrmAdministrarCaja(MenuGerente p_menuGerente)
        {
            InitializeComponent();
            instancia_gerente = p_menuGerente;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            instancia_gerente.OpenChildForm(new FrmApertYCierreCaja(instancia_gerente));
        }
    }
}
