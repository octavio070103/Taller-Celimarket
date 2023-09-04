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
            panel1 = new Panel();
            picRestaurar = new PictureBox();
            btnMenu = new Button();
            picMaxPantalla = new PictureBox();
            picMinPantalla = new PictureBox();
            picCerrar = new PictureBox();
            PVentana = new Panel();
            PMenuLat = new Panel();
            subMenuPromocion = new Panel();
            btnDescuentos = new Button();
            btnPromociones = new Button();
            btnPromocionDescuento = new Button();
            submenuPersonal = new Panel();
            btnReportePersonal = new Button();
            btnGestionPersonal = new Button();
            btnCuentas = new Button();
            btnPersonal = new Button();
            submenuVentas = new Panel();
            btnReportes = new Button();
            btnGastos = new Button();
            btnIngresos = new Button();
            btnInfomeVenta = new Button();
            btnVentas = new Button();
            btnLogout = new Button();
            PSubmenu1 = new Panel();
            btnCerrarCaja = new Button();
            btnInfoCaja = new Button();
            btnCaja = new Button();
            PLogo = new Panel();
            picUsuario = new PictureBox();
            pictureBox2 = new PictureBox();
            sidebarTime = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            PVentana.SuspendLayout();
            PMenuLat.SuspendLayout();
            subMenuPromocion.SuspendLayout();
            submenuPersonal.SuspendLayout();
            submenuVentas.SuspendLayout();
            PSubmenu1.SuspendLayout();
            PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 1, 2);
            panel1.Controls.Add(picRestaurar);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(picMaxPantalla);
            panel1.Controls.Add(picMinPantalla);
            panel1.Controls.Add(picCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 39);
            panel1.TabIndex = 0;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(882, 4);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(22, 24);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 0;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            picRestaurar.Click += picRestaurar_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(1, 1, 2);
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = SystemColors.ControlLightLight;
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.Size = new Size(141, 35);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu Principal";
            btnMenu.TextAlign = ContentAlignment.MiddleRight;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(882, 4);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(22, 23);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 8;
            picMaxPantalla.TabStop = false;
            picMaxPantalla.Click += picMaxPantalla_Click_1;
            // 
            // picMinPantalla
            // 
            picMinPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinPantalla.Cursor = Cursors.Hand;
            picMinPantalla.Image = (Image)resources.GetObject("picMinPantalla.Image");
            picMinPantalla.Location = new Point(853, 12);
            picMinPantalla.Name = "picMinPantalla";
            picMinPantalla.Size = new Size(23, 21);
            picMinPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMinPantalla.TabIndex = 1;
            picMinPantalla.TabStop = false;
            picMinPantalla.Click += picMinPantalla_Click;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(910, 4);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(24, 21);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 0;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // PVentana
            // 
            PVentana.BackColor = Color.FromArgb(52, 53, 68);
            PVentana.Controls.Add(PMenuLat);
            PVentana.Dock = DockStyle.Fill;
            PVentana.Location = new Point(0, 39);
            PVentana.Name = "PVentana";
            PVentana.Size = new Size(934, 561);
            PVentana.TabIndex = 3;
            // 
            // PMenuLat
            // 
            PMenuLat.AutoScroll = true;
            PMenuLat.BackColor = Color.FromArgb(17, 17, 27);
            PMenuLat.Controls.Add(subMenuPromocion);
            PMenuLat.Controls.Add(btnPromocionDescuento);
            PMenuLat.Controls.Add(submenuPersonal);
            PMenuLat.Controls.Add(btnPersonal);
            PMenuLat.Controls.Add(submenuVentas);
            PMenuLat.Controls.Add(btnVentas);
            PMenuLat.Controls.Add(btnLogout);
            PMenuLat.Controls.Add(PSubmenu1);
            PMenuLat.Controls.Add(btnCaja);
            PMenuLat.Controls.Add(PLogo);
            PMenuLat.Dock = DockStyle.Left;
            PMenuLat.Location = new Point(0, 0);
            PMenuLat.MaximumSize = new Size(251, 561);
            PMenuLat.MinimumSize = new Size(51, 561);
            PMenuLat.Name = "PMenuLat";
            PMenuLat.Size = new Size(251, 561);
            PMenuLat.TabIndex = 15;
            // 
            // subMenuPromocion
            // 
            subMenuPromocion.BackColor = Color.BlanchedAlmond;
            subMenuPromocion.Controls.Add(btnDescuentos);
            subMenuPromocion.Controls.Add(btnPromociones);
            subMenuPromocion.Dock = DockStyle.Top;
            subMenuPromocion.Location = new Point(0, 675);
            subMenuPromocion.Name = "subMenuPromocion";
            subMenuPromocion.Size = new Size(234, 80);
            subMenuPromocion.TabIndex = 15;
            // 
            // btnDescuentos
            // 
            btnDescuentos.BackColor = Color.FromArgb(67, 68, 89);
            btnDescuentos.Cursor = Cursors.Hand;
            btnDescuentos.Dock = DockStyle.Top;
            btnDescuentos.FlatAppearance.BorderSize = 0;
            btnDescuentos.FlatStyle = FlatStyle.Flat;
            btnDescuentos.ForeColor = SystemColors.HighlightText;
            btnDescuentos.Location = new Point(0, 40);
            btnDescuentos.Name = "btnDescuentos";
            btnDescuentos.Padding = new Padding(35, 0, 0, 0);
            btnDescuentos.Size = new Size(234, 40);
            btnDescuentos.TabIndex = 1;
            btnDescuentos.Text = "Gestionar Descuentos";
            btnDescuentos.TextAlign = ContentAlignment.MiddleLeft;
            btnDescuentos.UseVisualStyleBackColor = false;
            btnDescuentos.Click += btnDescuentos_Click_1;
            // 
            // btnPromociones
            // 
            btnPromociones.BackColor = Color.FromArgb(67, 68, 89);
            btnPromociones.Cursor = Cursors.Hand;
            btnPromociones.Dock = DockStyle.Top;
            btnPromociones.FlatAppearance.BorderSize = 0;
            btnPromociones.FlatStyle = FlatStyle.Flat;
            btnPromociones.ForeColor = SystemColors.HighlightText;
            btnPromociones.Location = new Point(0, 0);
            btnPromociones.Name = "btnPromociones";
            btnPromociones.Padding = new Padding(35, 0, 0, 0);
            btnPromociones.Size = new Size(234, 40);
            btnPromociones.TabIndex = 1;
            btnPromociones.Text = "Gestionar Promociones";
            btnPromociones.TextAlign = ContentAlignment.MiddleLeft;
            btnPromociones.UseVisualStyleBackColor = false;
            btnPromociones.Click += btnPromociones_Click_1;
            // 
            // btnPromocionDescuento
            // 
            btnPromocionDescuento.BackColor = Color.FromArgb(17, 17, 27);
            btnPromocionDescuento.Cursor = Cursors.Hand;
            btnPromocionDescuento.Dock = DockStyle.Top;
            btnPromocionDescuento.FlatAppearance.BorderSize = 0;
            btnPromocionDescuento.FlatStyle = FlatStyle.Flat;
            btnPromocionDescuento.ForeColor = SystemColors.ControlLightLight;
            btnPromocionDescuento.Location = new Point(0, 630);
            btnPromocionDescuento.Name = "btnPromocionDescuento";
            btnPromocionDescuento.Padding = new Padding(10, 0, 0, 0);
            btnPromocionDescuento.Size = new Size(234, 45);
            btnPromocionDescuento.TabIndex = 14;
            btnPromocionDescuento.Text = "Promocion y Descuento";
            btnPromocionDescuento.TextAlign = ContentAlignment.MiddleLeft;
            btnPromocionDescuento.UseVisualStyleBackColor = false;
            btnPromocionDescuento.Click += btnPromocionDescuento_Click_1;
            // 
            // submenuPersonal
            // 
            submenuPersonal.BackColor = Color.BlanchedAlmond;
            submenuPersonal.Controls.Add(btnReportePersonal);
            submenuPersonal.Controls.Add(btnGestionPersonal);
            submenuPersonal.Controls.Add(btnCuentas);
            submenuPersonal.Dock = DockStyle.Top;
            submenuPersonal.Location = new Point(0, 507);
            submenuPersonal.Name = "submenuPersonal";
            submenuPersonal.Size = new Size(234, 123);
            submenuPersonal.TabIndex = 12;
            // 
            // btnReportePersonal
            // 
            btnReportePersonal.BackColor = Color.FromArgb(67, 68, 89);
            btnReportePersonal.Cursor = Cursors.Hand;
            btnReportePersonal.Dock = DockStyle.Top;
            btnReportePersonal.FlatAppearance.BorderSize = 0;
            btnReportePersonal.FlatStyle = FlatStyle.Flat;
            btnReportePersonal.ForeColor = SystemColors.HighlightText;
            btnReportePersonal.Location = new Point(0, 80);
            btnReportePersonal.Name = "btnReportePersonal";
            btnReportePersonal.Padding = new Padding(35, 0, 0, 0);
            btnReportePersonal.Size = new Size(234, 45);
            btnReportePersonal.TabIndex = 2;
            btnReportePersonal.Text = "Generar Reporte de Personal";
            btnReportePersonal.TextAlign = ContentAlignment.MiddleLeft;
            btnReportePersonal.UseVisualStyleBackColor = false;
            // 
            // btnGestionPersonal
            // 
            btnGestionPersonal.BackColor = Color.FromArgb(67, 68, 89);
            btnGestionPersonal.Cursor = Cursors.Hand;
            btnGestionPersonal.Dock = DockStyle.Top;
            btnGestionPersonal.FlatAppearance.BorderSize = 0;
            btnGestionPersonal.FlatStyle = FlatStyle.Flat;
            btnGestionPersonal.ForeColor = SystemColors.HighlightText;
            btnGestionPersonal.Location = new Point(0, 40);
            btnGestionPersonal.Name = "btnGestionPersonal";
            btnGestionPersonal.Padding = new Padding(35, 0, 0, 0);
            btnGestionPersonal.Size = new Size(234, 40);
            btnGestionPersonal.TabIndex = 1;
            btnGestionPersonal.Text = "Gestionar Personal";
            btnGestionPersonal.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionPersonal.UseVisualStyleBackColor = false;
            btnGestionPersonal.Click += btnGestionPersonal_Click;
            // 
            // btnCuentas
            // 
            btnCuentas.BackColor = Color.FromArgb(67, 68, 89);
            btnCuentas.Cursor = Cursors.Hand;
            btnCuentas.Dock = DockStyle.Top;
            btnCuentas.FlatAppearance.BorderSize = 0;
            btnCuentas.FlatStyle = FlatStyle.Flat;
            btnCuentas.ForeColor = SystemColors.HighlightText;
            btnCuentas.Location = new Point(0, 0);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Padding = new Padding(35, 0, 0, 0);
            btnCuentas.Size = new Size(234, 40);
            btnCuentas.TabIndex = 1;
            btnCuentas.Text = "Administrar Cuentas";
            btnCuentas.TextAlign = ContentAlignment.MiddleLeft;
            btnCuentas.UseVisualStyleBackColor = false;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.BackColor = Color.FromArgb(17, 17, 27);
            btnPersonal.Cursor = Cursors.Hand;
            btnPersonal.Dock = DockStyle.Top;
            btnPersonal.FlatAppearance.BorderSize = 0;
            btnPersonal.FlatStyle = FlatStyle.Flat;
            btnPersonal.ForeColor = SystemColors.ControlLightLight;
            btnPersonal.Location = new Point(0, 462);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Padding = new Padding(10, 0, 0, 0);
            btnPersonal.Size = new Size(234, 45);
            btnPersonal.TabIndex = 11;
            btnPersonal.Text = "Personal";
            btnPersonal.TextAlign = ContentAlignment.MiddleLeft;
            btnPersonal.UseVisualStyleBackColor = false;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // submenuVentas
            // 
            submenuVentas.BackColor = Color.BlanchedAlmond;
            submenuVentas.Controls.Add(btnReportes);
            submenuVentas.Controls.Add(btnGastos);
            submenuVentas.Controls.Add(btnIngresos);
            submenuVentas.Controls.Add(btnInfomeVenta);
            submenuVentas.Dock = DockStyle.Top;
            submenuVentas.Location = new Point(0, 289);
            submenuVentas.Name = "submenuVentas";
            submenuVentas.Size = new Size(234, 173);
            submenuVentas.TabIndex = 8;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(67, 68, 89);
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = SystemColors.HighlightText;
            btnReportes.Location = new Point(0, 131);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(35, 0, 0, 0);
            btnReportes.Size = new Size(234, 42);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reporte Financieros";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnGastos
            // 
            btnGastos.BackColor = Color.FromArgb(67, 68, 89);
            btnGastos.Cursor = Cursors.Hand;
            btnGastos.Dock = DockStyle.Top;
            btnGastos.FlatAppearance.BorderSize = 0;
            btnGastos.FlatStyle = FlatStyle.Flat;
            btnGastos.ForeColor = SystemColors.HighlightText;
            btnGastos.Location = new Point(0, 91);
            btnGastos.Name = "btnGastos";
            btnGastos.Padding = new Padding(35, 0, 0, 0);
            btnGastos.Size = new Size(234, 40);
            btnGastos.TabIndex = 2;
            btnGastos.Text = "Gastos";
            btnGastos.TextAlign = ContentAlignment.MiddleLeft;
            btnGastos.UseVisualStyleBackColor = false;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.BackColor = Color.FromArgb(67, 68, 89);
            btnIngresos.Cursor = Cursors.Hand;
            btnIngresos.Dock = DockStyle.Top;
            btnIngresos.FlatAppearance.BorderSize = 0;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.ForeColor = SystemColors.HighlightText;
            btnIngresos.Location = new Point(0, 40);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Padding = new Padding(35, 0, 0, 0);
            btnIngresos.Size = new Size(234, 51);
            btnIngresos.TabIndex = 1;
            btnIngresos.Text = "Generar  Resumen de ingresos";
            btnIngresos.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresos.UseVisualStyleBackColor = false;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // btnInfomeVenta
            // 
            btnInfomeVenta.BackColor = Color.FromArgb(67, 68, 89);
            btnInfomeVenta.Cursor = Cursors.Hand;
            btnInfomeVenta.Dock = DockStyle.Top;
            btnInfomeVenta.FlatAppearance.BorderSize = 0;
            btnInfomeVenta.FlatStyle = FlatStyle.Flat;
            btnInfomeVenta.ForeColor = SystemColors.HighlightText;
            btnInfomeVenta.Location = new Point(0, 0);
            btnInfomeVenta.Name = "btnInfomeVenta";
            btnInfomeVenta.Padding = new Padding(35, 0, 0, 0);
            btnInfomeVenta.Size = new Size(234, 40);
            btnInfomeVenta.TabIndex = 1;
            btnInfomeVenta.Text = "Generar Informe de Venta";
            btnInfomeVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnInfomeVenta.UseVisualStyleBackColor = false;
            btnInfomeVenta.Click += btnInfomeVenta_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(17, 17, 27);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = SystemColors.ControlLightLight;
            btnVentas.Location = new Point(0, 244);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(234, 45);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
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
            btnLogout.Location = new Point(3, 1958);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(91, 37);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // PSubmenu1
            // 
            PSubmenu1.BackColor = Color.BlanchedAlmond;
            PSubmenu1.Controls.Add(btnCerrarCaja);
            PSubmenu1.Controls.Add(btnInfoCaja);
            PSubmenu1.Dock = DockStyle.Top;
            PSubmenu1.Location = new Point(0, 168);
            PSubmenu1.Name = "PSubmenu1";
            PSubmenu1.Size = new Size(234, 76);
            PSubmenu1.TabIndex = 1;
            // 
            // btnCerrarCaja
            // 
            btnCerrarCaja.BackColor = Color.FromArgb(67, 68, 89);
            btnCerrarCaja.Cursor = Cursors.Hand;
            btnCerrarCaja.Dock = DockStyle.Top;
            btnCerrarCaja.FlatAppearance.BorderSize = 0;
            btnCerrarCaja.FlatStyle = FlatStyle.Flat;
            btnCerrarCaja.ForeColor = SystemColors.HighlightText;
            btnCerrarCaja.Location = new Point(0, 40);
            btnCerrarCaja.Name = "btnCerrarCaja";
            btnCerrarCaja.Padding = new Padding(35, 0, 0, 0);
            btnCerrarCaja.Size = new Size(234, 40);
            btnCerrarCaja.TabIndex = 1;
            btnCerrarCaja.Text = "Cierre de Caja";
            btnCerrarCaja.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarCaja.UseVisualStyleBackColor = false;
            btnCerrarCaja.Click += btnCerrarCaja_Click;
            // 
            // btnInfoCaja
            // 
            btnInfoCaja.BackColor = Color.FromArgb(67, 68, 89);
            btnInfoCaja.Cursor = Cursors.Hand;
            btnInfoCaja.Dock = DockStyle.Top;
            btnInfoCaja.FlatAppearance.BorderSize = 0;
            btnInfoCaja.FlatStyle = FlatStyle.Flat;
            btnInfoCaja.ForeColor = SystemColors.HighlightText;
            btnInfoCaja.Location = new Point(0, 0);
            btnInfoCaja.Name = "btnInfoCaja";
            btnInfoCaja.Padding = new Padding(35, 0, 0, 0);
            btnInfoCaja.Size = new Size(234, 40);
            btnInfoCaja.TabIndex = 1;
            btnInfoCaja.Text = "Informacion de Caja";
            btnInfoCaja.TextAlign = ContentAlignment.MiddleLeft;
            btnInfoCaja.UseVisualStyleBackColor = false;
            btnInfoCaja.Click += btnInfoCaja_Click;
            // 
            // btnCaja
            // 
            btnCaja.BackColor = Color.FromArgb(17, 17, 27);
            btnCaja.Cursor = Cursors.Hand;
            btnCaja.Dock = DockStyle.Top;
            btnCaja.FlatAppearance.BorderSize = 0;
            btnCaja.FlatStyle = FlatStyle.Flat;
            btnCaja.ForeColor = SystemColors.ControlLightLight;
            btnCaja.Location = new Point(0, 123);
            btnCaja.Name = "btnCaja";
            btnCaja.Padding = new Padding(10, 0, 0, 0);
            btnCaja.Size = new Size(234, 45);
            btnCaja.TabIndex = 0;
            btnCaja.Text = "Caja";
            btnCaja.TextAlign = ContentAlignment.MiddleLeft;
            btnCaja.UseVisualStyleBackColor = false;
            btnCaja.Click += btnCaja_Click;
            // 
            // PLogo
            // 
            PLogo.BackColor = Color.FromArgb(9, 10, 25);
            PLogo.Controls.Add(picUsuario);
            PLogo.Controls.Add(pictureBox2);
            PLogo.Dock = DockStyle.Top;
            PLogo.Location = new Point(0, 0);
            PLogo.Name = "PLogo";
            PLogo.Size = new Size(234, 123);
            PLogo.TabIndex = 1;
            // 
            // picUsuario
            // 
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(146, 0);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(84, 84);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 0;
            picUsuario.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(9, 10, 25);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 10;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // MenuGerente
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 600);
            Controls.Add(PVentana);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MenuGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            PVentana.ResumeLayout(false);
            PMenuLat.ResumeLayout(false);
            subMenuPromocion.ResumeLayout(false);
            submenuPersonal.ResumeLayout(false);
            submenuVentas.ResumeLayout(false);
            PSubmenu1.ResumeLayout(false);
            PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picCerrar;
        private PictureBox picRestaurar;
        private PictureBox picMaxPantalla;
        private Button btnMenu;
        private Button btnVentas;
        private Panel PSubmenu1;
        private Button btnCerrarCaja;
        private Button btnInfoCaja;
        private Button btnCaja;
        private Button btnLogout;
        private Panel panel1;
        private Panel PVentana;
        private Panel submenuVentas;
        private Button btnIngresos;
        private Button btnInfomeVenta;
        private Button btnGastos;
        private Panel submenuPersonal;
        private Button btnReportePersonal;
        private Button btnGestionPersonal;
        private Button btnCuentas;
        private Button btnPersonal;
        private Button btnReportes;
        private Panel subMenuPromocion;
        private Button btnDescuentos;
        private Button btnPromociones;
        private Button btnPromocionDescuento;
        private Panel PLogo;
        private PictureBox picUsuario;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer sidebarTime;
        private PictureBox picMinPantalla;
        private Panel PMenuLat;
    }
}