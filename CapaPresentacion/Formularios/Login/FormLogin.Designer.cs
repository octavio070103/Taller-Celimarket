namespace Proyecto_Taller.Presentacion.Formularios.Login
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblCeliMarket = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            btnLogin = new Button();
            linkPassword = new LinkLabel();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            panel2 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 45);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(592, 358);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 59, 96);
            panel1.Controls.Add(lblCeliMarket);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(201, 112);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 200);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // lblCeliMarket
            // 
            lblCeliMarket.AutoSize = true;
            lblCeliMarket.BackColor = Color.FromArgb(58, 59, 96);
            lblCeliMarket.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCeliMarket.ForeColor = SystemColors.ControlLight;
            lblCeliMarket.Location = new Point(43, 0);
            lblCeliMarket.Margin = new Padding(4, 0, 4, 0);
            lblCeliMarket.Name = "lblCeliMarket";
            lblCeliMarket.Size = new Size(166, 40);
            lblCeliMarket.TabIndex = 2;
            lblCeliMarket.Text = "CeliMarket";
            lblCeliMarket.Click += lblDeliMarket_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(67, 68, 89);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(24, 99);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 18);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(67, 68, 89);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.Window;
            txtUsuario.Location = new Point(24, 61);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(187, 18);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(38, 142);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(0, 74, 173);
            linkPassword.AutoSize = true;
            linkPassword.BackColor = Color.FromArgb(15, 16, 44);
            linkPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkPassword.LinkColor = Color.DimGray;
            linkPassword.Location = new Point(234, 315);
            linkPassword.Margin = new Padding(4, 0, 4, 0);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(195, 17);
            linkPassword.TabIndex = 0;
            linkPassword.TabStop = true;
            linkPassword.Text = "Has olvidado la contraseña?";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(1, 1, 2);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(660, 0);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 27);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(1, 1, 2);
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(595, 7);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 27);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.FromArgb(1, 1, 2);
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(628, 0);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 33);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 7;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 1, 2);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnMaximizar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 37);
            panel2.TabIndex = 8;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(687, 440);
            Controls.Add(panel2);
            Controls.Add(linkPassword);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "formLogin";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += formLogin_Load;
            MouseDown += formLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLogin;
        private TextBox txtUsuario;
        private Label lblCeliMarket;
        private TextBox txtPassword;
        private LinkLabel linkPassword;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private Panel panel2;
        private ErrorProvider errorProvider1;
    }
}