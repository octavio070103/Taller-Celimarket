namespace CapaPresentacion.Formularios.Vendedor
{
    partial class ModuloRegistroGeren
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
            btnVerDetalle = new Button();
            lblRegistro = new Label();
            dtgvRegistroVentas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroVentas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 89, 150);
            panel1.Controls.Add(btnVerDetalle);
            panel1.Controls.Add(lblRegistro);
            panel1.Controls.Add(dtgvRegistroVentas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 571);
            panel1.TabIndex = 0;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerDetalle.BackColor = Color.FromArgb(56, 182, 255);
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerDetalle.ForeColor = SystemColors.HighlightText;
            btnVerDetalle.Location = new Point(42, 502);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(134, 39);
            btnVerDetalle.TabIndex = 16;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // lblRegistro
            // 
            lblRegistro.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblRegistro.ForeColor = SystemColors.ControlLightLight;
            lblRegistro.Location = new Point(42, 45);
            lblRegistro.Margin = new Padding(4, 0, 4, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(324, 39);
            lblRegistro.TabIndex = 14;
            lblRegistro.Text = "Registro de ventas";
            lblRegistro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtgvRegistroVentas
            // 
            dtgvRegistroVentas.AllowUserToAddRows = false;
            dtgvRegistroVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dtgvRegistroVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvRegistroVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvRegistroVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRegistroVentas.BackgroundColor = Color.White;
            dtgvRegistroVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvRegistroVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvRegistroVentas.ColumnHeadersHeight = 30;
            dtgvRegistroVentas.EnableHeadersVisualStyles = false;
            dtgvRegistroVentas.Location = new Point(42, 109);
            dtgvRegistroVentas.MultiSelect = false;
            dtgvRegistroVentas.Name = "dtgvRegistroVentas";
            dtgvRegistroVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvRegistroVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvRegistroVentas.RowTemplate.Height = 25;
            dtgvRegistroVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRegistroVentas.Size = new Size(802, 367);
            dtgvRegistroVentas.TabIndex = 0;
            // 
            // ModuloRegistroVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(panel1);
            Name = "ModuloRegistroVentas";
            Text = "ModuloRegistroVentas";
            Load += ModuloRegistroVentas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvRegistroVentas;
        private Label lblRegistro;
        private Button btnVerDetalle;
    }
}