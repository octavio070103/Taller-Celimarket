﻿namespace CapaPresentacion.Formularios.Admin.Producto
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
            lblRegistrarUsuario = new Label();
            panelProductos = new Panel();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            lblDescripcion = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            txtMarca = new TextBox();
            txtPrecioVenta = new TextBox();
            lblMarca = new Label();
            lblPrecioVenta = new Label();
            txtPrecioCompra = new TextBox();
            lblPrecioCompra = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panel2 = new Panel();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            picCerrar = new PictureBox();
            picRestaurar = new PictureBox();
            picMinimizar = new PictureBox();
            picMaxPantalla = new PictureBox();
            panel1.SuspendLayout();
            panelProductos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
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
            panelProductos.Controls.Add(label2);
            panelProductos.Controls.Add(comboBox2);
            panelProductos.Controls.Add(label1);
            panelProductos.Controls.Add(comboBox1);
            panelProductos.Controls.Add(lblDescripcion);
            panelProductos.Controls.Add(lblStock);
            panelProductos.Controls.Add(txtStock);
            panelProductos.Controls.Add(txtDescripcion);
            panelProductos.Controls.Add(txtMarca);
            panelProductos.Controls.Add(txtPrecioVenta);
            panelProductos.Controls.Add(lblMarca);
            panelProductos.Controls.Add(lblPrecioVenta);
            panelProductos.Controls.Add(txtPrecioCompra);
            panelProductos.Controls.Add(lblPrecioCompra);
            panelProductos.Controls.Add(txtNombre);
            panelProductos.Controls.Add(lblNombre);
            panelProductos.Controls.Add(panel2);
            panelProductos.Dock = DockStyle.Fill;
            panelProductos.Location = new Point(0, 61);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(512, 389);
            panelProductos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 17);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 95;
            label2.Text = "Proveedor";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 23);
            comboBox2.TabIndex = 94;
            comboBox2.Text = "Seleccione un Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 93;
            label1.Text = "Categoria";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(276, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 92;
            comboBox1.Text = "Seleccione una Categoria";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(276, 87);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 19);
            lblDescripcion.TabIndex = 89;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(276, 220);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(50, 19);
            lblStock.TabIndex = 88;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Location = new Point(276, 242);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(213, 23);
            txtStock.TabIndex = 87;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Location = new Point(276, 109);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(213, 23);
            txtDescripcion.TabIndex = 86;
            // 
            // txtMarca
            // 
            txtMarca.Cursor = Cursors.IBeam;
            txtMarca.Location = new Point(24, 242);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(213, 23);
            txtMarca.TabIndex = 85;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Cursor = Cursors.IBeam;
            txtPrecioVenta.Location = new Point(24, 177);
            txtPrecioVenta.Multiline = true;
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(213, 23);
            txtPrecioVenta.TabIndex = 84;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarca.Location = new Point(23, 220);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(60, 19);
            lblMarca.TabIndex = 83;
            lblMarca.Text = "Marca";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(24, 155);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(105, 19);
            lblPrecioVenta.TabIndex = 82;
            lblPrecioVenta.Text = "Precio venta";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Cursor = Cursors.IBeam;
            txtPrecioCompra.Location = new Point(273, 177);
            txtPrecioCompra.Multiline = true;
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(213, 23);
            txtPrecioCompra.TabIndex = 81;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioCompra.Location = new Point(273, 155);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(124, 19);
            lblPrecioCompra.TabIndex = 80;
            lblPrecioCompra.Text = "Precio compra";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(24, 109);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 79;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(24, 87);
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
            panel2.Location = new Point(0, 328);
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
            // FrmRegistrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(panelProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
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
        private TextBox txtMarca;
        private TextBox txtPrecioVenta;
        private Label lblMarca;
        private Label lblPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label lblPrecioCompra;
        private TextBox txtNombre;
        private Label lblNombre;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private PictureBox picCerrar;
        private PictureBox picRestaurar;
        private PictureBox picMinimizar;
        private PictureBox picMaxPantalla;
    }
}