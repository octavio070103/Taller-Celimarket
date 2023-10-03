namespace CapaPresentacion.Formularios.Vendedor
{
    partial class frmModuloVenta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlModuloVenta = new Panel();
            cboFiltroClientes = new ComboBox();
            pnlCarrito = new Panel();
            lblModificarMetodo = new Label();
            lblModificarCliente = new Label();
            lblMetodoCarrito = new Label();
            lblClienteCarrito = new Label();
            pnlTotal = new Panel();
            lblCalculoTotal = new Label();
            lblTotal = new Label();
            pnlEncabezado = new Panel();
            lblCarrito = new Label();
            btnPagar = new Button();
            dtgvListaCompra = new DataGridView();
            nombre_producto_carrito = new DataGridViewTextBoxColumn();
            cantidad_producto_carrito = new DataGridViewTextBoxColumn();
            precio_producto_carrito = new DataGridViewTextBoxColumn();
            categoria_producto_carrito = new DataGridViewTextBoxColumn();
            subtotal_producto_carrito = new DataGridViewTextBoxColumn();
            pnlListaProductos = new Panel();
            panel1 = new Panel();
            txtIdCliente = new TextBox();
            btnQuitarCarrito = new Button();
            txtCantidad = new TextBox();
            picFotoProducto = new PictureBox();
            lblDatos = new Label();
            txtPrecio = new TextBox();
            cboMetodoPago = new ComboBox();
            btnElegirCliente = new Button();
            txtCliente = new TextBox();
            txtCategoria = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtNombre = new TextBox();
            lblCliente = new Label();
            lblFecha = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblPago = new Label();
            lblNombre = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            lblListaProductos = new Label();
            dtgvProductos = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            nombre_producto = new DataGridViewTextBoxColumn();
            categoria_producto = new DataGridViewTextBoxColumn();
            precio_producto = new DataGridViewTextBoxColumn();
            stock_producto = new DataGridViewTextBoxColumn();
            lblBuscarClientes = new Label();
            txtBuscar = new TextBox();
            lblFiltro = new Label();
            pnlModuloVenta.SuspendLayout();
            pnlCarrito.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListaCompra).BeginInit();
            pnlListaProductos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).BeginInit();
            SuspendLayout();
            // 
            // pnlModuloVenta
            // 
            pnlModuloVenta.BackColor = Color.FromArgb(88, 89, 150);
            pnlModuloVenta.Controls.Add(cboFiltroClientes);
            pnlModuloVenta.Controls.Add(pnlCarrito);
            pnlModuloVenta.Controls.Add(pnlListaProductos);
            pnlModuloVenta.Controls.Add(lblBuscarClientes);
            pnlModuloVenta.Controls.Add(txtBuscar);
            pnlModuloVenta.Controls.Add(lblFiltro);
            pnlModuloVenta.Dock = DockStyle.Fill;
            pnlModuloVenta.Location = new Point(0, 0);
            pnlModuloVenta.Name = "pnlModuloVenta";
            pnlModuloVenta.Size = new Size(795, 571);
            pnlModuloVenta.TabIndex = 0;
            // 
            // cboFiltroClientes
            // 
            cboFiltroClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFiltroClientes.FormattingEnabled = true;
            cboFiltroClientes.Location = new Point(413, 41);
            cboFiltroClientes.Name = "cboFiltroClientes";
            cboFiltroClientes.Size = new Size(122, 23);
            cboFiltroClientes.TabIndex = 10;
            // 
            // pnlCarrito
            // 
            pnlCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlCarrito.BackColor = Color.White;
            pnlCarrito.Controls.Add(lblModificarMetodo);
            pnlCarrito.Controls.Add(lblModificarCliente);
            pnlCarrito.Controls.Add(lblMetodoCarrito);
            pnlCarrito.Controls.Add(lblClienteCarrito);
            pnlCarrito.Controls.Add(pnlTotal);
            pnlCarrito.Controls.Add(pnlEncabezado);
            pnlCarrito.Controls.Add(btnPagar);
            pnlCarrito.Controls.Add(dtgvListaCompra);
            pnlCarrito.Location = new Point(544, 39);
            pnlCarrito.Name = "pnlCarrito";
            pnlCarrito.Size = new Size(244, 508);
            pnlCarrito.TabIndex = 1;
            // 
            // lblModificarMetodo
            // 
            lblModificarMetodo.AutoSize = true;
            lblModificarMetodo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarMetodo.Location = new Point(132, 362);
            lblModificarMetodo.Name = "lblModificarMetodo";
            lblModificarMetodo.Size = new Size(18, 19);
            lblModificarMetodo.TabIndex = 20;
            lblModificarMetodo.Text = "...";
            // 
            // lblModificarCliente
            // 
            lblModificarCliente.AutoSize = true;
            lblModificarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarCliente.Location = new Point(67, 328);
            lblModificarCliente.Name = "lblModificarCliente";
            lblModificarCliente.Size = new Size(18, 19);
            lblModificarCliente.TabIndex = 19;
            lblModificarCliente.Text = "...";
            lblModificarCliente.Click += lblModificarCliente_Click;
            // 
            // lblMetodoCarrito
            // 
            lblMetodoCarrito.AutoSize = true;
            lblMetodoCarrito.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodoCarrito.Location = new Point(16, 362);
            lblMetodoCarrito.Name = "lblMetodoCarrito";
            lblMetodoCarrito.Size = new Size(119, 19);
            lblMetodoCarrito.TabIndex = 18;
            lblMetodoCarrito.Text = "Metodo de pago: ";
            // 
            // lblClienteCarrito
            // 
            lblClienteCarrito.AutoSize = true;
            lblClienteCarrito.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteCarrito.Location = new Point(16, 328);
            lblClienteCarrito.Name = "lblClienteCarrito";
            lblClienteCarrito.Size = new Size(54, 19);
            lblClienteCarrito.TabIndex = 17;
            lblClienteCarrito.Text = "Cliente:";
            // 
            // pnlTotal
            // 
            pnlTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblCalculoTotal);
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Location = new Point(16, 412);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(215, 25);
            pnlTotal.TabIndex = 16;
            // 
            // lblCalculoTotal
            // 
            lblCalculoTotal.AutoSize = true;
            lblCalculoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalculoTotal.Location = new Point(148, 0);
            lblCalculoTotal.Name = "lblCalculoTotal";
            lblCalculoTotal.Size = new Size(28, 21);
            lblCalculoTotal.TabIndex = 16;
            lblCalculoTotal.Text = "$0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 21);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "TOTAL:";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.Orange;
            pnlEncabezado.Controls.Add(lblCarrito);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(244, 43);
            pnlEncabezado.TabIndex = 14;
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.BackColor = Color.Orange;
            lblCarrito.FlatStyle = FlatStyle.Flat;
            lblCarrito.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarrito.ForeColor = Color.GhostWhite;
            lblCarrito.Location = new Point(39, 12);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(174, 25);
            lblCarrito.TabIndex = 0;
            lblCarrito.Text = "Carrito de compra";
            lblCarrito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPagar.BackColor = Color.Lime;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.FloralWhite;
            btnPagar.Location = new Point(16, 454);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(215, 44);
            btnPagar.TabIndex = 13;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // dtgvListaCompra
            // 
            dtgvListaCompra.AllowUserToAddRows = false;
            dtgvListaCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgvListaCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvListaCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgvListaCompra.BackgroundColor = SystemColors.ButtonShadow;
            dtgvListaCompra.BorderStyle = BorderStyle.None;
            dtgvListaCompra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvListaCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvListaCompra.ColumnHeadersHeight = 30;
            dtgvListaCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvListaCompra.Columns.AddRange(new DataGridViewColumn[] { nombre_producto_carrito, cantidad_producto_carrito, precio_producto_carrito, categoria_producto_carrito, subtotal_producto_carrito });
            dtgvListaCompra.EnableHeadersVisualStyles = false;
            dtgvListaCompra.Location = new Point(0, 40);
            dtgvListaCompra.Name = "dtgvListaCompra";
            dtgvListaCompra.ReadOnly = true;
            dtgvListaCompra.RowTemplate.Height = 25;
            dtgvListaCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListaCompra.Size = new Size(243, 261);
            dtgvListaCompra.TabIndex = 13;
            dtgvListaCompra.CellContentClick += dtgvListaCompra_CellContentClick;
            dtgvListaCompra.SelectionChanged += dtgvListaCompra_SelectionChanged;
            // 
            // nombre_producto_carrito
            // 
            nombre_producto_carrito.HeaderText = "Nombre";
            nombre_producto_carrito.Name = "nombre_producto_carrito";
            nombre_producto_carrito.ReadOnly = true;
            // 
            // cantidad_producto_carrito
            // 
            cantidad_producto_carrito.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cantidad_producto_carrito.HeaderText = "Cant.";
            cantidad_producto_carrito.Name = "cantidad_producto_carrito";
            cantidad_producto_carrito.ReadOnly = true;
            cantidad_producto_carrito.Width = 65;
            // 
            // precio_producto_carrito
            // 
            precio_producto_carrito.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            precio_producto_carrito.HeaderText = "Precio U.";
            precio_producto_carrito.Name = "precio_producto_carrito";
            precio_producto_carrito.ReadOnly = true;
            precio_producto_carrito.Width = 87;
            // 
            // categoria_producto_carrito
            // 
            categoria_producto_carrito.HeaderText = "Categoria";
            categoria_producto_carrito.Name = "categoria_producto_carrito";
            categoria_producto_carrito.ReadOnly = true;
            // 
            // subtotal_producto_carrito
            // 
            subtotal_producto_carrito.HeaderText = "Subtotal";
            subtotal_producto_carrito.Name = "subtotal_producto_carrito";
            subtotal_producto_carrito.ReadOnly = true;
            // 
            // pnlListaProductos
            // 
            pnlListaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListaProductos.BackColor = Color.White;
            pnlListaProductos.Controls.Add(panel1);
            pnlListaProductos.Controls.Add(lblListaProductos);
            pnlListaProductos.Controls.Add(dtgvProductos);
            pnlListaProductos.Location = new Point(12, 79);
            pnlListaProductos.Name = "pnlListaProductos";
            pnlListaProductos.Size = new Size(526, 468);
            pnlListaProductos.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtIdCliente);
            panel1.Controls.Add(btnQuitarCarrito);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(picFotoProducto);
            panel1.Controls.Add(lblDatos);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(cboMetodoPago);
            panel1.Controls.Add(btnElegirCliente);
            panel1.Controls.Add(txtCliente);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblCantidad);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblPago);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnModificar);
            panel1.Location = new Point(10, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 278);
            panel1.TabIndex = 30;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Anchor = AnchorStyles.None;
            txtIdCliente.Location = new Point(63, 179);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(43, 23);
            txtIdCliente.TabIndex = 31;
            txtIdCliente.KeyPress += desactivarModificacion_KeyPress;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Anchor = AnchorStyles.None;
            btnQuitarCarrito.BackColor = Color.Red;
            btnQuitarCarrito.Enabled = false;
            btnQuitarCarrito.FlatStyle = FlatStyle.Flat;
            btnQuitarCarrito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuitarCarrito.ForeColor = SystemColors.ControlLightLight;
            btnQuitarCarrito.Location = new Point(270, 232);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(96, 37);
            btnQuitarCarrito.TabIndex = 30;
            btnQuitarCarrito.Text = "QUITAR";
            btnQuitarCarrito.UseVisualStyleBackColor = false;
            btnQuitarCarrito.Click += btnQuitarCarrito_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.Location = new Point(321, 140);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 29;
            txtCantidad.KeyPress += soloNumeros_KeyPress;
            // 
            // picFotoProducto
            // 
            picFotoProducto.Anchor = AnchorStyles.None;
            picFotoProducto.BackColor = Color.Black;
            picFotoProducto.Location = new Point(411, 52);
            picFotoProducto.Name = "picFotoProducto";
            picFotoProducto.Size = new Size(94, 88);
            picFotoProducto.TabIndex = 21;
            picFotoProducto.TabStop = false;
            // 
            // lblDatos
            // 
            lblDatos.Anchor = AnchorStyles.None;
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDatos.Location = new Point(12, 10);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(160, 21);
            lblDatos.TabIndex = 27;
            lblDatos.Text = "Datos del producto:";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.None;
            txtPrecio.Location = new Point(353, 98);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(43, 23);
            txtPrecio.TabIndex = 28;
            txtPrecio.KeyPress += desactivarModificacion_KeyPress;
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.Anchor = AnchorStyles.None;
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Items.AddRange(new object[] { "Visa", "Mastercard" });
            cboMetodoPago.Location = new Point(107, 140);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(122, 23);
            cboMetodoPago.TabIndex = 26;
            cboMetodoPago.TextChanged += cboMetodoPago_TextChanged;
            // 
            // btnElegirCliente
            // 
            btnElegirCliente.Anchor = AnchorStyles.None;
            btnElegirCliente.Location = new Point(370, 179);
            btnElegirCliente.Name = "btnElegirCliente";
            btnElegirCliente.Size = new Size(26, 23);
            btnElegirCliente.TabIndex = 25;
            btnElegirCliente.Text = "...";
            btnElegirCliente.UseVisualStyleBackColor = true;
            btnElegirCliente.Click += btnElegirCliente_Click;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.None;
            txtCliente.Location = new Point(112, 179);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(252, 23);
            txtCliente.TabIndex = 24;
            txtCliente.TextChanged += txtCliente_TextChanged;
            txtCliente.KeyPress += desactivarModificacion_KeyPress;
            // 
            // txtCategoria
            // 
            txtCategoria.Anchor = AnchorStyles.None;
            txtCategoria.Location = new Point(83, 97);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(146, 23);
            txtCategoria.TabIndex = 23;
            txtCategoria.KeyPress += desactivarModificacion_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(299, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(97, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(83, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 11;
            txtNombre.KeyPress += desactivarModificacion_KeyPress;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.None;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(10, 179);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 19);
            lblCliente.TabIndex = 20;
            lblCliente.Text = "Cliente:";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(248, 52);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 19);
            lblFecha.TabIndex = 19;
            lblFecha.Text = "Fecha:";
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.None;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(248, 140);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(67, 19);
            lblCantidad.TabIndex = 18;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.None;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(247, 98);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 19);
            lblPrecio.TabIndex = 17;
            lblPrecio.Text = "Precio unitario:";
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.None;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(10, 98);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(71, 19);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoria:";
            // 
            // lblPago
            // 
            lblPago.Anchor = AnchorStyles.None;
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(10, 140);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(96, 19);
            lblPago.TabIndex = 15;
            lblPago.Text = "Metodo pago:";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(10, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.FromArgb(128, 128, 255);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(10, 232);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 37);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR AL CARRITO";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.OrangeRed;
            btnModificar.Enabled = false;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(168, 232);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 37);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblListaProductos
            // 
            lblListaProductos.Anchor = AnchorStyles.Top;
            lblListaProductos.AutoSize = true;
            lblListaProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaProductos.Location = new Point(188, 9);
            lblListaProductos.Name = "lblListaProductos";
            lblListaProductos.Size = new Size(176, 25);
            lblListaProductos.TabIndex = 13;
            lblListaProductos.Text = "Lista de productos";
            // 
            // dtgvProductos
            // 
            dtgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvProductos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvProductos.ColumnHeadersHeight = 30;
            dtgvProductos.Columns.AddRange(new DataGridViewColumn[] { id_producto, nombre_producto, categoria_producto, precio_producto, stock_producto });
            dtgvProductos.EnableHeadersVisualStyles = false;
            dtgvProductos.Location = new Point(0, 37);
            dtgvProductos.MultiSelect = false;
            dtgvProductos.Name = "dtgvProductos";
            dtgvProductos.RowTemplate.Height = 25;
            dtgvProductos.Size = new Size(526, 139);
            dtgvProductos.TabIndex = 0;
            dtgvProductos.CellContentClick += dtgvProductos_CellContentClick;
            dtgvProductos.SelectionChanged += dtgvProductos_SelectionChanged;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "ID";
            id_producto.Name = "id_producto";
            // 
            // nombre_producto
            // 
            nombre_producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre_producto.HeaderText = "Nombre";
            nombre_producto.Name = "nombre_producto";
            // 
            // categoria_producto
            // 
            categoria_producto.HeaderText = "Categoria";
            categoria_producto.Name = "categoria_producto";
            // 
            // precio_producto
            // 
            precio_producto.HeaderText = "Precio";
            precio_producto.Name = "precio_producto";
            // 
            // stock_producto
            // 
            stock_producto.HeaderText = "Stock";
            stock_producto.Name = "stock_producto";
            // 
            // lblBuscarClientes
            // 
            lblBuscarClientes.AutoSize = true;
            lblBuscarClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarClientes.ForeColor = SystemColors.HighlightText;
            lblBuscarClientes.Location = new Point(12, 39);
            lblBuscarClientes.Name = "lblBuscarClientes";
            lblBuscarClientes.Size = new Size(52, 20);
            lblBuscarClientes.TabIndex = 7;
            lblBuscarClientes.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(70, 41);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(192, 23);
            txtBuscar.TabIndex = 9;
            // 
            // lblFiltro
            // 
            lblFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltro.ForeColor = SystemColors.HighlightText;
            lblFiltro.Location = new Point(364, 39);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(43, 20);
            lblFiltro.TabIndex = 8;
            lblFiltro.Text = "Filtro";
            // 
            // frmModuloVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 571);
            Controls.Add(pnlModuloVenta);
            Name = "frmModuloVenta";
            Text = "Registrar venta";
            pnlModuloVenta.ResumeLayout(false);
            pnlModuloVenta.PerformLayout();
            pnlCarrito.ResumeLayout(false);
            pnlCarrito.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvListaCompra).EndInit();
            pnlListaProductos.ResumeLayout(false);
            pnlListaProductos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlModuloVenta;
        private Panel pnlCarrito;
        private Panel pnlListaProductos;
        private Label lblFiltro;
        private Label lblBuscarClientes;
        private TextBox txtBuscar;
        private ComboBox cboFiltroClientes;
        private DataGridView dtgvProductos;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnPagar;
        private Panel pnlEncabezado;
        private Label lblCarrito;
        private DataGridView dtgvListaCompra;
        private Panel pnlTotal;
        private Label lblTotal;
        private Label lblListaProductos;
        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblPago;
        private Label lblNombre;
        private PictureBox picFotoProducto;
        private Label lblCliente;
        private Label lblFecha;
        private Label lblCantidad;
        private TextBox txtNombre;
        private DateTimePicker dateTimePicker1;
        private Button btnElegirCliente;
        private TextBox txtCliente;
        private TextBox txtCategoria;
        private Label lblDatos;
        private ComboBox cboMetodoPago;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Panel panel1;
        private Button btnQuitarCarrito;
        private Label lblMetodoCarrito;
        private Label lblClienteCarrito;
        private Label lblModificarCliente;
        private Label lblModificarMetodo;
        private TextBox txtIdCliente;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn nombre_producto;
        private DataGridViewTextBoxColumn categoria_producto;
        private DataGridViewTextBoxColumn precio_producto;
        private DataGridViewTextBoxColumn stock_producto;
        private DataGridViewTextBoxColumn nombre_producto_carrito;
        private DataGridViewTextBoxColumn cantidad_producto_carrito;
        private DataGridViewTextBoxColumn precio_producto_carrito;
        private DataGridViewTextBoxColumn categoria_producto_carrito;
        private DataGridViewTextBoxColumn subtotal_producto_carrito;
        private Label lblCalculoTotal;
    }
}