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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            iconBtnExcel = new FontAwesome.Sharp.IconButton();
            iconBtnMarca = new FontAwesome.Sharp.IconButton();
            panelDatosProducto = new Panel();
            txtIdProducto = new TextBox();
            picImgEditarProducts = new PictureBox();
            label3 = new Label();
            comboMarcaDato = new ComboBox();
            comboCategDato = new ComboBox();
            txtStockDato = new TextBox();
            txtDescripcionDato = new TextBox();
            lblCategoriaDato = new Label();
            txtPrecioVenta = new TextBox();
            label1 = new Label();
            lblStock = new Label();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblEstadoDato = new Label();
            lblMarcaDato = new Label();
            txtNombreDato = new TextBox();
            txtPrecioCompraDato = new TextBox();
            lblNombreDato = new Label();
            lblDatosUsuario = new Label();
            lblPrecioCompraDato = new Label();
            label2 = new Label();
            iconBtnDarAlta = new FontAwesome.Sharp.IconButton();
            iconBtnCategorias = new FontAwesome.Sharp.IconButton();
            dataGridProducto = new DataGridView();
            Col_IDproducto = new DataGridViewTextBoxColumn();
            Col_CodBarra = new DataGridViewTextBoxColumn();
            Col_nombre_produc = new DataGridViewTextBoxColumn();
            Col_Descrip_producto = new DataGridViewTextBoxColumn();
            Col_precio_compra = new DataGridViewTextBoxColumn();
            Col_precio_venta = new DataGridViewTextBoxColumn();
            Col_stock_produc = new DataGridViewTextBoxColumn();
            Col_img_producto = new DataGridViewTextBoxColumn();
            Col_nom_marca = new DataGridViewTextBoxColumn();
            Col_nom_categ = new DataGridViewTextBoxColumn();
            Col_estado_produc = new DataGridViewTextBoxColumn();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            iconBtnDarBaja = new FontAwesome.Sharp.IconButton();
            lblCatalogoProducto = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panelDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImgEditarProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProducto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(iconBtnExcel);
            panel2.Controls.Add(iconBtnMarca);
            panel2.Controls.Add(panelDatosProducto);
            panel2.Controls.Add(iconBtnDarAlta);
            panel2.Controls.Add(iconBtnCategorias);
            panel2.Controls.Add(dataGridProducto);
            panel2.Controls.Add(iconBtnAgregar);
            panel2.Controls.Add(iconBtnDarBaja);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 501);
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
            iconBtnExcel.Location = new Point(12, 465);
            iconBtnExcel.Name = "iconBtnExcel";
            iconBtnExcel.Size = new Size(126, 27);
            iconBtnExcel.TabIndex = 19;
            iconBtnExcel.Text = "Descargar Excel";
            iconBtnExcel.TextAlign = ContentAlignment.MiddleRight;
            iconBtnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnExcel.UseVisualStyleBackColor = false;
            iconBtnExcel.Click += iconBtnExcel_Click;
            // 
            // iconBtnMarca
            // 
            iconBtnMarca.BackColor = Color.FromArgb(0, 84, 251);
            iconBtnMarca.BackgroundImage = (Image)resources.GetObject("iconBtnMarca.BackgroundImage");
            iconBtnMarca.BackgroundImageLayout = ImageLayout.None;
            iconBtnMarca.Cursor = Cursors.Hand;
            iconBtnMarca.FlatAppearance.BorderColor = Color.Black;
            iconBtnMarca.FlatStyle = FlatStyle.Flat;
            iconBtnMarca.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnMarca.ForeColor = SystemColors.ControlLightLight;
            iconBtnMarca.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnMarca.IconColor = Color.White;
            iconBtnMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnMarca.IconSize = 30;
            iconBtnMarca.Location = new Point(478, 24);
            iconBtnMarca.Name = "iconBtnMarca";
            iconBtnMarca.Size = new Size(91, 39);
            iconBtnMarca.TabIndex = 18;
            iconBtnMarca.Text = "Marca";
            iconBtnMarca.TextAlign = ContentAlignment.MiddleRight;
            iconBtnMarca.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnMarca.UseVisualStyleBackColor = false;
            iconBtnMarca.Click += iconBtnMarca_Click;
            // 
            // panelDatosProducto
            // 
            panelDatosProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosProducto.BackColor = Color.White;
            panelDatosProducto.Controls.Add(txtIdProducto);
            panelDatosProducto.Controls.Add(picImgEditarProducts);
            panelDatosProducto.Controls.Add(label3);
            panelDatosProducto.Controls.Add(comboMarcaDato);
            panelDatosProducto.Controls.Add(comboCategDato);
            panelDatosProducto.Controls.Add(txtStockDato);
            panelDatosProducto.Controls.Add(txtDescripcionDato);
            panelDatosProducto.Controls.Add(lblCategoriaDato);
            panelDatosProducto.Controls.Add(txtPrecioVenta);
            panelDatosProducto.Controls.Add(label1);
            panelDatosProducto.Controls.Add(lblStock);
            panelDatosProducto.Controls.Add(iconbtnGuardar);
            panelDatosProducto.Controls.Add(iconBtnCancelar);
            panelDatosProducto.Controls.Add(iconBtnModif);
            panelDatosProducto.Controls.Add(comboEstadoDato);
            panelDatosProducto.Controls.Add(lblEstadoDato);
            panelDatosProducto.Controls.Add(lblMarcaDato);
            panelDatosProducto.Controls.Add(txtNombreDato);
            panelDatosProducto.Controls.Add(txtPrecioCompraDato);
            panelDatosProducto.Controls.Add(lblNombreDato);
            panelDatosProducto.Controls.Add(lblDatosUsuario);
            panelDatosProducto.Controls.Add(lblPrecioCompraDato);
            panelDatosProducto.Controls.Add(label2);
            panelDatosProducto.Location = new Point(588, 3);
            panelDatosProducto.Name = "panelDatosProducto";
            panelDatosProducto.Size = new Size(234, 498);
            panelDatosProducto.TabIndex = 13;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(9, 3);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(17, 23);
            txtIdProducto.TabIndex = 81;
            txtIdProducto.Visible = false;
            // 
            // picImgEditarProducts
            // 
            picImgEditarProducts.Location = new Point(79, 302);
            picImgEditarProducts.Name = "picImgEditarProducts";
            picImgEditarProducts.Size = new Size(100, 103);
            picImgEditarProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            picImgEditarProducts.TabIndex = 80;
            picImgEditarProducts.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(2, 309);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 39;
            label3.Text = "Imagen";
            // 
            // comboMarcaDato
            // 
            comboMarcaDato.FlatStyle = FlatStyle.Popup;
            comboMarcaDato.FormattingEnabled = true;
            comboMarcaDato.Location = new Point(79, 56);
            comboMarcaDato.Name = "comboMarcaDato";
            comboMarcaDato.Size = new Size(144, 23);
            comboMarcaDato.TabIndex = 38;
            comboMarcaDato.Text = "Seleccione Marca";
            // 
            // comboCategDato
            // 
            comboCategDato.FlatStyle = FlatStyle.Popup;
            comboCategDato.FormattingEnabled = true;
            comboCategDato.Location = new Point(79, 32);
            comboCategDato.Name = "comboCategDato";
            comboCategDato.Size = new Size(144, 23);
            comboCategDato.TabIndex = 37;
            comboCategDato.Text = "Seleccione Categoria";
            // 
            // txtStockDato
            // 
            txtStockDato.Location = new Point(117, 114);
            txtStockDato.Name = "txtStockDato";
            txtStockDato.Size = new Size(61, 23);
            txtStockDato.TabIndex = 36;
            // 
            // txtDescripcionDato
            // 
            txtDescripcionDato.Location = new Point(79, 143);
            txtDescripcionDato.Multiline = true;
            txtDescripcionDato.Name = "txtDescripcionDato";
            txtDescripcionDato.Size = new Size(144, 75);
            txtDescripcionDato.TabIndex = 34;
            // 
            // lblCategoriaDato
            // 
            lblCategoriaDato.AutoSize = true;
            lblCategoriaDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriaDato.ForeColor = SystemColors.WindowText;
            lblCategoriaDato.Location = new Point(3, 33);
            lblCategoriaDato.Name = "lblCategoriaDato";
            lblCategoriaDato.Size = new Size(67, 17);
            lblCategoriaDato.TabIndex = 33;
            lblCategoriaDato.Text = "Categoria";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(150, 244);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(61, 23);
            txtPrecioVenta.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(140, 225);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 30;
            label1.Text = "Precio Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = SystemColors.WindowText;
            lblStock.Location = new Point(5, 115);
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
            iconbtnGuardar.Location = new Point(24, 411);
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
            iconBtnCancelar.Location = new Point(24, 456);
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
            iconBtnModif.Location = new Point(24, 411);
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
            comboEstadoDato.Location = new Point(79, 273);
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
            lblEstadoDato.Location = new Point(5, 273);
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
            lblMarcaDato.Location = new Point(3, 62);
            lblMarcaDato.Name = "lblMarcaDato";
            lblMarcaDato.Size = new Size(45, 17);
            lblMarcaDato.TabIndex = 17;
            lblMarcaDato.Text = "Marca";
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 83);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 16;
            // 
            // txtPrecioCompraDato
            // 
            txtPrecioCompraDato.Location = new Point(46, 244);
            txtPrecioCompraDato.Name = "txtPrecioCompraDato";
            txtPrecioCompraDato.Size = new Size(61, 23);
            txtPrecioCompraDato.TabIndex = 9;
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(3, 89);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(58, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Nombre";
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(32, 0);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(194, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos Del Producto";
            // 
            // lblPrecioCompraDato
            // 
            lblPrecioCompraDato.AutoSize = true;
            lblPrecioCompraDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioCompraDato.ForeColor = SystemColors.WindowText;
            lblPrecioCompraDato.Location = new Point(25, 225);
            lblPrecioCompraDato.Name = "lblPrecioCompraDato";
            lblPrecioCompraDato.Size = new Size(98, 17);
            lblPrecioCompraDato.TabIndex = 8;
            lblPrecioCompraDato.Text = "Precio Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(0, 149);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 35;
            label2.Text = "Descripcion";
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
            iconBtnDarAlta.Location = new Point(205, 24);
            iconBtnDarAlta.Name = "iconBtnDarAlta";
            iconBtnDarAlta.Size = new Size(89, 38);
            iconBtnDarAlta.TabIndex = 17;
            iconBtnDarAlta.Text = "Dar Alta";
            iconBtnDarAlta.TextAlign = ContentAlignment.MiddleRight;
            iconBtnDarAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDarAlta.UseVisualStyleBackColor = false;
            iconBtnDarAlta.Click += iconBtnDarAlta_Click;
            // 
            // iconBtnCategorias
            // 
            iconBtnCategorias.BackColor = Color.FromArgb(216, 103, 30);
            iconBtnCategorias.BackgroundImage = (Image)resources.GetObject("iconBtnCategorias.BackgroundImage");
            iconBtnCategorias.BackgroundImageLayout = ImageLayout.None;
            iconBtnCategorias.Cursor = Cursors.Hand;
            iconBtnCategorias.FlatAppearance.BorderColor = Color.Black;
            iconBtnCategorias.FlatStyle = FlatStyle.Flat;
            iconBtnCategorias.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCategorias.ForeColor = SystemColors.ControlLightLight;
            iconBtnCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCategorias.IconColor = Color.White;
            iconBtnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCategorias.IconSize = 30;
            iconBtnCategorias.Location = new Point(334, 24);
            iconBtnCategorias.Name = "iconBtnCategorias";
            iconBtnCategorias.Size = new Size(103, 39);
            iconBtnCategorias.TabIndex = 16;
            iconBtnCategorias.Text = "Categorias";
            iconBtnCategorias.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCategorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCategorias.UseVisualStyleBackColor = false;
            iconBtnCategorias.Click += iconBtnCategorias_Click;
            // 
            // dataGridProducto
            // 
            dataGridProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridProducto.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridProducto.BorderStyle = BorderStyle.None;
            dataGridProducto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducto.Columns.AddRange(new DataGridViewColumn[] { Col_IDproducto, Col_CodBarra, Col_nombre_produc, Col_Descrip_producto, Col_precio_compra, Col_precio_venta, Col_stock_produc, Col_img_producto, Col_nom_marca, Col_nom_categ, Col_estado_produc });
            dataGridProducto.Location = new Point(12, 85);
            dataGridProducto.MultiSelect = false;
            dataGridProducto.Name = "dataGridProducto";
            dataGridProducto.ReadOnly = true;
            dataGridProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridProducto.RowHeadersVisible = false;
            dataGridProducto.RowTemplate.Height = 28;
            dataGridProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProducto.Size = new Size(795, 368);
            dataGridProducto.TabIndex = 12;
            dataGridProducto.CellContentClick += dataGridProducto_CellContentClick;
            // 
            // Col_IDproducto
            // 
            Col_IDproducto.HeaderText = "ID Producto";
            Col_IDproducto.Name = "Col_IDproducto";
            Col_IDproducto.ReadOnly = true;
            Col_IDproducto.Width = 96;
            // 
            // Col_CodBarra
            // 
            Col_CodBarra.HeaderText = "Cod Barra";
            Col_CodBarra.Name = "Col_CodBarra";
            Col_CodBarra.ReadOnly = true;
            Col_CodBarra.Width = 88;
            // 
            // Col_nombre_produc
            // 
            Col_nombre_produc.HeaderText = "Nombre Producto";
            Col_nombre_produc.Name = "Col_nombre_produc";
            Col_nombre_produc.ReadOnly = true;
            Col_nombre_produc.Width = 128;
            // 
            // Col_Descrip_producto
            // 
            Col_Descrip_producto.HeaderText = "Descripcion Producto";
            Col_Descrip_producto.Name = "Col_Descrip_producto";
            Col_Descrip_producto.ReadOnly = true;
            Col_Descrip_producto.Width = 148;
            // 
            // Col_precio_compra
            // 
            Col_precio_compra.HeaderText = "Precio Compra";
            Col_precio_compra.Name = "Col_precio_compra";
            Col_precio_compra.ReadOnly = true;
            Col_precio_compra.Width = 115;
            // 
            // Col_precio_venta
            // 
            Col_precio_venta.HeaderText = "Precio Venta";
            Col_precio_venta.Name = "Col_precio_venta";
            Col_precio_venta.ReadOnly = true;
            Col_precio_venta.Width = 102;
            // 
            // Col_stock_produc
            // 
            Col_stock_produc.HeaderText = "Stock";
            Col_stock_produc.Name = "Col_stock_produc";
            Col_stock_produc.ReadOnly = true;
            Col_stock_produc.Width = 68;
            // 
            // Col_img_producto
            // 
            Col_img_producto.HeaderText = "Imagen";
            Col_img_producto.Name = "Col_img_producto";
            Col_img_producto.ReadOnly = true;
            Col_img_producto.Width = 82;
            // 
            // Col_nom_marca
            // 
            Col_nom_marca.HeaderText = "Marca";
            Col_nom_marca.Name = "Col_nom_marca";
            Col_nom_marca.ReadOnly = true;
            Col_nom_marca.Width = 75;
            // 
            // Col_nom_categ
            // 
            Col_nom_categ.HeaderText = "Categoria";
            Col_nom_categ.Name = "Col_nom_categ";
            Col_nom_categ.ReadOnly = true;
            Col_nom_categ.Width = 95;
            // 
            // Col_estado_produc
            // 
            Col_estado_produc.HeaderText = "Estado ";
            Col_estado_produc.Name = "Col_estado_produc";
            Col_estado_produc.ReadOnly = true;
            Col_estado_produc.Width = 77;
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
            iconBtnAgregar.Location = new Point(73, 24);
            iconBtnAgregar.Name = "iconBtnAgregar";
            iconBtnAgregar.Size = new Size(89, 39);
            iconBtnAgregar.TabIndex = 14;
            iconBtnAgregar.Text = "Agregar";
            iconBtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAgregar.UseVisualStyleBackColor = false;
            iconBtnAgregar.Click += iconBtnAgregar_Click;
            // 
            // iconBtnDarBaja
            // 
            iconBtnDarBaja.BackColor = Color.FromArgb(250, 21, 21);
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
            iconBtnDarBaja.Location = new Point(205, 24);
            iconBtnDarBaja.Name = "iconBtnDarBaja";
            iconBtnDarBaja.Size = new Size(97, 38);
            iconBtnDarBaja.TabIndex = 15;
            iconBtnDarBaja.Text = "Dar Baja";
            iconBtnDarBaja.TextAlign = ContentAlignment.MiddleRight;
            iconBtnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDarBaja.UseVisualStyleBackColor = false;
            iconBtnDarBaja.Click += iconBtnDarBaja_Click;
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
            // FrmGestionarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmGestionarProducto";
            Text = "FrmRegistrarProducto";
            Load += FrmGestionarProducto_Load;
            panel2.ResumeLayout(false);
            panelDatosProducto.ResumeLayout(false);
            panelDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImgEditarProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnDarAlta;
        private FontAwesome.Sharp.IconButton iconBtnCategorias;
        private FontAwesome.Sharp.IconButton iconBtnDarBaja;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private Panel panelDatosProducto;
        private Label lblStock;
        //private TextBox txtIdGuardado;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private Label lblMarcaDato;
        private TextBox txtPrecioCompraDato;
        private Label lblPrecioCompraDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatosUsuario;
        private DataGridView dataGridProducto;
        private Label lblCatalogoProducto;
        private Panel panel1;
        private TextBox txtPrecioVenta;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcionDato;
        private Label lblCategoriaDato;
        private FontAwesome.Sharp.IconButton iconBtnMarca;
        private TextBox txtStockDato;
        private ComboBox comboMarcaDato;
        private ComboBox comboCategDato;
        private PictureBox picImgEditarProducts;
        private Label label3;
        private TextBox txtIdProducto;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private DataGridViewTextBoxColumn Col_IDproducto;
        private DataGridViewTextBoxColumn Col_CodBarra;
        private DataGridViewTextBoxColumn Col_nombre_produc;
        private DataGridViewTextBoxColumn Col_Descrip_producto;
        private DataGridViewTextBoxColumn Col_precio_compra;
        private DataGridViewTextBoxColumn Col_precio_venta;
        private DataGridViewTextBoxColumn Col_stock_produc;
        private DataGridViewTextBoxColumn Col_img_producto;
        private DataGridViewTextBoxColumn Col_nom_marca;
        private DataGridViewTextBoxColumn Col_nom_categ;
        private DataGridViewTextBoxColumn Col_estado_produc;
    }
}