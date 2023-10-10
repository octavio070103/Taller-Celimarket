namespace CapaPresentacion.Formularios.Admin.Producto
{
    partial class FrmGestionarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarProducto));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            iconBtnAlta = new FontAwesome.Sharp.IconButton();
            iconBtnHistorial = new FontAwesome.Sharp.IconButton();
            iconBtnElim = new FontAwesome.Sharp.IconButton();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            panelDatosUsuario = new Panel();
            lblStock = new Label();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblEstadoDato = new Label();
            lblMarcaDato = new Label();
            txtEmailDato = new TextBox();
            lblTelefDato = new Label();
            txtTelefDato = new TextBox();
            lblIdDato = new Label();
            txtDniDato = new TextBox();
            txtApeDato = new TextBox();
            lblPrecioCompraDato = new Label();
            lblNombreDato = new Label();
            txtNombreDato = new TextBox();
            lblDatosUsuario = new Label();
            dataGridUsuarios = new DataGridView();
            lblCatalogoProducto = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lblCategoriaDato = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            panel2.SuspendLayout();
            panelDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(iconBtnAlta);
            panel2.Controls.Add(iconBtnHistorial);
            panel2.Controls.Add(iconBtnElim);
            panel2.Controls.Add(iconBtnAgregar);
            panel2.Controls.Add(panelDatosUsuario);
            panel2.Controls.Add(dataGridUsuarios);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 501);
            panel2.TabIndex = 2;
            // 
            // iconBtnAlta
            // 
            iconBtnAlta.BackColor = Color.Orange;
            iconBtnAlta.BackgroundImage = (Image)resources.GetObject("iconBtnAlta.BackgroundImage");
            iconBtnAlta.BackgroundImageLayout = ImageLayout.None;
            iconBtnAlta.Cursor = Cursors.Hand;
            iconBtnAlta.FlatAppearance.BorderColor = Color.Black;
            iconBtnAlta.FlatStyle = FlatStyle.Flat;
            iconBtnAlta.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAlta.ForeColor = SystemColors.ControlLightLight;
            iconBtnAlta.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAlta.IconColor = Color.White;
            iconBtnAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAlta.IconSize = 30;
            iconBtnAlta.Location = new Point(361, 23);
            iconBtnAlta.Name = "iconBtnAlta";
            iconBtnAlta.Size = new Size(89, 38);
            iconBtnAlta.TabIndex = 17;
            iconBtnAlta.Text = "Dar Alta";
            iconBtnAlta.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAlta.UseVisualStyleBackColor = false;
            // 
            // iconBtnHistorial
            // 
            iconBtnHistorial.BackColor = Color.FromArgb(216, 103, 30);
            iconBtnHistorial.BackgroundImage = (Image)resources.GetObject("iconBtnHistorial.BackgroundImage");
            iconBtnHistorial.BackgroundImageLayout = ImageLayout.None;
            iconBtnHistorial.Cursor = Cursors.Hand;
            iconBtnHistorial.FlatAppearance.BorderColor = Color.Black;
            iconBtnHistorial.FlatStyle = FlatStyle.Flat;
            iconBtnHistorial.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnHistorial.ForeColor = SystemColors.ControlLightLight;
            iconBtnHistorial.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnHistorial.IconColor = Color.White;
            iconBtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnHistorial.IconSize = 30;
            iconBtnHistorial.Location = new Point(491, 23);
            iconBtnHistorial.Name = "iconBtnHistorial";
            iconBtnHistorial.Size = new Size(90, 39);
            iconBtnHistorial.TabIndex = 16;
            iconBtnHistorial.Text = "Historial";
            iconBtnHistorial.TextAlign = ContentAlignment.MiddleRight;
            iconBtnHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnHistorial.UseVisualStyleBackColor = false;
            // 
            // iconBtnElim
            // 
            iconBtnElim.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnElim.BackgroundImage = (Image)resources.GetObject("iconBtnElim.BackgroundImage");
            iconBtnElim.BackgroundImageLayout = ImageLayout.None;
            iconBtnElim.Cursor = Cursors.Hand;
            iconBtnElim.FlatAppearance.BorderColor = Color.Black;
            iconBtnElim.FlatStyle = FlatStyle.Flat;
            iconBtnElim.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnElim.ForeColor = SystemColors.ControlLightLight;
            iconBtnElim.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnElim.IconColor = Color.White;
            iconBtnElim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnElim.IconSize = 30;
            iconBtnElim.Location = new Point(361, 23);
            iconBtnElim.Name = "iconBtnElim";
            iconBtnElim.Size = new Size(89, 39);
            iconBtnElim.TabIndex = 15;
            iconBtnElim.Text = "Eliminar";
            iconBtnElim.TextAlign = ContentAlignment.MiddleRight;
            iconBtnElim.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnElim.UseVisualStyleBackColor = false;
            // 
            // iconBtnAgregar
            // 
            iconBtnAgregar.BackColor = Color.FromArgb(19, 173, 39);
            iconBtnAgregar.BackgroundImage = (Image)resources.GetObject("iconBtnAgregar.BackgroundImage");
            iconBtnAgregar.BackgroundImageLayout = ImageLayout.None;
            iconBtnAgregar.Cursor = Cursors.Hand;
            iconBtnAgregar.FlatAppearance.BorderColor = Color.Black;
            iconBtnAgregar.FlatStyle = FlatStyle.Flat;
            iconBtnAgregar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAgregar.ForeColor = SystemColors.ControlLightLight;
            iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAgregar.IconColor = Color.White;
            iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregar.IconSize = 30;
            iconBtnAgregar.Location = new Point(230, 23);
            iconBtnAgregar.Name = "iconBtnAgregar";
            iconBtnAgregar.Size = new Size(89, 39);
            iconBtnAgregar.TabIndex = 14;
            iconBtnAgregar.Text = "Agregar";
            iconBtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAgregar.UseVisualStyleBackColor = false;
            iconBtnAgregar.Click += iconBtnAgregar_Click;
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(textBox3);
            panelDatosUsuario.Controls.Add(textBox2);
            panelDatosUsuario.Controls.Add(lblCategoriaDato);
            panelDatosUsuario.Controls.Add(textBox1);
            panelDatosUsuario.Controls.Add(label1);
            panelDatosUsuario.Controls.Add(lblStock);
            panelDatosUsuario.Controls.Add(iconbtnGuardar);
            panelDatosUsuario.Controls.Add(iconBtnCancelar);
            panelDatosUsuario.Controls.Add(iconBtnModif);
            panelDatosUsuario.Controls.Add(comboEstadoDato);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Controls.Add(lblMarcaDato);
            panelDatosUsuario.Controls.Add(txtEmailDato);
            panelDatosUsuario.Controls.Add(lblTelefDato);
            panelDatosUsuario.Controls.Add(txtTelefDato);
            panelDatosUsuario.Controls.Add(txtDniDato);
            panelDatosUsuario.Controls.Add(txtApeDato);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(txtNombreDato);
            panelDatosUsuario.Controls.Add(lblDatosUsuario);
            panelDatosUsuario.Controls.Add(lblIdDato);
            panelDatosUsuario.Controls.Add(lblPrecioCompraDato);
            panelDatosUsuario.Controls.Add(label2);
            panelDatosUsuario.Location = new Point(584, 14);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(238, 459);
            panelDatosUsuario.TabIndex = 13;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = SystemColors.WindowText;
            lblStock.Location = new Point(3, 175);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(41, 17);
            lblStock.TabIndex = 29;
            lblStock.Text = "Stock";
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
            iconbtnGuardar.Location = new Point(24, 365);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(202, 39);
            iconbtnGuardar.TabIndex = 25;
            iconbtnGuardar.Text = "Confirmar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
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
            iconBtnCancelar.Location = new Point(24, 410);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(202, 39);
            iconBtnCancelar.TabIndex = 11;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
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
            iconBtnModif.Location = new Point(24, 365);
            iconBtnModif.Name = "iconBtnModif";
            iconBtnModif.Size = new Size(202, 39);
            iconBtnModif.TabIndex = 24;
            iconBtnModif.Text = "Modificar";
            iconBtnModif.TextAlign = ContentAlignment.MiddleRight;
            iconBtnModif.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnModif.UseVisualStyleBackColor = false;
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 325);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            comboEstadoDato.Text = "Seleccione un Estado";
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(5, 325);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(49, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Estado";
            // 
            // lblMarcaDato
            // 
            lblMarcaDato.AutoSize = true;
            lblMarcaDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarcaDato.ForeColor = SystemColors.WindowText;
            lblMarcaDato.Location = new Point(3, 133);
            lblMarcaDato.Name = "lblMarcaDato";
            lblMarcaDato.Size = new Size(45, 17);
            lblMarcaDato.TabIndex = 17;
            lblMarcaDato.Text = "Marca";
            // 
            // txtEmailDato
            // 
            txtEmailDato.Location = new Point(79, 127);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 16;
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(7, 221);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(54, 17);
            lblTelefDato.TabIndex = 13;
            lblTelefDato.Text = "Imagen";
            // 
            // txtTelefDato
            // 
            txtTelefDato.Location = new Point(79, 215);
            txtTelefDato.Name = "txtTelefDato";
            txtTelefDato.Size = new Size(144, 23);
            txtTelefDato.TabIndex = 12;
            // 
            // lblIdDato
            // 
            lblIdDato.AutoSize = true;
            lblIdDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdDato.ForeColor = SystemColors.WindowText;
            lblIdDato.Location = new Point(0, 48);
            lblIdDato.Name = "lblIdDato";
            lblIdDato.Size = new Size(80, 17);
            lblIdDato.TabIndex = 11;
            lblIdDato.Text = "Id Producto";
            // 
            // txtDniDato
            // 
            txtDniDato.Location = new Point(79, 42);
            txtDniDato.Name = "txtDniDato";
            txtDniDato.Size = new Size(144, 23);
            txtDniDato.TabIndex = 10;
            // 
            // txtApeDato
            // 
            txtApeDato.Location = new Point(117, 156);
            txtApeDato.Name = "txtApeDato";
            txtApeDato.Size = new Size(61, 23);
            txtApeDato.TabIndex = 9;
            // 
            // lblPrecioCompraDato
            // 
            lblPrecioCompraDato.AutoSize = true;
            lblPrecioCompraDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioCompraDato.ForeColor = SystemColors.WindowText;
            lblPrecioCompraDato.Location = new Point(2, 162);
            lblPrecioCompraDato.Name = "lblPrecioCompraDato";
            lblPrecioCompraDato.Size = new Size(98, 17);
            lblPrecioCompraDato.TabIndex = 8;
            lblPrecioCompraDato.Text = "Precio Compra";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(3, 106);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(58, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Nombre";
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 100);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(32, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(180, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos Del Usuario";
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(12, 98);
            dataGridUsuarios.MultiSelect = false;
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.ReadOnly = true;
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridUsuarios.RowTemplate.Height = 28;
            dataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsuarios.Size = new Size(795, 364);
            dataGridUsuarios.TabIndex = 12;
            // 
            // lblCatalogoProducto
            // 
            lblCatalogoProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCatalogoProducto.AutoSize = true;
            lblCatalogoProducto.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatalogoProducto.ForeColor = SystemColors.ControlLightLight;
            lblCatalogoProducto.ImageAlign = ContentAlignment.TopCenter;
            lblCatalogoProducto.Location = new Point(275, 9);
            lblCatalogoProducto.Name = "lblCatalogoProducto";
            lblCatalogoProducto.Size = new Size(363, 45);
            lblCatalogoProducto.TabIndex = 0;
            lblCatalogoProducto.Text = "Catalogo de Productos";
            lblCatalogoProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblCatalogoProducto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 64);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(61, 23);
            textBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(2, 192);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 30;
            label1.Text = "Precio Venta";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 32;
            // 
            // lblCategoriaDato
            // 
            lblCategoriaDato.AutoSize = true;
            lblCategoriaDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriaDato.ForeColor = SystemColors.WindowText;
            lblCategoriaDato.Location = new Point(3, 77);
            lblCategoriaDato.Name = "lblCategoriaDato";
            lblCategoriaDato.Size = new Size(67, 17);
            lblCategoriaDato.TabIndex = 33;
            lblCategoriaDato.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(0, 250);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 35;
            label2.Text = "Descripcion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 244);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 75);
            textBox3.TabIndex = 34;
            // 
            // FrmGestionarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmGestionarProducto";
            Text = "FrmRegistrarProducto";
            panel2.ResumeLayout(false);
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnAlta;
        private FontAwesome.Sharp.IconButton iconBtnHistorial;
        private FontAwesome.Sharp.IconButton iconBtnElim;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private Panel panelDatosUsuario;
        private Label lblStock;
        private TextBox txtIdGuardado;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private Label lblMarcaDato;
        private TextBox txtEmailDato;
        private Label lblTelefDato;
        private TextBox txtTelefDato;
        private Label lblIdDato;
        private TextBox txtDniDato;
        private TextBox txtApeDato;
        private Label lblPrecioCompraDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatosUsuario;
        private DataGridView dataGridUsuarios;
        private Label lblCatalogoProducto;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lblCategoriaDato;
    }
}