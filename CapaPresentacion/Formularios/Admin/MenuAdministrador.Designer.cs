namespace CapaPresentacion.Formularios.Admin
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            picRestaurar = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTituloMenu = new Label();
            btnMenu = new Button();
            picMinPantalla = new PictureBox();
            picMaxPantalla = new PictureBox();
            picCerrar = new PictureBox();
            PVentana = new Panel();
            PMenuLat = new Panel();
            btnCategoria = new Button();
            btnAdministrarAcceso = new Button();
            BtnProducto = new Button();
            BtnDashBoard = new Button();
            BtnBackup = new Button();
            BtnGestionConsulta = new Button();
            btnGestionUsuario = new Button();
            BtnCerrarSesion = new Button();
            btnLogout = new Button();
            PLogo = new Panel();
            lblNombreDelUsu = new Label();
            lblRolDelUsu = new Label();
            pictureBox1 = new PictureBox();
            picUsuario = new PictureBox();
            sidebarTime = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            PVentana.SuspendLayout();
            PMenuLat.SuspendLayout();
            PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 1, 2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(picRestaurar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblTituloMenu);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(picMinPantalla);
            panel1.Controls.Add(picMaxPantalla);
            panel1.Controls.Add(picCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 45);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1127, 5);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(1099, 3);
            picRestaurar.Margin = new Padding(4, 3, 4, 3);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(26, 28);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 0;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            picRestaurar.Click += picRestaurar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1064, 14);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMenu.ForeColor = SystemColors.ControlLightLight;
            lblTituloMenu.Location = new Point(519, 8);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(58, 25);
            lblTituloMenu.TabIndex = 15;
            lblTituloMenu.Text = "Inicio";
            lblTituloMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(1, 1, 2);
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = SystemColors.ControlLightLight;
            btnMenu.Location = new Point(4, 3);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(12, 0, 0, 0);
            btnMenu.Size = new Size(125, 40);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu Principal";
            btnMenu.TextAlign = ContentAlignment.MiddleRight;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // picMinPantalla
            // 
            picMinPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinPantalla.Cursor = Cursors.Hand;
            picMinPantalla.Image = (Image)resources.GetObject("picMinPantalla.Image");
            picMinPantalla.Location = new Point(1798, 14);
            picMinPantalla.Margin = new Padding(4, 3, 4, 3);
            picMinPantalla.Name = "picMinPantalla";
            picMinPantalla.Size = new Size(27, 24);
            picMinPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMinPantalla.TabIndex = 1;
            picMinPantalla.TabStop = false;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(1099, 5);
            picMaxPantalla.Margin = new Padding(4, 3, 4, 3);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(26, 27);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 8;
            picMaxPantalla.TabStop = false;
            picMaxPantalla.Click += picMaxPantalla_Click;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1865, 5);
            picCerrar.Margin = new Padding(4, 3, 4, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(28, 24);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 0;
            picCerrar.TabStop = false;
            // 
            // PVentana
            // 
            PVentana.BackColor = Color.FromArgb(67, 68, 89);
            PVentana.Controls.Add(PMenuLat);
            PVentana.Dock = DockStyle.Fill;
            PVentana.Location = new Point(0, 45);
            PVentana.Margin = new Padding(4, 3, 4, 3);
            PVentana.Name = "PVentana";
            PVentana.Size = new Size(1159, 604);
            PVentana.TabIndex = 6;
            PVentana.MouseDown += PVentana_MouseDown;
            // 
            // PMenuLat
            // 
            PMenuLat.BackColor = Color.FromArgb(17, 17, 27);
            PMenuLat.Controls.Add(btnCategoria);
            PMenuLat.Controls.Add(btnAdministrarAcceso);
            PMenuLat.Controls.Add(BtnProducto);
            PMenuLat.Controls.Add(BtnDashBoard);
            PMenuLat.Controls.Add(BtnBackup);
            PMenuLat.Controls.Add(BtnGestionConsulta);
            PMenuLat.Controls.Add(btnGestionUsuario);
            PMenuLat.Controls.Add(BtnCerrarSesion);
            PMenuLat.Controls.Add(btnLogout);
            PMenuLat.Controls.Add(PLogo);
            PMenuLat.Dock = DockStyle.Left;
            PMenuLat.Location = new Point(0, 0);
            PMenuLat.Margin = new Padding(4, 3, 4, 3);
            PMenuLat.MaximumSize = new Size(186, 0);
            PMenuLat.MinimumSize = new Size(62, 604);
            PMenuLat.Name = "PMenuLat";
            PMenuLat.Size = new Size(186, 604);
            PMenuLat.TabIndex = 15;
            PMenuLat.MouseDown += PMenuLat_MouseDown;
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.FromArgb(17, 17, 27);
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.Dock = DockStyle.Top;
            btnCategoria.FlatStyle = FlatStyle.Popup;
            btnCategoria.ForeColor = SystemColors.ControlLightLight;
            btnCategoria.Image = (Image)resources.GetObject("btnCategoria.Image");
            btnCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategoria.Location = new Point(0, 412);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Padding = new Padding(10, 0, 0, 0);
            btnCategoria.Size = new Size(186, 45);
            btnCategoria.TabIndex = 33;
            btnCategoria.Text = "   Categoria";
            btnCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnAdministrarAcceso
            // 
            btnAdministrarAcceso.BackColor = Color.FromArgb(17, 17, 27);
            btnAdministrarAcceso.Cursor = Cursors.Hand;
            btnAdministrarAcceso.Dock = DockStyle.Top;
            btnAdministrarAcceso.FlatStyle = FlatStyle.Popup;
            btnAdministrarAcceso.ForeColor = SystemColors.ControlLightLight;
            btnAdministrarAcceso.Image = (Image)resources.GetObject("btnAdministrarAcceso.Image");
            btnAdministrarAcceso.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministrarAcceso.Location = new Point(0, 367);
            btnAdministrarAcceso.Name = "btnAdministrarAcceso";
            btnAdministrarAcceso.Padding = new Padding(10, 0, 0, 0);
            btnAdministrarAcceso.Size = new Size(186, 45);
            btnAdministrarAcceso.TabIndex = 32;
            btnAdministrarAcceso.Text = "   Administrar Acceso";
            btnAdministrarAcceso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministrarAcceso.UseVisualStyleBackColor = false;
            btnAdministrarAcceso.Click += btnAdministrarAcceso_Click;
            btnAdministrarAcceso.MouseEnter += btnAdministrarAcceso_MouseEnter;
            btnAdministrarAcceso.MouseLeave += btnAdministrarAcceso_MouseLeave;
            // 
            // BtnProducto
            // 
            BtnProducto.BackColor = Color.FromArgb(17, 17, 27);
            BtnProducto.Cursor = Cursors.Hand;
            BtnProducto.Dock = DockStyle.Top;
            BtnProducto.FlatStyle = FlatStyle.Popup;
            BtnProducto.ForeColor = SystemColors.ControlLightLight;
            BtnProducto.Image = (Image)resources.GetObject("BtnProducto.Image");
            BtnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProducto.Location = new Point(0, 322);
            BtnProducto.Name = "BtnProducto";
            BtnProducto.Padding = new Padding(10, 0, 0, 0);
            BtnProducto.Size = new Size(186, 45);
            BtnProducto.TabIndex = 31;
            BtnProducto.Text = "Producto";
            BtnProducto.UseVisualStyleBackColor = false;
            BtnProducto.Click += BtnProducto_Click;
            BtnProducto.MouseEnter += BtnProducto_MouseEnter;
            BtnProducto.MouseLeave += BtnProducto_MouseLeave;
            // 
            // BtnDashBoard
            // 
            BtnDashBoard.BackColor = Color.FromArgb(17, 17, 27);
            BtnDashBoard.Cursor = Cursors.Hand;
            BtnDashBoard.Dock = DockStyle.Top;
            BtnDashBoard.FlatStyle = FlatStyle.Popup;
            BtnDashBoard.ForeColor = SystemColors.ControlLightLight;
            BtnDashBoard.Image = (Image)resources.GetObject("BtnDashBoard.Image");
            BtnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashBoard.Location = new Point(0, 277);
            BtnDashBoard.Name = "BtnDashBoard";
            BtnDashBoard.Padding = new Padding(10, 0, 0, 0);
            BtnDashBoard.Size = new Size(186, 45);
            BtnDashBoard.TabIndex = 30;
            BtnDashBoard.Text = "DashBoard";
            BtnDashBoard.UseVisualStyleBackColor = false;
            BtnDashBoard.Click += BtnDashBoard_Click;
            BtnDashBoard.MouseEnter += BtnDashBoard_MouseEnter;
            BtnDashBoard.MouseLeave += BtnDashBoard_MouseLeave;
            // 
            // BtnBackup
            // 
            BtnBackup.BackColor = Color.FromArgb(17, 17, 27);
            BtnBackup.Cursor = Cursors.Hand;
            BtnBackup.Dock = DockStyle.Top;
            BtnBackup.FlatStyle = FlatStyle.Popup;
            BtnBackup.ForeColor = SystemColors.ControlLightLight;
            BtnBackup.Image = (Image)resources.GetObject("BtnBackup.Image");
            BtnBackup.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBackup.Location = new Point(0, 232);
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Padding = new Padding(10, 0, 0, 0);
            BtnBackup.Size = new Size(186, 45);
            BtnBackup.TabIndex = 29;
            BtnBackup.Text = "Respaldo y Restauracion";
            BtnBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBackup.UseVisualStyleBackColor = false;
            BtnBackup.Click += BtnBackup_Click;
            BtnBackup.MouseEnter += BtnBackup_MouseEnter;
            BtnBackup.MouseLeave += BtnBackup_MouseLeave;
            // 
            // BtnGestionConsulta
            // 
            BtnGestionConsulta.BackColor = Color.FromArgb(17, 17, 27);
            BtnGestionConsulta.Cursor = Cursors.Hand;
            BtnGestionConsulta.Dock = DockStyle.Top;
            BtnGestionConsulta.FlatStyle = FlatStyle.Popup;
            BtnGestionConsulta.ForeColor = SystemColors.ControlLightLight;
            BtnGestionConsulta.Image = (Image)resources.GetObject("BtnGestionConsulta.Image");
            BtnGestionConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGestionConsulta.Location = new Point(0, 187);
            BtnGestionConsulta.Name = "BtnGestionConsulta";
            BtnGestionConsulta.Padding = new Padding(10, 0, 0, 0);
            BtnGestionConsulta.Size = new Size(186, 45);
            BtnGestionConsulta.TabIndex = 28;
            BtnGestionConsulta.Text = "  Gestionar Consultas y Reclamos";
            BtnGestionConsulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGestionConsulta.UseVisualStyleBackColor = false;
            BtnGestionConsulta.Click += BtnGestionConsulta_Click;
            BtnGestionConsulta.MouseEnter += BtnGestionConsulta_MouseEnter;
            BtnGestionConsulta.MouseLeave += BtnGestionConsulta_MouseLeave;
            // 
            // btnGestionUsuario
            // 
            btnGestionUsuario.BackColor = Color.FromArgb(17, 17, 27);
            btnGestionUsuario.Cursor = Cursors.Hand;
            btnGestionUsuario.Dock = DockStyle.Top;
            btnGestionUsuario.FlatStyle = FlatStyle.Popup;
            btnGestionUsuario.ForeColor = SystemColors.ControlLightLight;
            btnGestionUsuario.Image = (Image)resources.GetObject("btnGestionUsuario.Image");
            btnGestionUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuario.Location = new Point(0, 142);
            btnGestionUsuario.Name = "btnGestionUsuario";
            btnGestionUsuario.Padding = new Padding(10, 0, 0, 0);
            btnGestionUsuario.Size = new Size(186, 45);
            btnGestionUsuario.TabIndex = 27;
            btnGestionUsuario.Text = "  Gestionar Usuario";
            btnGestionUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionUsuario.UseVisualStyleBackColor = false;
            btnGestionUsuario.Click += btnGestionUsuario_Click;
            btnGestionUsuario.MouseEnter += btnGestionUsuario_MouseEnter;
            btnGestionUsuario.MouseLeave += btnGestionUsuario_MouseLeave;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCerrarSesion.BackColor = Color.FromArgb(17, 17, 27);
            BtnCerrarSesion.Cursor = Cursors.Hand;
            BtnCerrarSesion.FlatStyle = FlatStyle.Popup;
            BtnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrarSesion.Location = new Point(-5, 556);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Padding = new Padding(10, 0, 0, 0);
            BtnCerrarSesion.Size = new Size(191, 45);
            BtnCerrarSesion.TabIndex = 25;
            BtnCerrarSesion.Text = "Cerrar Sesion";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(17, 17, 27);
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(4, 15142);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(106, 43);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // PLogo
            // 
            PLogo.BackColor = Color.FromArgb(9, 10, 25);
            PLogo.Controls.Add(lblNombreDelUsu);
            PLogo.Controls.Add(lblRolDelUsu);
            PLogo.Controls.Add(pictureBox1);
            PLogo.Controls.Add(picUsuario);
            PLogo.Dock = DockStyle.Top;
            PLogo.Location = new Point(0, 0);
            PLogo.Margin = new Padding(4, 3, 4, 3);
            PLogo.Name = "PLogo";
            PLogo.Size = new Size(186, 142);
            PLogo.TabIndex = 1;
            PLogo.MouseDown += PLogo_MouseDown;
            // 
            // lblNombreDelUsu
            // 
            lblNombreDelUsu.AutoSize = true;
            lblNombreDelUsu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDelUsu.ForeColor = SystemColors.ControlLightLight;
            lblNombreDelUsu.Location = new Point(4, 114);
            lblNombreDelUsu.Name = "lblNombreDelUsu";
            lblNombreDelUsu.Size = new Size(150, 21);
            lblNombreDelUsu.TabIndex = 17;
            lblNombreDelUsu.Text = "nombre y apellido";
            // 
            // lblRolDelUsu
            // 
            lblRolDelUsu.AutoSize = true;
            lblRolDelUsu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolDelUsu.ForeColor = Color.Red;
            lblRolDelUsu.Location = new Point(4, 81);
            lblRolDelUsu.Name = "lblRolDelUsu";
            lblRolDelUsu.Size = new Size(31, 21);
            lblRolDelUsu.TabIndex = 16;
            lblRolDelUsu.Text = "rol";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(9, 10, 25);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // picUsuario
            // 
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(117, 0);
            picUsuario.Margin = new Padding(4, 3, 4, 3);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(68, 78);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 0;
            picUsuario.TabStop = false;
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 10;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1159, 649);
            Controls.Add(PVentana);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1159, 649);
            Name = "MenuAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuAdmin";
            Load += MenuAdministrador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            PVentana.ResumeLayout(false);
            PMenuLat.ResumeLayout(false);
            PLogo.ResumeLayout(false);
            PLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTituloMenu;
        private PictureBox picRestaurar;
        private Button btnMenu;
        private PictureBox picMinPantalla;
        private PictureBox picMaxPantalla;
        private PictureBox picCerrar;
        private Panel PVentana;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer sidebarTime;
        private Panel PMenuLat;
        private Button btnLogout;
        private Panel PLogo;
        private Label lblNombreDelUsu;
        private Label lblRolDelUsu;
        private PictureBox pictureBox1;
        private PictureBox picUsuario;
        private Button BtnCerrarSesion;
        private Button BtnDashBoard;
        private Button BtnBackup;
        private Button BtnGestionConsulta;
        private Button btnGestionUsuario;
        private Button BtnProducto;
        private Button btnAdministrarAcceso;
        private Button btnCategoria;
    }
}