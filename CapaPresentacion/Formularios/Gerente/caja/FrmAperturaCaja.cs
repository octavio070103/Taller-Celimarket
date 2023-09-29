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
    public partial class FrmAperturaCaja : Form
    {
        private MenuGerente instancia_menuGerente;
        public FrmAperturaCaja(MenuGerente p_menuGerente)
        {
            InitializeComponent();
            instancia_menuGerente = p_menuGerente;
        }
    }
}
