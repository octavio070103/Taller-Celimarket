namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmGestionarUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarUsuario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblRolFiltro = new Label();
            comboFiltroRol = new ComboBox();
            iconbtnClean = new FontAwesome.Sharp.IconButton();
            comboFiltroEstado = new ComboBox();
            lblEstado = new Label();
            txtDniFiltro = new TextBox();
            txtNombreFiltro = new TextBox();
            txtApeFiltro = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            lblFiltrar = new Label();
            lblListaEmpleados = new Label();
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
            panelDatosUsuario = new Panel();
            lblFechaNac = new Label();
            dateTimePickerNacimientoDato = new DateTimePicker();
            lblPassword = new Label();
            txtPasswordDato = new TextBox();
            txtDomiciliodato = new TextBox();
            txtIdGuardado = new TextBox();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblEstadoDato = new Label();
            comboRolDato = new ComboBox();
            lblDomicilioDato = new Label();
            lblEmailDato = new Label();
            txtEmailDato = new TextBox();
            lblRolDato = new Label();
            lblTelefDato = new Label();
            txtTelefDato = new TextBox();
            lblDniDato = new Label();
            txtDniDato = new TextBox();
            txtApeDato = new TextBox();
            lblApellidoDato = new Label();
            lblNombreDato = new Label();
            txtNombreDato = new TextBox();
            lblDatosUsuario = new Label();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            iconBtnElim = new FontAwesome.Sharp.IconButton();
            iconBtnPermiso = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            iconBtnAlta = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panelDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblRolFiltro);
            panel1.Controls.Add(comboFiltroRol);
            panel1.Controls.Add(iconbtnClean);
            panel1.Controls.Add(comboFiltroEstado);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(txtDniFiltro);
            panel1.Controls.Add(txtNombreFiltro);
            panel1.Controls.Add(txtApeFiltro);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblFiltrar);
            panel1.Controls.Add(lblListaEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 0;
            // 
            // lblRolFiltro
            // 
            lblRolFiltro.AutoSize = true;
            lblRolFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolFiltro.ForeColor = SystemColors.ControlLightLight;
            lblRolFiltro.Location = new Point(638, 64);
            lblRolFiltro.Name = "lblRolFiltro";
            lblRolFiltro.Size = new Size(28, 17);
            lblRolFiltro.TabIndex = 27;
            lblRolFiltro.Text = "Rol";
            // 
            // comboFiltroRol
            // 
            comboFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltroRol.FlatStyle = FlatStyle.Popup;
            comboFiltroRol.FormattingEnabled = true;
            comboFiltroRol.Location = new Point(672, 62);
            comboFiltroRol.Name = "comboFiltroRol";
            comboFiltroRol.Size = new Size(88, 23);
            comboFiltroRol.TabIndex = 26;
            comboFiltroRol.TextChanged += comboFiltroRol_TextChanged;
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
            iconbtnClean.Location = new Point(782, 62);
            iconbtnClean.Name = "iconbtnClean";
            iconbtnClean.Size = new Size(25, 23);
            iconbtnClean.TabIndex = 25;
            iconbtnClean.TextAlign = ContentAlignment.MiddleRight;
            iconbtnClean.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnClean.UseVisualStyleBackColor = false;
            // 
            // comboFiltroEstado
            // 
            comboFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltroEstado.FlatStyle = FlatStyle.Popup;
            comboFiltroEstado.FormattingEnabled = true;
            comboFiltroEstado.Location = new Point(536, 62);
            comboFiltroEstado.Name = "comboFiltroEstado";
            comboFiltroEstado.Size = new Size(88, 23);
            comboFiltroEstado.TabIndex = 24;
            comboFiltroEstado.TextChanged += comboFiltroEstado_TextChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.ControlLightLight;
            lblEstado.Location = new Point(481, 65);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado";
            // 
            // txtDniFiltro
            // 
            txtDniFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniFiltro.ForeColor = Color.Silver;
            txtDniFiltro.Location = new Point(48, 64);
            txtDniFiltro.Multiline = true;
            txtDniFiltro.Name = "txtDniFiltro";
            txtDniFiltro.PlaceholderText = "DNI";
            txtDniFiltro.Size = new Size(97, 20);
            txtDniFiltro.TabIndex = 11;
            txtDniFiltro.TextChanged += txtDniFiltro_TextChanged;
            txtDniFiltro.KeyPress += txtDniFiltro_KeyPress;
            // 
            // txtNombreFiltro
            // 
            txtNombreFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreFiltro.ForeColor = Color.Silver;
            txtNombreFiltro.Location = new Point(211, 64);
            txtNombreFiltro.Multiline = true;
            txtNombreFiltro.Name = "txtNombreFiltro";
            txtNombreFiltro.PlaceholderText = "Nombre";
            txtNombreFiltro.Size = new Size(97, 20);
            txtNombreFiltro.TabIndex = 10;
            txtNombreFiltro.TextChanged += txtNombreFiltro_TextChanged;
            txtNombreFiltro.KeyPress += txtNombreFiltro_KeyPress;
            // 
            // txtApeFiltro
            // 
            txtApeFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApeFiltro.ForeColor = Color.Silver;
            txtApeFiltro.Location = new Point(372, 64);
            txtApeFiltro.Multiline = true;
            txtApeFiltro.Name = "txtApeFiltro";
            txtApeFiltro.PlaceholderText = "Apellido";
            txtApeFiltro.Size = new Size(97, 20);
            txtApeFiltro.TabIndex = 9;
            txtApeFiltro.TextChanged += txtApeFiltro_TextChanged;
            txtApeFiltro.KeyPress += txtApeFiltro_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(316, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(151, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlLightLight;
            lblDni.Location = new Point(17, 66);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 17);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI ";
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltrar.ForeColor = SystemColors.ControlLightLight;
            lblFiltrar.Location = new Point(3, 35);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(71, 25);
            lblFiltrar.TabIndex = 1;
            lblFiltrar.Text = "Filtrar:";
            // 
            // lblListaEmpleados
            // 
            lblListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaEmpleados.AutoSize = true;
            lblListaEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEmpleados.ForeColor = SystemColors.ControlLightLight;
            lblListaEmpleados.ImageAlign = ContentAlignment.TopCenter;
            lblListaEmpleados.Location = new Point(278, 0);
            lblListaEmpleados.Name = "lblListaEmpleados";
            lblListaEmpleados.Size = new Size(276, 45);
            lblListaEmpleados.TabIndex = 0;
            lblListaEmpleados.Text = "Lista De Usuarios";
            lblListaEmpleados.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { col_id_usuario, col_dni, col_nombre, col_apellido, col_email, col_password, col_telefono, col_id_rol, col_Rol, col_id_domicilio, col_domicilio_calle, col_domicilio_numero, col_domicilio_prov, Estado_Valor, col_estado });
            dataGridUsuarios.Location = new Point(12, 176);
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
            dataGridUsuarios.Size = new Size(795, 349);
            dataGridUsuarios.TabIndex = 1;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick_1;
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
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(lblFechaNac);
            panelDatosUsuario.Controls.Add(dateTimePickerNacimientoDato);
            panelDatosUsuario.Controls.Add(lblPassword);
            panelDatosUsuario.Controls.Add(txtPasswordDato);
            panelDatosUsuario.Controls.Add(txtDomiciliodato);
            panelDatosUsuario.Controls.Add(txtIdGuardado);
            panelDatosUsuario.Controls.Add(iconbtnGuardar);
            panelDatosUsuario.Controls.Add(iconBtnCancelar);
            panelDatosUsuario.Controls.Add(iconBtnModif);
            panelDatosUsuario.Controls.Add(comboEstadoDato);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Controls.Add(comboRolDato);
            panelDatosUsuario.Controls.Add(lblDomicilioDato);
            panelDatosUsuario.Controls.Add(lblEmailDato);
            panelDatosUsuario.Controls.Add(txtEmailDato);
            panelDatosUsuario.Controls.Add(lblRolDato);
            panelDatosUsuario.Controls.Add(lblTelefDato);
            panelDatosUsuario.Controls.Add(txtTelefDato);
            panelDatosUsuario.Controls.Add(lblDniDato);
            panelDatosUsuario.Controls.Add(txtDniDato);
            panelDatosUsuario.Controls.Add(txtApeDato);
            panelDatosUsuario.Controls.Add(lblApellidoDato);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(txtNombreDato);
            panelDatosUsuario.Controls.Add(lblDatosUsuario);
            panelDatosUsuario.Location = new Point(584, 92);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(238, 447);
            panelDatosUsuario.TabIndex = 3;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNac.ForeColor = SystemColors.WindowText;
            lblFechaNac.Location = new Point(3, 132);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(71, 15);
            lblFechaNac.TabIndex = 75;
            lblFechaNac.Text = "Nacimiento";
            // 
            // dateTimePickerNacimientoDato
            // 
            dateTimePickerNacimientoDato.Format = DateTimePickerFormat.Short;
            dateTimePickerNacimientoDato.Location = new Point(79, 127);
            dateTimePickerNacimientoDato.MaxDate = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            dateTimePickerNacimientoDato.Name = "dateTimePickerNacimientoDato";
            dateTimePickerNacimientoDato.Size = new Size(144, 23);
            dateTimePickerNacimientoDato.TabIndex = 74;
            dateTimePickerNacimientoDato.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.WindowText;
            lblPassword.Location = new Point(3, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(41, 17);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Clave";
            // 
            // txtPasswordDato
            // 
            txtPasswordDato.Location = new Point(79, 185);
            txtPasswordDato.Name = "txtPasswordDato";
            txtPasswordDato.Size = new Size(144, 23);
            txtPasswordDato.TabIndex = 28;
            // 
            // txtDomiciliodato
            // 
            txtDomiciliodato.BackColor = SystemColors.Window;
            txtDomiciliodato.Location = new Point(79, 278);
            txtDomiciliodato.Name = "txtDomiciliodato";
            txtDomiciliodato.ReadOnly = true;
            txtDomiciliodato.Size = new Size(144, 23);
            txtDomiciliodato.TabIndex = 27;
            txtDomiciliodato.MouseClick += txtDomiciliodato_MouseClick;
            // 
            // txtIdGuardado
            // 
            txtIdGuardado.Location = new Point(3, 18);
            txtIdGuardado.Name = "txtIdGuardado";
            txtIdGuardado.Size = new Size(26, 23);
            txtIdGuardado.TabIndex = 26;
            txtIdGuardado.Text = "0";
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(56, 182, 255);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 36;
            iconbtnGuardar.Location = new Point(24, 336);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(202, 39);
            iconbtnGuardar.TabIndex = 25;
            iconbtnGuardar.Text = "Confirmar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
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
            iconBtnCancelar.Location = new Point(24, 381);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(202, 39);
            iconBtnCancelar.TabIndex = 11;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconBtnModif
            // 
            iconBtnModif.BackColor = Color.FromArgb(255, 222, 89);
            iconBtnModif.Cursor = Cursors.Hand;
            iconBtnModif.FlatAppearance.BorderColor = Color.Black;
            iconBtnModif.FlatStyle = FlatStyle.Flat;
            iconBtnModif.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnModif.ForeColor = Color.White;
            iconBtnModif.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconBtnModif.IconColor = Color.White;
            iconBtnModif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnModif.IconSize = 30;
            iconBtnModif.Location = new Point(24, 336);
            iconBtnModif.Name = "iconBtnModif";
            iconBtnModif.Size = new Size(202, 39);
            iconBtnModif.TabIndex = 24;
            iconBtnModif.Text = "Modificar";
            iconBtnModif.TextAlign = ContentAlignment.MiddleRight;
            iconBtnModif.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnModif.UseVisualStyleBackColor = false;
            iconBtnModif.Click += iconBtnModif_Click_1;
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 307);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(5, 307);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(49, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Estado";
            // 
            // comboRolDato
            // 
            comboRolDato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRolDato.FlatStyle = FlatStyle.Popup;
            comboRolDato.FormattingEnabled = true;
            comboRolDato.Location = new Point(79, 248);
            comboRolDato.Name = "comboRolDato";
            comboRolDato.Size = new Size(144, 23);
            comboRolDato.TabIndex = 21;
            // 
            // lblDomicilioDato
            // 
            lblDomicilioDato.AutoSize = true;
            lblDomicilioDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomicilioDato.ForeColor = SystemColors.WindowText;
            lblDomicilioDato.Location = new Point(5, 278);
            lblDomicilioDato.Name = "lblDomicilioDato";
            lblDomicilioDato.Size = new Size(68, 17);
            lblDomicilioDato.TabIndex = 18;
            lblDomicilioDato.Text = "Domicilio";
            // 
            // lblEmailDato
            // 
            lblEmailDato.AutoSize = true;
            lblEmailDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailDato.ForeColor = SystemColors.WindowText;
            lblEmailDato.Location = new Point(3, 162);
            lblEmailDato.Name = "lblEmailDato";
            lblEmailDato.Size = new Size(42, 17);
            lblEmailDato.TabIndex = 17;
            lblEmailDato.Text = "Email";
            // 
            // txtEmailDato
            // 
            txtEmailDato.Location = new Point(79, 156);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 16;
            // 
            // lblRolDato
            // 
            lblRolDato.AutoSize = true;
            lblRolDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolDato.ForeColor = SystemColors.WindowText;
            lblRolDato.Location = new Point(6, 249);
            lblRolDato.Name = "lblRolDato";
            lblRolDato.Size = new Size(28, 17);
            lblRolDato.TabIndex = 14;
            lblRolDato.Text = "Rol";
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(3, 220);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(62, 17);
            lblTelefDato.TabIndex = 13;
            lblTelefDato.Text = "Telefono";
            // 
            // txtTelefDato
            // 
            txtTelefDato.Location = new Point(79, 214);
            txtTelefDato.Name = "txtTelefDato";
            txtTelefDato.Size = new Size(144, 23);
            txtTelefDato.TabIndex = 12;
            // 
            // lblDniDato
            // 
            lblDniDato.AutoSize = true;
            lblDniDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniDato.ForeColor = SystemColors.WindowText;
            lblDniDato.Location = new Point(3, 48);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new Size(32, 17);
            lblDniDato.TabIndex = 11;
            lblDniDato.Text = "DNI";
            // 
            // txtDniDato
            // 
            txtDniDato.Location = new Point(79, 42);
            txtDniDato.Name = "txtDniDato";
            txtDniDato.Size = new Size(144, 23);
            txtDniDato.TabIndex = 10;
            // 
            // txtApeDato
            // 
            txtApeDato.Location = new Point(79, 100);
            txtApeDato.Name = "txtApeDato";
            txtApeDato.Size = new Size(144, 23);
            txtApeDato.TabIndex = 9;
            // 
            // lblApellidoDato
            // 
            lblApellidoDato.AutoSize = true;
            lblApellidoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidoDato.ForeColor = SystemColors.WindowText;
            lblApellidoDato.Location = new Point(3, 106);
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
            lblNombreDato.Location = new Point(3, 77);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(58, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Nombre";
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 71);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(32, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(180, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos Del Usuario";
            // 
            // iconBtnAgregar
            // 
            iconBtnAgregar.BackColor = Color.FromArgb(19, 173, 39);
            iconBtnAgregar.Cursor = Cursors.Hand;
            iconBtnAgregar.FlatAppearance.BorderColor = Color.Black;
            iconBtnAgregar.FlatStyle = FlatStyle.Flat;
            iconBtnAgregar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAgregar.ForeColor = SystemColors.ControlLightLight;
            iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconBtnAgregar.IconColor = Color.White;
            iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregar.IconSize = 30;
            iconBtnAgregar.Location = new Point(230, 101);
            iconBtnAgregar.Name = "iconBtnAgregar";
            iconBtnAgregar.Size = new Size(89, 39);
            iconBtnAgregar.TabIndex = 7;
            iconBtnAgregar.Text = "Agregar";
            iconBtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAgregar.UseVisualStyleBackColor = false;
            iconBtnAgregar.Click += iconBtnAgregar_Click;
            // 
            // iconBtnElim
            // 
            iconBtnElim.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnElim.Cursor = Cursors.Hand;
            iconBtnElim.FlatAppearance.BorderColor = Color.Black;
            iconBtnElim.FlatStyle = FlatStyle.Flat;
            iconBtnElim.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnElim.ForeColor = SystemColors.ControlLightLight;
            iconBtnElim.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            iconBtnElim.IconColor = Color.White;
            iconBtnElim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnElim.IconSize = 30;
            iconBtnElim.Location = new Point(361, 101);
            iconBtnElim.Name = "iconBtnElim";
            iconBtnElim.Size = new Size(89, 39);
            iconBtnElim.TabIndex = 9;
            iconBtnElim.Text = "Eliminar";
            iconBtnElim.TextAlign = ContentAlignment.MiddleRight;
            iconBtnElim.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnElim.UseVisualStyleBackColor = false;
            iconBtnElim.Click += iconBtnElim_Click;
            // 
            // iconBtnPermiso
            // 
            iconBtnPermiso.BackColor = Color.FromArgb(216, 103, 30);
            iconBtnPermiso.Cursor = Cursors.Hand;
            iconBtnPermiso.FlatAppearance.BorderColor = Color.Black;
            iconBtnPermiso.FlatStyle = FlatStyle.Flat;
            iconBtnPermiso.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnPermiso.ForeColor = SystemColors.ControlLightLight;
            iconBtnPermiso.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconBtnPermiso.IconColor = Color.White;
            iconBtnPermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnPermiso.IconSize = 30;
            iconBtnPermiso.Location = new Point(491, 101);
            iconBtnPermiso.Name = "iconBtnPermiso";
            iconBtnPermiso.Size = new Size(90, 39);
            iconBtnPermiso.TabIndex = 10;
            iconBtnPermiso.Text = "Permiso";
            iconBtnPermiso.TextAlign = ContentAlignment.MiddleRight;
            iconBtnPermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnPermiso.UseVisualStyleBackColor = false;
            iconBtnPermiso.Click += iconBtnPermiso_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // iconBtnAlta
            // 
            iconBtnAlta.BackColor = Color.Orange;
            iconBtnAlta.BackgroundImage = (Image)resources.GetObject("iconBtnAlta.BackgroundImage");
            iconBtnAlta.BackgroundImageLayout = ImageLayout.None;
            iconBtnAlta.Cursor = Cursors.Hand;
            iconBtnAlta.FlatAppearance.BorderColor = Color.Black;
            iconBtnAlta.FlatStyle = FlatStyle.Flat;
            iconBtnAlta.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAlta.ForeColor = SystemColors.ControlLightLight;
            iconBtnAlta.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAlta.IconColor = Color.White;
            iconBtnAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAlta.IconSize = 30;
            iconBtnAlta.Location = new Point(361, 102);
            iconBtnAlta.Name = "iconBtnAlta";
            iconBtnAlta.Size = new Size(89, 38);
            iconBtnAlta.TabIndex = 11;
            iconBtnAlta.Text = "Dar Alta";
            iconBtnAlta.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAlta.UseVisualStyleBackColor = false;
            iconBtnAlta.Click += iconBtnAlta_Click;
            // 
            // FrmGestionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(iconBtnAlta);
            Controls.Add(iconBtnPermiso);
            Controls.Add(iconBtnElim);
            Controls.Add(iconBtnAgregar);
            Controls.Add(panelDatosUsuario);
            Controls.Add(dataGridUsuarios);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmGestionarUsuario";
            Text = "Lista de Usuarios";
            Load += FrmGestionarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private DataGridView dataGridUsuarios;
        private Label lblDni;
        private Label lblFiltrar;
        private TextBox txtApeFiltro;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtDniFiltro;
        private TextBox txtNombreFiltro;
        private Panel panelDatosUsuario;
        private Label lblDatosUsuario;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private FontAwesome.Sharp.IconButton iconBtnElim;
        private FontAwesome.Sharp.IconButton iconBtnPermiso;
        private Label lblEstado;
        private Label lblEmailDato;
        private TextBox txtEmailDato;
        private Label lblRolDato;
        private Label lblTelefDato;
        private TextBox txtTelefDato;
        private Label lblDniDato;
        private TextBox txtDniDato;
        private TextBox txtApeDato;
        private Label lblApellidoDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private ComboBox comboRolDato;
        private Label lblDomicilioDato;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private TextBox txtIdGuardado;
        private ComboBox comboFiltroEstado;
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
        private TextBox txtDomiciliodato;
        private ErrorProvider errorProvider1;
        private Label lblPassword;
        private TextBox txtPasswordDato;
        private FontAwesome.Sharp.IconButton iconBtnAlta;
        private FontAwesome.Sharp.IconButton iconbtnClean;
        private ComboBox comboFiltroRol;
        private Label lblRolFiltro;
        private DateTimePicker dateTimePickerNacimientoDato;
        private Label lblFechaNac;
    }
}