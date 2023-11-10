namespace CapaPresentacion.Formularios.Admin
{
    partial class RegistrarUsuario
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
            panel1 = new Panel();
            lblListaEmpleados = new Label();
            panel2 = new Panel();
            dateTimePickerNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            comboRolUsu = new ComboBox();
            contraVisible = new FontAwesome.Sharp.IconButton();
            lblPerfilUsuario = new Label();
            lblDomicilio = new Label();
            txtEmailUsu = new TextBox();
            txtPasswordUsu = new TextBox();
            lblPassword = new Label();
            txtTelefUsu = new TextBox();
            lblEmail = new Label();
            txtDniUsu = new TextBox();
            lblTelefono = new Label();
            lblDni = new Label();
            txtApelliUsu = new TextBox();
            lblApellido = new Label();
            txtNombreUsu = new TextBox();
            lblNombre = new Label();
            iconBtnDomicilio = new FontAwesome.Sharp.IconButton();
            txtDomRegistrado = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblListaEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 1;
            // 
            // lblListaEmpleados
            // 
            lblListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblListaEmpleados.AutoSize = true;
            lblListaEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEmpleados.ForeColor = SystemColors.ControlLightLight;
            lblListaEmpleados.ImageAlign = ContentAlignment.TopCenter;
            lblListaEmpleados.Location = new Point(267, 0);
            lblListaEmpleados.Name = "lblListaEmpleados";
            lblListaEmpleados.Size = new Size(279, 45);
            lblListaEmpleados.TabIndex = 0;
            lblListaEmpleados.Text = "Registrar Usuario";
            lblListaEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(dateTimePickerNacimiento);
            panel2.Controls.Add(lblFechaNacimiento);
            panel2.Controls.Add(iconBtnCancelar);
            panel2.Controls.Add(iconbtnGuardar);
            panel2.Controls.Add(iconBtnLimpiarDatos);
            panel2.Controls.Add(comboRolUsu);
            panel2.Controls.Add(contraVisible);
            panel2.Controls.Add(lblPerfilUsuario);
            panel2.Controls.Add(lblDomicilio);
            panel2.Controls.Add(txtEmailUsu);
            panel2.Controls.Add(txtPasswordUsu);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtTelefUsu);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(txtDniUsu);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(lblDni);
            panel2.Controls.Add(txtApelliUsu);
            panel2.Controls.Add(lblApellido);
            panel2.Controls.Add(txtNombreUsu);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(iconBtnDomicilio);
            panel2.Controls.Add(txtDomRegistrado);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 389);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePickerNacimiento
            // 
            dateTimePickerNacimiento.Format = DateTimePickerFormat.Short;
            dateTimePickerNacimiento.Location = new Point(99, 286);
            dateTimePickerNacimiento.MaxDate = new DateTime(2023, 11, 9, 0, 0, 0, 0);
            dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            dateTimePickerNacimiento.Size = new Size(200, 23);
            dateTimePickerNacimiento.TabIndex = 73;
            dateTimePickerNacimiento.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(99, 264);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(178, 19);
            lblFechaNacimiento.TabIndex = 72;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // iconBtnCancelar
            // 
            iconBtnCancelar.BackColor = Color.FromArgb(1, 1, 2);
            iconBtnCancelar.Cursor = Cursors.Hand;
            iconBtnCancelar.FlatAppearance.BorderColor = Color.Black;
            iconBtnCancelar.FlatStyle = FlatStyle.Flat;
            iconBtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(150, 343);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(162, 43);
            iconBtnCancelar.TabIndex = 70;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            iconBtnCancelar.Click += iconBtnCancelar_Click;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(47, 33, 75);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 30;
            iconbtnGuardar.Location = new Point(384, 343);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(162, 43);
            iconbtnGuardar.TabIndex = 69;
            iconbtnGuardar.Text = "Guardar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
            // 
            // iconBtnLimpiarDatos
            // 
            iconBtnLimpiarDatos.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnLimpiarDatos.Cursor = Cursors.Hand;
            iconBtnLimpiarDatos.FlatAppearance.BorderColor = Color.Black;
            iconBtnLimpiarDatos.FlatStyle = FlatStyle.Flat;
            iconBtnLimpiarDatos.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnLimpiarDatos.ForeColor = SystemColors.ControlLightLight;
            iconBtnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconBtnLimpiarDatos.IconColor = Color.White;
            iconBtnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnLimpiarDatos.IconSize = 30;
            iconBtnLimpiarDatos.Location = new Point(617, 298);
            iconBtnLimpiarDatos.Name = "iconBtnLimpiarDatos";
            iconBtnLimpiarDatos.Size = new Size(87, 43);
            iconBtnLimpiarDatos.TabIndex = 68;
            iconBtnLimpiarDatos.Text = "Limpiar";
            iconBtnLimpiarDatos.TextAlign = ContentAlignment.MiddleRight;
            iconBtnLimpiarDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnLimpiarDatos.UseVisualStyleBackColor = false;
            iconBtnLimpiarDatos.Click += iconBtnLimpiarDatos_Click;
            // 
            // comboRolUsu
            // 
            comboRolUsu.FormattingEnabled = true;
            comboRolUsu.Location = new Point(356, 180);
            comboRolUsu.Name = "comboRolUsu";
            comboRolUsu.Size = new Size(213, 23);
            comboRolUsu.TabIndex = 39;
            // 
            // contraVisible
            // 
            contraVisible.BackColor = SystemColors.Window;
            contraVisible.FlatStyle = FlatStyle.Flat;
            contraVisible.ForeColor = Color.Transparent;
            contraVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            contraVisible.IconColor = Color.Gray;
            contraVisible.IconFont = FontAwesome.Sharp.IconFont.Auto;
            contraVisible.IconSize = 26;
            contraVisible.Location = new Point(549, 244);
            contraVisible.Name = "contraVisible";
            contraVisible.Size = new Size(20, 20);
            contraVisible.TabIndex = 38;
            contraVisible.TextAlign = ContentAlignment.MiddleRight;
            contraVisible.UseVisualStyleBackColor = false;
            contraVisible.Visible = false;
            // 
            // lblPerfilUsuario
            // 
            lblPerfilUsuario.AutoSize = true;
            lblPerfilUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerfilUsuario.Location = new Point(356, 158);
            lblPerfilUsuario.Name = "lblPerfilUsuario";
            lblPerfilUsuario.Size = new Size(105, 19);
            lblPerfilUsuario.TabIndex = 17;
            lblPerfilUsuario.Text = "Perfil Usuario";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomicilio.Location = new Point(356, 94);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(82, 19);
            lblDomicilio.TabIndex = 15;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtEmailUsu
            // 
            txtEmailUsu.Cursor = Cursors.IBeam;
            txtEmailUsu.Location = new Point(99, 238);
            txtEmailUsu.Multiline = true;
            txtEmailUsu.Name = "txtEmailUsu";
            txtEmailUsu.Size = new Size(213, 23);
            txtEmailUsu.TabIndex = 14;
            // 
            // txtPasswordUsu
            // 
            txtPasswordUsu.Cursor = Cursors.IBeam;
            txtPasswordUsu.Location = new Point(356, 241);
            txtPasswordUsu.Multiline = true;
            txtPasswordUsu.Name = "txtPasswordUsu";
            txtPasswordUsu.PasswordChar = '*';
            txtPasswordUsu.Size = new Size(213, 23);
            txtPasswordUsu.TabIndex = 13;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(356, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 19);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Contraseña";
            // 
            // txtTelefUsu
            // 
            txtTelefUsu.Cursor = Cursors.IBeam;
            txtTelefUsu.Location = new Point(99, 180);
            txtTelefUsu.Multiline = true;
            txtTelefUsu.Name = "txtTelefUsu";
            txtTelefUsu.Size = new Size(213, 23);
            txtTelefUsu.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(99, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 19);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtDniUsu
            // 
            txtDniUsu.Cursor = Cursors.IBeam;
            txtDniUsu.Location = new Point(99, 122);
            txtDniUsu.Multiline = true;
            txtDniUsu.Name = "txtDniUsu";
            txtDniUsu.Size = new Size(213, 23);
            txtDniUsu.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.Location = new Point(98, 158);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 19);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(99, 100);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 19);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI";
            // 
            // txtApelliUsu
            // 
            txtApelliUsu.Cursor = Cursors.IBeam;
            txtApelliUsu.Location = new Point(356, 65);
            txtApelliUsu.Multiline = true;
            txtApelliUsu.Name = "txtApelliUsu";
            txtApelliUsu.Size = new Size(213, 23);
            txtApelliUsu.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(356, 43);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 19);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtNombreUsu
            // 
            txtNombreUsu.Cursor = Cursors.IBeam;
            txtNombreUsu.Location = new Point(99, 65);
            txtNombreUsu.Multiline = true;
            txtNombreUsu.Name = "txtNombreUsu";
            txtNombreUsu.Size = new Size(213, 23);
            txtNombreUsu.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(99, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // iconBtnDomicilio
            // 
            iconBtnDomicilio.BackColor = Color.FromArgb(255, 222, 89);
            iconBtnDomicilio.Cursor = Cursors.Hand;
            iconBtnDomicilio.FlatAppearance.BorderColor = Color.Black;
            iconBtnDomicilio.FlatStyle = FlatStyle.Flat;
            iconBtnDomicilio.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnDomicilio.ForeColor = Color.White;
            iconBtnDomicilio.IconChar = FontAwesome.Sharp.IconChar.House;
            iconBtnDomicilio.IconColor = Color.White;
            iconBtnDomicilio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDomicilio.IconSize = 30;
            iconBtnDomicilio.ImageAlign = ContentAlignment.TopCenter;
            iconBtnDomicilio.Location = new Point(356, 116);
            iconBtnDomicilio.Name = "iconBtnDomicilio";
            iconBtnDomicilio.Size = new Size(213, 33);
            iconBtnDomicilio.TabIndex = 66;
            iconBtnDomicilio.Text = "Agregar Domicilio";
            iconBtnDomicilio.TextAlign = ContentAlignment.MiddleRight;
            iconBtnDomicilio.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDomicilio.UseVisualStyleBackColor = false;
            iconBtnDomicilio.Click += iconBtnDomicilio_Click;
            // 
            // txtDomRegistrado
            // 
            txtDomRegistrado.Cursor = Cursors.IBeam;
            txtDomRegistrado.Location = new Point(356, 122);
            txtDomRegistrado.Multiline = true;
            txtDomRegistrado.Name = "txtDomRegistrado";
            txtDomRegistrado.ReadOnly = true;
            txtDomRegistrado.Size = new Size(213, 23);
            txtDomRegistrado.TabIndex = 74;
            txtDomRegistrado.Visible = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarUsuario";
            Text = "RegistrarUsuario";
            Load += RegistrarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private Panel panel2;
        private Label lblNombre;
        private TextBox txtNombreUsu;
        private TextBox txtApelliUsu;
        private Label lblApellido;
        private TextBox txtTelefUsu;
        private Label lblEmail;
        private TextBox txtDniUsu;
        private Label lblTelefono;
        private Label lblDni;
        private Label lblPerfilUsuario;
        private Label lblDomicilio;
        private TextBox txtEmailUsu;
        private TextBox txtPasswordUsu;
        private Label lblPassword;
        private ComboBox comboRolUsu;
        private FontAwesome.Sharp.IconButton contraVisible;
        private FontAwesome.Sharp.IconButton iconBtnDomicilio;
        private FontAwesome.Sharp.IconButton iconBtnLimpiarDatos;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private ErrorProvider errorProvider1;
        private Label lblFechaNacimiento;
        private DateTimePicker dateTimePickerNacimiento;
        private TextBox txtDomRegistrado;
    }
}