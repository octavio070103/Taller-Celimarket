using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using CapaLogica;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class RegistrarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public RegistrarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            List<rol> listaRol = new CL_rol().listarRol();

            //va a leer todos los items dentro de la lista
            foreach (rol item in listaRol)
            {
                comboRol.Items.Add(item.descripcion_rol);
            }
        }

       
    }
}
