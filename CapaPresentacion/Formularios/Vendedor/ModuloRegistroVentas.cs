using CapaDatos;
using capaEntidad;
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

namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class ModuloRegistroGeren : Form
    {
        private usuario usuarioActual;
        private Form formularioActivo = null;

        public ModuloRegistroGeren(capaEntidad.usuario objUsuario)
        {
            InitializeComponent();

            usuarioActual = objUsuario;
        }


        /** Permite cargar el datagrid con las ventas registradas
         */
        private void listarVentasVendedor()
        {
            // *** Se instancia un objeto venta que permite interactuar con la base de datos
            CD_venta Obj_venta = new CD_venta();

            dtgvRegistroVentas.DataSource = Obj_venta.listarVentasVendedor(usuarioActual.id_usuario);
        }


        /** Permite cargar la lista de ventas ni bien se abre el formulario
         */
        private void ModuloRegistroVentas_Load(object sender, EventArgs e)
        {
            listarVentasVendedor();


            dtgvRegistroVentas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRegistroVentas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

        }


        private void listarDetalleVenta(int pIdVenta)
        {
            CL_Venta auxVenta = new CL_Venta();
            dtgvDetalleVenta.DataSource = auxVenta.listarDetalleVenta(pIdVenta);
        }

        private void dtgvRegistroVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenta = int.Parse(dtgvRegistroVentas.CurrentRow.Cells[0].Value.ToString());
            listarDetalleVenta(idVenta);
            dtgvDetalleVenta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(dtgvRegistroVentas.CurrentRow.Cells[0].Value.ToString());
            abrirFormularioHijo( new frmFactura(idVenta));
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

    }
}
