﻿using Proyecto_Taller.Presentacion.Formularios.Vendedor;
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

    public partial class FrmListaUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;

        public FrmListaUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
