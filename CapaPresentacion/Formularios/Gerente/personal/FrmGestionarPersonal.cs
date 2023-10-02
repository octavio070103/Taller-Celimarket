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

namespace CapaPresentacion.Formularios.Gerente.personal
{
    public partial class FrmGestionarPersonal : Form
    {
        private MenuGerente obj_InstanciaMenuGerente;
        public FrmGestionarPersonal(MenuGerente p_menuGerente)
        {
            InitializeComponent();


            obj_InstanciaMenuGerente = p_menuGerente;

        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = 1;//e.RowIndex;
            //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                mostrarVentajaEmergente();
                // Obtener la fila seleccionada
                //DataGridViewRow selectedRow = dataGridUsuarios.Rows[e.RowIndex];

            }
        }

        //creo y muestor el formulario de deatlle de actividad de ese cliente,que contiene graficos y su actividad dentro de la plataforma
        private void mostrarVentajaEmergente()
        {
            FrmDetallesActividadUsuario frmDetalleUsuario = new FrmDetallesActividadUsuario();
            frmDetalleUsuario.Location = new Point(700, 100);
            frmDetalleUsuario.ShowDialog();


        }

        private void iconBtnClean_Click(object sender, EventArgs e)
        {
            txtUsuarioFiltro.Text = "";
            //falta para los combobox
        }

        private void iconBtnResumActiv_Click(object sender, EventArgs e)
        {

        }
    }
}
