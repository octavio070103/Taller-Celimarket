namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class FrmAdministrarCaja
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
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridUsuarios = new DataGridView();
            column_caja = new DataGridViewTextBoxColumn();
            column_usuario = new DataGridViewTextBoxColumn();
            Column_fecha_apertura = new DataGridViewTextBoxColumn();
            Column_monto_apertura = new DataGridViewTextBoxColumn();
            column_fecha_cierre = new DataGridViewTextBoxColumn();
            Column_monto_total = new DataGridViewTextBoxColumn();
            column_caja_estado = new DataGridViewTextBoxColumn();
            Column_opciones = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 68, 89);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 72);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(20, 148, 8);
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(12, 22);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(140, 35);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Apertura de Caja";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridUsuarios);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 493);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 3);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Entradas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(46, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Mostrar";
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { column_caja, column_usuario, Column_fecha_apertura, Column_monto_apertura, column_fecha_cierre, Column_monto_total, column_caja_estado, Column_opciones });
            dataGridUsuarios.Location = new Point(15, 39);
            dataGridUsuarios.MultiSelect = false;
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.ReadOnly = true;
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridUsuarios.RowTemplate.Height = 28;
            dataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsuarios.Size = new Size(795, 429);
            dataGridUsuarios.TabIndex = 2;
            // 
            // column_caja
            // 
            column_caja.HeaderText = "Caja";
            column_caja.Name = "column_caja";
            column_caja.ReadOnly = true;
            column_caja.Width = 64;
            // 
            // column_usuario
            // 
            column_usuario.HeaderText = "Usuario";
            column_usuario.Name = "column_usuario";
            column_usuario.ReadOnly = true;
            column_usuario.Width = 79;
            // 
            // Column_fecha_apertura
            // 
            Column_fecha_apertura.HeaderText = "Fecha Apertura";
            Column_fecha_apertura.MinimumWidth = 20;
            Column_fecha_apertura.Name = "Column_fecha_apertura";
            Column_fecha_apertura.ReadOnly = true;
            Column_fecha_apertura.Width = 117;
            // 
            // Column_monto_apertura
            // 
            Column_monto_apertura.HeaderText = "Monto Apertura";
            Column_monto_apertura.Name = "Column_monto_apertura";
            Column_monto_apertura.ReadOnly = true;
            Column_monto_apertura.Width = 117;
            // 
            // column_fecha_cierre
            // 
            column_fecha_cierre.HeaderText = "Fecha Cierre";
            column_fecha_cierre.Name = "column_fecha_cierre";
            column_fecha_cierre.ReadOnly = true;
            column_fecha_cierre.Width = 103;
            // 
            // Column_monto_total
            // 
            Column_monto_total.HeaderText = "Monto Total";
            Column_monto_total.Name = "Column_monto_total";
            Column_monto_total.ReadOnly = true;
            Column_monto_total.Width = 96;
            // 
            // column_caja_estado
            // 
            column_caja_estado.HeaderText = "Estado";
            column_caja_estado.Name = "column_caja_estado";
            column_caja_estado.ReadOnly = true;
            column_caja_estado.Width = 74;
            // 
            // Column_opciones
            // 
            Column_opciones.HeaderText = "Opciones";
            Column_opciones.Name = "Column_opciones";
            Column_opciones.ReadOnly = true;
            Column_opciones.Width = 93;
            // 
            // FrmAdministrarCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmAdministrarCaja";
            Text = "FrmAdministrarCaja";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridUsuarios;
        private DataGridViewTextBoxColumn column_caja;
        private DataGridViewTextBoxColumn column_usuario;
        private DataGridViewTextBoxColumn Column_fecha_apertura;
        private DataGridViewTextBoxColumn Column_monto_apertura;
        private DataGridViewTextBoxColumn column_fecha_cierre;
        private DataGridViewTextBoxColumn Column_monto_total;
        private DataGridViewTextBoxColumn column_caja_estado;
        private DataGridViewTextBoxColumn Column_opciones;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
    }
}