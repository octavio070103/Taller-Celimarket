namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
            panel1 = new Panel();
            lblListaEmpleados = new Label();
            pciBoxSubirImg = new PictureBox();
            comboBox1 = new ComboBox();
            contraVisible = new FontAwesome.Sharp.IconButton();
            lblPerfilUsuario = new Label();
            lblDomicilio = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            lblPassword = new Label();
            textBox5 = new TextBox();
            lblEmail = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            lblTelefono = new Label();
            lblDni = new Label();
            textBox3 = new TextBox();
            lblApellido = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            lblNombre = new Label();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pciBoxSubirImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.TabIndex = 2;
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
            lblListaEmpleados.Size = new Size(232, 45);
            lblListaEmpleados.TabIndex = 0;
            lblListaEmpleados.Text = "Editar Usuario";
            lblListaEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pciBoxSubirImg
            // 
            pciBoxSubirImg.Image = (Image)resources.GetObject("pciBoxSubirImg.Image");
            pciBoxSubirImg.Location = new Point(343, 308);
            pciBoxSubirImg.Name = "pciBoxSubirImg";
            pciBoxSubirImg.Size = new Size(65, 59);
            pciBoxSubirImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pciBoxSubirImg.TabIndex = 60;
            pciBoxSubirImg.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(392, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 59;
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
            contraVisible.Location = new Point(585, 268);
            contraVisible.Name = "contraVisible";
            contraVisible.Size = new Size(20, 20);
            contraVisible.TabIndex = 58;
            contraVisible.TextAlign = ContentAlignment.MiddleRight;
            contraVisible.UseVisualStyleBackColor = false;
            contraVisible.Visible = false;
            // 
            // lblPerfilUsuario
            // 
            lblPerfilUsuario.AutoSize = true;
            lblPerfilUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerfilUsuario.Location = new Point(392, 185);
            lblPerfilUsuario.Name = "lblPerfilUsuario";
            lblPerfilUsuario.Size = new Size(105, 19);
            lblPerfilUsuario.TabIndex = 57;
            lblPerfilUsuario.Text = "Perfil Usuario";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomicilio.Location = new Point(392, 127);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(82, 19);
            lblDomicilio.TabIndex = 56;
            lblDomicilio.Text = "Domicilio";
            // 
            // textBox7
            // 
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Location = new Point(135, 265);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 23);
            textBox7.TabIndex = 55;
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Location = new Point(392, 265);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 23);
            textBox6.TabIndex = 54;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(392, 243);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 19);
            lblPassword.TabIndex = 53;
            lblPassword.Text = "Contraseña";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(135, 207);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 23);
            textBox5.TabIndex = 52;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(135, 243);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 19);
            lblEmail.TabIndex = 51;
            lblEmail.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(392, 149);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 23);
            textBox4.TabIndex = 50;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(135, 149);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 49;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.Location = new Point(134, 185);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 19);
            lblTelefono.TabIndex = 48;
            lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(135, 127);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 19);
            lblDni.TabIndex = 47;
            lblDni.Text = "DNI";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(392, 92);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 46;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(392, 70);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 19);
            lblApellido.TabIndex = 45;
            lblApellido.Text = "Apellido";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(135, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 43;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(135, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 19);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Nombre";
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
            iconbtnGuardar.Location = new Point(401, 403);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(162, 43);
            iconbtnGuardar.TabIndex = 64;
            iconbtnGuardar.Text = "Guardar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
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
            iconBtnCancelar.Location = new Point(186, 403);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(162, 43);
            iconBtnCancelar.TabIndex = 65;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(800, 450);
            Controls.Add(iconBtnCancelar);
            Controls.Add(iconbtnGuardar);
            Controls.Add(pciBoxSubirImg);
            Controls.Add(comboBox1);
            Controls.Add(contraVisible);
            Controls.Add(lblPerfilUsuario);
            Controls.Add(lblDomicilio);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(lblPassword);
            Controls.Add(textBox5);
            Controls.Add(lblEmail);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(lblTelefono);
            Controls.Add(lblDni);
            Controls.Add(textBox3);
            Controls.Add(lblApellido);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(lblNombre);
            Controls.Add(panel1);
            Name = "FrmEditarUsuario";
            Text = "FrmEditarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pciBoxSubirImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private PictureBox pciBoxSubirImg;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton contraVisible;
        private Label lblPerfilUsuario;
        private Label lblDomicilio;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label lblPassword;
        private TextBox textBox5;
        private Label lblEmail;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label lblTelefono;
        private Label lblDni;
        private TextBox textBox3;
        private Label lblApellido;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label lblNombre;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
    }
}