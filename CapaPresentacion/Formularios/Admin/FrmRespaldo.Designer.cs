namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmRespaldo
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
            panel1 = new Panel();
            lblListaEmpleados = new Label();
            lblFiltrar = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelDatosUsuario = new Panel();
            lblPassword = new Label();
            txtPasswordDato = new TextBox();
            lblEstadoDato = new Label();
            lblEmailDato = new Label();
            txtEmailDato = new TextBox();
            lblTelefDato = new Label();
            txtTelefDato = new TextBox();
            lbl = new Label();
            txtDniDato = new TextBox();
            lblApellidoDato = new Label();
            lblNombreDato = new Label();
            txtNombreDato = new TextBox();
            lblDatoDelaBD = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panelDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblListaEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 92);
            panel1.TabIndex = 1;
            // 
            // lblListaEmpleados
            // 
            lblListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblListaEmpleados.AutoSize = true;
            lblListaEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEmpleados.ForeColor = SystemColors.ControlLightLight;
            lblListaEmpleados.ImageAlign = ContentAlignment.TopCenter;
            lblListaEmpleados.Location = new Point(308, 9);
            lblListaEmpleados.Name = "lblListaEmpleados";
            lblListaEmpleados.Size = new Size(384, 45);
            lblListaEmpleados.TabIndex = 0;
            lblListaEmpleados.Text = "Respaldo y Restauracion";
            lblListaEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltrar.ForeColor = SystemColors.ControlLightLight;
            lblFiltrar.Location = new Point(141, 129);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(201, 25);
            lblFiltrar.TabIndex = 2;
            lblFiltrar.Text = "Seleccionar Servidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(141, 176);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar La Base De Datos:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(463, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(463, 176);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(209, 23);
            comboBox2.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(19, 173, 39);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.Location = new Point(194, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 39);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Restaurar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(19, 173, 39);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(420, 253);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(166, 39);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Respaldar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(iconbtnGuardar);
            panelDatosUsuario.Controls.Add(iconBtnCancelar);
            panelDatosUsuario.Controls.Add(textBox1);
            panelDatosUsuario.Controls.Add(dateTimePicker1);
            panelDatosUsuario.Controls.Add(lblPassword);
            panelDatosUsuario.Controls.Add(txtPasswordDato);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Controls.Add(lblEmailDato);
            panelDatosUsuario.Controls.Add(txtEmailDato);
            panelDatosUsuario.Controls.Add(lblTelefDato);
            panelDatosUsuario.Controls.Add(txtTelefDato);
            panelDatosUsuario.Controls.Add(lbl);
            panelDatosUsuario.Controls.Add(txtDniDato);
            panelDatosUsuario.Controls.Add(lblApellidoDato);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(txtNombreDato);
            panelDatosUsuario.Controls.Add(lblDatoDelaBD);
            panelDatosUsuario.Location = new Point(757, 92);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(257, 517);
            panelDatosUsuario.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.WindowText;
            lblPassword.Location = new Point(3, 193);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(51, 17);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Tablas ";
            // 
            // txtPasswordDato
            // 
            txtPasswordDato.Location = new Point(79, 187);
            txtPasswordDato.Name = "txtPasswordDato";
            txtPasswordDato.Size = new Size(144, 23);
            txtPasswordDato.TabIndex = 28;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(5, 274);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(167, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Elegir donde se Guardara ";
            // 
            // lblEmailDato
            // 
            lblEmailDato.AutoSize = true;
            lblEmailDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailDato.ForeColor = SystemColors.WindowText;
            lblEmailDato.Location = new Point(3, 164);
            lblEmailDato.Name = "lblEmailDato";
            lblEmailDato.Size = new Size(49, 17);
            lblEmailDato.TabIndex = 17;
            lblEmailDato.Text = "Estado";
            // 
            // txtEmailDato
            // 
            txtEmailDato.Location = new Point(79, 158);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 16;
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(3, 222);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(125, 17);
            lblTelefDato.TabIndex = 13;
            lblTelefDato.Text = "objetos principales";
            // 
            // txtTelefDato
            // 
            txtTelefDato.Location = new Point(79, 242);
            txtTelefDato.Name = "txtTelefDato";
            txtTelefDato.Size = new Size(144, 23);
            txtTelefDato.TabIndex = 12;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.WindowText;
            lbl.Location = new Point(3, 48);
            lbl.Name = "lbl";
            lbl.Size = new Size(58, 17);
            lbl.TabIndex = 11;
            lbl.Text = "Nombre";
            // 
            // txtDniDato
            // 
            txtDniDato.Location = new Point(79, 42);
            txtDniDato.Name = "txtDniDato";
            txtDniDato.Size = new Size(144, 23);
            txtDniDato.TabIndex = 10;
            // 
            // lblApellidoDato
            // 
            lblApellidoDato.AutoSize = true;
            lblApellidoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidoDato.ForeColor = SystemColors.WindowText;
            lblApellidoDato.Location = new Point(3, 106);
            lblApellidoDato.Name = "lblApellidoDato";
            lblApellidoDato.Size = new Size(153, 17);
            lblApellidoDato.TabIndex = 8;
            lblApellidoDato.Text = "Ultimo Respaldo Hecho";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(3, 77);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(57, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Tamaño";
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 71);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            // 
            // lblDatoDelaBD
            // 
            lblDatoDelaBD.AutoSize = true;
            lblDatoDelaBD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatoDelaBD.Location = new Point(0, 9);
            lblDatoDelaBD.Name = "lblDatoDelaBD";
            lblDatoDelaBD.Size = new Size(261, 30);
            lblDatoDelaBD.TabIndex = 0;
            lblDatoDelaBD.Text = "Datos De La Base de datos";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(79, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(79, 294);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 31;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(56, 182, 255);
            iconbtnGuardar.BackgroundImageLayout = ImageLayout.Center;
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 36;
            iconbtnGuardar.Location = new Point(35, 398);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(188, 39);
            iconbtnGuardar.TabIndex = 33;
            iconbtnGuardar.Text = "Confirmar";
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
            iconBtnCancelar.Location = new Point(35, 443);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(188, 39);
            iconBtnCancelar.TabIndex = 32;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(1014, 633);
            Controls.Add(panelDatosUsuario);
            Controls.Add(iconButton1);
            Controls.Add(btnAgregar);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(lblFiltrar);
            Controls.Add(panel1);
            Name = "FrmRespaldo";
            Text = "Respaldo y Restauracion De La Base DeDa tos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private Label lblFiltrar;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelDatosUsuario;
        private Label lblPassword;
        private TextBox txtPasswordDato;
        private TextBox txtIdGuardado;
        private Label lblEstadoDato;
        private Label lblEmailDato;
        private TextBox txtEmailDato;
        private Label lblTelefDato;
        private TextBox txtTelefDato;
        private Label lblApellidoDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatoDelaBD;
        private Label lbl;
        private TextBox txtDniDato;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
    }
}