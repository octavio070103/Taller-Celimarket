﻿using CapaDatos;
using capaEntidad;
using CapaLogica;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Vendedor
{
    public partial class frmModuloCliente : Form
    {
        private Form formularioActivo = null;


        public frmModuloCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRegistrarCliente(this));
        }

        public void agregarCliente(string[] pDatosCliente)
        {
            // Agrega los datos al datagrid de clientes
            dtgvClientes.Rows.Add(pDatosCliente);
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
                pnlVentanaClientes.Controls.Add(formHijo);
                pnlVentanaClientes.Tag = formHijo;

                formHijo.Location = new Point((pnlVentanaClientes.Width - formHijo.Width) / 2,
                                         (pnlVentanaClientes.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                formularioActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                //formHijo.Dock = DockStyle.Fill;
                pnlVentanaClientes.Controls.Add(formHijo);
                pnlVentanaClientes.Tag = formHijo;

                formHijo.Location = new Point((pnlVentanaClientes.Width - formHijo.Width) / 2,
                         (pnlVentanaClientes.Height - formHijo.Height) / 2);

                formHijo.BringToFront();
                formHijo.Show();
            }

        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvClientes.Rows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

                txtDniCliente.Text = dtgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombreCliente.Text = dtgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtApellidoCliente.Text = dtgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtFechaNac.Text = dtgvClientes.CurrentRow.Cells[4].FormattedValue.ToString();
                txtTelefonoCliente.Text = dtgvClientes.CurrentRow.Cells[5].Value.ToString();
                dtpFechaNac.Value = transformarFecha(dtgvClientes.CurrentRow.Cells[4].FormattedValue.ToString()); //
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dtgvClientes.Rows.Count > 0)
            {
                DialogResult pregunta = MessageBox.Show("Esta a punto de eliminar a un cliente del registro, ¿Desea continuar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (pregunta == DialogResult.Yes)
                {
                    CL_Cliente auxCliente = new CL_Cliente();

                    int auxIdCliente = (int)dtgvClientes.CurrentRow.Cells[0].Value;
                    int resultadoEjec;

                    auxCliente.eliminarCliente(auxIdCliente, out resultadoEjec);

                    if (resultadoEjec == 1)
                    {
                        MessageBox.Show("El cliente fue eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListaClientes(); // Se refresca el datagridview con los datos actualizados
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //eliminarCliente();
                }
            }

        }


        private void eliminarCliente(int pIdCliente, out int resultadoEjec)
        {
            resultadoEjec = 0;

            //dtgvClientes.Rows.Remove(dtgvClientes.CurrentRow);
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtDniCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtFechaNac.Text = "";
            dtpFechaNac.Text = null;//
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int resultadoEjec = 0;

            if (dtgvClientes.Rows.Count > 0)
            {
                if (validarCampos() == true)
                {
                    DialogResult pregunta = MessageBox.Show("Esta a punto de modificar este registro, ¿Desea continuar?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (pregunta == DialogResult.Yes)
                    {
                        // Obtenemos la fecha de nacimiento en formato string y la transformamos a DateTime
                        //DateTime auxFechaFormateada = transformarFecha(txtFechaNac.Text);
                        DateTime auxFechaFormateada = dtpFechaNac.Value.Date;

                        persona auxPersona = new persona()
                        {
                            dni = txtDniCliente.Text,
                            apellido = txtApellidoCliente.Text,
                            nombre = txtNombreCliente.Text,
                            fecha_nacimiento = auxFechaFormateada,
                            telefono = txtTelefonoCliente.Text
                        };

                        int idCliente = (int)dtgvClientes.CurrentRow.Cells[0].Value; // Obtenemos el id del cliente
                        CL_Cliente auxCliente = new CL_Cliente();
                        auxCliente.modificarDatosCliente(idCliente, auxPersona, out resultadoEjec);

                        if (resultadoEjec == 1)
                        {
                            MessageBox.Show("Se modificaron los datos del cliente correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarListaClientes();
                            limpiarCampos();
                            //borrarMensajeError();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar los datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        borrarMensajeError();

                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }


        private bool validarCampos()
        {
            bool validacion = true;

            if (txtApellidoCliente.Text == "")
            {
                errorProvider1.SetError(txtApellidoCliente, "Ingrese el apellido");
                validacion = false;
            }

            if (txtNombreCliente.Text == "")
            {
                errorProvider1.SetError(txtNombreCliente, "Ingrese el nombre");
                validacion = false;
            }

            if (txtDniCliente.Text == "")
            {
                errorProvider1.SetError(txtDniCliente, "Ingrese el DNI");
                validacion = false;
            }

            if (txtDniCliente.Text != "" && txtDniCliente.Text.Length != 8)//
            {
                errorProvider1.SetError(txtDniCliente, "El DNI debe contener 8 dígitos");
                validacion = false;
            }

            if (txtFechaNac.Text == "")
            {
                errorProvider1.SetError(txtFechaNac, "Ingrese la fecha de nacimiento");
                validacion = false;
            }


            if (txtTelefonoCliente.Text == "")
            {
                errorProvider1.SetError(txtTelefonoCliente, "Ingrese el numero de telefono");
                validacion = false;
            }


            return validacion;
        }


        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtApellidoCliente, "");
            errorProvider1.SetError(txtNombreCliente, "");
            errorProvider1.SetError(txtDniCliente, "");
            errorProvider1.SetError(txtFechaNac, "");
            errorProvider1.SetError(txtTelefonoCliente, "");
        }


        //******* LISTAR CLIENTES *********

        public void cargarListaClientes()
        {
            // Instanciamos un objeto de la clase CL_Cliente para obtener los datos de los clientes
            CL_Cliente objCliente = new CL_Cliente();

            dtgvClientes.DataSource = objCliente.obtenerListaClientes();
        }

        private void frmModuloCliente_Load(object sender, EventArgs e)
        {
            cboFiltroClientes.SelectedIndex = 0;
            cargarListaClientes();

            configurarDatagridView();

        }


        private void configurarDatagridView()
        {
            if (dtgvClientes.Rows.Count > 0)
            {
                dtgvClientes.Columns[0].HeaderText = "ID Cliente";
                dtgvClientes.Columns[1].HeaderText = "DNI";
                dtgvClientes.Columns[2].HeaderText = "Apellido";
                dtgvClientes.Columns[3].HeaderText = "Nombre";
                dtgvClientes.Columns[4].HeaderText = "Fecha de nacimiento";
                dtgvClientes.Columns[5].HeaderText = "Teléfono";
                dtgvClientes.Columns[6].HeaderText = "Fecha de registro";

                dtgvClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgvClientes.Columns[3].MinimumWidth = TextRenderer.MeasureText(dtgvClientes.Columns[3].HeaderText, dtgvClientes.Font).Width + 20;
            }
            else
            {
                dtgvClientes.Columns[0].HeaderText = "ID Cliente";
                dtgvClientes.Columns[1].HeaderText = "DNI";
                dtgvClientes.Columns[2].HeaderText = "Apellido";
                dtgvClientes.Columns[3].HeaderText = "Nombre";
                dtgvClientes.Columns[4].HeaderText = "Fecha de nacimiento";
                dtgvClientes.Columns[5].HeaderText = "Teléfono";
                dtgvClientes.Columns[6].HeaderText = "Fecha de registro";

                dtgvClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgvClientes.Columns[3].MinimumWidth = TextRenderer.MeasureText(dtgvClientes.Columns[3].HeaderText, dtgvClientes.Font).Width + 20;
            }

            //dtgvClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxValidacion = new Auxiliares();
            auxValidacion.soloLetras_KeyPress(sender, e);
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxValidacion = new Auxiliares();
            auxValidacion.soloNumeros_KeyPress(sender, e);
        }


        private DateTime transformarFecha(string pFecha)
        {
            string[] componentesFecha = pFecha.Split('/');

            string dia = componentesFecha[0];
            string mes = componentesFecha[1];
            string anio = componentesFecha[2];
            string fechaFormateada = "";

            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }

            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }

            fechaFormateada = anio + "-" + mes + "-" + dia;

            DateTime fecha = DateTime.Parse(fechaFormateada);

            return fecha;
        }


        private void buscarCliente(string pTerminoBusqueda, string pTipoBusqueda)
        {
            CL_Cliente auxCliente = new CL_Cliente();
            int tipoBusqueda;

            switch (pTipoBusqueda)
            {
                case "Apellido":
                    tipoBusqueda = 1;
                    break;

                case "Nombre":
                    tipoBusqueda = 2;
                    break;

                default:
                    tipoBusqueda = 0;
                    break;
            }

            dtgvClientes.DataSource = null;
            dtgvClientes.DataSource = auxCliente.buscarCliente(pTerminoBusqueda, tipoBusqueda);
            configurarDatagridView();
        }


        private void txtBuscadorClientes_TextChanged(object sender, EventArgs e)
        {
            //dtgvClientes.DataSource = null;
            string pTermino = txtBuscadorClientes.Text.ToString();
            buscarCliente(pTermino, cboFiltroClientes.Text);
            //configurarDatagridView();
        }

        private void cboFiltroClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Auxiliares auxiliar = new Auxiliares();
            auxiliar.desactivarModificacion_KeyPress(sender, e);
        }

        private void dtgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvClientes.Rows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

                txtDniCliente.Text = dtgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombreCliente.Text = dtgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtApellidoCliente.Text = dtgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtFechaNac.Text = dtgvClientes.CurrentRow.Cells[4].FormattedValue.ToString();
                txtTelefonoCliente.Text = dtgvClientes.CurrentRow.Cells[5].Value.ToString();
                dtpFechaNac.Value = transformarFecha(dtgvClientes.CurrentRow.Cells[4].FormattedValue.ToString()); //

            }
        }

        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            dtgvClientes_DoubleClick(sender, e);
        }


        public void recargarListaClientes()
        {
            dtgvClientes.DataSource = null;
            cargarListaClientes();

            configurarDatagridView();
        }

    }
}
