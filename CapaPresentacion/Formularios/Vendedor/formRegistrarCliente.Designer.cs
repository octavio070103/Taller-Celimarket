namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    partial class frmRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarCliente));
            pnlBarraClientes = new Panel();
            picMaximizar = new PictureBox();
            picMinimizar = new PictureBox();
            picCerrarVentana = new PictureBox();
            picRestaurar = new PictureBox();
            picMaxPantalla = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pnlRegistrarCliente = new Panel();
            btnGuardar = new Button();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblDomicilio = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            lblRegistrar = new Label();
            txtNombre = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            pnlBarraClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            pnlRegistrarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlBarraClientes
            // 
            pnlBarraClientes.BackColor = Color.FromArgb(1, 1, 2);
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
            pnlBarraClientes.Size = new Size(542, 33);
            pnlBarraClientes.TabIndex = 1;
            // 
            // picMaximizar
            // 
            picMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaximizar.BackColor = Color.FromArgb(1, 1, 2);
            picMaximizar.Cursor = Cursors.Hand;
            picMaximizar.Image = (Image)resources.GetObject("picMaximizar.Image");
            picMaximizar.Location = new Point(487, 3);
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
            picMinimizar.Location = new Point(458, 12);
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
            picCerrarVentana.Location = new Point(515, 3);
            picCerrarVentana.Name = "picCerrarVentana";
            picCerrarVentana.Size = new Size(24, 21);
            picCerrarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrarVentana.TabIndex = 20;
            picCerrarVentana.TabStop = false;
            picCerrarVentana.Click += pictureBox1_Click;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(1445, 9);
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
            picMaxPantalla.Location = new Point(1445, 9);
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
            pictureBox3.Location = new Point(1416, 18);
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
            pictureBox4.Location = new Point(1473, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 53, 68);
            panel1.Controls.Add(pnlRegistrarCliente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 388);
            panel1.TabIndex = 2;
            // 
            // pnlRegistrarCliente
            // 
            pnlRegistrarCliente.BackColor = Color.SteelBlue;
            pnlRegistrarCliente.Controls.Add(btnGuardar);
            pnlRegistrarCliente.Controls.Add(txtCorreo);
            pnlRegistrarCliente.Controls.Add(lblTelefono);
            pnlRegistrarCliente.Controls.Add(lblCorreo);
            pnlRegistrarCliente.Controls.Add(lblDomicilio);
            pnlRegistrarCliente.Controls.Add(lblDni);
            pnlRegistrarCliente.Controls.Add(lblApellido);
            pnlRegistrarCliente.Controls.Add(lblNombre);
            pnlRegistrarCliente.Controls.Add(txtDomicilio);
            pnlRegistrarCliente.Controls.Add(txtTelefono);
            pnlRegistrarCliente.Controls.Add(txtDni);
            pnlRegistrarCliente.Controls.Add(txtApellido);
            pnlRegistrarCliente.Controls.Add(lblRegistrar);
            pnlRegistrarCliente.Controls.Add(txtNombre);
            pnlRegistrarCliente.Dock = DockStyle.Fill;
            pnlRegistrarCliente.Location = new Point(0, 0);
            pnlRegistrarCliente.Name = "pnlRegistrarCliente";
            pnlRegistrarCliente.Size = new Size(542, 388);
            pnlRegistrarCliente.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(56, 182, 255);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(28, 309);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 40);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.Location = new Point(276, 188);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(195, 23);
            txtCorreo.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.ForeColor = SystemColors.HighlightText;
            lblTelefono.Location = new Point(276, 230);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(68, 21);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Teléfono";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = SystemColors.HighlightText;
            lblCorreo.Location = new Point(276, 164);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(138, 21);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo electronico";
            lblCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDomicilio.ForeColor = SystemColors.HighlightText;
            lblDomicilio.Location = new Point(276, 93);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(76, 21);
            lblDomicilio.TabIndex = 10;
            lblDomicilio.Text = "Domicilio";
            lblDomicilio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.HighlightText;
            lblDni.Location = new Point(28, 224);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(37, 21);
            lblDni.TabIndex = 9;
            lblDni.Text = "DNI";
            lblDni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.HighlightText;
            lblApellido.Location = new Point(28, 159);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.HighlightText;
            lblNombre.Location = new Point(28, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.White;
            txtDomicilio.Location = new Point(276, 117);
            txtDomicilio.Margin = new Padding(4, 3, 4, 3);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(195, 23);
            txtDomicilio.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Location = new Point(276, 254);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(195, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += soloNumeros_KeyPress;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.Location = new Point(28, 248);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += soloNumeros_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.Location = new Point(28, 183);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(195, 23);
            txtApellido.TabIndex = 2;
            txtApellido.KeyPress += soloLetras_KeyPress;
            // 
            // lblRegistrar
            // 
            lblRegistrar.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblRegistrar.ForeColor = SystemColors.ControlLightLight;
            lblRegistrar.Location = new Point(28, 29);
            lblRegistrar.Margin = new Padding(4, 0, 4, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(286, 39);
            lblRegistrar.TabIndex = 0;
            lblRegistrar.Text = "Registrar Cliente";
            lblRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Location = new Point(28, 117);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += soloLetras_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 421);
            Controls.Add(panel1);
            Controls.Add(pnlBarraClientes);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRegistrarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar Cliente";
            pnlBarraClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            pnlRegistrarCliente.ResumeLayout(false);
            pnlRegistrarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBarraClientes;
        private PictureBox picRestaurar;
        private PictureBox picMaxPantalla;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox picCerrarVentana;
        private PictureBox picMinimizar;
        private Panel panel1;
        private Panel pnlRegistrarCliente;
        private Button btnGuardar;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblDomicilio;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtDomicilio;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label lblRegistrar;
        private TextBox txtNombre;
        private PictureBox picMaximizar;
        private ErrorProvider errorProvider1;
    }
}