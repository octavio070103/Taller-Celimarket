namespace CapaPresentacion.Formularios.Admin.Producto
{
    partial class FrmRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarProducto));
            panel1 = new Panel();
            picMaxPantalla = new PictureBox();
            picCerrar = new PictureBox();
            picRestaurar = new PictureBox();
            picMinimizar = new PictureBox();
            lblRegistrarUsuario = new Label();
            panelProductos = new Panel();
            lblprueba = new Label();
            label3 = new Label();
            picBoxIMGProducto = new PictureBox();
            txtCodBarra = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboBoxMarca = new ComboBox();
            label1 = new Label();
            comboBoxCateg = new ComboBox();
            lblDescripcion = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtPrecioCompra = new TextBox();
            lblPrecioCompra = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panel2 = new Panel();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxIMGProducto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 27);
            panel1.Controls.Add(picMaxPantalla);
            panel1.Controls.Add(picCerrar);
            panel1.Controls.Add(picRestaurar);
            panel1.Controls.Add(picMinimizar);
            panel1.Controls.Add(lblRegistrarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 61);
            panel1.TabIndex = 2;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(459, 3);
            picMaxPantalla.Margin = new Padding(4, 3, 4, 3);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(17, 17);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 24;
            picMaxPantalla.TabStop = false;
            picMaxPantalla.Click += picMaxPantalla_Click;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(484, 3);
            picCerrar.Margin = new Padding(4, 3, 4, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(17, 17);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 22;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(459, 3);
            picRestaurar.Margin = new Padding(4, 3, 4, 3);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(17, 17);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 21;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            picRestaurar.Click += picRestaurar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinimizar.Cursor = Cursors.Hand;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(436, 3);
            picMinimizar.Margin = new Padding(4, 3, 4, 3);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 17);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 23;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // lblRegistrarUsuario
            // 
            lblRegistrarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRegistrarUsuario.AutoSize = true;
            lblRegistrarUsuario.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrarUsuario.ForeColor = SystemColors.ControlLightLight;
            lblRegistrarUsuario.ImageAlign = ContentAlignment.TopCenter;
            lblRegistrarUsuario.Location = new Point(92, 13);
            lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            lblRegistrarUsuario.Size = new Size(305, 45);
            lblRegistrarUsuario.TabIndex = 0;
            lblRegistrarUsuario.Text = "Agregar Productos";
            lblRegistrarUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelProductos
            // 
            panelProductos.BackColor = Color.FromArgb(67, 68, 89);
            panelProductos.Controls.Add(lblprueba);
            panelProductos.Controls.Add(label3);
            panelProductos.Controls.Add(picBoxIMGProducto);
            panelProductos.Controls.Add(txtCodBarra);
            panelProductos.Controls.Add(label4);
            panelProductos.Controls.Add(label2);
            panelProductos.Controls.Add(comboBoxMarca);
            panelProductos.Controls.Add(label1);
            panelProductos.Controls.Add(comboBoxCateg);
            panelProductos.Controls.Add(lblDescripcion);
            panelProductos.Controls.Add(lblStock);
            panelProductos.Controls.Add(txtStock);
            panelProductos.Controls.Add(txtDescripcion);
            panelProductos.Controls.Add(txtPrecioVenta);
            panelProductos.Controls.Add(lblPrecioVenta);
            panelProductos.Controls.Add(txtPrecioCompra);
            panelProductos.Controls.Add(lblPrecioCompra);
            panelProductos.Controls.Add(txtNombre);
            panelProductos.Controls.Add(lblNombre);
            panelProductos.Controls.Add(panel2);
            panelProductos.Dock = DockStyle.Fill;
            panelProductos.Location = new Point(0, 61);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(512, 417);
            panelProductos.TabIndex = 3;
            // 
            // lblprueba
            // 
            lblprueba.AutoSize = true;
            lblprueba.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblprueba.Location = new Point(363, 333);
            lblprueba.Name = "lblprueba";
            lblprueba.Size = new Size(43, 19);
            lblprueba.TabIndex = 100;
            lblprueba.Text = "Ruta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(344, 169);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 99;
            label3.Text = "Imagen";
            // 
            // picBoxIMGProducto
            // 
            picBoxIMGProducto.BackgroundImage = (Image)resources.GetObject("picBoxIMGProducto.BackgroundImage");
            picBoxIMGProducto.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxIMGProducto.BorderStyle = BorderStyle.Fixed3D;
            picBoxIMGProducto.InitialImage = null;
            picBoxIMGProducto.Location = new Point(326, 198);
            picBoxIMGProducto.Name = "picBoxIMGProducto";
            picBoxIMGProducto.Size = new Size(125, 127);
            picBoxIMGProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxIMGProducto.TabIndex = 98;
            picBoxIMGProducto.TabStop = false;
            picBoxIMGProducto.Click += picBoxIMGProducto_Click;
            // 
            // txtCodBarra
            // 
            txtCodBarra.Cursor = Cursors.IBeam;
            txtCodBarra.Location = new Point(17, 83);
            txtCodBarra.Multiline = true;
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Size = new Size(213, 23);
            txtCodBarra.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 61);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 96;
            label4.Text = "Codigo Barra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(272, 6);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 95;
            label2.Text = "Marca";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(272, 28);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(210, 23);
            comboBoxMarca.TabIndex = 94;
            comboBoxMarca.Text = "Seleccione una Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 93;
            label1.Text = "Categoria";
            // 
            // comboBoxCateg
            // 
            comboBoxCateg.FormattingEnabled = true;
            comboBoxCateg.Location = new Point(17, 28);
            comboBoxCateg.Name = "comboBoxCateg";
            comboBoxCateg.Size = new Size(210, 23);
            comboBoxCateg.TabIndex = 92;
            comboBoxCateg.Text = "Seleccione una Categoria";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(17, 208);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 19);
            lblDescripcion.TabIndex = 89;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(17, 160);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(50, 19);
            lblStock.TabIndex = 88;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Location = new Point(17, 179);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(213, 23);
            txtStock.TabIndex = 87;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Location = new Point(17, 230);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(213, 122);
            txtDescripcion.TabIndex = 86;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Cursor = Cursors.IBeam;
            txtPrecioVenta.Location = new Point(273, 131);
            txtPrecioVenta.Multiline = true;
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(213, 23);
            txtPrecioVenta.TabIndex = 84;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(273, 109);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(105, 19);
            lblPrecioVenta.TabIndex = 82;
            lblPrecioVenta.Text = "Precio venta";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Cursor = Cursors.IBeam;
            txtPrecioCompra.Location = new Point(17, 131);
            txtPrecioCompra.Multiline = true;
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(213, 23);
            txtPrecioCompra.TabIndex = 81;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioCompra.Location = new Point(17, 109);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(124, 19);
            lblPrecioCompra.TabIndex = 80;
            lblPrecioCompra.Text = "Precio compra";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(272, 83);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 79;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(272, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 19);
            lblNombre.TabIndex = 78;
            lblNombre.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 17, 27);
            panel2.Controls.Add(iconbtnGuardar);
            panel2.Controls.Add(iconBtnCancelar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 61);
            panel2.TabIndex = 75;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(47, 33, 75);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 30;
            iconbtnGuardar.Location = new Point(266, 3);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(131, 33);
            iconbtnGuardar.TabIndex = 69;
            iconbtnGuardar.Text = "Guardar";
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
            iconBtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(96, 3);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(127, 33);
            iconBtnCancelar.TabIndex = 70;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmRegistrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 478);
            Controls.Add(panelProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += FrmRegistrarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxIMGProducto).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblRegistrarUsuario;
        private Panel panelProductos;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private Label lblDescripcion;
        private Label lblStock;
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label lblPrecioCompra;
        private TextBox txtNombre;
        private Label lblNombre;
        private ComboBox comboBoxCateg;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxMarca;
        private PictureBox picCerrar;
        private PictureBox picRestaurar;
        private PictureBox picMinimizar;
        private PictureBox picMaxPantalla;
        private TextBox txtCodBarra;
        private Label label4;
        private Label label3;
        private PictureBox picBoxIMGProducto;
        private Label lblprueba;
    }
}