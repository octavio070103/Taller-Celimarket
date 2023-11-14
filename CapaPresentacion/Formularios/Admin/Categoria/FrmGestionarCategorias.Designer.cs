namespace CapaPresentacion.Formularios.Admin.Categoria
{
    partial class FrmGestionarCategorias
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarCategorias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblListaCategoria = new Label();
            panel2 = new Panel();
            iconBtnExcel = new FontAwesome.Sharp.IconButton();
            iconBtnProducto = new FontAwesome.Sharp.IconButton();
            iconBtnDarBaja = new FontAwesome.Sharp.IconButton();
            iconBtnDarAlta = new FontAwesome.Sharp.IconButton();
            iconBtnAgregarCateg = new FontAwesome.Sharp.IconButton();
            panelDatosUsuario = new Panel();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblIdCategDato = new Label();
            txtIdDato = new TextBox();
            txtDescripDato = new TextBox();
            txtNombreDato = new TextBox();
            lblDatosUsuario = new Label();
            lblNombreDato = new Label();
            lblDescripDato = new Label();
            lblEstadoDato = new Label();
            dataGridCategoria = new DataGridView();
            col_id_categoria = new DataGridViewTextBoxColumn();
            col_nombre_categ = new DataGridViewTextBoxColumn();
            col_descrip_categ = new DataGridViewTextBoxColumn();
            col_estado_categoria = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblListaCategoria);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 1;
            // 
            // lblListaCategoria
            // 
            lblListaCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaCategoria.AutoSize = true;
            lblListaCategoria.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaCategoria.ForeColor = SystemColors.ControlLightLight;
            lblListaCategoria.ImageAlign = ContentAlignment.TopCenter;
            lblListaCategoria.Location = new Point(278, 0);
            lblListaCategoria.Name = "lblListaCategoria";
            lblListaCategoria.Size = new Size(306, 45);
            lblListaCategoria.TabIndex = 0;
            lblListaCategoria.Text = "Lista De Categorias";
            lblListaCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(iconBtnExcel);
            panel2.Controls.Add(iconBtnProducto);
            panel2.Controls.Add(iconBtnDarBaja);
            panel2.Controls.Add(iconBtnDarAlta);
            panel2.Controls.Add(iconBtnAgregarCateg);
            panel2.Controls.Add(panelDatosUsuario);
            panel2.Controls.Add(dataGridCategoria);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 473);
            panel2.TabIndex = 2;
            // 
            // iconBtnExcel
            // 
            iconBtnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconBtnExcel.BackColor = Color.DarkGray;
            iconBtnExcel.BackgroundImage = (Image)resources.GetObject("iconBtnExcel.BackgroundImage");
            iconBtnExcel.BackgroundImageLayout = ImageLayout.None;
            iconBtnExcel.Cursor = Cursors.Hand;
            iconBtnExcel.FlatAppearance.BorderColor = Color.Black;
            iconBtnExcel.FlatStyle = FlatStyle.Flat;
            iconBtnExcel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnExcel.ForeColor = SystemColors.ControlLightLight;
            iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnExcel.IconColor = Color.White;
            iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnExcel.IconSize = 30;
            iconBtnExcel.Location = new Point(22, 434);
            iconBtnExcel.Name = "iconBtnExcel";
            iconBtnExcel.Size = new Size(126, 27);
            iconBtnExcel.TabIndex = 23;
            iconBtnExcel.Text = "Descargar Excel";
            iconBtnExcel.TextAlign = ContentAlignment.MiddleRight;
            iconBtnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnExcel.UseVisualStyleBackColor = false;
            iconBtnExcel.Click += iconBtnExcel_Click;
            // 
            // iconBtnProducto
            // 
            iconBtnProducto.BackColor = Color.Navy;
            iconBtnProducto.BackgroundImage = (Image)resources.GetObject("iconBtnProducto.BackgroundImage");
            iconBtnProducto.BackgroundImageLayout = ImageLayout.None;
            iconBtnProducto.Cursor = Cursors.Hand;
            iconBtnProducto.FlatAppearance.BorderColor = Color.Black;
            iconBtnProducto.FlatStyle = FlatStyle.Flat;
            iconBtnProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnProducto.ForeColor = SystemColors.ControlLightLight;
            iconBtnProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnProducto.IconColor = Color.White;
            iconBtnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnProducto.IconSize = 30;
            iconBtnProducto.Location = new Point(431, 6);
            iconBtnProducto.Name = "iconBtnProducto";
            iconBtnProducto.Size = new Size(103, 39);
            iconBtnProducto.TabIndex = 22;
            iconBtnProducto.Text = "Productos";
            iconBtnProducto.TextAlign = ContentAlignment.MiddleRight;
            iconBtnProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnProducto.UseVisualStyleBackColor = false;
            iconBtnProducto.Click += iconBtnProducto_Click;
            // 
            // iconBtnDarBaja
            // 
            iconBtnDarBaja.BackColor = Color.FromArgb(246, 69, 32);
            iconBtnDarBaja.BackgroundImage = (Image)resources.GetObject("iconBtnDarBaja.BackgroundImage");
            iconBtnDarBaja.BackgroundImageLayout = ImageLayout.None;
            iconBtnDarBaja.Cursor = Cursors.Hand;
            iconBtnDarBaja.FlatAppearance.BorderColor = Color.Black;
            iconBtnDarBaja.FlatStyle = FlatStyle.Flat;
            iconBtnDarBaja.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnDarBaja.ForeColor = SystemColors.ControlLightLight;
            iconBtnDarBaja.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnDarBaja.IconColor = Color.White;
            iconBtnDarBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDarBaja.IconSize = 30;
            iconBtnDarBaja.Location = new Point(278, 7);
            iconBtnDarBaja.Name = "iconBtnDarBaja";
            iconBtnDarBaja.Size = new Size(109, 38);
            iconBtnDarBaja.TabIndex = 21;
            iconBtnDarBaja.Text = "Dar De Baja";
            iconBtnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            iconBtnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDarBaja.UseVisualStyleBackColor = false;
            iconBtnDarBaja.Click += iconBtnDarBaja_Click;
            // 
            // iconBtnDarAlta
            // 
            iconBtnDarAlta.BackColor = Color.Orange;
            iconBtnDarAlta.BackgroundImage = (Image)resources.GetObject("iconBtnDarAlta.BackgroundImage");
            iconBtnDarAlta.BackgroundImageLayout = ImageLayout.None;
            iconBtnDarAlta.Cursor = Cursors.Hand;
            iconBtnDarAlta.FlatAppearance.BorderColor = Color.Black;
            iconBtnDarAlta.FlatStyle = FlatStyle.Flat;
            iconBtnDarAlta.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnDarAlta.ForeColor = SystemColors.ControlLightLight;
            iconBtnDarAlta.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnDarAlta.IconColor = Color.White;
            iconBtnDarAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDarAlta.IconSize = 30;
            iconBtnDarAlta.Location = new Point(278, 6);
            iconBtnDarAlta.Name = "iconBtnDarAlta";
            iconBtnDarAlta.Size = new Size(89, 38);
            iconBtnDarAlta.TabIndex = 20;
            iconBtnDarAlta.Text = "Dar Alta";
            iconBtnDarAlta.TextAlign = ContentAlignment.MiddleRight;
            iconBtnDarAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDarAlta.UseVisualStyleBackColor = false;
            iconBtnDarAlta.Click += iconBtnDarAlta_Click;
            // 
            // iconBtnAgregarCateg
            // 
            iconBtnAgregarCateg.BackColor = Color.FromArgb(118, 254, 64);
            iconBtnAgregarCateg.BackgroundImage = (Image)resources.GetObject("iconBtnAgregarCateg.BackgroundImage");
            iconBtnAgregarCateg.BackgroundImageLayout = ImageLayout.None;
            iconBtnAgregarCateg.Cursor = Cursors.Hand;
            iconBtnAgregarCateg.FlatAppearance.BorderColor = Color.Black;
            iconBtnAgregarCateg.FlatStyle = FlatStyle.Flat;
            iconBtnAgregarCateg.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAgregarCateg.ForeColor = SystemColors.ControlLightLight;
            iconBtnAgregarCateg.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAgregarCateg.IconColor = Color.White;
            iconBtnAgregarCateg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregarCateg.IconSize = 30;
            iconBtnAgregarCateg.Location = new Point(147, 6);
            iconBtnAgregarCateg.Name = "iconBtnAgregarCateg";
            iconBtnAgregarCateg.Size = new Size(89, 39);
            iconBtnAgregarCateg.TabIndex = 18;
            iconBtnAgregarCateg.Text = "Agregar";
            iconBtnAgregarCateg.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAgregarCateg.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAgregarCateg.UseVisualStyleBackColor = false;
            iconBtnAgregarCateg.Click += iconBtnAgregarCateg_Click;
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(iconbtnGuardar);
            panelDatosUsuario.Controls.Add(iconBtnCancelar);
            panelDatosUsuario.Controls.Add(iconBtnModif);
            panelDatosUsuario.Controls.Add(comboEstadoDato);
            panelDatosUsuario.Controls.Add(lblIdCategDato);
            panelDatosUsuario.Controls.Add(txtIdDato);
            panelDatosUsuario.Controls.Add(txtDescripDato);
            panelDatosUsuario.Controls.Add(txtNombreDato);
            panelDatosUsuario.Controls.Add(lblDatosUsuario);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(lblDescripDato);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Location = new Point(584, 27);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(238, 348);
            panelDatosUsuario.TabIndex = 13;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(56, 182, 255);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 36;
            iconbtnGuardar.Location = new Point(24, 238);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(202, 39);
            iconbtnGuardar.TabIndex = 25;
            iconbtnGuardar.Text = "Confirmar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
            // 
            // iconBtnCancelar
            // 
            iconBtnCancelar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnCancelar.Cursor = Cursors.Hand;
            iconBtnCancelar.FlatAppearance.BorderColor = Color.Black;
            iconBtnCancelar.FlatStyle = FlatStyle.Flat;
            iconBtnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(24, 283);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(202, 39);
            iconBtnCancelar.TabIndex = 11;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            iconBtnCancelar.Click += iconBtnCancelar_Click;
            // 
            // iconBtnModif
            // 
            iconBtnModif.BackColor = Color.FromArgb(255, 222, 89);
            iconBtnModif.Cursor = Cursors.Hand;
            iconBtnModif.FlatAppearance.BorderColor = Color.Black;
            iconBtnModif.FlatStyle = FlatStyle.Flat;
            iconBtnModif.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnModif.ForeColor = Color.White;
            iconBtnModif.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconBtnModif.IconColor = Color.White;
            iconBtnModif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnModif.IconSize = 30;
            iconBtnModif.Location = new Point(24, 238);
            iconBtnModif.Name = "iconBtnModif";
            iconBtnModif.Size = new Size(202, 39);
            iconBtnModif.TabIndex = 24;
            iconBtnModif.Text = "Modificar";
            iconBtnModif.TextAlign = ContentAlignment.MiddleRight;
            iconBtnModif.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnModif.UseVisualStyleBackColor = false;
            iconBtnModif.Click += iconBtnModif_Click;
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 139);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            comboEstadoDato.Text = "Seleccione un Estado";
            // 
            // lblIdCategDato
            // 
            lblIdCategDato.AutoSize = true;
            lblIdCategDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdCategDato.ForeColor = SystemColors.WindowText;
            lblIdCategDato.Location = new Point(3, 61);
            lblIdCategDato.Name = "lblIdCategDato";
            lblIdCategDato.Size = new Size(22, 17);
            lblIdCategDato.TabIndex = 11;
            lblIdCategDato.Text = "ID";
            // 
            // txtIdDato
            // 
            txtIdDato.Location = new Point(79, 55);
            txtIdDato.Name = "txtIdDato";
            txtIdDato.ReadOnly = true;
            txtIdDato.Size = new Size(144, 23);
            txtIdDato.TabIndex = 10;
            txtIdDato.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescripDato
            // 
            txtDescripDato.Location = new Point(79, 113);
            txtDescripDato.Name = "txtDescripDato";
            txtDescripDato.Size = new Size(144, 23);
            txtDescripDato.TabIndex = 9;
            txtDescripDato.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 84);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            txtNombreDato.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(10, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(216, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos De la Categoria";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(0, 90);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(58, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Nombre";
            // 
            // lblDescripDato
            // 
            lblDescripDato.AutoSize = true;
            lblDescripDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripDato.ForeColor = SystemColors.WindowText;
            lblDescripDato.Location = new Point(0, 119);
            lblDescripDato.Name = "lblDescripDato";
            lblDescripDato.Size = new Size(80, 17);
            lblDescripDato.TabIndex = 8;
            lblDescripDato.Text = "Descripcion";
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(0, 139);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(49, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Estado";
            // 
            // dataGridCategoria
            // 
            dataGridCategoria.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridCategoria.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridCategoria.BorderStyle = BorderStyle.None;
            dataGridCategoria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategoria.Columns.AddRange(new DataGridViewColumn[] { col_id_categoria, col_nombre_categ, col_descrip_categ, col_estado_categoria });
            dataGridCategoria.Location = new Point(22, 90);
            dataGridCategoria.MultiSelect = false;
            dataGridCategoria.Name = "dataGridCategoria";
            dataGridCategoria.ReadOnly = true;
            dataGridCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCategoria.RowHeadersVisible = false;
            dataGridCategoria.RowTemplate.Height = 28;
            dataGridCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCategoria.Size = new Size(556, 301);
            dataGridCategoria.TabIndex = 12;
            dataGridCategoria.CellContentClick += dataGridCategoria_CellContentClick;
            // 
            // col_id_categoria
            // 
            col_id_categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_id_categoria.HeaderText = "Id_categoria";
            col_id_categoria.MinimumWidth = 100;
            col_id_categoria.Name = "col_id_categoria";
            col_id_categoria.ReadOnly = true;
            col_id_categoria.Width = 112;
            // 
            // col_nombre_categ
            // 
            col_nombre_categ.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_nombre_categ.HeaderText = "Nombre";
            col_nombre_categ.MinimumWidth = 50;
            col_nombre_categ.Name = "col_nombre_categ";
            col_nombre_categ.ReadOnly = true;
            // 
            // col_descrip_categ
            // 
            col_descrip_categ.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_descrip_categ.HeaderText = "Descripcion";
            col_descrip_categ.MinimumWidth = 130;
            col_descrip_categ.Name = "col_descrip_categ";
            col_descrip_categ.ReadOnly = true;
            // 
            // col_estado_categoria
            // 
            col_estado_categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_estado_categoria.HeaderText = "Estado";
            col_estado_categoria.MinimumWidth = 50;
            col_estado_categoria.Name = "col_estado_categoria";
            col_estado_categoria.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmGestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmGestionarCategorias";
            Text = "FrmGestionarCategorias";
            Load += FrmGestionarCategorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaCategoria;
        private Panel panel2;
        private Panel panelDatosUsuario;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private Label lblIdCategDato;
        private TextBox txtIdDato;
        private TextBox txtDescripDato;
        private Label lblDescripDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatosUsuario;
        private DataGridView dataGridCategoria;
        private FontAwesome.Sharp.IconButton iconBtnDarAlta;
        private FontAwesome.Sharp.IconButton iconBtnAgregarCateg;
        private FontAwesome.Sharp.IconButton iconBtnDarBaja;
        private FontAwesome.Sharp.IconButton iconBtnProducto;
        private DataGridViewTextBoxColumn col_id_categoria;
        private DataGridViewTextBoxColumn col_nombre_categ;
        private DataGridViewTextBoxColumn col_descrip_categ;
        private DataGridViewTextBoxColumn col_estado_categoria;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private ErrorProvider errorProvider1;
    }
}