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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 521);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 44);
            panel2.TabIndex = 15;
            // 
            // dataGridConsultas
            // 
            dataGridConsultas.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridConsultas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridConsultas.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridConsultas.BorderStyle = BorderStyle.None;
            dataGridConsultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.Padding = new Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsultas.Columns.AddRange(new DataGridViewColumn[] { Col_id_motivo_consulta, Col_motivo_consulta, Col_id_consulta, Col_comentario_consulta, Col_fecha_consulta, Col_estado_consulta, dataGridViewTextBoxColumn1, Col_id_Rol, Col_nombre_rol, Col_id_persona, Col_Dni, Col_nombre_persona, Col_Apellido_persona, Responder_Consulta, MarcarLeido });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridConsultas.Location = new Point(18, 159);
            dataGridConsultas.MultiSelect = false;
            dataGridConsultas.Name = "dataGridConsultas";
            dataGridConsultas.ReadOnly = true;
            dataGridConsultas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            Col_motivo_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_motivo_consulta.HeaderText = "Motivo Consulta";
            Col_motivo_consulta.Name = "Col_motivo_consulta";
            Col_motivo_consulta.ReadOnly = true;
            Col_motivo_consulta.Width = 120;
            // 
            // Col_id_consulta
            // 
            Col_id_consulta.HeaderText = "id_consulta";
            Col_id_consulta.Name = "Col_id_consulta";
            Col_id_consulta.ReadOnly = true;
            Col_id_consulta.Visible = false;
            Col_id_consulta.Width = 102;
            // 
            // Col_comentario_consulta
            // 
            Col_comentario_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_comentario_consulta.HeaderText = "Comentario Consulta";
            Col_comentario_consulta.Name = "Col_comentario_consulta";
            Col_comentario_consulta.ReadOnly = true;
            Col_comentario_consulta.Width = 260;
            // 
            // Col_fecha_consulta
            // 
            Col_fecha_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_fecha_consulta.HeaderText = "Fecha Consulta";
            Col_fecha_consulta.Name = "Col_fecha_consulta";
            Col_fecha_consulta.ReadOnly = true;
            Col_fecha_consulta.Width = 120;
            // 
            // Col_estado_consulta
            // 
            Col_estado_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_estado_consulta.HeaderText = "Estado Consulta";
            Col_estado_consulta.Name = "Col_estado_consulta";
            Col_estado_consulta.ReadOnly = true;
            Col_estado_consulta.Width = 120;
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
            Col_nombre_rol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_nombre_rol.HeaderText = "Rol";
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
            Col_Dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_Dni.HeaderText = "DNI";
            Col_Dni.Name = "Col_Dni";
            Col_Dni.ReadOnly = true;
            Col_Dni.Width = 120;
            // 
            // Col_nombre_persona
            // 
            Col_nombre_persona.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_nombre_persona.HeaderText = "Nombre";
            Col_nombre_persona.Name = "Col_nombre_persona";
            Col_nombre_persona.ReadOnly = true;
            Col_nombre_persona.Width = 120;
            // 
            // Col_Apellido_persona
            // 
            Col_Apellido_persona.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_Apellido_persona.HeaderText = "Apellido";
            Col_Apellido_persona.Name = "Col_Apellido_persona";
            Col_Apellido_persona.ReadOnly = true;
            Col_Apellido_persona.Width = 120;
            // 
            // Responder_Consulta
            // 
            Responder_Consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Responder_Consulta.HeaderText = "Responder";
            Responder_Consulta.Image = (Image)resources.GetObject("Responder_Consulta.Image");
            Responder_Consulta.Name = "Responder_Consulta";
            Responder_Consulta.ReadOnly = true;
            // 
            // MarcarLeido
            // 
            MarcarLeido.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MarcarLeido.HeaderText = "Marca Como Leido";
            MarcarLeido.Image = (Image)resources.GetObject("MarcarLeido.Image");
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
        private ComboBox comboMotivo;
    }
}