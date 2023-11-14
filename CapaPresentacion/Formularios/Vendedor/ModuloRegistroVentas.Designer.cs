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
            btnReiniciar = new Button();
            pnlFiltro = new Panel();
            pnlBotones = new Panel();
            btnFiltroHisto = new Button();
            btnFiltroSiete = new Button();
            btnFiltroHoy = new Button();
            btnFiltroTreinta = new Button();
            label5 = new Label();
            btnAplicar = new Button();
            label4 = new Label();
            label3 = new Label();
            dtpFechaFin = new DateTimePicker();
            label2 = new Label();
            dtpFechaInicio = new DateTimePicker();
            pnlVentas = new Panel();
            dtgvRegistroVentas = new DataGridView();
            pnlDetalle = new Panel();
            dtgvDetalleVenta = new DataGridView();
            btnVerDetalle = new Button();
            lblRegistro = new Label();
            pnlRegistro.SuspendLayout();
            pnlFiltro.SuspendLayout();
            pnlBotones.SuspendLayout();
            pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroVentas).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // pnlRegistro
            // 
            pnlRegistro.BackColor = Color.FromArgb(88, 89, 150);
            pnlRegistro.Controls.Add(btnReiniciar);
            pnlRegistro.Controls.Add(pnlFiltro);
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
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReiniciar.BackColor = Color.FromArgb(255, 128, 0);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = SystemColors.HighlightText;
            btnReiniciar.Location = new Point(197, 502);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(134, 39);
            btnReiniciar.TabIndex = 23;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // pnlFiltro
            // 
            pnlFiltro.Anchor = AnchorStyles.Top;
            pnlFiltro.BackColor = SystemColors.GradientActiveCaption;
            pnlFiltro.Controls.Add(pnlBotones);
            pnlFiltro.Controls.Add(label5);
            pnlFiltro.Controls.Add(btnAplicar);
            pnlFiltro.Controls.Add(label4);
            pnlFiltro.Controls.Add(label3);
            pnlFiltro.Controls.Add(dtpFechaFin);
            pnlFiltro.Controls.Add(label2);
            pnlFiltro.Controls.Add(dtpFechaInicio);
            pnlFiltro.Location = new Point(0, 61);
            pnlFiltro.Name = "pnlFiltro";
            pnlFiltro.Size = new Size(893, 38);
            pnlFiltro.TabIndex = 22;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = SystemColors.Window;
            pnlBotones.Controls.Add(btnFiltroHisto);
            pnlBotones.Controls.Add(btnFiltroSiete);
            pnlBotones.Controls.Add(btnFiltroHoy);
            pnlBotones.Controls.Add(btnFiltroTreinta);
            pnlBotones.Location = new Point(552, 4);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(290, 28);
            pnlBotones.TabIndex = 7;
            // 
            // btnFiltroHisto
            // 
            btnFiltroHisto.BackColor = Color.DarkCyan;
            btnFiltroHisto.FlatAppearance.BorderColor = Color.White;
            btnFiltroHisto.FlatAppearance.BorderSize = 0;
            btnFiltroHisto.FlatStyle = FlatStyle.Flat;
            btnFiltroHisto.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroHisto.ForeColor = SystemColors.ControlLightLight;
            btnFiltroHisto.Location = new Point(219, 0);
            btnFiltroHisto.Name = "btnFiltroHisto";
            btnFiltroHisto.Size = new Size(72, 28);
            btnFiltroHisto.TabIndex = 3;
            btnFiltroHisto.Text = "HISTORICO";
            btnFiltroHisto.UseVisualStyleBackColor = false;
            btnFiltroHisto.Click += btnFiltroHisto_Click;
            // 
            // btnFiltroSiete
            // 
            btnFiltroSiete.BackColor = Color.DarkCyan;
            btnFiltroSiete.FlatAppearance.BorderColor = Color.White;
            btnFiltroSiete.FlatAppearance.BorderSize = 0;
            btnFiltroSiete.FlatStyle = FlatStyle.Flat;
            btnFiltroSiete.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroSiete.ForeColor = SystemColors.ControlLightLight;
            btnFiltroSiete.Location = new Point(73, 0);
            btnFiltroSiete.Name = "btnFiltroSiete";
            btnFiltroSiete.Size = new Size(72, 28);
            btnFiltroSiete.TabIndex = 0;
            btnFiltroSiete.Text = "7 DIAS";
            btnFiltroSiete.UseVisualStyleBackColor = false;
            btnFiltroSiete.Click += btnFiltroSiete_Click;
            // 
            // btnFiltroHoy
            // 
            btnFiltroHoy.BackColor = Color.DarkCyan;
            btnFiltroHoy.FlatAppearance.BorderColor = Color.White;
            btnFiltroHoy.FlatAppearance.BorderSize = 0;
            btnFiltroHoy.FlatStyle = FlatStyle.Flat;
            btnFiltroHoy.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroHoy.ForeColor = SystemColors.ControlLightLight;
            btnFiltroHoy.Location = new Point(0, 0);
            btnFiltroHoy.Name = "btnFiltroHoy";
            btnFiltroHoy.Size = new Size(72, 28);
            btnFiltroHoy.TabIndex = 2;
            btnFiltroHoy.Text = "Hoy";
            btnFiltroHoy.UseVisualStyleBackColor = false;
            btnFiltroHoy.Click += btnFiltroHoy_Click;
            // 
            // btnFiltroTreinta
            // 
            btnFiltroTreinta.BackColor = Color.DarkCyan;
            btnFiltroTreinta.FlatAppearance.BorderColor = Color.White;
            btnFiltroTreinta.FlatAppearance.BorderSize = 0;
            btnFiltroTreinta.FlatStyle = FlatStyle.Flat;
            btnFiltroTreinta.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroTreinta.ForeColor = SystemColors.ControlLightLight;
            btnFiltroTreinta.Location = new Point(146, 0);
            btnFiltroTreinta.Name = "btnFiltroTreinta";
            btnFiltroTreinta.Size = new Size(72, 28);
            btnFiltroTreinta.TabIndex = 1;
            btnFiltroTreinta.Text = "30 DIAS";
            btnFiltroTreinta.UseVisualStyleBackColor = false;
            btnFiltroTreinta.Click += btnFiltroTreinta_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(487, 10);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 10;
            label5.Text = "Últimos:";
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.DarkCyan;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAplicar.ForeColor = SystemColors.ControlLightLight;
            btnAplicar.Location = new Point(415, 9);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(59, 23);
            btnAplicar.TabIndex = 9;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(45, 9);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 8;
            label4.Text = "PERIODO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(277, 8);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 7;
            label3.Text = "Fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(314, 9);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(95, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 9);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Inicio:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(176, 9);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(95, 23);
            dtpFechaInicio.TabIndex = 4;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // pnlVentas
            // 
            pnlVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVentas.BackColor = Color.Wheat;
            pnlVentas.Controls.Add(dtgvRegistroVentas);
            pnlVentas.Location = new Point(42, 105);
            pnlVentas.Name = "pnlVentas";
            pnlVentas.Size = new Size(439, 372);
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
            dtgvRegistroVentas.Size = new Size(439, 372);
            dtgvRegistroVentas.TabIndex = 18;
            dtgvRegistroVentas.CellClick += dtgvRegistroVentas_CellClick;
            // 
            // pnlDetalle
            // 
            pnlDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.Controls.Add(dtgvDetalleVenta);
            pnlDetalle.Location = new Point(487, 105);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(370, 372);
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
            dtgvDetalleVenta.Size = new Size(370, 372);
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
            lblRegistro.Location = new Point(42, 9);
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
            Text = "Registro de ventas";
            Load += ModuloRegistroVentas_Load;
            pnlRegistro.ResumeLayout(false);
            pnlFiltro.ResumeLayout(false);
            pnlFiltro.PerformLayout();
            pnlBotones.ResumeLayout(false);
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
        private Panel pnlFiltro;
        private Panel pnlBotones;
        private Button btnFiltroHisto;
        private Button btnFiltroSiete;
        private Button btnFiltroHoy;
        private Button btnFiltroTreinta;
        private Label label5;
        private Button btnAplicar;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFechaFin;
        private Label label2;
        private DateTimePicker dtpFechaInicio;
        private Button btnReiniciar;
    }
}