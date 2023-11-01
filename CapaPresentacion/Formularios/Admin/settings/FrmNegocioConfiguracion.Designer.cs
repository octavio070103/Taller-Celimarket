namespace CapaPresentacion.Formularios.Admin.settings
{
    partial class FrmNegocioConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNegocioConfiguracion));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            BtnGuardarCambios = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnSubirLogo = new FontAwesome.Sharp.IconButton();
            txtDireNegocio = new TextBox();
            label7 = new Label();
            txtEmailNegocio = new TextBox();
            label5 = new Label();
            txtTelefNegocio = new TextBox();
            label6 = new Label();
            txtCUITNegocio = new TextBox();
            label4 = new Label();
            txtNombreNegocio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            piclogo = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 565);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 22);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 0;
            label1.Text = "Configuracion del Negocio";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnGuardarCambios);
            panel2.Controls.Add(iconBtnCancelar);
            panel2.Controls.Add(BtnSubirLogo);
            panel2.Controls.Add(txtDireNegocio);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtEmailNegocio);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtTelefNegocio);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCUITNegocio);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNombreNegocio);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(piclogo);
            panel2.Location = new Point(55, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 455);
            panel2.TabIndex = 0;
            // 
            // BtnGuardarCambios
            // 
            BtnGuardarCambios.BackColor = Color.FromArgb(41, 166, 87);
            BtnGuardarCambios.Cursor = Cursors.Hand;
            BtnGuardarCambios.FlatAppearance.BorderColor = Color.Black;
            BtnGuardarCambios.FlatStyle = FlatStyle.Flat;
            BtnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarCambios.ForeColor = SystemColors.ControlLightLight;
            BtnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            BtnGuardarCambios.IconColor = Color.White;
            BtnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarCambios.IconSize = 30;
            BtnGuardarCambios.Location = new Point(17, 401);
            BtnGuardarCambios.Name = "BtnGuardarCambios";
            BtnGuardarCambios.Size = new Size(281, 32);
            BtnGuardarCambios.TabIndex = 72;
            BtnGuardarCambios.Text = "Guardar Cambios";
            BtnGuardarCambios.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardarCambios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardarCambios.UseVisualStyleBackColor = false;
            BtnGuardarCambios.Click += BtnGuardarCambios_Click;
            // 
            // iconBtnCancelar
            // 
            iconBtnCancelar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnCancelar.Cursor = Cursors.Hand;
            iconBtnCancelar.FlatAppearance.BorderColor = Color.Black;
            iconBtnCancelar.FlatStyle = FlatStyle.Flat;
            iconBtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(418, 401);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(281, 32);
            iconBtnCancelar.TabIndex = 71;
            iconBtnCancelar.Text = "Cancelar Cambios";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnSubirLogo
            // 
            BtnSubirLogo.BackColor = Color.FromArgb(41, 166, 87);
            BtnSubirLogo.BackgroundImage = (Image)resources.GetObject("BtnSubirLogo.BackgroundImage");
            BtnSubirLogo.BackgroundImageLayout = ImageLayout.None;
            BtnSubirLogo.Cursor = Cursors.Hand;
            BtnSubirLogo.FlatAppearance.BorderColor = Color.Black;
            BtnSubirLogo.FlatStyle = FlatStyle.Popup;
            BtnSubirLogo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubirLogo.ForeColor = SystemColors.ControlLightLight;
            BtnSubirLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnSubirLogo.IconColor = Color.White;
            BtnSubirLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSubirLogo.IconSize = 30;
            BtnSubirLogo.Location = new Point(494, 294);
            BtnSubirLogo.Name = "BtnSubirLogo";
            BtnSubirLogo.Size = new Size(166, 36);
            BtnSubirLogo.TabIndex = 19;
            BtnSubirLogo.Text = "Subir logo ";
            BtnSubirLogo.TextAlign = ContentAlignment.MiddleRight;
            BtnSubirLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSubirLogo.UseVisualStyleBackColor = false;
            BtnSubirLogo.Click += BtnSubirLogo_Click;
            // 
            // txtDireNegocio
            // 
            txtDireNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtDireNegocio.Location = new Point(17, 326);
            txtDireNegocio.Name = "txtDireNegocio";
            txtDireNegocio.Size = new Size(270, 23);
            txtDireNegocio.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 302);
            label7.Name = "label7";
            label7.Size = new Size(164, 21);
            label7.TabIndex = 10;
            label7.Text = "Direccion Del Negocio";
            // 
            // txtEmailNegocio
            // 
            txtEmailNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtEmailNegocio.Location = new Point(17, 260);
            txtEmailNegocio.Name = "txtEmailNegocio";
            txtEmailNegocio.Size = new Size(270, 23);
            txtEmailNegocio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 236);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 8;
            label5.Text = "Email  Del Negocio";
            // 
            // txtTelefNegocio
            // 
            txtTelefNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtTelefNegocio.Location = new Point(17, 205);
            txtTelefNegocio.Name = "txtTelefNegocio";
            txtTelefNegocio.Size = new Size(270, 23);
            txtTelefNegocio.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(17, 181);
            label6.Name = "label6";
            label6.Size = new Size(161, 21);
            label6.TabIndex = 6;
            label6.Text = "Telefono  Del Negocio";
            // 
            // txtCUITNegocio
            // 
            txtCUITNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtCUITNegocio.Location = new Point(17, 144);
            txtCUITNegocio.Name = "txtCUITNegocio";
            txtCUITNegocio.Size = new Size(270, 23);
            txtCUITNegocio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 120);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 4;
            label4.Text = "CUIT";
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtNombreNegocio.Location = new Point(17, 89);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(270, 23);
            txtNombreNegocio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 65);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre  Del Negocio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(503, 60);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Logo del Negocio";
            // 
            // piclogo
            // 
            piclogo.BorderStyle = BorderStyle.FixedSingle;
            piclogo.Location = new Point(464, 83);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(218, 205);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // FrmNegocioConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 565);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNegocioConfiguracion";
            Text = "Configuracion del Negocio";
            Load += FrmNegocioConfiguracion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox piclogo;
        private TextBox txtNombreNegocio;
        private Label label3;
        private TextBox txtDireNegocio;
        private Label label7;
        private TextBox txtEmailNegocio;
        private Label label5;
        private TextBox txtTelefNegocio;
        private Label label6;
        private TextBox txtCUITNegocio;
        private Label label4;
        private FontAwesome.Sharp.IconButton BtnSubirLogo;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardarCambios;
    }
}