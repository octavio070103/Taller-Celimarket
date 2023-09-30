using CapaPresentacion.Formularios.Admin.consulta_reclamo;
using CapaPresentacion.Formularios.Gerente.caja;
using FontAwesome.Sharp;
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
    public partial class FrmGestionarConsulta : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public FrmGestionarConsulta(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;

            panelDatosConsulta.Visible = false;//escondo el panel de editar datos del consulta al inicio sino selecciono ninguna consulta para editar,estara oculto
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            FrmResponderConsulta ventanaEmergREspConsul = new FrmResponderConsulta();
            ventanaEmergREspConsul.ShowDialog();
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int indice = e.RowIndex;
            int indice = 1;
            //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                mostrarDetallesConsulta();

                limpiartxtDato();
            }
        }

        //si el usuario selecciona una fila para editar se redimensionan los paneles y se hace visible el editar,redimensiona los botones los cambia de posicion
        private void mostrarDetallesConsulta()
        {
            panelDatosConsulta.Visible = true;
            // Establecer el tamaño del data grid es decir lo redimienciono cuando se muestran los detalles del uusario 
            dataGridUsuarios.Location = new System.Drawing.Point(12, 176);
            dataGridUsuarios.Size = new System.Drawing.Size(690, 349); // ancho y alto en píxeles

            //iconBtnAgregar.Location = new System.Drawing.Point(80, 99);
            //iconBtnAlta.Location = new System.Drawing.Point(211, 99);
            //iconBtnElim.Location = new System.Drawing.Point(211, 99);
            //iconBtnPermiso.Location = new System.Drawing.Point(341, 99);

        }
        private void limpiartxtDato()
        {

            txtDniDato.Text = "";
            txtNombreDato.Text = "";
            txtApeDato.Text = "";
            txtEmailDato.Text = "";
            txtAsuntoDato.Text = "";
            txtMotivoDato.Text = "";
            txtAsuntoDato.Text = "";
        }

        private void iconbtnClean_Click(object sender, EventArgs e)
        {
            txtUsuarioFiltro.Text = "";
            txtTipoFiltro.Text = "";

        }

    }
}
