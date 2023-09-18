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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
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
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtIdGuardado = new TextBox();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            label8 = new Label();
            comboRolDato = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            txtEmailDato = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTelefDato = new TextBox();
            label3 = new Label();
            txtDniDato = new TextBox();
            txtApeDato = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombreDato = new TextBox();
            lblDatosUsuario = new Label();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            iconBtnElim = new FontAwesome.Sharp.IconButton();
            iconBtnPermiso = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
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
            panel1.Size = new Size(1014, 92);
            panel1.TabIndex = 0;
            // 
            // comboFiltroEstado
            // 
            comboFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltroEstado.FormattingEnabled = true;
            comboFiltroEstado.Location = new Point(723, 56);
            comboFiltroEstado.Name = "comboFiltroEstado";
            comboFiltroEstado.Size = new Size(88, 23);
            comboFiltroEstado.TabIndex = 24;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.ControlLightLight;
            lblEstado.Location = new Point(668, 57);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado";
            // 
            // txtDniFiltro
            // 
            txtDniFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniFiltro.ForeColor = Color.Silver;
            txtDniFiltro.Location = new Point(211, 58);
            txtDniFiltro.Multiline = true;
            txtDniFiltro.Name = "txtDniFiltro";
            txtDniFiltro.Size = new Size(97, 20);
            txtDniFiltro.TabIndex = 11;
            txtDniFiltro.Text = "DNI";
            // 
            // txtNombreFiltro
            // 
            txtNombreFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreFiltro.ForeColor = Color.Silver;
            txtNombreFiltro.Location = new Point(378, 59);
            txtNombreFiltro.Multiline = true;
            txtNombreFiltro.Name = "txtNombreFiltro";
            txtNombreFiltro.Size = new Size(97, 20);
            txtNombreFiltro.TabIndex = 10;
            txtNombreFiltro.Text = "Nombre";
            // 
            // txtApeFiltro
            // 
            txtApeFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApeFiltro.ForeColor = Color.Silver;
            txtApeFiltro.Location = new Point(550, 58);
            txtApeFiltro.Multiline = true;
            txtApeFiltro.Name = "txtApeFiltro";
            txtApeFiltro.Size = new Size(97, 20);
            txtApeFiltro.TabIndex = 9;
            txtApeFiltro.Text = "Apellido";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(484, 59);
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
            lblNombre.Location = new Point(314, 59);
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
            lblDni.Location = new Point(171, 59);
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
            lblFiltrar.Location = new Point(80, 51);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(71, 25);
            lblFiltrar.TabIndex = 1;
            lblFiltrar.Text = "Filtrar:";
            // 
            // lblListaEmpleados
            // 
            lblListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblListaEmpleados.AutoSize = true;
            lblListaEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEmpleados.ForeColor = SystemColors.ControlLightLight;
            lblListaEmpleados.ImageAlign = ContentAlignment.TopCenter;
            lblListaEmpleados.Location = new Point(372, 0);
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
            dataGridUsuarios.Size = new Size(731, 433);
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(txtIdGuardado);
            panel2.Controls.Add(iconbtnGuardar);
            panel2.Controls.Add(iconBtnCancelar);
            panel2.Controls.Add(iconBtnModif);
            panel2.Controls.Add(comboEstadoDato);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboRolDato);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEmailDato);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtTelefDato);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDniDato);
            panel2.Controls.Add(txtApeDato);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNombreDato);
            panel2.Controls.Add(lblDatosUsuario);
            panel2.Location = new Point(776, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 517);
            panel2.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 222, 89);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(79, 222);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(144, 23);
            iconButton1.TabIndex = 27;
            iconButton1.Text = "Modificar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
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
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 27;
            iconbtnGuardar.Location = new Point(21, 346);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(202, 39);
            iconbtnGuardar.TabIndex = 25;
            iconbtnGuardar.Text = "Guardar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
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
            iconBtnCancelar.Location = new Point(21, 391);
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
            iconBtnModif.Location = new Point(21, 301);
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
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 251);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(0, 251);
            label8.Name = "label8";
            label8.Size = new Size(49, 17);
            label8.TabIndex = 22;
            label8.Text = "Estado";
            // 
            // comboRolDato
            // 
            comboRolDato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRolDato.FormattingEnabled = true;
            comboRolDato.Location = new Point(79, 192);
            comboRolDato.Name = "comboRolDato";
            comboRolDato.Size = new Size(144, 23);
            comboRolDato.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(0, 222);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 18;
            label7.Text = "Domicilio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 17;
            label4.Text = "Email";
            // 
            // txtEmailDato
            // 
            txtEmailDato.Location = new Point(79, 129);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(3, 193);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 14;
            label5.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(3, 164);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 13;
            label6.Text = "Telefono";
            // 
            // txtTelefDato
            // 
            txtTelefDato.Location = new Point(79, 158);
            txtTelefDato.Name = "txtTelefDato";
            txtTelefDato.Size = new Size(144, 23);
            txtTelefDato.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 11;
            label3.Text = "DNI";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(3, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(3, 77);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
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
            iconBtnAgregar.Location = new Point(80, 99);
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
            iconBtnElim.Location = new Point(211, 99);
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
            iconBtnPermiso.Location = new Point(341, 99);
            iconBtnPermiso.Name = "iconBtnPermiso";
            iconBtnPermiso.Size = new Size(90, 39);
            iconBtnPermiso.TabIndex = 10;
            iconBtnPermiso.Text = "Permiso";
            iconBtnPermiso.TextAlign = ContentAlignment.MiddleRight;
            iconBtnPermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnPermiso.UseVisualStyleBackColor = false;
            iconBtnPermiso.Click += iconBtnPermiso_Click;
            // 
            // FrmGestionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(1014, 633);
            Controls.Add(iconBtnPermiso);
            Controls.Add(iconBtnElim);
            Controls.Add(iconBtnAgregar);
            Controls.Add(panel2);
            Controls.Add(dataGridUsuarios);
            Controls.Add(panel1);
            Name = "FrmGestionarUsuario";
            Text = "Lista de Usuarios";
            Load += FrmGestionarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Label lblDatosUsuario;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private FontAwesome.Sharp.IconButton iconBtnElim;
        private FontAwesome.Sharp.IconButton iconBtnPermiso;
        private Label lblEstado;
        private Label label4;
        private TextBox txtEmailDato;
        private Label label5;
        private Label label6;
        private TextBox txtTelefDato;
        private Label label3;
        private TextBox txtDniDato;
        private TextBox txtApeDato;
        private Label label2;
        private Label label1;
        private TextBox txtNombreDato;
        private ComboBox comboEstadoDato;
        private Label label8;
        private ComboBox comboRolDato;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private TextBox txtIdGuardado;
        private FontAwesome.Sharp.IconButton iconButton1;
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
    }
}