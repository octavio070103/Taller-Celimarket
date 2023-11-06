namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmGestionarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarConsulta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboMotivo = new ComboBox();
            lblRolFiltro = new Label();
            comboFiltroRol = new ComboBox();
            comboFiltroEstado = new ComboBox();
            lblEstado = new Label();
            txtDniFiltro = new TextBox();
            label2 = new Label();
            iconbtnClean = new FontAwesome.Sharp.IconButton();
            dateTimeFiltro = new DateTimePicker();
            lblMotivoConsulta = new Label();
            lblDni = new Label();
            lblListaConsultas = new Label();
            panel2 = new Panel();
            iconBtnExcel = new FontAwesome.Sharp.IconButton();
            dataGridConsultas = new DataGridView();
            Col_id_motivo_consulta = new DataGridViewTextBoxColumn();
            Col_motivo_consulta = new DataGridViewTextBoxColumn();
            Col_id_consulta = new DataGridViewTextBoxColumn();
            Col_comentario_consulta = new DataGridViewTextBoxColumn();
            Col_fecha_consulta = new DataGridViewTextBoxColumn();
            Col_estado_consulta = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Col_id_Rol = new DataGridViewTextBoxColumn();
            Col_nombre_rol = new DataGridViewTextBoxColumn();
            Col_id_persona = new DataGridViewTextBoxColumn();
            Col_Dni = new DataGridViewTextBoxColumn();
            Col_nombre_persona = new DataGridViewTextBoxColumn();
            Col_Apellido_persona = new DataGridViewTextBoxColumn();
            Responder_Consulta = new DataGridViewImageColumn();
            MarcarLeido = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(comboMotivo);
            panel1.Controls.Add(lblRolFiltro);
            panel1.Controls.Add(comboFiltroRol);
            panel1.Controls.Add(comboFiltroEstado);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(txtDniFiltro);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconbtnClean);
            panel1.Controls.Add(dateTimeFiltro);
            panel1.Controls.Add(lblMotivoConsulta);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblListaConsultas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 1;
            // 
            // comboMotivo
            // 
            comboMotivo.FlatStyle = FlatStyle.Popup;
            comboMotivo.FormattingEnabled = true;
            comboMotivo.Location = new Point(230, 58);
            comboMotivo.Name = "comboMotivo";
            comboMotivo.Size = new Size(94, 23);
            comboMotivo.TabIndex = 39;
            comboMotivo.Text = "Filtrar Motivo";
            comboMotivo.SelectedIndexChanged += comboMotivo_SelectedIndexChanged;
            // 
            // lblRolFiltro
            // 
            lblRolFiltro.AutoSize = true;
            lblRolFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolFiltro.ForeColor = SystemColors.ControlLightLight;
            lblRolFiltro.Location = new Point(619, 60);
            lblRolFiltro.Name = "lblRolFiltro";
            lblRolFiltro.Size = new Size(28, 17);
            lblRolFiltro.TabIndex = 38;
            lblRolFiltro.Text = "Rol";
            // 
            // comboFiltroRol
            // 
            comboFiltroRol.FlatStyle = FlatStyle.Popup;
            comboFiltroRol.FormattingEnabled = true;
            comboFiltroRol.Location = new Point(653, 58);
            comboFiltroRol.Name = "comboFiltroRol";
            comboFiltroRol.Size = new Size(88, 23);
            comboFiltroRol.TabIndex = 37;
            comboFiltroRol.Text = "Filtrar Rol";
            comboFiltroRol.SelectedIndexChanged += comboFiltroRol_SelectedIndexChanged;
            // 
            // comboFiltroEstado
            // 
            comboFiltroEstado.FlatStyle = FlatStyle.Popup;
            comboFiltroEstado.FormattingEnabled = true;
            comboFiltroEstado.Location = new Point(527, 58);
            comboFiltroEstado.Name = "comboFiltroEstado";
            comboFiltroEstado.Size = new Size(88, 23);
            comboFiltroEstado.TabIndex = 36;
            comboFiltroEstado.Text = "Filtrar Estado";
            comboFiltroEstado.SelectedIndexChanged += comboFiltroEstado_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.ControlLightLight;
            lblEstado.Location = new Point(468, 62);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 35;
            lblEstado.Text = "Estado";
            // 
            // txtDniFiltro
            // 
            txtDniFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniFiltro.ForeColor = Color.Silver;
            txtDniFiltro.Location = new Point(365, 60);
            txtDniFiltro.Multiline = true;
            txtDniFiltro.Name = "txtDniFiltro";
            txtDniFiltro.PlaceholderText = "Filtrar DNI";
            txtDniFiltro.Size = new Size(97, 20);
            txtDniFiltro.TabIndex = 34;
            txtDniFiltro.TextChanged += txtDniFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(334, 62);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 29;
            label2.Text = "DNI ";
            // 
            // iconbtnClean
            // 
            iconbtnClean.BackColor = Color.FromArgb(255, 50, 50);
            iconbtnClean.BackgroundImage = (Image)resources.GetObject("iconbtnClean.BackgroundImage");
            iconbtnClean.BackgroundImageLayout = ImageLayout.Stretch;
            iconbtnClean.Cursor = Cursors.Hand;
            iconbtnClean.FlatAppearance.BorderColor = Color.Black;
            iconbtnClean.FlatStyle = FlatStyle.Flat;
            iconbtnClean.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnClean.ForeColor = SystemColors.ControlLightLight;
            iconbtnClean.IconChar = FontAwesome.Sharp.IconChar.None;
            iconbtnClean.IconColor = Color.White;
            iconbtnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnClean.IconSize = 30;
            iconbtnClean.Location = new Point(779, 56);
            iconbtnClean.Name = "iconbtnClean";
            iconbtnClean.Size = new Size(25, 23);
            iconbtnClean.TabIndex = 26;
            iconbtnClean.TextAlign = ContentAlignment.MiddleRight;
            iconbtnClean.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnClean.UseVisualStyleBackColor = false;
            iconbtnClean.Click += iconbtnClean_Click;
            // 
            // dateTimeFiltro
            // 
            dateTimeFiltro.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeFiltro.Format = DateTimePickerFormat.Short;
            dateTimeFiltro.Location = new Point(60, 60);
            dateTimeFiltro.Name = "dateTimeFiltro";
            dateTimeFiltro.Size = new Size(88, 23);
            dateTimeFiltro.TabIndex = 2;
            dateTimeFiltro.ValueChanged += dateTimeFiltro_ValueChanged;
            // 
            // lblMotivoConsulta
            // 
            lblMotivoConsulta.AutoSize = true;
            lblMotivoConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMotivoConsulta.ForeColor = SystemColors.ControlLightLight;
            lblMotivoConsulta.Location = new Point(172, 62);
            lblMotivoConsulta.Name = "lblMotivoConsulta";
            lblMotivoConsulta.Size = new Size(52, 17);
            lblMotivoConsulta.TabIndex = 6;
            lblMotivoConsulta.Text = "Motivo";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlLightLight;
            lblDni.Location = new Point(11, 60);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 17);
            lblDni.TabIndex = 4;
            lblDni.Text = "Fecha";
            // 
            // lblListaConsultas
            // 
            lblListaConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaConsultas.AutoSize = true;
            lblListaConsultas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaConsultas.ForeColor = SystemColors.ControlLightLight;
            lblListaConsultas.ImageAlign = ContentAlignment.TopCenter;
            lblListaConsultas.Location = new Point(278, 0);
            lblListaConsultas.Name = "lblListaConsultas";
            lblListaConsultas.Size = new Size(291, 45);
            lblListaConsultas.TabIndex = 0;
            lblListaConsultas.Text = "Lista De Consultas";
            lblListaConsultas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconBtnExcel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 521);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 44);
            panel2.TabIndex = 15;
            // 
            // iconBtnExcel
            // 
            iconBtnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconBtnExcel.BackColor = Color.DarkGray;
            iconBtnExcel.BackgroundImage = (Image)resources.GetObject("iconBtnExcel.BackgroundImage");
            iconBtnExcel.BackgroundImageLayout = ImageLayout.None;
            iconBtnExcel.Cursor = Cursors.Hand;
            iconBtnExcel.FlatAppearance.BorderColor = Color.Black;
            iconBtnExcel.FlatStyle = FlatStyle.Flat;
            iconBtnExcel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnExcel.ForeColor = SystemColors.ControlLightLight;
            iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnExcel.IconColor = Color.White;
            iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnExcel.IconSize = 30;
            iconBtnExcel.Location = new Point(22, 5);
            iconBtnExcel.Name = "iconBtnExcel";
            iconBtnExcel.Size = new Size(126, 27);
            iconBtnExcel.TabIndex = 20;
            iconBtnExcel.Text = "Descargar Excel";
            iconBtnExcel.TextAlign = ContentAlignment.MiddleRight;
            iconBtnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnExcel.UseVisualStyleBackColor = false;
            iconBtnExcel.Click += iconBtnExcel_Click;
            // 
            // dataGridConsultas
            // 
            dataGridConsultas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridConsultas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridConsultas.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridConsultas.BorderStyle = BorderStyle.None;
            dataGridConsultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsultas.Columns.AddRange(new DataGridViewColumn[] { Col_id_motivo_consulta, Col_motivo_consulta, Col_id_consulta, Col_comentario_consulta, Col_fecha_consulta, Col_estado_consulta, dataGridViewTextBoxColumn1, Col_id_Rol, Col_nombre_rol, Col_id_persona, Col_Dni, Col_nombre_persona, Col_Apellido_persona, Responder_Consulta, MarcarLeido });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridConsultas.GridColor = SystemColors.ActiveCaptionText;
            dataGridConsultas.Location = new Point(18, 159);
            dataGridConsultas.MultiSelect = false;
            dataGridConsultas.Name = "dataGridConsultas";
            dataGridConsultas.ReadOnly = true;
            dataGridConsultas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridConsultas.RowHeadersVisible = false;
            dataGridConsultas.RowTemplate.Height = 28;
            dataGridConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridConsultas.Size = new Size(795, 353);
            dataGridConsultas.TabIndex = 36;
            dataGridConsultas.CellClick += dataGridConsultas_CellClick;
            // 
            // Col_id_motivo_consulta
            // 
            Col_id_motivo_consulta.HeaderText = "id_motivo_consulta";
            Col_id_motivo_consulta.Name = "Col_id_motivo_consulta";
            Col_id_motivo_consulta.ReadOnly = true;
            Col_id_motivo_consulta.Visible = false;
            Col_id_motivo_consulta.Width = 129;
            // 
            // Col_motivo_consulta
            // 
            Col_motivo_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_motivo_consulta.HeaderText = "Motivo Consulta";
            Col_motivo_consulta.MinimumWidth = 120;
            Col_motivo_consulta.Name = "Col_motivo_consulta";
            Col_motivo_consulta.ReadOnly = true;
            // 
            // Col_id_consulta
            // 
            Col_id_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_id_consulta.HeaderText = "id_consulta";
            Col_id_consulta.MinimumWidth = 102;
            Col_id_consulta.Name = "Col_id_consulta";
            Col_id_consulta.ReadOnly = true;
            Col_id_consulta.Visible = false;
            // 
            // Col_comentario_consulta
            // 
            Col_comentario_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_comentario_consulta.HeaderText = "Comentario Consulta";
            Col_comentario_consulta.MinimumWidth = 260;
            Col_comentario_consulta.Name = "Col_comentario_consulta";
            Col_comentario_consulta.ReadOnly = true;
            // 
            // Col_fecha_consulta
            // 
            Col_fecha_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_fecha_consulta.HeaderText = "Fecha Consulta";
            Col_fecha_consulta.MinimumWidth = 120;
            Col_fecha_consulta.Name = "Col_fecha_consulta";
            Col_fecha_consulta.ReadOnly = true;
            // 
            // Col_estado_consulta
            // 
            Col_estado_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_estado_consulta.HeaderText = "Estado Consulta";
            Col_estado_consulta.MinimumWidth = 120;
            Col_estado_consulta.Name = "Col_estado_consulta";
            Col_estado_consulta.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "id_usuario";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 95;
            // 
            // Col_id_Rol
            // 
            Col_id_Rol.HeaderText = "id_rol";
            Col_id_Rol.Name = "Col_id_Rol";
            Col_id_Rol.ReadOnly = true;
            Col_id_Rol.Visible = false;
            Col_id_Rol.Width = 68;
            // 
            // Col_nombre_rol
            // 
            Col_nombre_rol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_nombre_rol.HeaderText = "Rol";
            Col_nombre_rol.MinimumWidth = 100;
            Col_nombre_rol.Name = "Col_nombre_rol";
            Col_nombre_rol.ReadOnly = true;
            // 
            // Col_id_persona
            // 
            Col_id_persona.HeaderText = "id_persona";
            Col_id_persona.Name = "Col_id_persona";
            Col_id_persona.ReadOnly = true;
            Col_id_persona.Visible = false;
            Col_id_persona.Width = 101;
            // 
            // Col_Dni
            // 
            Col_Dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Dni.HeaderText = "DNI";
            Col_Dni.MinimumWidth = 120;
            Col_Dni.Name = "Col_Dni";
            Col_Dni.ReadOnly = true;
            // 
            // Col_nombre_persona
            // 
            Col_nombre_persona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_nombre_persona.HeaderText = "Nombre";
            Col_nombre_persona.MinimumWidth = 120;
            Col_nombre_persona.Name = "Col_nombre_persona";
            Col_nombre_persona.ReadOnly = true;
            // 
            // Col_Apellido_persona
            // 
            Col_Apellido_persona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Col_Apellido_persona.HeaderText = "Apellido";
            Col_Apellido_persona.MinimumWidth = 120;
            Col_Apellido_persona.Name = "Col_Apellido_persona";
            Col_Apellido_persona.ReadOnly = true;
            // 
            // Responder_Consulta
            // 
            Responder_Consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Responder_Consulta.HeaderText = "Responder";
            Responder_Consulta.Image = (Image)resources.GetObject("Responder_Consulta.Image");
            Responder_Consulta.MinimumWidth = 80;
            Responder_Consulta.Name = "Responder_Consulta";
            Responder_Consulta.ReadOnly = true;
            // 
            // MarcarLeido
            // 
            MarcarLeido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MarcarLeido.HeaderText = "Marca Como Leido";
            MarcarLeido.Image = (Image)resources.GetObject("MarcarLeido.Image");
            MarcarLeido.MinimumWidth = 90;
            MarcarLeido.Name = "MarcarLeido";
            MarcarLeido.ReadOnly = true;
            // 
            // FrmGestionarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridConsultas);
            MinimumSize = new Size(838, 604);
            Name = "FrmGestionarConsulta";
            Text = "Gestionar Consultas ";
            Load += FrmGestionarConsulta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDni;
        private Label lblListaConsultas;
        private DateTimePicker dateTimeFiltro;
        private FontAwesome.Sharp.IconButton iconbtnClean;
        private Label lblFechaNac;
        private TextBox txtDomiciliodato;
        private Label lblDomicilioDato;
        private TextBox textBox3;
        private Panel panel2;
        private Label lblMotivoConsulta;
        private ComboBox comboFiltroEstado;
        private Label lblEstado;
        private TextBox txtDniFiltro;
        private Label label2;
        private Label lblRolFiltro;
        private ComboBox comboFiltroRol;
        private DataGridView dataGridConsultas;
        private ComboBox comboMotivo;
        private DataGridViewTextBoxColumn Col_id_motivo_consulta;
        private DataGridViewTextBoxColumn Col_motivo_consulta;
        private DataGridViewTextBoxColumn Col_id_consulta;
        private DataGridViewTextBoxColumn Col_comentario_consulta;
        private DataGridViewTextBoxColumn Col_fecha_consulta;
        private DataGridViewTextBoxColumn Col_estado_consulta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Col_id_Rol;
        private DataGridViewTextBoxColumn Col_nombre_rol;
        private DataGridViewTextBoxColumn Col_id_persona;
        private DataGridViewTextBoxColumn Col_Dni;
        private DataGridViewTextBoxColumn Col_nombre_persona;
        private DataGridViewTextBoxColumn Col_Apellido_persona;
        private DataGridViewImageColumn Responder_Consulta;
        private DataGridViewImageColumn MarcarLeido;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
    }
}