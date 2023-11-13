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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlRegistro = new Panel();
            pnlFiltro = new Panel();
            panel3 = new Panel();
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
            panel2 = new Panel();
            pnlDetalle = new Panel();
            dtgvDetalleVenta = new DataGridView();
            dtgvRegistroGeren = new DataGridView();
            btnVerDetalle = new Button();
            pnlEncabezadoEsta = new Panel();
            label11 = new Label();
            btnReiniciar = new Button();
            pnlRegistro.SuspendLayout();
            pnlFiltro.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroGeren).BeginInit();
            pnlEncabezadoEsta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegistro
            // 
            pnlRegistro.BackColor = Color.FromArgb(67, 68, 89);
            pnlRegistro.Controls.Add(pnlFiltro);
            pnlRegistro.Controls.Add(panel2);
            pnlRegistro.Controls.Add(pnlEncabezadoEsta);
            pnlRegistro.Dock = DockStyle.Fill;
            pnlRegistro.Location = new Point(0, 0);
            pnlRegistro.Name = "pnlRegistro";
            pnlRegistro.Size = new Size(893, 571);
            pnlRegistro.TabIndex = 0;
            // 
            // pnlFiltro
            // 
            pnlFiltro.Anchor = AnchorStyles.Top;
            pnlFiltro.BackColor = SystemColors.GradientActiveCaption;
            pnlFiltro.Controls.Add(panel3);
            pnlFiltro.Controls.Add(label5);
            pnlFiltro.Controls.Add(btnAplicar);
            pnlFiltro.Controls.Add(label4);
            pnlFiltro.Controls.Add(label3);
            pnlFiltro.Controls.Add(dtpFechaFin);
            pnlFiltro.Controls.Add(label2);
            pnlFiltro.Controls.Add(dtpFechaInicio);
            pnlFiltro.Location = new Point(38, 56);
            pnlFiltro.Name = "pnlFiltro";
            pnlFiltro.Size = new Size(816, 38);
            pnlFiltro.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(btnFiltroHisto);
            panel3.Controls.Add(btnFiltroSiete);
            panel3.Controls.Add(btnFiltroHoy);
            panel3.Controls.Add(btnFiltroTreinta);
            panel3.Location = new Point(512, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 28);
            panel3.TabIndex = 20;
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
            label5.Location = new Point(447, 9);
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
            btnAplicar.Location = new Point(375, 8);
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
            label4.Location = new Point(5, 8);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 8;
            label4.Text = "PERIODO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(237, 7);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 7;
            label3.Text = "Fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(274, 8);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(95, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 8);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Inicio:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(136, 8);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(95, 23);
            dtpFechaInicio.TabIndex = 4;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(btnReiniciar);
            panel2.Controls.Add(pnlDetalle);
            panel2.Controls.Add(dtgvRegistroGeren);
            panel2.Controls.Add(btnVerDetalle);
            panel2.Location = new Point(12, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 459);
            panel2.TabIndex = 21;
            // 
            // pnlDetalle
            // 
            pnlDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.Controls.Add(dtgvDetalleVenta);
            pnlDetalle.Location = new Point(484, 15);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(368, 378);
            pnlDetalle.TabIndex = 21;
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
            dtgvDetalleVenta.Size = new Size(368, 378);
            dtgvDetalleVenta.TabIndex = 19;
            // 
            // dtgvRegistroGeren
            // 
            dtgvRegistroGeren.AllowUserToAddRows = false;
            dtgvRegistroGeren.AllowUserToDeleteRows = false;
            dtgvRegistroGeren.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 192, 255);
            dtgvRegistroGeren.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvRegistroGeren.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvRegistroGeren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRegistroGeren.BackgroundColor = Color.White;
            dtgvRegistroGeren.BorderStyle = BorderStyle.None;
            dtgvRegistroGeren.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvRegistroGeren.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvRegistroGeren.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvRegistroGeren.EnableHeadersVisualStyles = false;
            dtgvRegistroGeren.Location = new Point(19, 15);
            dtgvRegistroGeren.MultiSelect = false;
            dtgvRegistroGeren.Name = "dtgvRegistroGeren";
            dtgvRegistroGeren.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgvRegistroGeren.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgvRegistroGeren.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgvRegistroGeren.RowTemplate.Height = 25;
            dtgvRegistroGeren.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRegistroGeren.Size = new Size(459, 378);
            dtgvRegistroGeren.TabIndex = 17;
            dtgvRegistroGeren.Click += dtgvRegistroGeren_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerDetalle.BackColor = Color.FromArgb(128, 128, 255);
            btnVerDetalle.FlatAppearance.BorderSize = 0;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerDetalle.ForeColor = SystemColors.HighlightText;
            btnVerDetalle.Location = new Point(19, 408);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(134, 39);
            btnVerDetalle.TabIndex = 19;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // pnlEncabezadoEsta
            // 
            pnlEncabezadoEsta.BackColor = Color.FromArgb(47, 33, 75);
            pnlEncabezadoEsta.Controls.Add(label11);
            pnlEncabezadoEsta.Dock = DockStyle.Top;
            pnlEncabezadoEsta.Location = new Point(0, 0);
            pnlEncabezadoEsta.Name = "pnlEncabezadoEsta";
            pnlEncabezadoEsta.Size = new Size(893, 47);
            pnlEncabezadoEsta.TabIndex = 20;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(301, 0);
            label11.Name = "label11";
            label11.Size = new Size(296, 45);
            label11.TabIndex = 1;
            label11.Text = "Registro de ventas";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReiniciar.BackColor = Color.FromArgb(255, 128, 0);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = SystemColors.HighlightText;
            btnReiniciar.Location = new Point(173, 408);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(134, 39);
            btnReiniciar.TabIndex = 22;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // ModuloRegistroGeren
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(pnlRegistro);
            Name = "ModuloRegistroGeren";
            Text = "ModuloRegistroGeren";
            Load += ModuloRegistroGeren_Load;
            pnlRegistro.ResumeLayout(false);
            pnlFiltro.ResumeLayout(false);
            pnlFiltro.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvRegistroGeren).EndInit();
            pnlEncabezadoEsta.ResumeLayout(false);
            pnlEncabezadoEsta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegistro;
        private Button btnVerDetalle;
        private DataGridView dtgvRegistroGeren;
        private Panel pnlEncabezadoEsta;
        private Label label11;
        private Panel panel2;
        private Panel pnlFiltro;
        private Label label5;
        private Button btnAplicar;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFechaFin;
        private Label label2;
        private DateTimePicker dtpFechaInicio;
        private Panel panel3;
        private Button btnFiltroHisto;
        private Button btnFiltroSiete;
        private Button btnFiltroHoy;
        private Button btnFiltroTreinta;
        private Panel pnlDetalle;
        private DataGridView dtgvDetalleVenta;
        private Button btnReiniciar;
    }
}