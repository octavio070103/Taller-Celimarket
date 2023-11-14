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
            dataGridCajasCerradas = new DataGridView();
            id_cierre_caja = new DataGridViewTextBoxColumn();
            fecha_cierre = new DataGridViewTextBoxColumn();
            monto_final = new DataGridViewTextBoxColumn();
            diferencia_Cierre = new DataGridViewTextBoxColumn();
            estado_cierre = new DataGridViewTextBoxColumn();
            Dni_usuario_cierre = new DataGridViewTextBoxColumn();
            Usuario_cierre = new DataGridViewTextBoxColumn();
            id_apertura_caja = new DataGridViewTextBoxColumn();
            fecha_apertura_caja = new DataGridViewTextBoxColumn();
            Monto_inicial_apertura = new DataGridViewTextBoxColumn();
            Dni_usuario_Apertura = new DataGridViewTextBoxColumn();
            Usuario_apertura = new DataGridViewTextBoxColumn();
            estado_apertura = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCajasCerradas).BeginInit();
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
            panel2.Controls.Add(dataGridCajasCerradas);
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
            // dataGridCajasCerradas
            // 
            dataGridCajasCerradas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridCajasCerradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCajasCerradas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCajasCerradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridCajasCerradas.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridCajasCerradas.BorderStyle = BorderStyle.None;
            dataGridCajasCerradas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCajasCerradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCajasCerradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCajasCerradas.Columns.AddRange(new DataGridViewColumn[] { id_cierre_caja, fecha_cierre, monto_final, diferencia_Cierre, estado_cierre, Dni_usuario_cierre, Usuario_cierre, id_apertura_caja, fecha_apertura_caja, Monto_inicial_apertura, Dni_usuario_Apertura, Usuario_apertura, estado_apertura });
            dataGridCajasCerradas.Location = new Point(15, 39);
            dataGridCajasCerradas.MultiSelect = false;
            dataGridCajasCerradas.Name = "dataGridCajasCerradas";
            dataGridCajasCerradas.ReadOnly = true;
            dataGridCajasCerradas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridCajasCerradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCajasCerradas.RowHeadersVisible = false;
            dataGridCajasCerradas.RowTemplate.Height = 28;
            dataGridCajasCerradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCajasCerradas.Size = new Size(795, 429);
            dataGridCajasCerradas.TabIndex = 2;
            // 
            // id_cierre_caja
            // 
            id_cierre_caja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_cierre_caja.HeaderText = "id_cierre_caja";
            id_cierre_caja.Name = "id_cierre_caja";
            id_cierre_caja.ReadOnly = true;
            id_cierre_caja.Visible = false;
            // 
            // fecha_cierre
            // 
            fecha_cierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fecha_cierre.HeaderText = "Fecha Cierre Caja";
            fecha_cierre.MinimumWidth = 100;
            fecha_cierre.Name = "fecha_cierre";
            fecha_cierre.ReadOnly = true;
            // 
            // monto_final
            // 
            monto_final.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            monto_final.HeaderText = "Monto Final";
            monto_final.MinimumWidth = 100;
            monto_final.Name = "monto_final";
            monto_final.ReadOnly = true;
            // 
            // diferencia_Cierre
            // 
            diferencia_Cierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            diferencia_Cierre.HeaderText = "Diferencia";
            diferencia_Cierre.MinimumWidth = 100;
            diferencia_Cierre.Name = "diferencia_Cierre";
            diferencia_Cierre.ReadOnly = true;
            // 
            // estado_cierre
            // 
            estado_cierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estado_cierre.HeaderText = "Estado del Cierre";
            estado_cierre.MinimumWidth = 150;
            estado_cierre.Name = "estado_cierre";
            estado_cierre.ReadOnly = true;
            // 
            // Dni_usuario_cierre
            // 
            Dni_usuario_cierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dni_usuario_cierre.HeaderText = "Dni Usuario Cierre";
            Dni_usuario_cierre.MinimumWidth = 150;
            Dni_usuario_cierre.Name = "Dni_usuario_cierre";
            Dni_usuario_cierre.ReadOnly = true;
            // 
            // Usuario_cierre
            // 
            Usuario_cierre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Usuario_cierre.HeaderText = "Usuario Cierre";
            Usuario_cierre.MinimumWidth = 170;
            Usuario_cierre.Name = "Usuario_cierre";
            Usuario_cierre.ReadOnly = true;
            // 
            // id_apertura_caja
            // 
            id_apertura_caja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_apertura_caja.HeaderText = "id_apertura_caja";
            id_apertura_caja.MinimumWidth = 136;
            id_apertura_caja.Name = "id_apertura_caja";
            id_apertura_caja.ReadOnly = true;
            id_apertura_caja.Visible = false;
            // 
            // fecha_apertura_caja
            // 
            fecha_apertura_caja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fecha_apertura_caja.HeaderText = "Fecha Apertura";
            fecha_apertura_caja.MinimumWidth = 100;
            fecha_apertura_caja.Name = "fecha_apertura_caja";
            fecha_apertura_caja.ReadOnly = true;
            // 
            // Monto_inicial_apertura
            // 
            Monto_inicial_apertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Monto_inicial_apertura.HeaderText = "Monto inicial";
            Monto_inicial_apertura.MinimumWidth = 100;
            Monto_inicial_apertura.Name = "Monto_inicial_apertura";
            Monto_inicial_apertura.ReadOnly = true;
            // 
            // Dni_usuario_Apertura
            // 
            Dni_usuario_Apertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dni_usuario_Apertura.HeaderText = "Dni de usuario Apertura";
            Dni_usuario_Apertura.MinimumWidth = 150;
            Dni_usuario_Apertura.Name = "Dni_usuario_Apertura";
            Dni_usuario_Apertura.ReadOnly = true;
            // 
            // Usuario_apertura
            // 
            Usuario_apertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Usuario_apertura.HeaderText = "Usuario Apertura";
            Usuario_apertura.MinimumWidth = 170;
            Usuario_apertura.Name = "Usuario_apertura";
            Usuario_apertura.ReadOnly = true;
            // 
            // estado_apertura
            // 
            estado_apertura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estado_apertura.HeaderText = "estado apertura";
            estado_apertura.MinimumWidth = 150;
            estado_apertura.Name = "estado_apertura";
            estado_apertura.ReadOnly = true;
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
            Load += FrmAdministrarCaja_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCajasCerradas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridCajasCerradas;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridViewTextBoxColumn id_cierre_caja;
        private DataGridViewTextBoxColumn fecha_cierre;
        private DataGridViewTextBoxColumn monto_final;
        private DataGridViewTextBoxColumn diferencia_Cierre;
        private DataGridViewTextBoxColumn estado_cierre;
        private DataGridViewTextBoxColumn Dni_usuario_cierre;
        private DataGridViewTextBoxColumn Usuario_cierre;
        private DataGridViewTextBoxColumn id_apertura_caja;
        private DataGridViewTextBoxColumn fecha_apertura_caja;
        private DataGridViewTextBoxColumn Monto_inicial_apertura;
        private DataGridViewTextBoxColumn Dni_usuario_Apertura;
        private DataGridViewTextBoxColumn Usuario_apertura;
        private DataGridViewTextBoxColumn estado_apertura;
    }
}