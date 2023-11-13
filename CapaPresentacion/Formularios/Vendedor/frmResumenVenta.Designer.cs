namespace CapaPresentacion.Formularios.Vendedor
{
    partial class frmResumenVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenVenta));
            pnlResumen = new Panel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            lblTotalRes = new Label();
            lblTotal = new Label();
            lblMetodoPago = new Label();
            lblNombreCli = new Label();
            lblMetodoRes = new Label();
            lblClienteRes = new Label();
            lblResumen = new Label();
            dtgvResumen = new DataGridView();
            producto_resumen = new DataGridViewTextBoxColumn();
            cantidad_resumen = new DataGridViewTextBoxColumn();
            precio_resumen = new DataGridViewTextBoxColumn();
            categoria_resumen = new DataGridViewTextBoxColumn();
            subtotal_resumen = new DataGridViewTextBoxColumn();
            id_producto_resumen = new DataGridViewTextBoxColumn();
            pnlBarraClientes = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            picMaximizar = new PictureBox();
            picMinimizar = new PictureBox();
            picCerrarVentana = new PictureBox();
            picRestaurar = new PictureBox();
            picMaxPantalla = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResumen).BeginInit();
            pnlBarraClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.SteelBlue;
            pnlResumen.Controls.Add(btnCancelar);
            pnlResumen.Controls.Add(btnConfirmar);
            pnlResumen.Controls.Add(lblTotalRes);
            pnlResumen.Controls.Add(lblTotal);
            pnlResumen.Controls.Add(lblMetodoPago);
            pnlResumen.Controls.Add(lblNombreCli);
            pnlResumen.Controls.Add(lblMetodoRes);
            pnlResumen.Controls.Add(lblClienteRes);
            pnlResumen.Controls.Add(lblResumen);
            pnlResumen.Controls.Add(dtgvResumen);
            pnlResumen.Controls.Add(pnlBarraClientes);
            pnlResumen.Dock = DockStyle.Fill;
            pnlResumen.Location = new Point(0, 0);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new Size(702, 511);
            pnlResumen.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(228, 459);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(138, 40);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(30, 459);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(179, 40);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar pago";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblTotalRes
            // 
            lblTotalRes.AutoSize = true;
            lblTotalRes.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRes.ForeColor = SystemColors.ControlLightLight;
            lblTotalRes.Location = new Point(534, 422);
            lblTotalRes.Name = "lblTotalRes";
            lblTotalRes.Size = new Size(70, 25);
            lblTotalRes.TabIndex = 10;
            lblTotalRes.Text = "TOTAL: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ControlLightLight;
            lblTotal.Location = new Point(610, 422);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "$xxxxx";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodoPago.ForeColor = SystemColors.ControlLightLight;
            lblMetodoPago.Location = new Point(188, 154);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(114, 25);
            lblMetodoPago.TabIndex = 8;
            lblMetodoPago.Text = "[Descripcion]";
            lblMetodoPago.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreCli
            // 
            lblNombreCli.AutoSize = true;
            lblNombreCli.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreCli.ForeColor = SystemColors.ControlLightLight;
            lblNombreCli.Location = new Point(110, 112);
            lblNombreCli.Name = "lblNombreCli";
            lblNombreCli.Size = new Size(88, 25);
            lblNombreCli.TabIndex = 7;
            lblNombreCli.Text = "[Nombre]";
            lblNombreCli.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMetodoRes
            // 
            lblMetodoRes.AutoSize = true;
            lblMetodoRes.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodoRes.ForeColor = SystemColors.ControlLightLight;
            lblMetodoRes.Location = new Point(30, 154);
            lblMetodoRes.Name = "lblMetodoRes";
            lblMetodoRes.Size = new Size(152, 25);
            lblMetodoRes.TabIndex = 6;
            lblMetodoRes.Text = "Método de pago:";
            // 
            // lblClienteRes
            // 
            lblClienteRes.AutoSize = true;
            lblClienteRes.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteRes.ForeColor = SystemColors.ControlLightLight;
            lblClienteRes.Location = new Point(30, 113);
            lblClienteRes.Name = "lblClienteRes";
            lblClienteRes.Size = new Size(74, 25);
            lblClienteRes.TabIndex = 5;
            lblClienteRes.Text = "Cliente: ";
            // 
            // lblResumen
            // 
            lblResumen.Font = new Font("Microsoft Sans Serif", 23.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblResumen.ForeColor = SystemColors.ControlLightLight;
            lblResumen.Location = new Point(30, 51);
            lblResumen.Margin = new Padding(4, 0, 4, 0);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(313, 39);
            lblResumen.TabIndex = 4;
            lblResumen.Text = "Resumen de venta";
            lblResumen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtgvResumen
            // 
            dtgvResumen.AllowUserToAddRows = false;
            dtgvResumen.AllowUserToDeleteRows = false;
            dtgvResumen.AllowUserToResizeRows = false;
            dtgvResumen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvResumen.BackgroundColor = SystemColors.ControlLightLight;
            dtgvResumen.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvResumen.Columns.AddRange(new DataGridViewColumn[] { producto_resumen, cantidad_resumen, precio_resumen, categoria_resumen, subtotal_resumen, id_producto_resumen });
            dtgvResumen.Location = new Point(30, 205);
            dtgvResumen.Name = "dtgvResumen";
            dtgvResumen.ReadOnly = true;
            dtgvResumen.RowHeadersVisible = false;
            dtgvResumen.RowTemplate.Height = 25;
            dtgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvResumen.Size = new Size(642, 211);
            dtgvResumen.TabIndex = 3;
            // 
            // producto_resumen
            // 
            producto_resumen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            producto_resumen.HeaderText = "Producto";
            producto_resumen.Name = "producto_resumen";
            producto_resumen.ReadOnly = true;
            // 
            // cantidad_resumen
            // 
            cantidad_resumen.HeaderText = "Cantidad";
            cantidad_resumen.Name = "cantidad_resumen";
            cantidad_resumen.ReadOnly = true;
            // 
            // precio_resumen
            // 
            precio_resumen.HeaderText = "Precio";
            precio_resumen.Name = "precio_resumen";
            precio_resumen.ReadOnly = true;
            // 
            // categoria_resumen
            // 
            categoria_resumen.HeaderText = "Categoria";
            categoria_resumen.Name = "categoria_resumen";
            categoria_resumen.ReadOnly = true;
            // 
            // subtotal_resumen
            // 
            subtotal_resumen.HeaderText = "Subtotal";
            subtotal_resumen.Name = "subtotal_resumen";
            subtotal_resumen.ReadOnly = true;
            // 
            // id_producto_resumen
            // 
            id_producto_resumen.HeaderText = "ID Producto";
            id_producto_resumen.Name = "id_producto_resumen";
            id_producto_resumen.ReadOnly = true;
            id_producto_resumen.Visible = false;
            // 
            // pnlBarraClientes
            // 
            pnlBarraClientes.BackColor = Color.FromArgb(1, 1, 2);
            pnlBarraClientes.Controls.Add(pictureBox2);
            pnlBarraClientes.Controls.Add(pictureBox5);
            pnlBarraClientes.Controls.Add(pictureBox1);
            pnlBarraClientes.Controls.Add(picMaximizar);
            pnlBarraClientes.Controls.Add(picMinimizar);
            pnlBarraClientes.Controls.Add(picCerrarVentana);
            pnlBarraClientes.Controls.Add(picRestaurar);
            pnlBarraClientes.Controls.Add(picMaxPantalla);
            pnlBarraClientes.Controls.Add(pictureBox3);
            pnlBarraClientes.Controls.Add(pictureBox4);
            pnlBarraClientes.Dock = DockStyle.Top;
            pnlBarraClientes.Location = new Point(0, 0);
            pnlBarraClientes.Name = "pnlBarraClientes";
            pnlBarraClientes.Size = new Size(702, 33);
            pnlBarraClientes.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(1, 1, 2);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(650, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(621, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(678, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // picMaximizar
            // 
            picMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaximizar.BackColor = Color.FromArgb(1, 1, 2);
            picMaximizar.Cursor = Cursors.Hand;
            picMaximizar.Image = (Image)resources.GetObject("picMaximizar.Image");
            picMaximizar.Location = new Point(864, 3);
            picMaximizar.Name = "picMaximizar";
            picMaximizar.Size = new Size(22, 23);
            picMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMaximizar.TabIndex = 23;
            picMaximizar.TabStop = false;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinimizar.Cursor = Cursors.Hand;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(835, 12);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(23, 21);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 22;
            picMinimizar.TabStop = false;
            // 
            // picCerrarVentana
            // 
            picCerrarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrarVentana.Cursor = Cursors.Hand;
            picCerrarVentana.Image = (Image)resources.GetObject("picCerrarVentana.Image");
            picCerrarVentana.Location = new Point(892, 3);
            picCerrarVentana.Name = "picCerrarVentana";
            picCerrarVentana.Size = new Size(24, 21);
            picCerrarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrarVentana.TabIndex = 20;
            picCerrarVentana.TabStop = false;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(1822, 9);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(22, 24);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 16;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Cursor = Cursors.Hand;
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(1822, 9);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(22, 23);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 19;
            picMaxPantalla.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1793, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1850, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // frmResumenVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 511);
            Controls.Add(pnlResumen);
            Name = "frmResumenVenta";
            Text = "frmResumenVenta";
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResumen).EndInit();
            pnlBarraClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlResumen;
        private Panel pnlBarraClientes;
        private PictureBox picMaximizar;
        private PictureBox picMinimizar;
        private PictureBox picCerrarVentana;
        private PictureBox picRestaurar;
        private PictureBox picMaxPantalla;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private DataGridView dtgvResumen;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label lblResumen;
        private Label lblMetodoRes;
        private Label lblClienteRes;
        private Label lblMetodoPago;
        private Label lblNombreCli;
        private Label lblTotal;
        private Label lblTotalRes;
        private Button btnCancelar;
        private Button btnConfirmar;
        private DataGridViewTextBoxColumn producto_resumen;
        private DataGridViewTextBoxColumn cantidad_resumen;
        private DataGridViewTextBoxColumn precio_resumen;
        private DataGridViewTextBoxColumn categoria_resumen;
        private DataGridViewTextBoxColumn subtotal_resumen;
        private DataGridViewTextBoxColumn id_producto_resumen;
    }
}