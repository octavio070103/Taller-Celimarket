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

namespace CapaPresentacion.Formularios.Gerente.personal
{
    public partial class FrmGestionarPersonal : Form
    {
        private MenuGerente obj_InstanciaMenuGerente;
        public FrmGestionarPersonal(MenuGerente p_menuGerente)
        {
            InitializeComponent();
            panelDatosUsuario.Visible = false;

            obj_InstanciaMenuGerente = p_menuGerente;

        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = 1;//e.RowIndex;
            //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                mostrarDetallesUsuario();
                // Obtener la fila seleccionada
                //DataGridViewRow selectedRow = dataGridUsuarios.Rows[e.RowIndex];

            }
        }

        private void mostrarDetallesUsuario()
        {
            panelDatosUsuario.Visible = true;
            // Establecer el tamaño del data grid es decir lo redimienciono cuando se muestran los detalles del uusario 
            dataGridUsuarios.Size = new System.Drawing.Size(600, 447); // ancho y alto en píxeles
            dataGridUsuarios.Location = new System.Drawing.Point(12, 176);


        }

    }
}
