﻿namespace CapaPresentacion.Formularios.Vendedor
{
    partial class frmModuloCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlVentanaClientes = new Panel();
            lblFiltro = new Label();
            cboFiltroClientes = new ComboBox();
            lblBuscarClientes = new Label();
            txtBuscadorClientes = new TextBox();
            pnlListaClientes = new Panel();
            btnEliminar = new Button();
            btnAgregar = new Button();
            dtgvClientes = new DataGridView();
            dni_cliente = new DataGridViewTextBoxColumn();
            apellido_cliente = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            telefono_cliente = new DataGridViewTextBoxColumn();
            direccion_cliente = new DataGridViewTextBoxColumn();
            correo_cliente = new DataGridViewTextBoxColumn();
            pnlInfoCliente = new Panel();
            txtCorreoCliente = new TextBox();
            lblCorreoCliente = new Label();
            txtDireccionCliente = new TextBox();
            lblDireccionCliente = new Label();
            txtTelefonoCliente = new TextBox();
            lblTelefonoCliente = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            txtApellidoCliente = new TextBox();
            lblApellidoCliente = new Label();
            txtDniCliente = new TextBox();
            lblDniCliente = new Label();
            pnlEncabezado = new Panel();
            lblEncabezado = new Label();
            btnModificar = new Button();
            pnlVentanaClientes.SuspendLayout();
            pnlListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            pnlInfoCliente.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVentanaClientes
            // 
            pnlVentanaClientes.BackColor = Color.FromArgb(88, 89, 150);
            pnlVentanaClientes.Controls.Add(lblFiltro);
            pnlVentanaClientes.Controls.Add(cboFiltroClientes);
            pnlVentanaClientes.Controls.Add(lblBuscarClientes);
            pnlVentanaClientes.Controls.Add(txtBuscadorClientes);
            pnlVentanaClientes.Controls.Add(pnlListaClientes);
            pnlVentanaClientes.Controls.Add(pnlInfoCliente);
            pnlVentanaClientes.Dock = DockStyle.Fill;
            pnlVentanaClientes.Location = new Point(0, 0);
            pnlVentanaClientes.Name = "pnlVentanaClientes";
            pnlVentanaClientes.Size = new Size(893, 571);
            pnlVentanaClientes.TabIndex = 0;
            // 
            // lblFiltro
            // 
            lblFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltro.ForeColor = SystemColors.HighlightText;
            lblFiltro.Location = new Point(413, 35);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(43, 20);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtro";
            // 
            // cboFiltroClientes
            // 
            cboFiltroClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFiltroClientes.FormattingEnabled = true;
            cboFiltroClientes.Location = new Point(462, 36);
            cboFiltroClientes.Name = "cboFiltroClientes";
            cboFiltroClientes.Size = new Size(122, 23);
            cboFiltroClientes.TabIndex = 5;
            // 
            // lblBuscarClientes
            // 
            lblBuscarClientes.AutoSize = true;
            lblBuscarClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarClientes.ForeColor = SystemColors.HighlightText;
            lblBuscarClientes.Location = new Point(29, 36);
            lblBuscarClientes.Name = "lblBuscarClientes";
            lblBuscarClientes.Size = new Size(52, 20);
            lblBuscarClientes.TabIndex = 4;
            lblBuscarClientes.Text = "Buscar";
            // 
            // txtBuscadorClientes
            // 
            txtBuscadorClientes.Location = new Point(87, 36);
            txtBuscadorClientes.Name = "txtBuscadorClientes";
            txtBuscadorClientes.Size = new Size(213, 23);
            txtBuscadorClientes.TabIndex = 3;
            // 
            // pnlListaClientes
            // 
            pnlListaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListaClientes.BackColor = Color.White;
            pnlListaClientes.Controls.Add(btnEliminar);
            pnlListaClientes.Controls.Add(btnAgregar);
            pnlListaClientes.Controls.Add(dtgvClientes);
            pnlListaClientes.Location = new Point(29, 71);
            pnlListaClientes.Name = "pnlListaClientes";
            pnlListaClientes.Size = new Size(555, 467);
            pnlListaClientes.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(129, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(15, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtgvClientes
            // 
            dtgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Columns.AddRange(new DataGridViewColumn[] { dni_cliente, apellido_cliente, nombre_cliente, telefono_cliente, direccion_cliente, correo_cliente });
            dtgvClientes.Location = new Point(0, 0);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.RowTemplate.Height = 25;
            dtgvClientes.Size = new Size(555, 414);
            dtgvClientes.TabIndex = 0;
            dtgvClientes.CellContentClick += dtgvClientes_CellContentClick;
            // 
            // dni_cliente
            // 
            dni_cliente.HeaderText = "DNI";
            dni_cliente.Name = "dni_cliente";
            // 
            // apellido_cliente
            // 
            apellido_cliente.HeaderText = "Apellido";
            apellido_cliente.Name = "apellido_cliente";
            // 
            // nombre_cliente
            // 
            nombre_cliente.HeaderText = "Nombre";
            nombre_cliente.Name = "nombre_cliente";
            // 
            // telefono_cliente
            // 
            telefono_cliente.HeaderText = "Teléfono";
            telefono_cliente.Name = "telefono_cliente";
            // 
            // direccion_cliente
            // 
            direccion_cliente.HeaderText = "Dirección";
            direccion_cliente.Name = "direccion_cliente";
            // 
            // correo_cliente
            // 
            correo_cliente.HeaderText = "Correo";
            correo_cliente.Name = "correo_cliente";
            // 
            // pnlInfoCliente
            // 
            pnlInfoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlInfoCliente.BackColor = Color.White;
            pnlInfoCliente.Controls.Add(txtCorreoCliente);
            pnlInfoCliente.Controls.Add(lblCorreoCliente);
            pnlInfoCliente.Controls.Add(txtDireccionCliente);
            pnlInfoCliente.Controls.Add(lblDireccionCliente);
            pnlInfoCliente.Controls.Add(txtTelefonoCliente);
            pnlInfoCliente.Controls.Add(lblTelefonoCliente);
            pnlInfoCliente.Controls.Add(txtNombreCliente);
            pnlInfoCliente.Controls.Add(lblNombreCliente);
            pnlInfoCliente.Controls.Add(txtApellidoCliente);
            pnlInfoCliente.Controls.Add(lblApellidoCliente);
            pnlInfoCliente.Controls.Add(txtDniCliente);
            pnlInfoCliente.Controls.Add(lblDniCliente);
            pnlInfoCliente.Controls.Add(pnlEncabezado);
            pnlInfoCliente.Controls.Add(btnModificar);
            pnlInfoCliente.Location = new Point(602, 36);
            pnlInfoCliente.Name = "pnlInfoCliente";
            pnlInfoCliente.Size = new Size(266, 502);
            pnlInfoCliente.TabIndex = 1;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(86, 323);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(150, 23);
            txtCorreoCliente.TabIndex = 16;
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreoCliente.Location = new Point(14, 322);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(54, 20);
            lblCorreoCliente.TabIndex = 15;
            lblCorreoCliente.Text = "Correo";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(86, 279);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(150, 23);
            txtDireccionCliente.TabIndex = 14;
            // 
            // lblDireccionCliente
            // 
            lblDireccionCliente.AutoSize = true;
            lblDireccionCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccionCliente.Location = new Point(14, 278);
            lblDireccionCliente.Name = "lblDireccionCliente";
            lblDireccionCliente.Size = new Size(72, 20);
            lblDireccionCliente.TabIndex = 13;
            lblDireccionCliente.Text = "Dirección";
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(86, 234);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(150, 23);
            txtTelefonoCliente.TabIndex = 12;
            // 
            // lblTelefonoCliente
            // 
            lblTelefonoCliente.AutoSize = true;
            lblTelefonoCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefonoCliente.Location = new Point(14, 233);
            lblTelefonoCliente.Name = "lblTelefonoCliente";
            lblTelefonoCliente.Size = new Size(67, 20);
            lblTelefonoCliente.TabIndex = 11;
            lblTelefonoCliente.Text = "Teléfono";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(86, 187);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(150, 23);
            txtNombreCliente.TabIndex = 10;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCliente.Location = new Point(14, 186);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(64, 20);
            lblNombreCliente.TabIndex = 9;
            lblNombreCliente.Text = "Nombre";
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(86, 141);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(150, 23);
            txtApellidoCliente.TabIndex = 8;
            // 
            // lblApellidoCliente
            // 
            lblApellidoCliente.AutoSize = true;
            lblApellidoCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidoCliente.Location = new Point(14, 140);
            lblApellidoCliente.Name = "lblApellidoCliente";
            lblApellidoCliente.Size = new Size(66, 20);
            lblApellidoCliente.TabIndex = 7;
            lblApellidoCliente.Text = "Apellido";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(86, 91);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(150, 23);
            txtDniCliente.TabIndex = 6;
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniCliente.Location = new Point(14, 90);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(35, 20);
            lblDniCliente.TabIndex = 5;
            lblDniCliente.Text = "DNI";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.LightBlue;
            pnlEncabezado.Controls.Add(lblEncabezado);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(266, 48);
            pnlEncabezado.TabIndex = 4;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEncabezado.ForeColor = SystemColors.ActiveCaptionText;
            lblEncabezado.Location = new Point(32, 11);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(195, 23);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Información del cliente";
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.Location = new Point(14, 455);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 35);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmModuloCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(pnlVentanaClientes);
            Name = "frmModuloCliente";
            Text = "Clientes";
            pnlVentanaClientes.ResumeLayout(false);
            pnlVentanaClientes.PerformLayout();
            pnlListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            pnlInfoCliente.ResumeLayout(false);
            pnlInfoCliente.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVentanaClientes;
        private Panel pnlInfoCliente;
        private Panel pnlListaClientes;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dtgvClientes;
        private Button btnModificar;
        private Label lblBuscarClientes;
        private TextBox txtBuscadorClientes;
        private Label lblFiltro;
        private ComboBox cboFiltroClientes;
        private DataGridViewTextBoxColumn dni_cliente;
        private DataGridViewTextBoxColumn apellido_cliente;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn telefono_cliente;
        private DataGridViewTextBoxColumn direccion_cliente;
        private DataGridViewTextBoxColumn correo_cliente;
        private Panel pnlEncabezado;
        private Label lblEncabezado;
        private TextBox txtApellidoCliente;
        private Label lblApellidoCliente;
        private TextBox txtDniCliente;
        private Label lblDniCliente;
        private TextBox txtNombreCliente;
        private Label lblNombreCliente;
        private TextBox txtDireccionCliente;
        private Label lblDireccionCliente;
        private TextBox txtTelefonoCliente;
        private Label lblTelefonoCliente;
        private TextBox txtCorreoCliente;
        private Label lblCorreoCliente;
    }
}