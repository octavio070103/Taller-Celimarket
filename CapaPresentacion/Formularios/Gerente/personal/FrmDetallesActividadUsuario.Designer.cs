namespace CapaPresentacion.Formularios.Gerente.personal
{
    partial class FrmDetallesActividadUsuario
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
            panel1 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelDatosUsuario.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panelDatosUsuario.Location = new Point(569, 3);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(238, 426);
            panelDatosUsuario.TabIndex = 17;
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
            // panel1
            // 
            panel1.Controls.Add(panelDatosUsuario);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 442);
            panel1.TabIndex = 18;
            // 
            // FrmDetallesActividadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(806, 441);
            Controls.Add(panel1);
            Name = "FrmDetallesActividadUsuario";
            Text = "FrmDetallesActividadUsuario";
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}