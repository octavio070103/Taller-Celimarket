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
    public partial class FrmApertYCierreCaja : Form
    {
        private MenuGerente instancia_menuGerente;
        public FrmApertYCierreCaja(MenuGerente p_menuGerente)
        {
            InitializeComponent();
            instancia_menuGerente = p_menuGerente;
        }

        private void iconBtnCerrarCaja_Click(object sender, EventArgs e)
        {
            DialogResult = advertenciaCierreCaja();


        }
        private DialogResult advertenciaCierreCaja()
        {
            AdvertenciaCierreCaja ventEmergenAdverCierreCaja = new AdvertenciaCierreCaja();
            DialogResult resultado = ventEmergenAdverCierreCaja.ShowDialog();
            return resultado;
        }

        private void iconBtnAbrirCaja_Click(object sender, EventArgs e)
        {
            DialogResult = advertenciaAbrirCaja();
        }

        private DialogResult advertenciaAbrirCaja()
        {
            AdvertenciaAbrirCaja ventEmergenAdverAbrirCaja = new AdvertenciaAbrirCaja();
            DialogResult resultado = ventEmergenAdverAbrirCaja.ShowDialog();
            return resultado;
        }
    }
}
