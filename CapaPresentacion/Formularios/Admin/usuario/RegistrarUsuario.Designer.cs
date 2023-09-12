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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuario));
            panel1 = new Panel();
            lblListaEmpleados = new Label();
            panel2 = new Panel();
            btnActualizar = new Button();
            btnCancelar = new Button();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(pciBoxSubirImg);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(contraVisible);
            panel2.Controls.Add(lblPerfilUsuario);
            panel2.Controls.Add(lblDomicilio);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(lblDni);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(lblApellido);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblNombre);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 389);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.BackColor = Color.FromArgb(47, 33, 75);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(374, 343);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(161, 43);
            btnActualizar.TabIndex = 65;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.FromArgb(1, 1, 2);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(151, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 43);
            btnCancelar.TabIndex = 64;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pciBoxSubirImg
            // 
            pciBoxSubirImg.Image = (Image)resources.GetObject("pciBoxSubirImg.Image");
            pciBoxSubirImg.Location = new Point(301, 283);
            pciBoxSubirImg.Name = "pciBoxSubirImg";
            pciBoxSubirImg.Size = new Size(62, 55);
            pciBoxSubirImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pciBoxSubirImg.TabIndex = 41;
            pciBoxSubirImg.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(356, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 39;
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
            contraVisible.Location = new Point(549, 180);
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
            lblDomicilio.Location = new Point(356, 100);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(82, 19);
            lblDomicilio.TabIndex = 15;
            lblDomicilio.Text = "Domicilio";
            // 
            // textBox7
            // 
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Location = new Point(99, 238);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Location = new Point(356, 180);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 23);
            textBox6.TabIndex = 13;
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
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(99, 180);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 23);
            textBox5.TabIndex = 11;
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
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(356, 122);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(99, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 8;
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
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(356, 65);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 5;
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(660, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(99, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 1;
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
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrarUsuario";
            Text = "RegistrarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pciBoxSubirImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private Panel panel2;
        private Label lblNombre;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label lblApellido;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label lblEmail;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label lblTelefono;
        private Label lblDni;
        private Label lblPerfilUsuario;
        private Label lblDomicilio;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label lblPassword;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton contraVisible;
        private PictureBox pciBoxSubirImg;
        private Button btnCancelar;
        private Button btnActualizar;
    }
}