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
    public partial class AdvertenciaAbrirCaja : Form
    {
        public AdvertenciaAbrirCaja()
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
    }
}
