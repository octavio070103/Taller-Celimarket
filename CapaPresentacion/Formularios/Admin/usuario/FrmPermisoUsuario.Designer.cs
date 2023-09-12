namespace CapaPresentacion.Formularios.Admin.usuario
{
    partial class FrmPermisoUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtEmpleado = new TextBox();
            txtTipo = new TextBox();
            textBox2 = new TextBox();
            lblFecha = new Label();
            lblTipo = new Label();
            lblEmpleado = new Label();
            lblFiltrar = new Label();
            lblPermisoUsu = new Label();
            iconBtnAprobar = new FontAwesome.Sharp.IconButton();
            dataGridUsuarios = new DataGridView();
            panel2 = new Panel();
            lblDatosUsuario = new Label();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            iconBtnRechazar = new FontAwesome.Sharp.IconButton();
            iconBtnHistorial = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(txtEmpleado);
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lblFiltrar);
            panel1.Controls.Add(lblPermisoUsu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 92);
            panel1.TabIndex = 1;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpleado.ForeColor = Color.Silver;
            txtEmpleado.Location = new Point(246, 58);
            txtEmpleado.Multiline = true;
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(97, 20);
            txtEmpleado.TabIndex = 11;
            txtEmpleado.Text = "Empleado";
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.ForeColor = Color.Silver;
            txtTipo.Location = new Point(405, 61);
            txtTipo.Multiline = true;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(102, 20);
            txtTipo.TabIndex = 10;
            txtTipo.Text = "Tipo de Permiso";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(582, 61);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 20);
            textBox2.TabIndex = 9;
            textBox2.Text = "Fecha";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(533, 62);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 17);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = SystemColors.ControlLightLight;
            lblTipo.Location = new Point(363, 61);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpleado.ForeColor = SystemColors.ControlLightLight;
            lblEmpleado.Location = new Point(171, 59);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(69, 17);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado";
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltrar.ForeColor = SystemColors.ControlLightLight;
            lblFiltrar.Location = new Point(80, 51);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(71, 25);
            lblFiltrar.TabIndex = 1;
            lblFiltrar.Text = "Filtrar:";
            // 
            // lblPermisoUsu
            // 
            lblPermisoUsu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPermisoUsu.AutoSize = true;
            lblPermisoUsu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermisoUsu.ForeColor = SystemColors.ControlLightLight;
            lblPermisoUsu.ImageAlign = ContentAlignment.TopCenter;
            lblPermisoUsu.Location = new Point(267, 0);
            lblPermisoUsu.Name = "lblPermisoUsu";
            lblPermisoUsu.Size = new Size(282, 45);
            lblPermisoUsu.TabIndex = 0;
            lblPermisoUsu.Text = "Lista De Permisos";
            lblPermisoUsu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconBtnAprobar
            // 
            iconBtnAprobar.BackColor = Color.FromArgb(19, 173, 39);
            iconBtnAprobar.Cursor = Cursors.Hand;
            iconBtnAprobar.FlatAppearance.BorderColor = Color.Black;
            iconBtnAprobar.FlatStyle = FlatStyle.Flat;
            iconBtnAprobar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnAprobar.ForeColor = SystemColors.ControlLightLight;
            iconBtnAprobar.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconBtnAprobar.IconColor = Color.White;
            iconBtnAprobar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAprobar.IconSize = 30;
            iconBtnAprobar.Location = new Point(80, 98);
            iconBtnAprobar.Name = "iconBtnAprobar";
            iconBtnAprobar.Size = new Size(89, 39);
            iconBtnAprobar.TabIndex = 8;
            iconBtnAprobar.Text = "Aprobar";
            iconBtnAprobar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAprobar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAprobar.UseVisualStyleBackColor = false;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.White;
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(80, 161);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridUsuarios.RowTemplate.Height = 25;
            dataGridUsuarios.Size = new Size(427, 277);
            dataGridUsuarios.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblDatosUsuario);
            panel2.Location = new Point(550, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 340);
            panel2.TabIndex = 10;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(76, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(87, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Detalles";
            // 
            // iconBtnModif
            // 
            iconBtnModif.BackColor = Color.FromArgb(56, 182, 255);
            iconBtnModif.Cursor = Cursors.Hand;
            iconBtnModif.FlatAppearance.BorderColor = Color.Black;
            iconBtnModif.FlatStyle = FlatStyle.Flat;
            iconBtnModif.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnModif.ForeColor = SystemColors.ControlLightLight;
            iconBtnModif.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconBtnModif.IconColor = Color.White;
            iconBtnModif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnModif.IconSize = 30;
            iconBtnModif.Location = new Point(185, 98);
            iconBtnModif.Name = "iconBtnModif";
            iconBtnModif.Size = new Size(96, 39);
            iconBtnModif.TabIndex = 13;
            iconBtnModif.Text = "Modificar";
            iconBtnModif.TextAlign = ContentAlignment.MiddleRight;
            iconBtnModif.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnModif.UseVisualStyleBackColor = false;
            // 
            // iconBtnRechazar
            // 
            iconBtnRechazar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnRechazar.Cursor = Cursors.Hand;
            iconBtnRechazar.FlatAppearance.BorderColor = Color.Black;
            iconBtnRechazar.FlatStyle = FlatStyle.Flat;
            iconBtnRechazar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnRechazar.ForeColor = SystemColors.ControlLightLight;
            iconBtnRechazar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnRechazar.IconColor = Color.White;
            iconBtnRechazar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnRechazar.IconSize = 30;
            iconBtnRechazar.Location = new Point(298, 98);
            iconBtnRechazar.Name = "iconBtnRechazar";
            iconBtnRechazar.Size = new Size(101, 39);
            iconBtnRechazar.TabIndex = 14;
            iconBtnRechazar.Text = "Rechazar";
            iconBtnRechazar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRechazar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRechazar.UseVisualStyleBackColor = false;
            // 
            // iconBtnHistorial
            // 
            iconBtnHistorial.BackColor = Color.FromArgb(216, 103, 30);
            iconBtnHistorial.Cursor = Cursors.Hand;
            iconBtnHistorial.FlatAppearance.BorderColor = Color.Black;
            iconBtnHistorial.FlatStyle = FlatStyle.Flat;
            iconBtnHistorial.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnHistorial.ForeColor = SystemColors.ControlLightLight;
            iconBtnHistorial.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconBtnHistorial.IconColor = Color.White;
            iconBtnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnHistorial.IconSize = 30;
            iconBtnHistorial.Location = new Point(417, 98);
            iconBtnHistorial.Name = "iconBtnHistorial";
            iconBtnHistorial.Size = new Size(90, 39);
            iconBtnHistorial.TabIndex = 15;
            iconBtnHistorial.Text = "Historial";
            iconBtnHistorial.TextAlign = ContentAlignment.MiddleRight;
            iconBtnHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnHistorial.UseVisualStyleBackColor = false;
            // 
            // FrmPermisoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(800, 450);
            Controls.Add(iconBtnHistorial);
            Controls.Add(iconBtnRechazar);
            Controls.Add(iconBtnModif);
            Controls.Add(panel2);
            Controls.Add(dataGridUsuarios);
            Controls.Add(iconBtnAprobar);
            Controls.Add(panel1);
            Name = "FrmPermisoUsuario";
            Text = "Permiso de Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmpleado;
        private TextBox txtTipo;
        private TextBox textBox2;
        private Label lblFecha;
        private Label lblTipo;
        private Label lblEmpleado;
        private Label lblFiltrar;
        private Label lblPermisoUsu;
        private FontAwesome.Sharp.IconButton iconBtnAprobar;
        private DataGridView dataGridUsuarios;
        private Panel panel2;
        private Label lblDatosUsuario;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private FontAwesome.Sharp.IconButton iconBtnRechazar;
        private FontAwesome.Sharp.IconButton iconBtnHistorial;
    }
}