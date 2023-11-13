namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    partial class MenuGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGerente));
            sidebarTime = new System.Windows.Forms.Timer(components);
            panelBarraSuperior = new Panel();
            btnCrearF = new FontAwesome.Sharp.IconButton();
            picRestaurar = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTituloMenu = new Label();
            btnMenu = new Button();
            picMinPantalla = new PictureBox();
            picMaxPantalla = new PictureBox();
            picCerrar = new PictureBox();
            PVentana = new Panel();
            panelCrearPoC = new Panel();
            iconBtnCrearConsulta = new FontAwesome.Sharp.IconButton();
            iconbtnCrearPermiso = new FontAwesome.Sharp.IconButton();
            PMenuLat = new Panel();
            BtnCerrarSesion = new Button();
            iconBtnCaja = new FontAwesome.Sharp.IconButton();
            iconBtnOperaciones = new FontAwesome.Sharp.IconButton();
            iconBtnEstadisticas = new FontAwesome.Sharp.IconButton();
            iconBtnVentas = new FontAwesome.Sharp.IconButton();
            iconBtnPersonal = new FontAwesome.Sharp.IconButton();
            btnLogout = new Button();
            PLogo = new Panel();
            lblNombreDelUsu = new Label();
            lblRolDelUsu = new Label();
            pictureMenuHambur = new PictureBox();
            picUsuario = new PictureBox();
            toolTipMenuGerente = new ToolTip(components);
            panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            PVentana.SuspendLayout();
            panelCrearPoC.SuspendLayout();
            PMenuLat.SuspendLayout();
            PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMenuHambur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            SuspendLayout();
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 10;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.BackColor = Color.FromArgb(1, 1, 2);
            panelBarraSuperior.Controls.Add(btnCrearF);
            panelBarraSuperior.Controls.Add(picRestaurar);
            panelBarraSuperior.Controls.Add(pictureBox2);
            panelBarraSuperior.Controls.Add(lblTituloMenu);
            panelBarraSuperior.Controls.Add(btnMenu);
            panelBarraSuperior.Controls.Add(picMinPantalla);
            panelBarraSuperior.Controls.Add(picMaxPantalla);
            panelBarraSuperior.Controls.Add(picCerrar);
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Margin = new Padding(4, 3, 4, 3);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(1159, 45);
            panelBarraSuperior.TabIndex = 6;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown;
            // 
            // btnCrearF
            // 
            btnCrearF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCrearF.BackColor = Color.FromArgb(1, 1, 2);
            btnCrearF.BackgroundImage = (Image)resources.GetObject("btnCrearF.BackgroundImage");
            btnCrearF.BackgroundImageLayout = ImageLayout.Center;
            btnCrearF.Cursor = Cursors.Hand;
            btnCrearF.FlatAppearance.BorderColor = Color.Black;
            btnCrearF.FlatStyle = FlatStyle.Flat;
            btnCrearF.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearF.ForeColor = SystemColors.ControlLightLight;
            btnCrearF.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCrearF.IconColor = Color.White;
            btnCrearF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearF.IconSize = 30;
            btnCrearF.Location = new Point(934, 9);
            btnCrearF.Name = "btnCrearF";
            btnCrearF.Size = new Size(29, 35);
            btnCrearF.TabIndex = 19;
            btnCrearF.TextAlign = ContentAlignment.MiddleRight;
            btnCrearF.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTipMenuGerente.SetToolTip(btnCrearF, "Ver Permiso o consulta");
            btnCrearF.UseVisualStyleBackColor = false;
            btnCrearF.Click += btnCrearF_Click;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(1099, 5);
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
            pictureBox2.Location = new Point(2023, 14);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
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
            btnMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlLightLight;
            btnMenu.Location = new Point(4, 2);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(12, 0, 0, 0);
            btnMenu.Size = new Size(123, 40);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu Principal";
            btnMenu.TextAlign = ContentAlignment.MiddleRight;
            toolTipMenuGerente.SetToolTip(btnMenu, "Menu principal");
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // picMinPantalla
            // 
            picMinPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinPantalla.Cursor = Cursors.Hand;
            picMinPantalla.Image = (Image)resources.GetObject("picMinPantalla.Image");
            picMinPantalla.Location = new Point(1064, 14);
            picMinPantalla.Margin = new Padding(4, 3, 4, 3);
            picMinPantalla.Name = "picMinPantalla";
            picMinPantalla.Size = new Size(27, 24);
            picMinPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMinPantalla.TabIndex = 1;
            picMinPantalla.TabStop = false;
            toolTipMenuGerente.SetToolTip(picMinPantalla, "Minimizar Ventana");
            picMinPantalla.Click += picMinPantalla_Click;
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
            picCerrar.Location = new Point(1127, 5);
            picCerrar.Margin = new Padding(4, 3, 4, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(28, 24);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 0;
            picCerrar.TabStop = false;
            toolTipMenuGerente.SetToolTip(picCerrar, "Cerrar Ventana");
            picCerrar.Click += picCerrar_Click;
            // 
            // PVentana
            // 
            PVentana.BackColor = Color.FromArgb(67, 68, 89);
            PVentana.Controls.Add(panelCrearPoC);
            PVentana.Controls.Add(PMenuLat);
            PVentana.Dock = DockStyle.Fill;
            PVentana.Location = new Point(0, 45);
            PVentana.Margin = new Padding(4, 3, 4, 3);
            PVentana.Name = "PVentana";
            PVentana.Size = new Size(1159, 604);
            PVentana.TabIndex = 7;
            PVentana.MouseDown += PVentana_MouseDown;
            // 
            // panelCrearPoC
            // 
            panelCrearPoC.BackColor = Color.White;
            panelCrearPoC.Controls.Add(iconBtnCrearConsulta);
            panelCrearPoC.Controls.Add(iconbtnCrearPermiso);
            panelCrearPoC.Location = new Point(806, 0);
            panelCrearPoC.Name = "panelCrearPoC";
            panelCrearPoC.Size = new Size(168, 66);
            panelCrearPoC.TabIndex = 16;
            // 
            // iconBtnCrearConsulta
            // 
            iconBtnCrearConsulta.BackColor = Color.FromArgb(17, 17, 27);
            iconBtnCrearConsulta.BackgroundImageLayout = ImageLayout.None;
            iconBtnCrearConsulta.Dock = DockStyle.Top;
            iconBtnCrearConsulta.FlatStyle = FlatStyle.Popup;
            iconBtnCrearConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCrearConsulta.ForeColor = Color.White;
            iconBtnCrearConsulta.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCrearConsulta.IconColor = Color.White;
            iconBtnCrearConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCrearConsulta.IconSize = 40;
            iconBtnCrearConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnCrearConsulta.Location = new Point(0, 33);
            iconBtnCrearConsulta.Name = "iconBtnCrearConsulta";
            iconBtnCrearConsulta.Size = new Size(168, 33);
            iconBtnCrearConsulta.TabIndex = 18;
            iconBtnCrearConsulta.Text = "Crear una nueva consulta";
            iconBtnCrearConsulta.UseVisualStyleBackColor = false;
            iconBtnCrearConsulta.Click += iconBtnCrearConsulta_Click;
            // 
            // iconbtnCrearPermiso
            // 
            iconbtnCrearPermiso.BackColor = Color.FromArgb(17, 17, 27);
            iconbtnCrearPermiso.BackgroundImageLayout = ImageLayout.None;
            iconbtnCrearPermiso.Dock = DockStyle.Top;
            iconbtnCrearPermiso.FlatStyle = FlatStyle.Popup;
            iconbtnCrearPermiso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnCrearPermiso.ForeColor = Color.White;
            iconbtnCrearPermiso.IconChar = FontAwesome.Sharp.IconChar.None;
            iconbtnCrearPermiso.IconColor = Color.White;
            iconbtnCrearPermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnCrearPermiso.IconSize = 40;
            iconbtnCrearPermiso.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnCrearPermiso.Location = new Point(0, 0);
            iconbtnCrearPermiso.Name = "iconbtnCrearPermiso";
            iconbtnCrearPermiso.Size = new Size(168, 33);
            iconbtnCrearPermiso.TabIndex = 17;
            iconbtnCrearPermiso.Text = "Crear un nuevo Permiso";
            iconbtnCrearPermiso.UseVisualStyleBackColor = false;
            iconbtnCrearPermiso.Click += iconbtnCrearPermiso_Click;
            // 
            // PMenuLat
            // 
            PMenuLat.BackColor = Color.FromArgb(17, 17, 27);
            PMenuLat.Controls.Add(BtnCerrarSesion);
            PMenuLat.Controls.Add(iconBtnCaja);
            PMenuLat.Controls.Add(iconBtnOperaciones);
            PMenuLat.Controls.Add(iconBtnEstadisticas);
            PMenuLat.Controls.Add(iconBtnVentas);
            PMenuLat.Controls.Add(iconBtnPersonal);
            PMenuLat.Controls.Add(btnLogout);
            PMenuLat.Controls.Add(PLogo);
            PMenuLat.Dock = DockStyle.Left;
            PMenuLat.Location = new Point(0, 0);
            PMenuLat.Margin = new Padding(4, 3, 4, 3);
            PMenuLat.MaximumSize = new Size(186, 0);
            PMenuLat.MinimumSize = new Size(40, 604);
            PMenuLat.Name = "PMenuLat";
            PMenuLat.Size = new Size(186, 604);
            PMenuLat.TabIndex = 15;
            PMenuLat.MouseDown += PMenuLat_MouseDown;
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
            BtnCerrarSesion.Location = new Point(-10, 558);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Padding = new Padding(10, 0, 0, 0);
            BtnCerrarSesion.Size = new Size(151, 43);
            BtnCerrarSesion.TabIndex = 26;
            BtnCerrarSesion.Text = "Cerrar Sesion";
            BtnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // iconBtnCaja
            // 
            iconBtnCaja.BackColor = Color.FromArgb(17, 17, 27);
            iconBtnCaja.BackgroundImage = (Image)resources.GetObject("iconBtnCaja.BackgroundImage");
            iconBtnCaja.BackgroundImageLayout = ImageLayout.None;
            iconBtnCaja.Dock = DockStyle.Top;
            iconBtnCaja.FlatStyle = FlatStyle.Popup;
            iconBtnCaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCaja.ForeColor = Color.White;
            iconBtnCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCaja.IconColor = Color.White;
            iconBtnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCaja.IconSize = 40;
            iconBtnCaja.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnCaja.Location = new Point(0, 350);
            iconBtnCaja.Name = "iconBtnCaja";
            iconBtnCaja.Size = new Size(186, 52);
            iconBtnCaja.TabIndex = 22;
            iconBtnCaja.Text = "Punto de Venta";
            toolTipMenuGerente.SetToolTip(iconBtnCaja, "Gestionar Caja");
            iconBtnCaja.UseVisualStyleBackColor = false;
            iconBtnCaja.Click += iconBtnCaja_Click;
            iconBtnCaja.Leave += iconBtnCaja_Leave;
            iconBtnCaja.MouseEnter += iconBtnCaja_MouseEnter;
            // 
            // iconBtnOperaciones
            // 
            iconBtnOperaciones.BackColor = Color.FromArgb(17, 17, 27);
            iconBtnOperaciones.BackgroundImage = (Image)resources.GetObject("iconBtnOperaciones.BackgroundImage");
            iconBtnOperaciones.BackgroundImageLayout = ImageLayout.None;
            iconBtnOperaciones.Dock = DockStyle.Top;
            iconBtnOperaciones.FlatStyle = FlatStyle.Popup;
            iconBtnOperaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnOperaciones.ForeColor = Color.White;
            iconBtnOperaciones.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnOperaciones.IconColor = Color.White;
            iconBtnOperaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnOperaciones.IconSize = 40;
            iconBtnOperaciones.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnOperaciones.Location = new Point(0, 298);
            iconBtnOperaciones.Name = "iconBtnOperaciones";
            iconBtnOperaciones.Size = new Size(186, 52);
            iconBtnOperaciones.TabIndex = 21;
            iconBtnOperaciones.Text = "Operaciones";
            toolTipMenuGerente.SetToolTip(iconBtnOperaciones, "Ver operaciones");
            iconBtnOperaciones.UseVisualStyleBackColor = false;
            iconBtnOperaciones.Click += iconBtnOperaciones_Click;
            iconBtnOperaciones.Leave += iconBtnOperaciones_Leave;
            iconBtnOperaciones.MouseEnter += iconBtnOperaciones_MouseEnter;
            // 
            // iconBtnEstadisticas
            // 
            iconBtnEstadisticas.BackColor = Color.FromArgb(17, 17, 27);
            iconBtnEstadisticas.BackgroundImage = (Image)resources.GetObject("iconBtnEstadisticas.BackgroundImage");
            iconBtnEstadisticas.BackgroundImageLayout = ImageLayout.None;
            iconBtnEstadisticas.Dock = DockStyle.Top;
            iconBtnEstadisticas.FlatStyle = FlatStyle.Popup;
            iconBtnEstadisticas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnEstadisticas.ForeColor = Color.White;
            iconBtnEstadisticas.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnEstadisticas.IconColor = Color.White;
            iconBtnEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnEstadisticas.IconSize = 40;
            iconBtnEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnEstadisticas.Location = new Point(0, 246);
            iconBtnEstadisticas.Name = "iconBtnEstadisticas";
            iconBtnEstadisticas.Size = new Size(186, 52);
            iconBtnEstadisticas.TabIndex = 18;
            iconBtnEstadisticas.Text = "Estadisticas";
            toolTipMenuGerente.SetToolTip(iconBtnEstadisticas, "Ver Estadisticas");
            iconBtnEstadisticas.UseVisualStyleBackColor = false;
            iconBtnEstadisticas.Click += iconBtnEstadisticas_Click;
            iconBtnEstadisticas.Leave += iconBtnEstadisticas_Leave;
            iconBtnEstadisticas.MouseEnter += iconBtnEstadisticas_MouseEnter;
            // 
            // iconBtnVentas
            // 
            iconBtnVentas.BackColor = Color.FromArgb(17, 17, 27);
            iconBtnVentas.BackgroundImage = (Image)resources.GetObject("iconBtnVentas.BackgroundImage");
            iconBtnVentas.BackgroundImageLayout = ImageLayout.None;
            iconBtnVentas.Dock = DockStyle.Top;
            iconBtnVentas.FlatStyle = FlatStyle.Popup;
            iconBtnVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnVentas.ForeColor = Color.White;
            iconBtnVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnVentas.IconColor = Color.White;
            iconBtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnVentas.IconSize = 40;
            iconBtnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnVentas.Location = new Point(0, 194);
            iconBtnVentas.Name = "iconBtnVentas";
            iconBtnVentas.Size = new Size(186, 52);
            iconBtnVentas.TabIndex = 17;
            iconBtnVentas.Text = "Ventas";
            toolTipMenuGerente.SetToolTip(iconBtnVentas, "Gestionar Ventas");
            iconBtnVentas.UseVisualStyleBackColor = false;
            iconBtnVentas.Click += iconBtnVentas_Click;
            iconBtnVentas.Leave += iconBtnVentas_Leave;
            iconBtnVentas.MouseEnter += iconBtnVentas_MouseEnter;
            // 
            // iconBtnPersonal
            // 
            iconBtnPersonal.BackColor = Color.FromArgb(17, 17, 27);
            iconBtnPersonal.BackgroundImage = (Image)resources.GetObject("iconBtnPersonal.BackgroundImage");
            iconBtnPersonal.BackgroundImageLayout = ImageLayout.None;
            iconBtnPersonal.Dock = DockStyle.Top;
            iconBtnPersonal.FlatStyle = FlatStyle.Popup;
            iconBtnPersonal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnPersonal.ForeColor = Color.White;
            iconBtnPersonal.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnPersonal.IconColor = Color.White;
            iconBtnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnPersonal.IconSize = 40;
            iconBtnPersonal.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtnPersonal.Location = new Point(0, 142);
            iconBtnPersonal.Name = "iconBtnPersonal";
            iconBtnPersonal.Size = new Size(186, 52);
            iconBtnPersonal.TabIndex = 16;
            iconBtnPersonal.Text = "Personal";
            toolTipMenuGerente.SetToolTip(iconBtnPersonal, "Gestionar Personal");
            iconBtnPersonal.UseVisualStyleBackColor = false;
            iconBtnPersonal.Click += iconBtnPersonal_Click;
            iconBtnPersonal.Leave += iconBtnPersonal_Leave;
            iconBtnPersonal.MouseEnter += iconBtnPersonal_MouseEnter;
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
            btnLogout.Location = new Point(4, 15794);
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
            PLogo.Controls.Add(pictureMenuHambur);
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
            lblNombreDelUsu.Location = new Point(4, 119);
            lblNombreDelUsu.Name = "lblNombreDelUsu";
            lblNombreDelUsu.Size = new Size(150, 21);
            lblNombreDelUsu.TabIndex = 19;
            lblNombreDelUsu.Text = "nombre y apellido";
            // 
            // lblRolDelUsu
            // 
            lblRolDelUsu.AutoSize = true;
            lblRolDelUsu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolDelUsu.ForeColor = Color.Red;
            lblRolDelUsu.Location = new Point(4, 86);
            lblRolDelUsu.Name = "lblRolDelUsu";
            lblRolDelUsu.Size = new Size(31, 21);
            lblRolDelUsu.TabIndex = 18;
            lblRolDelUsu.Text = "rol";
            // 
            // pictureMenuHambur
            // 
            pictureMenuHambur.BackColor = Color.FromArgb(9, 10, 25);
            pictureMenuHambur.Cursor = Cursors.Hand;
            pictureMenuHambur.Image = (Image)resources.GetObject("pictureMenuHambur.Image");
            pictureMenuHambur.Location = new Point(5, 3);
            pictureMenuHambur.Margin = new Padding(4, 3, 4, 3);
            pictureMenuHambur.Name = "pictureMenuHambur";
            pictureMenuHambur.Size = new Size(30, 31);
            pictureMenuHambur.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMenuHambur.TabIndex = 15;
            pictureMenuHambur.TabStop = false;
            pictureMenuHambur.Click += pictureMenuHambur_Click;
            // 
            // picUsuario
            // 
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(118, 0);
            picUsuario.Margin = new Padding(4, 3, 4, 3);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(68, 78);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 0;
            picUsuario.TabStop = false;
            // 
            // MenuGerente
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1159, 649);
            Controls.Add(PVentana);
            Controls.Add(panelBarraSuperior);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MenuGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f";
            Load += MenuGerente_Load;
            panelBarraSuperior.ResumeLayout(false);
            panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            PVentana.ResumeLayout(false);
            panelCrearPoC.ResumeLayout(false);
            PMenuLat.ResumeLayout(false);
            PLogo.ResumeLayout(false);
            PLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMenuHambur).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer sidebarTime;
        private Panel panelBarraSuperior;
        private PictureBox picRestaurar;
        private PictureBox pictureBox2;
        private Label lblTituloMenu;
        private Button btnMenu;
        private PictureBox picMinPantalla;
        private PictureBox picMaxPantalla;
        private PictureBox picCerrar;
        private Panel PVentana;
        private Panel PMenuLat;
        private FontAwesome.Sharp.IconButton iconBtnEstadisticas;
        private FontAwesome.Sharp.IconButton iconBtnVentas;
        private FontAwesome.Sharp.IconButton iconBtnPersonal;
        private Button btnLogout;
        private Panel PLogo;
        private PictureBox pictureMenuHambur;
        private PictureBox picUsuario;
        private FontAwesome.Sharp.IconButton iconBtnCaja;
        private FontAwesome.Sharp.IconButton iconBtnOperaciones;
        private Label lblNombreDelUsu;
        private Label lblRolDelUsu;
        private FontAwesome.Sharp.IconButton btnCrearF;
        private ToolTip toolTipMenuGerente;
        private Panel panelCrearPoC;
        private FontAwesome.Sharp.IconButton iconBtnCrearConsulta;
        private FontAwesome.Sharp.IconButton iconbtnCrearPermiso;
        private Button BtnCerrarSesion;
    }
}