namespace CapaPresentacion.Formularios.Gerente.personal
{
    partial class FrmGestionarPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarPersonal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboTipoActFiltro = new ComboBox();
            txtUsuarioFiltro = new TextBox();
            iconBtnClean = new FontAwesome.Sharp.IconButton();
            dateTimePickActUsuFiltro = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblOperacionRealizadas = new Label();
            dataGridUsuarios = new DataGridView();
            estado_actividad_login = new DataGridViewTextBoxColumn();
            id_usuario_actividad = new DataGridViewTextBoxColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            nombre_actividad = new DataGridViewTextBoxColumn();
            fecha_usuario_actividad = new DataGridViewTextBoxColumn();
            dni_persona = new DataGridViewTextBoxColumn();
            nombre_persona = new DataGridViewTextBoxColumn();
            apellido_persona = new DataGridViewTextBoxColumn();
            email_usuario = new DataGridViewTextBoxColumn();
            rol_usuario = new DataGridViewTextBoxColumn();
            exportar_actividad = new DataGridViewTextBoxColumn();
            iconBtnExpRegistro = new FontAwesome.Sharp.IconButton();
            iconBtnResumActiv = new FontAwesome.Sharp.IconButton();
            iconBtnElimRegistros = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(comboTipoActFiltro);
            panel1.Controls.Add(txtUsuarioFiltro);
            panel1.Controls.Add(iconBtnClean);
            panel1.Controls.Add(dateTimePickActUsuFiltro);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblOperacionRealizadas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 13;
            // 
            // comboTipoActFiltro
            // 
            comboTipoActFiltro.FormattingEnabled = true;
            comboTipoActFiltro.Location = new Point(369, 57);
            comboTipoActFiltro.Name = "comboTipoActFiltro";
            comboTipoActFiltro.Size = new Size(121, 23);
            comboTipoActFiltro.TabIndex = 39;
            // 
            // txtUsuarioFiltro
            // 
            txtUsuarioFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioFiltro.ForeColor = Color.Silver;
            txtUsuarioFiltro.Location = new Point(147, 60);
            txtUsuarioFiltro.Multiline = true;
            txtUsuarioFiltro.Name = "txtUsuarioFiltro";
            txtUsuarioFiltro.PlaceholderText = "Dni";
            txtUsuarioFiltro.Size = new Size(97, 20);
            txtUsuarioFiltro.TabIndex = 38;
            // 
            // iconBtnClean
            // 
            iconBtnClean.BackColor = Color.FromArgb(255, 50, 50);
            iconBtnClean.BackgroundImage = (Image)resources.GetObject("iconBtnClean.BackgroundImage");
            iconBtnClean.BackgroundImageLayout = ImageLayout.Stretch;
            iconBtnClean.Cursor = Cursors.Hand;
            iconBtnClean.FlatAppearance.BorderColor = Color.Black;
            iconBtnClean.FlatStyle = FlatStyle.Flat;
            iconBtnClean.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnClean.ForeColor = SystemColors.ControlLightLight;
            iconBtnClean.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnClean.IconColor = Color.White;
            iconBtnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnClean.IconSize = 30;
            iconBtnClean.Location = new Point(647, 59);
            iconBtnClean.Name = "iconBtnClean";
            iconBtnClean.Size = new Size(25, 23);
            iconBtnClean.TabIndex = 36;
            iconBtnClean.TextAlign = ContentAlignment.MiddleRight;
            iconBtnClean.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnClean.UseVisualStyleBackColor = false;
            iconBtnClean.Click += iconBtnClean_Click;
            // 
            // dateTimePickActUsuFiltro
            // 
            dateTimePickActUsuFiltro.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickActUsuFiltro.Format = DateTimePickerFormat.Short;
            dateTimePickActUsuFiltro.Location = new Point(545, 57);
            dateTimePickActUsuFiltro.Name = "dateTimePickActUsuFiltro";
            dateTimePickActUsuFiltro.Size = new Size(88, 23);
            dateTimePickActUsuFiltro.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(250, 60);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 34;
            label2.Text = "Tipo de actividad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(95, 59);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 33;
            label3.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 51);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 30;
            label5.Text = "Filtrar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(496, 57);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 32;
            label4.Text = "Fecha";
            // 
            // lblOperacionRealizadas
            // 
            lblOperacionRealizadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOperacionRealizadas.AutoSize = true;
            lblOperacionRealizadas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacionRealizadas.ForeColor = SystemColors.ControlLightLight;
            lblOperacionRealizadas.ImageAlign = ContentAlignment.TopCenter;
            lblOperacionRealizadas.Location = new Point(118, 0);
            lblOperacionRealizadas.Name = "lblOperacionRealizadas";
            lblOperacionRealizadas.Size = new Size(589, 45);
            lblOperacionRealizadas.TabIndex = 0;
            lblOperacionRealizadas.Text = "Registro de Actividad De Los Usuarios";
            lblOperacionRealizadas.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { estado_actividad_login, id_usuario_actividad, id_usuario, nombre_actividad, fecha_usuario_actividad, dni_persona, nombre_persona, apellido_persona, email_usuario, rol_usuario, exportar_actividad });
            dataGridUsuarios.Location = new Point(16, 166);
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
            dataGridUsuarios.Size = new Size(768, 360);
            dataGridUsuarios.TabIndex = 14;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // estado_actividad_login
            // 
            estado_actividad_login.HeaderText = "Estado";
            estado_actividad_login.Name = "estado_actividad_login";
            estado_actividad_login.ReadOnly = true;
            estado_actividad_login.Width = 74;
            // 
            // id_usuario_actividad
            // 
            id_usuario_actividad.HeaderText = "id_usuario_actividad";
            id_usuario_actividad.Name = "id_usuario_actividad";
            id_usuario_actividad.ReadOnly = true;
            id_usuario_actividad.Visible = false;
            id_usuario_actividad.Width = 157;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "id_usuario";
            id_usuario.Name = "id_usuario";
            id_usuario.ReadOnly = true;
            id_usuario.Visible = false;
            id_usuario.Width = 95;
            // 
            // nombre_actividad
            // 
            nombre_actividad.HeaderText = "tipo de actividad";
            nombre_actividad.Name = "nombre_actividad";
            nombre_actividad.ReadOnly = true;
            nombre_actividad.Width = 125;
            // 
            // fecha_usuario_actividad
            // 
            fecha_usuario_actividad.HeaderText = "Fecha";
            fecha_usuario_actividad.Name = "fecha_usuario_actividad";
            fecha_usuario_actividad.ReadOnly = true;
            fecha_usuario_actividad.Width = 73;
            // 
            // dni_persona
            // 
            dni_persona.HeaderText = "DNI";
            dni_persona.Name = "dni_persona";
            dni_persona.ReadOnly = true;
            dni_persona.Width = 57;
            // 
            // nombre_persona
            // 
            nombre_persona.HeaderText = "Nombre";
            nombre_persona.Name = "nombre_persona";
            nombre_persona.ReadOnly = true;
            nombre_persona.Width = 84;
            // 
            // apellido_persona
            // 
            apellido_persona.HeaderText = "Apellido";
            apellido_persona.Name = "apellido_persona";
            apellido_persona.ReadOnly = true;
            apellido_persona.Width = 86;
            // 
            // email_usuario
            // 
            email_usuario.HeaderText = "Email";
            email_usuario.Name = "email_usuario";
            email_usuario.ReadOnly = true;
            email_usuario.Width = 67;
            // 
            // rol_usuario
            // 
            rol_usuario.HeaderText = "Rol Del Usuario";
            rol_usuario.MinimumWidth = 10;
            rol_usuario.Name = "rol_usuario";
            rol_usuario.ReadOnly = true;
            rol_usuario.Width = 112;
            // 
            // exportar_actividad
            // 
            exportar_actividad.HeaderText = "Exportar ";
            exportar_actividad.Name = "exportar_actividad";
            exportar_actividad.ReadOnly = true;
            exportar_actividad.Width = 87;
            // 
            // iconBtnExpRegistro
            // 
            iconBtnExpRegistro.BackColor = Color.Orange;
            iconBtnExpRegistro.BackgroundImage = (Image)resources.GetObject("iconBtnExpRegistro.BackgroundImage");
            iconBtnExpRegistro.BackgroundImageLayout = ImageLayout.None;
            iconBtnExpRegistro.Cursor = Cursors.Hand;
            iconBtnExpRegistro.FlatAppearance.BorderColor = Color.Black;
            iconBtnExpRegistro.FlatStyle = FlatStyle.Flat;
            iconBtnExpRegistro.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnExpRegistro.ForeColor = SystemColors.ControlLightLight;
            iconBtnExpRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnExpRegistro.IconColor = Color.White;
            iconBtnExpRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnExpRegistro.IconSize = 30;
            iconBtnExpRegistro.Location = new Point(95, 98);
            iconBtnExpRegistro.Name = "iconBtnExpRegistro";
            iconBtnExpRegistro.Size = new Size(99, 38);
            iconBtnExpRegistro.TabIndex = 22;
            iconBtnExpRegistro.Text = "Exportar Registros";
            iconBtnExpRegistro.TextAlign = ContentAlignment.MiddleRight;
            iconBtnExpRegistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnExpRegistro.UseVisualStyleBackColor = false;
            // 
            // iconBtnResumActiv
            // 
            iconBtnResumActiv.BackColor = Color.Orange;
            iconBtnResumActiv.BackgroundImage = (Image)resources.GetObject("iconBtnResumActiv.BackgroundImage");
            iconBtnResumActiv.BackgroundImageLayout = ImageLayout.None;
            iconBtnResumActiv.Cursor = Cursors.Hand;
            iconBtnResumActiv.FlatAppearance.BorderColor = Color.Black;
            iconBtnResumActiv.FlatStyle = FlatStyle.Flat;
            iconBtnResumActiv.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnResumActiv.ForeColor = SystemColors.ControlLightLight;
            iconBtnResumActiv.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnResumActiv.IconColor = Color.White;
            iconBtnResumActiv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnResumActiv.IconSize = 30;
            iconBtnResumActiv.Location = new Point(345, 98);
            iconBtnResumActiv.Name = "iconBtnResumActiv";
            iconBtnResumActiv.Size = new Size(111, 38);
            iconBtnResumActiv.TabIndex = 24;
            iconBtnResumActiv.Text = "Resumen de Actividad";
            iconBtnResumActiv.TextAlign = ContentAlignment.MiddleRight;
            iconBtnResumActiv.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnResumActiv.UseVisualStyleBackColor = false;
            iconBtnResumActiv.Click += iconBtnResumActiv_Click;
            // 
            // iconBtnElimRegistros
            // 
            iconBtnElimRegistros.BackColor = Color.Orange;
            iconBtnElimRegistros.BackgroundImage = (Image)resources.GetObject("iconBtnElimRegistros.BackgroundImage");
            iconBtnElimRegistros.BackgroundImageLayout = ImageLayout.None;
            iconBtnElimRegistros.Cursor = Cursors.Hand;
            iconBtnElimRegistros.FlatAppearance.BorderColor = Color.Black;
            iconBtnElimRegistros.FlatStyle = FlatStyle.Flat;
            iconBtnElimRegistros.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnElimRegistros.ForeColor = SystemColors.ControlLightLight;
            iconBtnElimRegistros.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnElimRegistros.IconColor = Color.White;
            iconBtnElimRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnElimRegistros.IconSize = 30;
            iconBtnElimRegistros.Location = new Point(215, 98);
            iconBtnElimRegistros.Name = "iconBtnElimRegistros";
            iconBtnElimRegistros.Size = new Size(99, 38);
            iconBtnElimRegistros.TabIndex = 25;
            iconBtnElimRegistros.Text = "Eliminar Registros";
            iconBtnElimRegistros.TextAlign = ContentAlignment.MiddleRight;
            iconBtnElimRegistros.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnElimRegistros.UseVisualStyleBackColor = false;
            // 
            // FrmGestionarPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(iconBtnElimRegistros);
            Controls.Add(iconBtnResumActiv);
            Controls.Add(iconBtnExpRegistro);
            Controls.Add(dataGridUsuarios);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmGestionarPersonal";
            Text = "Log Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuarioFiltro;
        private FontAwesome.Sharp.IconButton iconBtnClean;
        private DateTimePicker dateTimePickActUsuFiltro;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label lblOperacionRealizadas;
        private DataGridView dataGridUsuarios;
        private ComboBox comboTipoActFiltro;
        private FontAwesome.Sharp.IconButton iconBtnExpRegistro;
        private FontAwesome.Sharp.IconButton iconBtnResumActiv;
        private FontAwesome.Sharp.IconButton iconBtnElimRegistros;
        private DataGridViewTextBoxColumn estado_actividad_login;
        private DataGridViewTextBoxColumn id_usuario_actividad;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn nombre_actividad;
        private DataGridViewTextBoxColumn fecha_usuario_actividad;
        private DataGridViewTextBoxColumn dni_persona;
        private DataGridViewTextBoxColumn nombre_persona;
        private DataGridViewTextBoxColumn apellido_persona;
        private DataGridViewTextBoxColumn email_usuario;
        private DataGridViewTextBoxColumn rol_usuario;
        private DataGridViewTextBoxColumn exportar_actividad;
    }
}