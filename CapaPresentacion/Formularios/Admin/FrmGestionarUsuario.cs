using capaEntidad;
using CapaLogica;
using FontAwesome.Sharp;
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

namespace CapaPresentacion.Formularios.Admin
{

    public partial class FrmGestionarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        private Form currentChildForm;

        public FrmGestionarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }


        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm( new Admin.RegistrarUsuario(this.instanciaMenuAdministrador));
        }

        private void iconBtnModif_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm( new Admin.FrmEditarUsuario(this.instanciaMenuAdministrador));
        }

        private void iconBtnElim_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnPermiso_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.usuario.FrmPermisoUsuario(this.instanciaMenuAdministrador));
        }

        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            CL_usuario obj_CL_Usuario = new CL_usuario();
            //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
            List<capaEntidad.usuario> listaUsuarios = obj_CL_Usuario.listarUsuarios();

            // Asigna la lista de usuarios al DataGridView (como fuente de datos)
            dataGridUsuarios.DataSource = listaUsuarios;
        }
    }
}
