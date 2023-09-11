namespace CapaPresentacion.Formularios.Vendedor
{
    partial class frmModuloCliente
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
            pnlVentanaClientes = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            btnEliminar = new Button();
            btnAgregar = new Button();
            dtgvClientes = new DataGridView();
            panel2 = new Panel();
            btnModificar = new Button();
            dni_cliente = new DataGridViewTextBoxColumn();
            apellido_cliente = new DataGridViewTextBoxColumn();
            nombre_cliente = new DataGridViewTextBoxColumn();
            telefono_cliente = new DataGridViewTextBoxColumn();
            direccion_cliente = new DataGridViewTextBoxColumn();
            correo_cliente = new DataGridViewTextBoxColumn();
            pnlVentanaClientes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVentanaClientes
            // 
            pnlVentanaClientes.BackColor = Color.FromArgb(88, 89, 150);
            pnlVentanaClientes.Controls.Add(label2);
            pnlVentanaClientes.Controls.Add(comboBox1);
            pnlVentanaClientes.Controls.Add(label1);
            pnlVentanaClientes.Controls.Add(textBox1);
            pnlVentanaClientes.Controls.Add(panel3);
            pnlVentanaClientes.Controls.Add(panel2);
            pnlVentanaClientes.Dock = DockStyle.Fill;
            pnlVentanaClientes.Location = new Point(0, 0);
            pnlVentanaClientes.Name = "pnlVentanaClientes";
            pnlVentanaClientes.Size = new Size(893, 571);
            pnlVentanaClientes.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(413, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "Filtro";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(462, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(122, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(dtgvClientes);
            panel3.Location = new Point(29, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 467);
            panel3.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(129, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(15, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtgvClientes
            // 
            dtgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClientes.Columns.AddRange(new DataGridViewColumn[] { dni_cliente, apellido_cliente, nombre_cliente, telefono_cliente, direccion_cliente, correo_cliente });
            dtgvClientes.Location = new Point(0, 0);
            dtgvClientes.Name = "dtgvClientes";
            dtgvClientes.RowTemplate.Height = 25;
            dtgvClientes.Size = new Size(555, 414);
            dtgvClientes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnModificar);
            panel2.Location = new Point(602, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 467);
            panel2.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.Location = new Point(14, 420);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 35);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
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
            nombre_cliente.HeaderText = "Nombre";
            nombre_cliente.Name = "nombre_cliente";
            // 
            // telefono_cliente
            // 
            telefono_cliente.HeaderText = "Teléfono";
            telefono_cliente.Name = "telefono_cliente";
            // 
            // direccion_cliente
            // 
            direccion_cliente.HeaderText = "Dirección";
            direccion_cliente.Name = "direccion_cliente";
            // 
            // correo_cliente
            // 
            correo_cliente.HeaderText = "Correo";
            correo_cliente.Name = "correo_cliente";
            // 
            // frmModuloCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(pnlVentanaClientes);
            Name = "frmModuloCliente";
            Text = "Clientes";
            pnlVentanaClientes.ResumeLayout(false);
            pnlVentanaClientes.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvClientes).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVentanaClientes;
        private Panel panel2;
        private Panel panel3;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dtgvClientes;
        private Button btnModificar;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn dni_cliente;
        private DataGridViewTextBoxColumn apellido_cliente;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn telefono_cliente;
        private DataGridViewTextBoxColumn direccion_cliente;
        private DataGridViewTextBoxColumn correo_cliente;
    }
}