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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pnlRegistro = new Panel();
            pnlVentas = new Panel();
            dtgvRegistroVentas = new DataGridView();
            pnlDetalle = new Panel();
            dtgvDetalleVenta = new DataGridView();
            btnVerDetalle = new Button();
            lblRegistro = new Label();
            pnlRegistro.SuspendLayout();
            pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroVentas).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // pnlRegistro
            // 
            pnlRegistro.BackColor = Color.FromArgb(88, 89, 150);
            pnlRegistro.Controls.Add(pnlVentas);
            pnlRegistro.Controls.Add(pnlDetalle);
            pnlRegistro.Controls.Add(btnVerDetalle);
            pnlRegistro.Controls.Add(lblRegistro);
            pnlRegistro.Dock = DockStyle.Fill;
            pnlRegistro.Location = new Point(0, 0);
            pnlRegistro.Name = "pnlRegistro";
            pnlRegistro.Size = new Size(893, 571);
            pnlRegistro.TabIndex = 0;
            // 
            // pnlVentas
            // 
            pnlVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVentas.BackColor = Color.Wheat;
            pnlVentas.Controls.Add(dtgvRegistroVentas);
            pnlVentas.Location = new Point(42, 102);
            pnlVentas.Name = "pnlVentas";
            pnlVentas.Size = new Size(439, 375);
            pnlVentas.TabIndex = 21;
            // 
            // dtgvRegistroVentas
            // 
            dtgvRegistroVentas.AllowUserToAddRows = false;
            dtgvRegistroVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 192, 255);
            dtgvRegistroVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvRegistroVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgvRegistroVentas.BackgroundColor = Color.White;
            dtgvRegistroVentas.BorderStyle = BorderStyle.None;
            dtgvRegistroVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvRegistroVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvRegistroVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRegistroVentas.Dock = DockStyle.Fill;
            dtgvRegistroVentas.EnableHeadersVisualStyles = false;
            dtgvRegistroVentas.Location = new Point(0, 0);
            dtgvRegistroVentas.MultiSelect = false;
            dtgvRegistroVentas.Name = "dtgvRegistroVentas";
            dtgvRegistroVentas.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgvRegistroVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgvRegistroVentas.RowTemplate.Height = 25;
            dtgvRegistroVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRegistroVentas.Size = new Size(439, 375);
            dtgvRegistroVentas.TabIndex = 18;
            dtgvRegistroVentas.CellClick += dtgvRegistroVentas_CellClick;
            // 
            // pnlDetalle
            // 
            pnlDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.Controls.Add(dtgvDetalleVenta);
            pnlDetalle.Location = new Point(487, 102);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(370, 375);
            pnlDetalle.TabIndex = 20;
            // 
            // dtgvDetalleVenta
            // 
            dtgvDetalleVenta.AllowUserToAddRows = false;
            dtgvDetalleVenta.AllowUserToDeleteRows = false;
            dtgvDetalleVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dtgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dtgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgvDetalleVenta.BackgroundColor = Color.White;
            dtgvDetalleVenta.BorderStyle = BorderStyle.None;
            dtgvDetalleVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dtgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dtgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDetalleVenta.Dock = DockStyle.Fill;
            dtgvDetalleVenta.EnableHeadersVisualStyles = false;
            dtgvDetalleVenta.Location = new Point(0, 0);
            dtgvDetalleVenta.Name = "dtgvDetalleVenta";
            dtgvDetalleVenta.ReadOnly = true;
            dtgvDetalleVenta.RowHeadersVisible = false;
            dtgvDetalleVenta.RowTemplate.Height = 25;
            dtgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDetalleVenta.Size = new Size(370, 375);
            dtgvDetalleVenta.TabIndex = 19;
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
            btnVerDetalle.Click += btnVerDetalle_Click;
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
            // ModuloRegistroGeren
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(pnlRegistro);
            Name = "ModuloRegistroGeren";
            Text = "ModuloRegistroVentas";
            Load += ModuloRegistroVentas_Load;
            pnlRegistro.ResumeLayout(false);
            pnlVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroVentas).EndInit();
            pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegistro;
        private Label lblRegistro;
        private Button btnVerDetalle;
        private DataGridView dtgvDetalleVenta;
        private DataGridView dtgvRegistroVentas;
        private Panel pnlDetalle;
        private Panel pnlVentas;
    }
}