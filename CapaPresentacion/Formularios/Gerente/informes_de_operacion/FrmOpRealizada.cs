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
    public partial class FrmOpRealizada : Form
    {
        private MenuGerente instanciaMenuGerente;
        // Create and initialize a VScrollBar.


        public FrmOpRealizada(MenuGerente p_menuGerente)
        {
            InitializeComponent();
            IconBtnExportar.Visible = false;//esconodo el boton de exportar al inico ya que este no debe de poder se usado hasta que no haya alguna operacion cargada para exportaxr
            this.instanciaMenuGerente = p_menuGerente;

            VScrollBar vScrollBar1 = new VScrollBar();

            // Dock the scroll bar to the right side of the form.
            vScrollBar1.Dock = DockStyle.Right;

            // Add the scroll bar to the form.
            Controls.Add(vScrollBar1);
            this.AdjustFormScrollbars(true);
        }

        private void iconBtnVenta_Click(object sender, EventArgs e)
        {
            //aca llamaremos y cargaremos el datagrid para esta operacion
        }

        private void ventasOpRealizadas()
        {
            //aca llamaremos y cargaremos el datagrid para esta operacion
        }

        private void iconBtnPago_Click(object sender, EventArgs e)
        {
            //aca llamaremos y cargaremos el datagrid para esta operacion
        }
        private void pagosOpRealizadas()
        {
            //aca llamaremos y cargaremos el datagrid para esta operacion
        }
        private void iconBtnDevolucion_Click(object sender, EventArgs e)
        {

        }
        private void devolucionOpRealizadas()
        {
            //aca llamaremos y cargaremos el datagrid para esta operacion
        }
        private void iconBtnCompras_Click(object sender, EventArgs e)
        {
            //aca llamaremos y cargaremos el datagrid para esta operacion
        }
        private void comprasOpRealizadas()
        { //aca llamaremos y cargaremos el datagrid para esta operacion

        }
        private void iconBtnAlta_Click(object sender, EventArgs e)
        {
            // instanciaMenuGerente.OpenChildForm(new frmHistorialOp(this.instanciaMenuGerente));
            historialOpRealizadas();
        }
        private void historialOpRealizadas()
        {
            iconBtnAprobado.Visible = false;
            iconBtnIrregular.Visible = false;
            IconBtnExportar.Visible = true;

            IconBtnExportar.Location = new System.Drawing.Point(79, 349);

        }
    }
}
