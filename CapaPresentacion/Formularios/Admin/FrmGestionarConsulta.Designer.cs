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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtTipoFiltro = new TextBox();
            txtUsuarioFiltro = new TextBox();
            iconbtnClean = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            lblFiltrar = new Label();
            lblListaConsultas = new Label();
            btnResponder = new FontAwesome.Sharp.IconButton();
            iconBtnMarcar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconBtnEliminar = new FontAwesome.Sharp.IconButton();
            dataGridUsuarios = new DataGridView();
            col_id_usuario = new DataGridViewTextBoxColumn();
            col_dni = new DataGridViewTextBoxColumn();
            col_nombre = new DataGridViewTextBoxColumn();
            col_apellido = new DataGridViewTextBoxColumn();
            col_email = new DataGridViewTextBoxColumn();
            col_password = new DataGridViewTextBoxColumn();
            col_telefono = new DataGridViewTextBoxColumn();
            col_id_rol = new DataGridViewTextBoxColumn();
            col_Rol = new DataGridViewTextBoxColumn();
            col_id_domicilio = new DataGridViewTextBoxColumn();
            col_domicilio_calle = new DataGridViewTextBoxColumn();
            col_domicilio_numero = new DataGridViewTextBoxColumn();
            col_domicilio_prov = new DataGridViewTextBoxColumn();
            Estado_Valor = new DataGridViewTextBoxColumn();
            col_estado = new DataGridViewTextBoxColumn();
            panelDatosConsulta = new Panel();
            dateTimePickerEnvioDato = new DateTimePicker();
            lblFecha = new Label();
            lblAsunto = new Label();
            txtAsuntoDato = new TextBox();
            iconbtnLeido = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblMotivo = new Label();
            txtMotivoDato = new TextBox();
            lblEstadoDato = new Label();
            comboTipoConsulta = new ComboBox();
            lblEmailDato = new Label();
            txtEmailDato = new TextBox();
            lblTipoDato = new Label();
            lblDniDato = new Label();
            txtDniDato = new TextBox();
            txtApeDato = new TextBox();
            lblApellidoDato = new Label();
            lblNombreDato = new Label();
            txtNombreDato = new TextBox();
            lblDatosConsulta = new Label();
            iconBtnNoLeido = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            comboFiltroRol = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panelDatosConsulta.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(comboFiltroRol);
            panel1.Controls.Add(txtTipoFiltro);
            panel1.Controls.Add(txtUsuarioFiltro);
            panel1.Controls.Add(iconbtnClean);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblFiltrar);
            panel1.Controls.Add(lblListaConsultas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 1;
            // 
            // txtTipoFiltro
            // 
            txtTipoFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoFiltro.ForeColor = Color.Silver;
            txtTipoFiltro.Location = new Point(347, 59);
            txtTipoFiltro.Multiline = true;
            txtTipoFiltro.Name = "txtTipoFiltro";
            txtTipoFiltro.PlaceholderText = "Tipo";
            txtTipoFiltro.Size = new Size(97, 20);
            txtTipoFiltro.TabIndex = 28;
            // 
            // txtUsuarioFiltro
            // 
            txtUsuarioFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioFiltro.ForeColor = Color.Silver;
            txtUsuarioFiltro.Location = new Point(513, 58);
            txtUsuarioFiltro.Multiline = true;
            txtUsuarioFiltro.Name = "txtUsuarioFiltro";
            txtUsuarioFiltro.PlaceholderText = "Dni";
            txtUsuarioFiltro.Size = new Size(97, 20);
            txtUsuarioFiltro.TabIndex = 27;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(616, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 11;
            label1.Text = "Estado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(220, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(88, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(459, 59);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(314, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(36, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Tipo";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlLightLight;
            lblDni.Location = new Point(171, 59);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 17);
            lblDni.TabIndex = 4;
            lblDni.Text = "Fecha";
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
            // btnResponder
            // 
            btnResponder.BackColor = Color.FromArgb(19, 173, 39);
            btnResponder.Cursor = Cursors.Hand;
            btnResponder.FlatAppearance.BorderColor = Color.Black;
            btnResponder.FlatStyle = FlatStyle.Flat;
            btnResponder.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResponder.ForeColor = SystemColors.ControlLightLight;
            btnResponder.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            btnResponder.IconColor = Color.White;
            btnResponder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResponder.IconSize = 30;
            btnResponder.Location = new Point(195, 98);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(103, 39);
            btnResponder.TabIndex = 8;
            btnResponder.Text = "Responder";
            btnResponder.TextAlign = ContentAlignment.MiddleRight;
            btnResponder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResponder.UseVisualStyleBackColor = false;
            btnResponder.Click += btnResponder_Click;
            // 
            // iconBtnMarcar
            // 
            iconBtnMarcar.BackColor = Color.DarkGray;
            iconBtnMarcar.Cursor = Cursors.Hand;
            iconBtnMarcar.FlatAppearance.BorderColor = Color.Black;
            iconBtnMarcar.FlatStyle = FlatStyle.Flat;
            iconBtnMarcar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnMarcar.ForeColor = SystemColors.ControlLightLight;
            iconBtnMarcar.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            iconBtnMarcar.IconColor = Color.White;
            iconBtnMarcar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnMarcar.IconSize = 30;
            iconBtnMarcar.Location = new Point(323, 98);
            iconBtnMarcar.Name = "iconBtnMarcar";
            iconBtnMarcar.Size = new Size(107, 39);
            iconBtnMarcar.TabIndex = 9;
            iconBtnMarcar.Text = "Marcar Leido";
            iconBtnMarcar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnMarcar.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.BackColor = Color.FromArgb(255, 222, 89);
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlLightLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(220, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(235, 36);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Ver Papelera";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconBtnEliminar
            // 
            iconBtnEliminar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnEliminar.Cursor = Cursors.Hand;
            iconBtnEliminar.FlatAppearance.BorderColor = Color.Black;
            iconBtnEliminar.FlatStyle = FlatStyle.Flat;
            iconBtnEliminar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnEliminar.ForeColor = SystemColors.ControlLightLight;
            iconBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconBtnEliminar.IconColor = Color.White;
            iconBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnEliminar.IconSize = 30;
            iconBtnEliminar.Location = new Point(459, 98);
            iconBtnEliminar.Name = "iconBtnEliminar";
            iconBtnEliminar.Size = new Size(88, 39);
            iconBtnEliminar.TabIndex = 11;
            iconBtnEliminar.Text = "Eliminar";
            iconBtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { col_id_usuario, col_dni, col_nombre, col_apellido, col_email, col_password, col_telefono, col_id_rol, col_Rol, col_id_domicilio, col_domicilio_calle, col_domicilio_numero, col_domicilio_prov, Estado_Valor, col_estado });
            dataGridUsuarios.Location = new Point(12, 158);
            dataGridUsuarios.MultiSelect = false;
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.ReadOnly = true;
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridUsuarios.RowTemplate.Height = 28;
            dataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsuarios.Size = new Size(795, 353);
            dataGridUsuarios.TabIndex = 12;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // col_id_usuario
            // 
            col_id_usuario.HeaderText = "Id_usuario";
            col_id_usuario.Name = "col_id_usuario";
            col_id_usuario.ReadOnly = true;
            col_id_usuario.Visible = false;
            col_id_usuario.Width = 77;
            // 
            // col_dni
            // 
            col_dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_dni.HeaderText = "DNI";
            col_dni.Name = "col_dni";
            col_dni.ReadOnly = true;
            col_dni.Width = 130;
            // 
            // col_nombre
            // 
            col_nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_nombre.HeaderText = "Nombre";
            col_nombre.Name = "col_nombre";
            col_nombre.ReadOnly = true;
            // 
            // col_apellido
            // 
            col_apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_apellido.HeaderText = "Apellido";
            col_apellido.Name = "col_apellido";
            col_apellido.ReadOnly = true;
            // 
            // col_email
            // 
            col_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_email.HeaderText = "Email";
            col_email.Name = "col_email";
            col_email.ReadOnly = true;
            col_email.Width = 130;
            // 
            // col_password
            // 
            col_password.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_password.HeaderText = "Password";
            col_password.Name = "col_password";
            col_password.ReadOnly = true;
            col_password.Visible = false;
            col_password.Width = 87;
            // 
            // col_telefono
            // 
            col_telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_telefono.HeaderText = "Telefono";
            col_telefono.Name = "col_telefono";
            col_telefono.ReadOnly = true;
            // 
            // col_id_rol
            // 
            col_id_rol.HeaderText = "id_rol";
            col_id_rol.Name = "col_id_rol";
            col_id_rol.ReadOnly = true;
            col_id_rol.Visible = false;
            col_id_rol.Width = 68;
            // 
            // col_Rol
            // 
            col_Rol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_Rol.HeaderText = "Rol";
            col_Rol.Name = "col_Rol";
            col_Rol.ReadOnly = true;
            // 
            // col_id_domicilio
            // 
            col_id_domicilio.HeaderText = "id_domicilio";
            col_id_domicilio.Name = "col_id_domicilio";
            col_id_domicilio.ReadOnly = true;
            col_id_domicilio.Visible = false;
            col_id_domicilio.Width = 108;
            // 
            // col_domicilio_calle
            // 
            col_domicilio_calle.HeaderText = "Calle";
            col_domicilio_calle.Name = "col_domicilio_calle";
            col_domicilio_calle.ReadOnly = true;
            col_domicilio_calle.Width = 67;
            // 
            // col_domicilio_numero
            // 
            col_domicilio_numero.HeaderText = "Numero";
            col_domicilio_numero.Name = "col_domicilio_numero";
            col_domicilio_numero.ReadOnly = true;
            col_domicilio_numero.Width = 83;
            // 
            // col_domicilio_prov
            // 
            col_domicilio_prov.HeaderText = "Provincia";
            col_domicilio_prov.Name = "col_domicilio_prov";
            col_domicilio_prov.ReadOnly = true;
            col_domicilio_prov.Width = 91;
            // 
            // Estado_Valor
            // 
            Estado_Valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Estado_Valor.HeaderText = "Estado Valor";
            Estado_Valor.Name = "Estado_Valor";
            Estado_Valor.ReadOnly = true;
            Estado_Valor.Visible = false;
            // 
            // col_estado
            // 
            col_estado.HeaderText = "Estado";
            col_estado.Name = "col_estado";
            col_estado.ReadOnly = true;
            col_estado.Width = 74;
            // 
            // panelDatosConsulta
            // 
            panelDatosConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosConsulta.BackColor = Color.White;
            panelDatosConsulta.Controls.Add(dateTimePickerEnvioDato);
            panelDatosConsulta.Controls.Add(lblFecha);
            panelDatosConsulta.Controls.Add(lblAsunto);
            panelDatosConsulta.Controls.Add(txtAsuntoDato);
            panelDatosConsulta.Controls.Add(iconbtnLeido);
            panelDatosConsulta.Controls.Add(iconBtnCancelar);
            panelDatosConsulta.Controls.Add(comboEstadoDato);
            panelDatosConsulta.Controls.Add(lblMotivo);
            panelDatosConsulta.Controls.Add(txtMotivoDato);
            panelDatosConsulta.Controls.Add(lblEstadoDato);
            panelDatosConsulta.Controls.Add(comboTipoConsulta);
            panelDatosConsulta.Controls.Add(lblEmailDato);
            panelDatosConsulta.Controls.Add(txtEmailDato);
            panelDatosConsulta.Controls.Add(lblTipoDato);
            panelDatosConsulta.Controls.Add(lblDniDato);
            panelDatosConsulta.Controls.Add(txtDniDato);
            panelDatosConsulta.Controls.Add(txtApeDato);
            panelDatosConsulta.Controls.Add(lblApellidoDato);
            panelDatosConsulta.Controls.Add(lblNombreDato);
            panelDatosConsulta.Controls.Add(txtNombreDato);
            panelDatosConsulta.Controls.Add(lblDatosConsulta);
            panelDatosConsulta.Location = new Point(584, 92);
            panelDatosConsulta.Name = "panelDatosConsulta";
            panelDatosConsulta.Size = new Size(238, 423);
            panelDatosConsulta.TabIndex = 13;
            // 
            // dateTimePickerEnvioDato
            // 
            dateTimePickerEnvioDato.Format = DateTimePickerFormat.Short;
            dateTimePickerEnvioDato.Location = new Point(120, 178);
            dateTimePickerEnvioDato.MaxDate = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            dateTimePickerEnvioDato.Name = "dateTimePickerEnvioDato";
            dateTimePickerEnvioDato.Size = new Size(106, 23);
            dateTimePickerEnvioDato.TabIndex = 75;
            dateTimePickerEnvioDato.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.WindowText;
            lblFecha.Location = new Point(6, 184);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 17);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "Fecha Enviada";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsunto.ForeColor = SystemColors.WindowText;
            lblAsunto.Location = new Point(6, 155);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(52, 17);
            lblAsunto.TabIndex = 29;
            lblAsunto.Text = "Asunto";
            // 
            // txtAsuntoDato
            // 
            txtAsuntoDato.Location = new Point(82, 149);
            txtAsuntoDato.Name = "txtAsuntoDato";
            txtAsuntoDato.Size = new Size(144, 23);
            txtAsuntoDato.TabIndex = 28;
            // 
            // iconbtnLeido
            // 
            iconbtnLeido.BackColor = Color.FromArgb(56, 182, 255);
            iconbtnLeido.Cursor = Cursors.Hand;
            iconbtnLeido.FlatAppearance.BorderColor = Color.Black;
            iconbtnLeido.FlatStyle = FlatStyle.Flat;
            iconbtnLeido.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnLeido.ForeColor = SystemColors.ControlLightLight;
            iconbtnLeido.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconbtnLeido.IconColor = Color.White;
            iconbtnLeido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLeido.IconSize = 36;
            iconbtnLeido.Location = new Point(27, 344);
            iconbtnLeido.Name = "iconbtnLeido";
            iconbtnLeido.Size = new Size(202, 39);
            iconbtnLeido.TabIndex = 25;
            iconbtnLeido.Text = "Marcar como Leido";
            iconbtnLeido.TextAlign = ContentAlignment.MiddleRight;
            iconbtnLeido.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnLeido.UseVisualStyleBackColor = false;
            // 
            // iconBtnCancelar
            // 
            iconBtnCancelar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnCancelar.Cursor = Cursors.Hand;
            iconBtnCancelar.FlatAppearance.BorderColor = Color.Black;
            iconBtnCancelar.FlatStyle = FlatStyle.Flat;
            iconBtnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(27, 384);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(202, 39);
            iconBtnCancelar.TabIndex = 11;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(82, 236);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMotivo.ForeColor = SystemColors.WindowText;
            lblMotivo.Location = new Point(6, 265);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(52, 17);
            lblMotivo.TabIndex = 13;
            lblMotivo.Text = "Motivo";
            // 
            // txtMotivoDato
            // 
            txtMotivoDato.Location = new Point(85, 265);
            txtMotivoDato.Multiline = true;
            txtMotivoDato.Name = "txtMotivoDato";
            txtMotivoDato.Size = new Size(144, 73);
            txtMotivoDato.TabIndex = 12;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(8, 236);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(49, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Estado";
            // 
            // comboTipoConsulta
            // 
            comboTipoConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoConsulta.FlatStyle = FlatStyle.Popup;
            comboTipoConsulta.FormattingEnabled = true;
            comboTipoConsulta.Location = new Point(82, 207);
            comboTipoConsulta.Name = "comboTipoConsulta";
            comboTipoConsulta.Size = new Size(144, 23);
            comboTipoConsulta.TabIndex = 21;
            // 
            // lblEmailDato
            // 
            lblEmailDato.AutoSize = true;
            lblEmailDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailDato.ForeColor = SystemColors.WindowText;
            lblEmailDato.Location = new Point(6, 126);
            lblEmailDato.Name = "lblEmailDato";
            lblEmailDato.Size = new Size(42, 17);
            lblEmailDato.TabIndex = 17;
            lblEmailDato.Text = "Email";
            // 
            // txtEmailDato
            // 
            txtEmailDato.Location = new Point(82, 120);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 16;
            // 
            // lblTipoDato
            // 
            lblTipoDato.AutoSize = true;
            lblTipoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDato.ForeColor = SystemColors.WindowText;
            lblTipoDato.Location = new Point(9, 208);
            lblTipoDato.Name = "lblTipoDato";
            lblTipoDato.Size = new Size(36, 17);
            lblTipoDato.TabIndex = 14;
            lblTipoDato.Text = "Tipo";
            // 
            // lblDniDato
            // 
            lblDniDato.AutoSize = true;
            lblDniDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniDato.ForeColor = SystemColors.WindowText;
            lblDniDato.Location = new Point(6, 39);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new Size(32, 17);
            lblDniDato.TabIndex = 11;
            lblDniDato.Text = "DNI";
            // 
            // txtDniDato
            // 
            txtDniDato.Location = new Point(82, 33);
            txtDniDato.Name = "txtDniDato";
            txtDniDato.Size = new Size(144, 23);
            txtDniDato.TabIndex = 10;
            // 
            // txtApeDato
            // 
            txtApeDato.Location = new Point(82, 91);
            txtApeDato.Name = "txtApeDato";
            txtApeDato.Size = new Size(144, 23);
            txtApeDato.TabIndex = 9;
            // 
            // lblApellidoDato
            // 
            lblApellidoDato.AutoSize = true;
            lblApellidoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidoDato.ForeColor = SystemColors.WindowText;
            lblApellidoDato.Location = new Point(6, 97);
            lblApellidoDato.Name = "lblApellidoDato";
            lblApellidoDato.Size = new Size(60, 17);
            lblApellidoDato.TabIndex = 8;
            lblApellidoDato.Text = "Apellido";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(6, 68);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(58, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Nombre";
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(82, 62);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            // 
            // lblDatosConsulta
            // 
            lblDatosConsulta.AutoSize = true;
            lblDatosConsulta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosConsulta.Location = new Point(18, 0);
            lblDatosConsulta.Name = "lblDatosConsulta";
            lblDatosConsulta.Size = new Size(208, 30);
            lblDatosConsulta.TabIndex = 0;
            lblDatosConsulta.Text = "Datos De la Consulta";
            // 
            // iconBtnNoLeido
            // 
            iconBtnNoLeido.BackColor = Color.DarkGray;
            iconBtnNoLeido.Cursor = Cursors.Hand;
            iconBtnNoLeido.FlatAppearance.BorderColor = Color.Black;
            iconBtnNoLeido.FlatStyle = FlatStyle.Flat;
            iconBtnNoLeido.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnNoLeido.ForeColor = SystemColors.ControlLightLight;
            iconBtnNoLeido.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            iconBtnNoLeido.IconColor = Color.White;
            iconBtnNoLeido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnNoLeido.IconSize = 30;
            iconBtnNoLeido.Location = new Point(314, 98);
            iconBtnNoLeido.Name = "iconBtnNoLeido";
            iconBtnNoLeido.Size = new Size(107, 39);
            iconBtnNoLeido.TabIndex = 14;
            iconBtnNoLeido.Text = "Marcar NO Leido";
            iconBtnNoLeido.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnNoLeido.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 521);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 44);
            panel2.TabIndex = 15;
            // 
            // comboFiltroRol
            // 
            comboFiltroRol.FlatStyle = FlatStyle.Popup;
            comboFiltroRol.FormattingEnabled = true;
            comboFiltroRol.Location = new Point(666, 57);
            comboFiltroRol.Name = "comboFiltroRol";
            comboFiltroRol.Size = new Size(97, 23);
            comboFiltroRol.TabIndex = 29;
            // 
            // FrmGestionarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(iconBtnNoLeido);
            Controls.Add(panelDatosConsulta);
            Controls.Add(dataGridUsuarios);
            Controls.Add(iconBtnEliminar);
            Controls.Add(iconBtnMarcar);
            Controls.Add(btnResponder);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmGestionarConsulta";
            Text = "Gestionar Consultas ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panelDatosConsulta.ResumeLayout(false);
            panelDatosConsulta.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDni;
        private Label lblFiltrar;
        private Label lblListaConsultas;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnResponder;
        private FontAwesome.Sharp.IconButton iconBtnMarcar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconBtnEliminar;
        private FontAwesome.Sharp.IconButton iconbtnClean;
        private TextBox txtTipoFiltro;
        private TextBox txtUsuarioFiltro;
        private DataGridView dataGridUsuarios;
        private DataGridViewTextBoxColumn col_id_usuario;
        private DataGridViewTextBoxColumn col_dni;
        private DataGridViewTextBoxColumn col_nombre;
        private DataGridViewTextBoxColumn col_apellido;
        private DataGridViewTextBoxColumn col_email;
        private DataGridViewTextBoxColumn col_password;
        private DataGridViewTextBoxColumn col_telefono;
        private DataGridViewTextBoxColumn col_id_rol;
        private DataGridViewTextBoxColumn col_Rol;
        private DataGridViewTextBoxColumn col_id_domicilio;
        private DataGridViewTextBoxColumn col_domicilio_calle;
        private DataGridViewTextBoxColumn col_domicilio_numero;
        private DataGridViewTextBoxColumn col_domicilio_prov;
        private DataGridViewTextBoxColumn Estado_Valor;
        private DataGridViewTextBoxColumn col_estado;
        private Panel panelDatosConsulta;
        private Label lblFechaNac;
        private Label lblAsunto;
        private TextBox txtAsuntoDato;
        private TextBox txtDomiciliodato;
        private FontAwesome.Sharp.IconButton iconbtnLeido;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private ComboBox comboTipoConsulta;
        private Label lblDomicilioDato;
        private Label lblEmailDato;
        private TextBox txtEmailDato;
        private Label lblTipoDato;
        private Label lblMotivo;
        private TextBox txtMotivoDato;
        private Label lblDniDato;
        private TextBox txtDniDato;
        private TextBox txtApeDato;
        private Label lblApellidoDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatosConsulta;
        private FontAwesome.Sharp.IconButton iconBtnNoLeido;
        private Label lblFecha;
        private DateTimePicker dateTimePickerEnvioDato;
        private TextBox textBox3;
        private Panel panel2;
        private ComboBox comboFiltroRol;
    }
}