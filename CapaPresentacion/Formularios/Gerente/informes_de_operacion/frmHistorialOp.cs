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

namespace CapaPresentacion.Formularios.Gerente.informes_de_operacion
{
    public partial class frmHistorialOp : Form
    {
        private MenuGerente instanciaMenuGerente;
        public frmHistorialOp(MenuGerente p_gerente)
        {
            InitializeComponent();

            instanciaMenuGerente = p_gerente;
        }


    }
}
