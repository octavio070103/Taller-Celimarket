namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
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
            panel2 = new Panel();
            dtgvRegistroGeren = new DataGridView();
            btnVerDetalle = new Button();
            pnlEncabezadoEsta = new Panel();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroGeren).BeginInit();
            pnlEncabezadoEsta.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 68, 89);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlEncabezadoEsta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 571);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(dtgvRegistroGeren);
            panel2.Controls.Add(btnVerDetalle);
            panel2.Location = new Point(25, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(856, 471);
            panel2.TabIndex = 21;
            // 
            // dtgvRegistroGeren
            // 
            dtgvRegistroGeren.AllowUserToAddRows = false;
            dtgvRegistroGeren.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dtgvRegistroGeren.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvRegistroGeren.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvRegistroGeren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRegistroGeren.BackgroundColor = Color.White;
            dtgvRegistroGeren.BorderStyle = BorderStyle.None;
            dtgvRegistroGeren.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvRegistroGeren.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvRegistroGeren.ColumnHeadersHeight = 30;
            dtgvRegistroGeren.EnableHeadersVisualStyles = false;
            dtgvRegistroGeren.Location = new Point(19, 15);
            dtgvRegistroGeren.MultiSelect = false;
            dtgvRegistroGeren.Name = "dtgvRegistroGeren";
            dtgvRegistroGeren.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvRegistroGeren.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvRegistroGeren.RowTemplate.Height = 25;
            dtgvRegistroGeren.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRegistroGeren.Size = new Size(816, 390);
            dtgvRegistroGeren.TabIndex = 17;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerDetalle.BackColor = Color.FromArgb(128, 128, 255);
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerDetalle.ForeColor = SystemColors.HighlightText;
            btnVerDetalle.Location = new Point(19, 420);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(134, 39);
            btnVerDetalle.TabIndex = 19;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // pnlEncabezadoEsta
            // 
            pnlEncabezadoEsta.BackColor = Color.FromArgb(47, 33, 75);
            pnlEncabezadoEsta.Controls.Add(label11);
            pnlEncabezadoEsta.Dock = DockStyle.Top;
            pnlEncabezadoEsta.Location = new Point(0, 0);
            pnlEncabezadoEsta.Name = "pnlEncabezadoEsta";
            pnlEncabezadoEsta.Size = new Size(893, 71);
            pnlEncabezadoEsta.TabIndex = 20;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(298, 9);
            label11.Name = "label11";
            label11.Size = new Size(296, 45);
            label11.TabIndex = 1;
            label11.Text = "Registro de ventas";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModuloRegistroGeren
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(panel1);
            Name = "ModuloRegistroGeren";
            Text = "ModuloRegistroGeren";
            Load += ModuloRegistroGeren_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroGeren).EndInit();
            pnlEncabezadoEsta.ResumeLayout(false);
            pnlEncabezadoEsta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVerDetalle;
        private DataGridView dtgvRegistroGeren;
        private Panel pnlEncabezadoEsta;
        private Label label11;
        private Panel panel2;
    }
}