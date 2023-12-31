﻿using System;
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
    public partial class AdvertenciaCierreCaja : Form
    {
        public AdvertenciaCierreCaja()
        {
            InitializeComponent();
        }

        private void iconBtnAceptar_Click(object sender, EventArgs e)
        {
            // Establece el resultado de DialogResult como OK para indicar que el usuario eligió "Aceptar".
            this.DialogResult = DialogResult.OK;

            // Cierra la ventana emergente.
            this.Close();
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            // Establece el resultado de DialogResult como Cancel para indicar que el usuario eligió "Cancelar".
            this.DialogResult = DialogResult.Cancel;

            // Cierra la ventana emergente.
            this.Close();
        }
    }
}
