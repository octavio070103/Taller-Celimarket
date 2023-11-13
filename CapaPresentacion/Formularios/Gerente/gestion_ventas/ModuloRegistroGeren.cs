using CapaDatos;
using CapaLogica;
using CapaPresentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
{
    public partial class ModuloRegistroGeren : Form
    {
        private Form formularioActivo = null;

        public ModuloRegistroGeren()
        {
            InitializeComponent();
        }
        private void listarVentas()
        {
            CD_venta Obj_venta = new CD_venta();

            dtgvRegistroGeren.DataSource = Obj_venta.listarVentas();
        }

        private void ModuloRegistroGeren_Load(object sender, EventArgs e)
        {
            listarVentas();
            dtpFechaInicio_ValueChanged(sender, e);
        }

        private void configurarDatagridView()
        {
            if (dtgvRegistroGeren.Rows.Count > 0)
            {
                if (dtgvDetalleVenta.Rows.Count > 0)
                {
                    dtgvDetalleVenta.DataSource = null;
                }
            }
            else
            {
                if (dtgvDetalleVenta.Rows.Count > 0)
                {
                    dtgvDetalleVenta.DataSource = null;
                }
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFechaInicio.Value.Date;
            DateTime fechaHasta = dtpFechaFin.Value.Date;

            filtrarVentasPeriodo(fechaDesde, fechaHasta);
            configurarDatagridView();
        }


        private void filtrarVentasPeriodo(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            CL_Venta auxVenta = new CL_Venta();
            DataTable listaVentas = auxVenta.listarVentasPorPeriodo(pFechaDesde, pFechaHasta);

            dtgvRegistroGeren.DataSource = null;
            dtgvRegistroGeren.DataSource = listaVentas;
        }

        private void filtrarPorDias(int pDias)
        {
            DateTime fechaHasta = DateTime.Now.Date;
            DateTime fechaDesde = fechaHasta.AddDays(-1 * pDias).Date;

            filtrarVentasPeriodo(fechaDesde, fechaHasta);
            configurarDatagridView();
        }

        private void btnFiltroHoy_Click(object sender, EventArgs e)
        {
            filtrarPorDias(0);
        }

        private void btnFiltroSiete_Click(object sender, EventArgs e)
        {
            filtrarPorDias(7);
        }

        private void btnFiltroTreinta_Click(object sender, EventArgs e)
        {
            filtrarPorDias(30);
        }

        private void btnFiltroHisto_Click(object sender, EventArgs e)
        {
            listarVentas();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaMinima = dtpFechaInicio.Value;

            dtpFechaFin.MinDate = fechaMinima;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dtgvRegistroGeren.Rows.Count > 0)
            {
                int idVenta = int.Parse(dtgvRegistroGeren.CurrentRow.Cells[0].Value.ToString());
                abrirFormularioHijo(new frmFactura(idVenta));
            }
        }


        private void listarDetalleVenta(int pIdVenta)
        {
            CL_Venta auxVenta = new CL_Venta();
            dtgvDetalleVenta.DataSource = auxVenta.listarDetalleVenta(pIdVenta);
        }





        private void abrirFormularioHijo(Form formHijo)
        {
            //**** Este metodo abrira el formulario indicado por cada boton ****

            if (formularioActivo != null) // cambiar por !=
            {
                formularioActivo.Close();
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                //formHijo.Dock = DockStyle.Fill;
                pnlRegistro.Controls.Add(formHijo);
                pnlRegistro.Tag = formHijo;

                formHijo.Location = new Point((pnlRegistro.Width - formHijo.Width) / 2,
                                         (pnlRegistro.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                //formHijo.Dock = DockStyle.Fill;
                pnlRegistro.Controls.Add(formHijo);
                pnlRegistro.Tag = formHijo;

                formHijo.Location = new Point((pnlRegistro.Width - formHijo.Width) / 2,
                         (pnlRegistro.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }

        }

        private void dtgvRegistroGeren_DoubleClick(object sender, EventArgs e)
        {
            int idVenta;

            if (dtgvDetalleVenta.Rows.Count > 0)
            {
                idVenta = int.Parse(dtgvRegistroGeren.CurrentRow.Cells[0].Value.ToString());
                dtgvDetalleVenta.DataSource = null;
                listarDetalleVenta(idVenta);
            }
        }

        private void dtgvRegistroGeren_Click(object sender, EventArgs e)
        {
            int idVenta;

            if (dtgvRegistroGeren.Rows.Count > 0)
            {
                idVenta = int.Parse(dtgvRegistroGeren.CurrentRow.Cells[0].Value.ToString());
                dtgvDetalleVenta.DataSource = null;
                listarDetalleVenta(idVenta);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnFiltroHisto_Click(sender, e);
        }
    }
}
