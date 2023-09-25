namespace CapaPresentacion.Formularios.Vendedor
{
    partial class frmSeleccionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarCliente));
            pnlBarraClientes = new Panel();
            picMinCliente = new PictureBox();
            picMaxCliente = new PictureBox();
            picCerrar = new PictureBox();
            picMaximizar = new PictureBox();
            picMinimizar = new PictureBox();
            picCerrarVentana = new PictureBox();
            picRestaurar = new PictureBox();
            picMaxPantalla = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlRegistrarCliente = new Panel();
            comboBox1 = new ComboBox();
            lblFiltrarCliente = new Label();
            dtgvSelecClientes = new DataGridView();
            id_cliente = new DataGridViewTextBoxColumn();
            dni_cliente = new DataGridViewTextBoxColumn();
            apellido_cliente = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            telefono_cliente = new DataGridViewTextBoxColumn();
            direccion_cliente = new DataGridViewTextBoxColumn();
            btnSeleccionar = new Button();
            lblBuscarCliente = new Label();
            lblSeleccionar = new Label();
            txtNombre = new TextBox();
            pnlBarraClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlRegistrarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSelecClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlBarraClientes
            // 
            pnlBarraClientes.BackColor = Color.FromArgb(1, 1, 2);
            pnlBarraClientes.Controls.Add(picMinCliente);
            pnlBarraClientes.Controls.Add(picMaxCliente);
            pnlBarraClientes.Controls.Add(picCerrar);
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
            pnlBarraClientes.Size = new Size(620, 33);
            pnlBarraClientes.TabIndex = 2;
            // 
            // picMinCliente
            // 
            picMinCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinCliente.Cursor = Cursors.Hand;
            picMinCliente.Image = (Image)resources.GetObject("picMinCliente.Image");
            picMinCliente.Location = new Point(527, 12);
            picMinCliente.Name = "picMinCliente";
            picMinCliente.Size = new Size(23, 21);
            picMinCliente.SizeMode = PictureBoxSizeMode.Zoom;
            picMinCliente.TabIndex = 25;
            picMinCliente.TabStop = false;
            // 
            // picMaxCliente
            // 
            picMaxCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaxCliente.BackColor = Color.FromArgb(1, 1, 2);
            picMaxCliente.Cursor = Cursors.Hand;
            picMaxCliente.Image = (Image)resources.GetObject("picMaxCliente.Image");
            picMaxCliente.Location = new Point(556, 4);
            picMaxCliente.Name = "picMaxCliente";
            picMaxCliente.Size = new Size(22, 23);
            picMaxCliente.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxCliente.TabIndex = 24;
            picMaxCliente.TabStop = false;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(584, 6);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(24, 21);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 24;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMaximizar
            // 
            picMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaximizar.BackColor = Color.FromArgb(1, 1, 2);
            picMaximizar.Cursor = Cursors.Hand;
            picMaximizar.Image = (Image)resources.GetObject("picMaximizar.Image");
            picMaximizar.Location = new Point(907, 3);
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
            picMinimizar.Location = new Point(878, 12);
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
            picCerrarVentana.Location = new Point(935, 3);
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
            picRestaurar.Location = new Point(1865, 9);
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
            picMaxPantalla.Location = new Point(1865, 9);
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
            pictureBox3.Location = new Point(1836, 18);
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
            pictureBox4.Location = new Point(1893, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pnlRegistrarCliente
            // 
            pnlRegistrarCliente.BackColor = Color.SteelBlue;
            pnlRegistrarCliente.Controls.Add(comboBox1);
            pnlRegistrarCliente.Controls.Add(lblFiltrarCliente);
            pnlRegistrarCliente.Controls.Add(dtgvSelecClientes);
            pnlRegistrarCliente.Controls.Add(btnSeleccionar);
            pnlRegistrarCliente.Controls.Add(lblBuscarCliente);
            pnlRegistrarCliente.Controls.Add(lblSeleccionar);
            pnlRegistrarCliente.Controls.Add(txtNombre);
            pnlRegistrarCliente.Dock = DockStyle.Fill;
            pnlRegistrarCliente.Location = new Point(0, 33);
            pnlRegistrarCliente.Name = "pnlRegistrarCliente";
            pnlRegistrarCliente.Size = new Size(620, 429);
            pnlRegistrarCliente.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(478, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 17;
            // 
            // lblFiltrarCliente
            // 
            lblFiltrarCliente.AutoSize = true;
            lblFiltrarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltrarCliente.ForeColor = SystemColors.HighlightText;
            lblFiltrarCliente.Location = new Point(421, 71);
            lblFiltrarCliente.Name = "lblFiltrarCliente";
            lblFiltrarCliente.Size = new Size(51, 21);
            lblFiltrarCliente.TabIndex = 16;
            lblFiltrarCliente.Text = "Filtrar";
            lblFiltrarCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtgvSelecClientes
            // 
            dtgvSelecClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSelecClientes.Columns.AddRange(new DataGridViewColumn[] { id_cliente, dni_cliente, apellido_cliente, nombre_cliente, telefono_cliente, direccion_cliente });
            dtgvSelecClientes.Location = new Point(28, 108);
            dtgvSelecClientes.Name = "dtgvSelecClientes";
            dtgvSelecClientes.RowTemplate.Height = 25;
            dtgvSelecClientes.Size = new Size(564, 248);
            dtgvSelecClientes.TabIndex = 15;
//            dtgvSelecClientes.SelectionChanged += obtenerDatosCliente;
            // 
            // id_cliente
            // 
            id_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id_cliente.HeaderText = "ID";
            id_cliente.Name = "id_cliente";
            id_cliente.Width = 43;
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
            nombre_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre_cliente.HeaderText = "Nombre";
            nombre_cliente.Name = "nombre_cliente";
            // 
            // telefono_cliente
            // 
            telefono_cliente.HeaderText = "Telefono";
            telefono_cliente.Name = "telefono_cliente";
            // 
            // direccion_cliente
            // 
            direccion_cliente.HeaderText = "Direccion";
            direccion_cliente.Name = "direccion_cliente";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(56, 182, 255);
            btnSeleccionar.FlatAppearance.BorderSize = 0;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(28, 377);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(138, 40);
            btnSeleccionar.TabIndex = 14;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // lblBuscarCliente
            // 
            lblBuscarCliente.AutoSize = true;
            lblBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarCliente.ForeColor = SystemColors.HighlightText;
            lblBuscarCliente.Location = new Point(28, 69);
            lblBuscarCliente.Name = "lblBuscarCliente";
            lblBuscarCliente.Size = new Size(56, 21);
            lblBuscarCliente.TabIndex = 7;
            lblBuscarCliente.Text = "Buscar";
            lblBuscarCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblSeleccionar.ForeColor = SystemColors.ControlLightLight;
            lblSeleccionar.Location = new Point(148, 13);
            lblSeleccionar.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(324, 39);
            lblSeleccionar.TabIndex = 0;
            lblSeleccionar.Text = "Seleccionar Cliente";
            lblSeleccionar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Location = new Point(91, 71);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 1;
            // 
            // frmSeleccionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 462);
            Controls.Add(pnlRegistrarCliente);
            Controls.Add(pnlBarraClientes);
            Name = "frmSeleccionarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSeleccionarCliente";
            pnlBarraClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMinCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlRegistrarCliente.ResumeLayout(false);
            pnlRegistrarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSelecClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarraClientes;
        private PictureBox picMaximizar;
        private PictureBox picMinimizar;
        private PictureBox picCerrarVentana;
        private PictureBox picRestaurar;
        private PictureBox picMaxPantalla;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel pnlRegistrarCliente;
        private Button btnSeleccionar;
        private Label lblBuscarCliente;
        private Label lblSeleccionar;
        private TextBox txtNombre;
        private Label lblFiltrarCliente;
        private DataGridView dtgvSelecClientes;
        private ComboBox comboBox1;
        private PictureBox picCerrar;
        private PictureBox picMaxCliente;
        private PictureBox picMinCliente;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn dni_cliente;
        private DataGridViewTextBoxColumn apellido_cliente;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn telefono_cliente;
        private DataGridViewTextBoxColumn direccion_cliente;
    }
}