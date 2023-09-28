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
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblOperacionRealizadas = new Label();
            dataGridUsuarios = new DataGridView();
            panelDatosUsuario = new Panel();
            lblFechaNac = new Label();
            dateTimePickerNacimientoDato = new DateTimePicker();
            txtDomiciliodato = new TextBox();
            txtIdGuardado = new TextBox();
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
            comboBox1 = new ComboBox();
            iconBtnCompras = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panelDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(dateTimePicker1);
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
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(147, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Dni";
            textBox1.Size = new Size(97, 20);
            textBox1.TabIndex = 38;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 50, 50);
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.BackgroundImageLayout = ImageLayout.Stretch;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(647, 59);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(25, 23);
            iconButton1.TabIndex = 36;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(545, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(88, 23);
            dateTimePicker1.TabIndex = 31;
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
            dataGridUsuarios.Size = new Size(806, 360);
            dataGridUsuarios.TabIndex = 14;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(lblFechaNac);
            panelDatosUsuario.Controls.Add(dateTimePickerNacimientoDato);
            panelDatosUsuario.Controls.Add(txtDomiciliodato);
            panelDatosUsuario.Controls.Add(txtIdGuardado);
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
            panelDatosUsuario.Size = new Size(238, 303);
            panelDatosUsuario.TabIndex = 16;
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
            // txtDomiciliodato
            // 
            txtDomiciliodato.BackColor = SystemColors.Window;
            txtDomiciliodato.Location = new Point(79, 249);
            txtDomiciliodato.Name = "txtDomiciliodato";
            txtDomiciliodato.ReadOnly = true;
            txtDomiciliodato.Size = new Size(144, 23);
            txtDomiciliodato.TabIndex = 27;
            // 
            // txtIdGuardado
            // 
            txtIdGuardado.Location = new Point(3, 18);
            txtIdGuardado.Name = "txtIdGuardado";
            txtIdGuardado.Size = new Size(26, 23);
            txtIdGuardado.TabIndex = 26;
            txtIdGuardado.Text = "0";
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 278);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(5, 278);
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
            comboRolDato.Location = new Point(79, 219);
            comboRolDato.Name = "comboRolDato";
            comboRolDato.Size = new Size(144, 23);
            comboRolDato.TabIndex = 21;
            // 
            // lblDomicilioDato
            // 
            lblDomicilioDato.AutoSize = true;
            lblDomicilioDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomicilioDato.ForeColor = SystemColors.WindowText;
            lblDomicilioDato.Location = new Point(5, 249);
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
            lblTelefDato.Location = new Point(3, 191);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(62, 17);
            lblTelefDato.TabIndex = 13;
            lblTelefDato.Text = "Telefono";
            // 
            // txtTelefDato
            // 
            txtTelefDato.Location = new Point(79, 185);
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
            lblDatosUsuario.Location = new Point(46, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(180, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos Del Usuario";
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
            nombre_persona.HeaderText = "Persona";
            nombre_persona.Name = "nombre_persona";
            nombre_persona.ReadOnly = true;
            nombre_persona.Width = 83;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(369, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 39;
            // 
            // iconBtnCompras
            // 
            iconBtnCompras.BackColor = Color.Orange;
            iconBtnCompras.BackgroundImage = (Image)resources.GetObject("iconBtnCompras.BackgroundImage");
            iconBtnCompras.BackgroundImageLayout = ImageLayout.None;
            iconBtnCompras.Cursor = Cursors.Hand;
            iconBtnCompras.FlatAppearance.BorderColor = Color.Black;
            iconBtnCompras.FlatStyle = FlatStyle.Flat;
            iconBtnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCompras.ForeColor = SystemColors.ControlLightLight;
            iconBtnCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCompras.IconColor = Color.White;
            iconBtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCompras.IconSize = 30;
            iconBtnCompras.Location = new Point(95, 98);
            iconBtnCompras.Name = "iconBtnCompras";
            iconBtnCompras.Size = new Size(99, 38);
            iconBtnCompras.TabIndex = 22;
            iconBtnCompras.Text = "Exportar Registros";
            iconBtnCompras.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCompras.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Orange;
            iconButton3.BackgroundImage = (Image)resources.GetObject("iconButton3.BackgroundImage");
            iconButton3.BackgroundImageLayout = ImageLayout.None;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderColor = Color.Black;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = SystemColors.ControlLightLight;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(342, 98);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(111, 38);
            iconButton3.TabIndex = 24;
            iconButton3.Text = "Resumen de Actividad";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Orange;
            iconButton4.BackgroundImage = (Image)resources.GetObject("iconButton4.BackgroundImage");
            iconButton4.BackgroundImageLayout = ImageLayout.None;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderColor = Color.Black;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = SystemColors.ControlLightLight;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.Location = new Point(216, 101);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(99, 38);
            iconButton4.TabIndex = 25;
            iconButton4.Text = "Eliminar Registros";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // FrmGestionarPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(panelDatosUsuario);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconBtnCompras);
            Controls.Add(dataGridUsuarios);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmGestionarPersonal";
            Text = "Gestionar Personal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label lblOperacionRealizadas;
        private DataGridView dataGridUsuarios;
        private Panel panelDatosUsuario;
        private Label lblFechaNac;
        private DateTimePicker dateTimePickerNacimientoDato;
        private TextBox txtDomiciliodato;
        private TextBox txtIdGuardado;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private ComboBox comboRolDato;
        private Label lblDomicilioDato;
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
        private Label lblDatosUsuario;
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
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconBtnCompras;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}