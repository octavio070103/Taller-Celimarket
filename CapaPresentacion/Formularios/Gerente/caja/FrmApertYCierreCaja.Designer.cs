namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class FrmApertYCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApertYCierreCaja));
            panel1 = new Panel();
            lblListaConsultas = new Label();
            tabControl1 = new TabControl();
            tabPageCajaApertura = new TabPage();
            panel2 = new Panel();
            txtRolUsuAper = new TextBox();
            label6 = new Label();
            dataGridMovEnCaja = new DataGridView();
            id_venta = new DataGridViewTextBoxColumn();
            venta_fecha = new DataGridViewTextBoxColumn();
            id_cliente = new DataGridViewTextBoxColumn();
            dni_cliente = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            Dni_usuario = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            id_apertura_caja = new DataGridViewTextBoxColumn();
            id_producto = new DataGridViewTextBoxColumn();
            nombre_producto = new DataGridViewTextBoxColumn();
            cantidad_detalle_venta = new DataGridViewTextBoxColumn();
            subtotal_detalle_venta = new DataGridViewTextBoxColumn();
            lblTituloDatelleMov = new Label();
            BtnRegresarApertura = new FontAwesome.Sharp.IconButton();
            iconBtnAbrirCaja = new FontAwesome.Sharp.IconButton();
            txtUsuAper = new TextBox();
            label2 = new Label();
            txtTipoMovimientoAper = new TextBox();
            label3 = new Label();
            txtMontoApertura = new TextBox();
            label4 = new Label();
            txtFechaApertura = new TextBox();
            label5 = new Label();
            tabPageCerrarCaja = new TabPage();
            panel4 = new Panel();
            panelDatosCajaCerra = new Panel();
            label17 = new Label();
            label12 = new Label();
            lblDiferencia = new Label();
            lblFechaApertura = new Label();
            label15 = new Label();
            label21 = new Label();
            lblMontoCierre = new Label();
            lblUsuAper = new Label();
            label19 = new Label();
            label13 = new Label();
            lblNumVentas = new Label();
            lblMontoInicial = new Label();
            txtMontoCaja = new TextBox();
            label1 = new Label();
            txtFechaCierre = new TextBox();
            iconBtnImprimir = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtUsuCierre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dataGridView3 = new DataGridView();
            Column_Forma_Pago = new DataGridViewTextBoxColumn();
            Column_total = new DataGridViewTextBoxColumn();
            label14 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            iconBtnRegresarCierre = new FontAwesome.Sharp.IconButton();
            iconBtnCerrarCaja = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCajaApertura.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMovEnCaja).BeginInit();
            tabPageCerrarCaja.SuspendLayout();
            panel4.SuspendLayout();
            panelDatosCajaCerra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 68, 89);
            panel1.Controls.Add(lblListaConsultas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 72);
            panel1.TabIndex = 1;
            // 
            // lblListaConsultas
            // 
            lblListaConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaConsultas.AutoSize = true;
            lblListaConsultas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaConsultas.ForeColor = SystemColors.ControlLightLight;
            lblListaConsultas.ImageAlign = ContentAlignment.TopCenter;
            lblListaConsultas.Location = new Point(233, 15);
            lblListaConsultas.Name = "lblListaConsultas";
            lblListaConsultas.Size = new Size(282, 45);
            lblListaConsultas.TabIndex = 1;
            lblListaConsultas.Text = "Apertura de Caja ";
            lblListaConsultas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCajaApertura);
            tabControl1.Controls.Add(tabPageCerrarCaja);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(839, 607);
            tabControl1.TabIndex = 4;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageCajaApertura
            // 
            tabPageCajaApertura.Controls.Add(panel2);
            tabPageCajaApertura.Controls.Add(panel1);
            tabPageCajaApertura.Location = new Point(4, 24);
            tabPageCajaApertura.Name = "tabPageCajaApertura";
            tabPageCajaApertura.Padding = new Padding(3);
            tabPageCajaApertura.Size = new Size(831, 579);
            tabPageCajaApertura.TabIndex = 0;
            tabPageCajaApertura.Text = "Apertura Caja";
            tabPageCajaApertura.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(txtRolUsuAper);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dataGridMovEnCaja);
            panel2.Controls.Add(lblTituloDatelleMov);
            panel2.Controls.Add(BtnRegresarApertura);
            panel2.Controls.Add(iconBtnAbrirCaja);
            panel2.Controls.Add(txtUsuAper);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTipoMovimientoAper);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtMontoApertura);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtFechaApertura);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 501);
            panel2.TabIndex = 5;
            // 
            // txtRolUsuAper
            // 
            txtRolUsuAper.Location = new Point(44, 107);
            txtRolUsuAper.Name = "txtRolUsuAper";
            txtRolUsuAper.ReadOnly = true;
            txtRolUsuAper.Size = new Size(254, 23);
            txtRolUsuAper.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 79);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 17;
            label6.Text = "Rol del usuario";
            // 
            // dataGridMovEnCaja
            // 
            dataGridMovEnCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMovEnCaja.Columns.AddRange(new DataGridViewColumn[] { id_venta, venta_fecha, id_cliente, dni_cliente, nombre_cliente, id_usuario, Dni_usuario, nombre_usuario, id_apertura_caja, id_producto, nombre_producto, cantidad_detalle_venta, subtotal_detalle_venta });
            dataGridMovEnCaja.Location = new Point(355, 64);
            dataGridMovEnCaja.Name = "dataGridMovEnCaja";
            dataGridMovEnCaja.RowTemplate.Height = 25;
            dataGridMovEnCaja.Size = new Size(470, 227);
            dataGridMovEnCaja.TabIndex = 16;
            // 
            // id_venta
            // 
            id_venta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_venta.HeaderText = "id_venta";
            id_venta.Name = "id_venta";
            id_venta.Visible = false;
            // 
            // venta_fecha
            // 
            venta_fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            venta_fecha.HeaderText = "Fecha de la Venta";
            venta_fecha.MinimumWidth = 70;
            venta_fecha.Name = "venta_fecha";
            // 
            // id_cliente
            // 
            id_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_cliente.HeaderText = "id_cliente";
            id_cliente.Name = "id_cliente";
            id_cliente.Visible = false;
            // 
            // dni_cliente
            // 
            dni_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dni_cliente.HeaderText = "Dni del cliente";
            dni_cliente.MinimumWidth = 100;
            dni_cliente.Name = "dni_cliente";
            // 
            // nombre_cliente
            // 
            nombre_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre_cliente.HeaderText = "nombre del cliente";
            nombre_cliente.MinimumWidth = 100;
            nombre_cliente.Name = "nombre_cliente";
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "id_usuario";
            id_usuario.Name = "id_usuario";
            id_usuario.Visible = false;
            // 
            // Dni_usuario
            // 
            Dni_usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dni_usuario.HeaderText = "Dni del usuario";
            Dni_usuario.MinimumWidth = 150;
            Dni_usuario.Name = "Dni_usuario";
            // 
            // nombre_usuario
            // 
            nombre_usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre_usuario.HeaderText = "nombre del usuario";
            nombre_usuario.MinimumWidth = 170;
            nombre_usuario.Name = "nombre_usuario";
            // 
            // id_apertura_caja
            // 
            id_apertura_caja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_apertura_caja.HeaderText = "id_apertura_caja";
            id_apertura_caja.Name = "id_apertura_caja";
            id_apertura_caja.Visible = false;
            // 
            // id_producto
            // 
            id_producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_producto.HeaderText = "id_producto";
            id_producto.Name = "id_producto";
            id_producto.Visible = false;
            // 
            // nombre_producto
            // 
            nombre_producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre_producto.HeaderText = "Nombre del producto";
            nombre_producto.MinimumWidth = 150;
            nombre_producto.Name = "nombre_producto";
            // 
            // cantidad_detalle_venta
            // 
            cantidad_detalle_venta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidad_detalle_venta.HeaderText = "Cantidad Venta";
            cantidad_detalle_venta.MinimumWidth = 70;
            cantidad_detalle_venta.Name = "cantidad_detalle_venta";
            // 
            // subtotal_detalle_venta
            // 
            subtotal_detalle_venta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtotal_detalle_venta.HeaderText = "subotal de la venta";
            subtotal_detalle_venta.MinimumWidth = 70;
            subtotal_detalle_venta.Name = "subtotal_detalle_venta";
            // 
            // lblTituloDatelleMov
            // 
            lblTituloDatelleMov.AutoSize = true;
            lblTituloDatelleMov.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloDatelleMov.Location = new Point(355, 21);
            lblTituloDatelleMov.Name = "lblTituloDatelleMov";
            lblTituloDatelleMov.Size = new Size(299, 25);
            lblTituloDatelleMov.TabIndex = 15;
            lblTituloDatelleMov.Text = "Detalle de Movimientos En la Caja";
            // 
            // BtnRegresarApertura
            // 
            BtnRegresarApertura.BackColor = Color.Orange;
            BtnRegresarApertura.BackgroundImage = (Image)resources.GetObject("BtnRegresarApertura.BackgroundImage");
            BtnRegresarApertura.BackgroundImageLayout = ImageLayout.None;
            BtnRegresarApertura.Cursor = Cursors.Hand;
            BtnRegresarApertura.FlatAppearance.BorderColor = Color.Black;
            BtnRegresarApertura.FlatStyle = FlatStyle.Flat;
            BtnRegresarApertura.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRegresarApertura.ForeColor = Color.Black;
            BtnRegresarApertura.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnRegresarApertura.IconColor = Color.White;
            BtnRegresarApertura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRegresarApertura.IconSize = 30;
            BtnRegresarApertura.Location = new Point(184, 353);
            BtnRegresarApertura.Name = "BtnRegresarApertura";
            BtnRegresarApertura.Size = new Size(105, 38);
            BtnRegresarApertura.TabIndex = 14;
            BtnRegresarApertura.Text = "Regresar";
            BtnRegresarApertura.TextAlign = ContentAlignment.MiddleRight;
            BtnRegresarApertura.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRegresarApertura.UseVisualStyleBackColor = false;
            BtnRegresarApertura.Click += BtnRegresarApertura_Click;
            // 
            // iconBtnAbrirCaja
            // 
            iconBtnAbrirCaja.BackColor = Color.LightGreen;
            iconBtnAbrirCaja.BackgroundImage = (Image)resources.GetObject("iconBtnAbrirCaja.BackgroundImage");
            iconBtnAbrirCaja.BackgroundImageLayout = ImageLayout.None;
            iconBtnAbrirCaja.Cursor = Cursors.Hand;
            iconBtnAbrirCaja.FlatAppearance.BorderColor = Color.Black;
            iconBtnAbrirCaja.FlatStyle = FlatStyle.Flat;
            iconBtnAbrirCaja.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAbrirCaja.ForeColor = Color.Black;
            iconBtnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAbrirCaja.IconColor = Color.White;
            iconBtnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAbrirCaja.IconSize = 30;
            iconBtnAbrirCaja.Location = new Point(44, 353);
            iconBtnAbrirCaja.Name = "iconBtnAbrirCaja";
            iconBtnAbrirCaja.Size = new Size(105, 38);
            iconBtnAbrirCaja.TabIndex = 13;
            iconBtnAbrirCaja.Text = "Abrir Caja";
            iconBtnAbrirCaja.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAbrirCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAbrirCaja.UseVisualStyleBackColor = false;
            iconBtnAbrirCaja.Click += iconBtnAbrirCaja_Click;
            // 
            // txtUsuAper
            // 
            txtUsuAper.Location = new Point(44, 49);
            txtUsuAper.Name = "txtUsuAper";
            txtUsuAper.ReadOnly = true;
            txtUsuAper.Size = new Size(254, 23);
            txtUsuAper.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 21);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 10;
            label2.Text = "Usuario de Turno";
            // 
            // txtTipoMovimientoAper
            // 
            txtTipoMovimientoAper.Location = new Point(44, 235);
            txtTipoMovimientoAper.Name = "txtTipoMovimientoAper";
            txtTipoMovimientoAper.ReadOnly = true;
            txtTipoMovimientoAper.Size = new Size(254, 23);
            txtTipoMovimientoAper.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 207);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Movimiento";
            // 
            // txtMontoApertura
            // 
            txtMontoApertura.Location = new Point(44, 298);
            txtMontoApertura.Name = "txtMontoApertura";
            txtMontoApertura.Size = new Size(254, 23);
            txtMontoApertura.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 270);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 6;
            label4.Text = "Monto de Apertura";
            // 
            // txtFechaApertura
            // 
            txtFechaApertura.Location = new Point(44, 167);
            txtFechaApertura.Name = "txtFechaApertura";
            txtFechaApertura.ReadOnly = true;
            txtFechaApertura.Size = new Size(254, 23);
            txtFechaApertura.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 139);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha y Hora de Apertura";
            // 
            // tabPageCerrarCaja
            // 
            tabPageCerrarCaja.Controls.Add(panel4);
            tabPageCerrarCaja.Controls.Add(panel3);
            tabPageCerrarCaja.Location = new Point(4, 24);
            tabPageCerrarCaja.Name = "tabPageCerrarCaja";
            tabPageCerrarCaja.Padding = new Padding(3);
            tabPageCerrarCaja.Size = new Size(831, 579);
            tabPageCerrarCaja.TabIndex = 1;
            tabPageCerrarCaja.Text = "Cerrar Caja";
            tabPageCerrarCaja.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(panelDatosCajaCerra);
            panel4.Controls.Add(txtMontoCaja);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtFechaCierre);
            panel4.Controls.Add(iconBtnImprimir);
            panel4.Controls.Add(iconButton5);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtUsuCierre);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dataGridView3);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(iconBtnRegresarCierre);
            panel4.Controls.Add(iconBtnCerrarCaja);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(825, 523);
            panel4.TabIndex = 4;
            // 
            // panelDatosCajaCerra
            // 
            panelDatosCajaCerra.Controls.Add(label17);
            panelDatosCajaCerra.Controls.Add(label12);
            panelDatosCajaCerra.Controls.Add(lblDiferencia);
            panelDatosCajaCerra.Controls.Add(lblFechaApertura);
            panelDatosCajaCerra.Controls.Add(label15);
            panelDatosCajaCerra.Controls.Add(label21);
            panelDatosCajaCerra.Controls.Add(lblMontoCierre);
            panelDatosCajaCerra.Controls.Add(lblUsuAper);
            panelDatosCajaCerra.Controls.Add(label19);
            panelDatosCajaCerra.Controls.Add(label13);
            panelDatosCajaCerra.Controls.Add(lblNumVentas);
            panelDatosCajaCerra.Controls.Add(lblMontoInicial);
            panelDatosCajaCerra.Location = new Point(6, 221);
            panelDatosCajaCerra.Name = "panelDatosCajaCerra";
            panelDatosCajaCerra.Size = new Size(393, 218);
            panelDatosCajaCerra.TabIndex = 43;
            panelDatosCajaCerra.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(3, 19);
            label17.Name = "label17";
            label17.Size = new Size(157, 21);
            label17.TabIndex = 35;
            label17.Text = "Monto De Apertura";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 181);
            label12.Name = "label12";
            label12.Size = new Size(89, 21);
            label12.TabIndex = 25;
            label12.Text = "Diferencia";
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiferencia.Location = new Point(227, 181);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.Size = new Size(131, 21);
            lblDiferencia.TabIndex = 26;
            lblDiferencia.Text = "label Diferencia";
            // 
            // lblFechaApertura
            // 
            lblFechaApertura.AutoSize = true;
            lblFechaApertura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaApertura.Location = new Point(227, 118);
            lblFechaApertura.Name = "lblFechaApertura";
            lblFechaApertura.Size = new Size(129, 21);
            lblFechaApertura.TabIndex = 40;
            lblFechaApertura.Text = "labe fecha Aper";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(3, 146);
            label15.Name = "label15";
            label15.Size = new Size(102, 21);
            label15.TabIndex = 27;
            label15.Text = "Monto Final";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(3, 118);
            label21.Name = "label21";
            label21.Size = new Size(148, 21);
            label21.TabIndex = 39;
            label21.Text = "Fecha de Apertura";
            // 
            // lblMontoCierre
            // 
            lblMontoCierre.AutoSize = true;
            lblMontoCierre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMontoCierre.Location = new Point(228, 146);
            lblMontoCierre.Name = "lblMontoCierre";
            lblMontoCierre.Size = new Size(150, 21);
            lblMontoCierre.TabIndex = 28;
            lblMontoCierre.Text = "label Monto cierre";
            // 
            // lblUsuAper
            // 
            lblUsuAper.AutoSize = true;
            lblUsuAper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuAper.Location = new Point(228, 82);
            lblUsuAper.Name = "lblUsuAper";
            lblUsuAper.Size = new Size(115, 21);
            lblUsuAper.TabIndex = 38;
            lblUsuAper.Text = "label usuAper";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(3, 51);
            label19.Name = "label19";
            label19.Size = new Size(182, 21);
            label19.TabIndex = 31;
            label19.Text = "Transacciones / Ventas";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 82);
            label13.Name = "label13";
            label13.Size = new Size(209, 21);
            label13.TabIndex = 37;
            label13.Text = "Usuario de turno Apertura";
            // 
            // lblNumVentas
            // 
            lblNumVentas.AutoSize = true;
            lblNumVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumVentas.Location = new Point(227, 51);
            lblNumVentas.Name = "lblNumVentas";
            lblNumVentas.Size = new Size(145, 21);
            lblNumVentas.TabIndex = 32;
            lblNumVentas.Text = "label Num Ventas";
            // 
            // lblMontoInicial
            // 
            lblMontoInicial.AutoSize = true;
            lblMontoInicial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMontoInicial.Location = new Point(227, 19);
            lblMontoInicial.Name = "lblMontoInicial";
            lblMontoInicial.Size = new Size(154, 21);
            lblMontoInicial.TabIndex = 36;
            lblMontoInicial.Text = "label saldo Ingreso";
            // 
            // txtMontoCaja
            // 
            txtMontoCaja.Location = new Point(17, 150);
            txtMontoCaja.Name = "txtMontoCaja";
            txtMontoCaja.Size = new Size(233, 23);
            txtMontoCaja.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 126);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 41;
            label1.Text = "Monto De La Caja";
            // 
            // txtFechaCierre
            // 
            txtFechaCierre.Location = new Point(17, 34);
            txtFechaCierre.Name = "txtFechaCierre";
            txtFechaCierre.ReadOnly = true;
            txtFechaCierre.Size = new Size(233, 23);
            txtFechaCierre.TabIndex = 34;
            // 
            // iconBtnImprimir
            // 
            iconBtnImprimir.BackColor = SystemColors.ControlDark;
            iconBtnImprimir.BackgroundImage = (Image)resources.GetObject("iconBtnImprimir.BackgroundImage");
            iconBtnImprimir.BackgroundImageLayout = ImageLayout.None;
            iconBtnImprimir.Cursor = Cursors.Hand;
            iconBtnImprimir.FlatAppearance.BorderColor = Color.Black;
            iconBtnImprimir.FlatStyle = FlatStyle.Flat;
            iconBtnImprimir.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnImprimir.ForeColor = Color.Black;
            iconBtnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnImprimir.IconColor = Color.White;
            iconBtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnImprimir.IconSize = 30;
            iconBtnImprimir.Location = new Point(571, 443);
            iconBtnImprimir.Name = "iconBtnImprimir";
            iconBtnImprimir.Size = new Size(105, 38);
            iconBtnImprimir.TabIndex = 33;
            iconBtnImprimir.Text = "Imprimir";
            iconBtnImprimir.TextAlign = ContentAlignment.MiddleRight;
            iconBtnImprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnImprimir.UseVisualStyleBackColor = false;
            iconBtnImprimir.Visible = false;
            iconBtnImprimir.Click += iconBtnImprimir_Click;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Green;
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.Location = new Point(124, 191);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(75, 23);
            iconButton5.TabIndex = 24;
            iconButton5.Text = "Abierto";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(17, 191);
            label11.Name = "label11";
            label11.Size = new Size(102, 21);
            label11.TabIndex = 23;
            label11.Text = "Estado Caja:";
            // 
            // txtUsuCierre
            // 
            txtUsuCierre.Location = new Point(17, 96);
            txtUsuCierre.Name = "txtUsuCierre";
            txtUsuCierre.ReadOnly = true;
            txtUsuCierre.Size = new Size(233, 23);
            txtUsuCierre.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(17, 72);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 21;
            label10.Text = "Usuario de Turno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 10);
            label9.Name = "label9";
            label9.Size = new Size(186, 21);
            label9.TabIndex = 20;
            label9.Text = "Fecha de Cierre de Caja";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column_Forma_Pago, Column_total });
            dataGridView3.Location = new Point(410, 293);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(410, 144);
            dataGridView3.TabIndex = 18;
            // 
            // Column_Forma_Pago
            // 
            Column_Forma_Pago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Forma_Pago.HeaderText = "Forma de Pago";
            Column_Forma_Pago.MinimumWidth = 100;
            Column_Forma_Pago.Name = "Column_Forma_Pago";
            // 
            // Column_total
            // 
            Column_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_total.HeaderText = "Total";
            Column_total.MinimumWidth = 100;
            Column_total.Name = "Column_total";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(410, 258);
            label14.Name = "label14";
            label14.Size = new Size(266, 25);
            label14.TabIndex = 17;
            label14.Text = "Resumen de Metodos de Pago";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(405, 34);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(410, 210);
            dataGridView2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Movimiento";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Monto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tipo Documento";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Serie";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Correlativo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Observacion";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(415, 6);
            label8.Name = "label8";
            label8.Size = new Size(277, 25);
            label8.TabIndex = 15;
            label8.Text = "Detalle de Movimientos Del Dia";
            // 
            // iconBtnRegresarCierre
            // 
            iconBtnRegresarCierre.BackColor = Color.Orange;
            iconBtnRegresarCierre.BackgroundImage = (Image)resources.GetObject("iconBtnRegresarCierre.BackgroundImage");
            iconBtnRegresarCierre.BackgroundImageLayout = ImageLayout.None;
            iconBtnRegresarCierre.Cursor = Cursors.Hand;
            iconBtnRegresarCierre.FlatAppearance.BorderColor = Color.Black;
            iconBtnRegresarCierre.FlatStyle = FlatStyle.Flat;
            iconBtnRegresarCierre.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnRegresarCierre.ForeColor = Color.Black;
            iconBtnRegresarCierre.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnRegresarCierre.IconColor = Color.White;
            iconBtnRegresarCierre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnRegresarCierre.IconSize = 30;
            iconBtnRegresarCierre.Location = new Point(210, 445);
            iconBtnRegresarCierre.Name = "iconBtnRegresarCierre";
            iconBtnRegresarCierre.Size = new Size(105, 38);
            iconBtnRegresarCierre.TabIndex = 14;
            iconBtnRegresarCierre.Text = "Regresar";
            iconBtnRegresarCierre.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRegresarCierre.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRegresarCierre.UseVisualStyleBackColor = false;
            iconBtnRegresarCierre.Click += iconBtnRegresarCierre_Click;
            // 
            // iconBtnCerrarCaja
            // 
            iconBtnCerrarCaja.BackColor = Color.LightGreen;
            iconBtnCerrarCaja.BackgroundImage = (Image)resources.GetObject("iconBtnCerrarCaja.BackgroundImage");
            iconBtnCerrarCaja.BackgroundImageLayout = ImageLayout.None;
            iconBtnCerrarCaja.Cursor = Cursors.Hand;
            iconBtnCerrarCaja.FlatAppearance.BorderColor = Color.Black;
            iconBtnCerrarCaja.FlatStyle = FlatStyle.Flat;
            iconBtnCerrarCaja.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCerrarCaja.ForeColor = Color.Black;
            iconBtnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCerrarCaja.IconColor = Color.White;
            iconBtnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCerrarCaja.IconSize = 30;
            iconBtnCerrarCaja.Location = new Point(75, 445);
            iconBtnCerrarCaja.Name = "iconBtnCerrarCaja";
            iconBtnCerrarCaja.Size = new Size(105, 38);
            iconBtnCerrarCaja.TabIndex = 13;
            iconBtnCerrarCaja.Text = "Cerrar Caja";
            iconBtnCerrarCaja.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCerrarCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCerrarCaja.UseVisualStyleBackColor = false;
            iconBtnCerrarCaja.Click += iconBtnCerrarCaja_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 68, 89);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 50);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(274, 0);
            label7.Name = "label7";
            label7.Size = new Size(227, 45);
            label7.TabIndex = 1;
            label7.Text = "Cierre de Caja";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmApertYCierreCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 604);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(838, 604);
            Name = "FrmApertYCierreCaja";
            Text = "Administrar Caja";
            Load += FrmApertYCierreCaja_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCajaApertura.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMovEnCaja).EndInit();
            tabPageCerrarCaja.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelDatosCajaCerra.ResumeLayout(false);
            panelDatosCajaCerra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaConsultas;
        private TabControl tabControl1;
        private TabPage tabPageCajaApertura;
        private TabPage tabPageCerrarCaja;
        private Panel panel3;
        private Label label7;
        private Panel panel2;
        private DataGridView dataGridMovEnCaja;
        private Label lblTituloDatelleMov;
        private FontAwesome.Sharp.IconButton BtnRegresarApertura;
        private FontAwesome.Sharp.IconButton iconBtnAbrirCaja;
        private TextBox txtUsuAper;
        private Label label2;
        private TextBox txtTipoMovimientoAper;
        private Label label3;
        private TextBox txtMontoApertura;
        private Label label4;
        private TextBox txtFechaApertura;
        private Label label5;
        private Panel panel4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column_Forma_Pago;
        private DataGridViewTextBoxColumn Column_total;
        private Label label14;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconBtnRegresarCierre;
        private FontAwesome.Sharp.IconButton iconBtnCerrarCaja;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label label11;
        private TextBox txtUsuCierre;
        private Label label10;
        private Label label9;
        private Label lblNumVentas;
        private Label label19;
        private Label lblMontoCierre;
        private Label label15;
        private Label lblDiferencia;
        private Label label12;
        private FontAwesome.Sharp.IconButton iconBtnImprimir;
        private TextBox txtRolUsuAper;
        private Label label6;
        private TextBox txtFechaCierre;
        private Label lblMontoInicial;
        private Label label17;
        private TabPage tabPageAperturaCaja;
        private TabPage tabPagCerrarCaja;
        private DataGridViewTextBoxColumn id_venta;
        private DataGridViewTextBoxColumn venta_fecha;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn dni_cliente;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn Dni_usuario;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn id_apertura_caja;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn nombre_producto;
        private DataGridViewTextBoxColumn cantidad_detalle_venta;
        private DataGridViewTextBoxColumn subtotal_detalle_venta;
        private Label lblUsuAper;
        private Label label13;
        private Label lblFechaApertura;
        private Label label21;
        private TextBox txtMontoCaja;
        private Label label1;
        private Panel panelDatosCajaCerra;
    }
}