﻿namespace Proyecto_Taller.Presentacion.Formularios.Vendedor
{
    partial class MenuVendedo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedo));
            panel1 = new Panel();
            lblTituloMenu = new Label();
            picRestaurar = new PictureBox();
            picMaxPantalla = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnMenu = new Button();
            PMenuLat = new Panel();
            panelCrearSolicitud = new Panel();
            iconBtnCrearConsulta = new FontAwesome.Sharp.IconButton();
            iconbtnCrearPermiso = new FontAwesome.Sharp.IconButton();
            btnRegistrarConsultas = new Button();
            btnRegistroVen = new Button();
            lblCerrarSesion = new Label();
            picCerrarSesion = new PictureBox();
            button5 = new Button();
            btnAbrirClientes = new Button();
            PLogo = new Panel();
            lblNombreUsuario = new Label();
            lblRolUsuario = new Label();
            pictureBox1 = new PictureBox();
            picUsuario = new PictureBox();
            PVentana = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            PMenuLat.SuspendLayout();
            panelCrearSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).BeginInit();
            PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 1, 2);
            panel1.Controls.Add(lblTituloMenu);
            panel1.Controls.Add(picRestaurar);
            panel1.Controls.Add(picMaxPantalla);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 39);
            panel1.TabIndex = 0;
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMenu.ForeColor = SystemColors.ControlLightLight;
            lblTituloMenu.Location = new Point(605, 9);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(58, 25);
            lblTituloMenu.TabIndex = 16;
            lblTituloMenu.Text = "Inicio";
            lblTituloMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(1103, 9);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(22, 24);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 16;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            picRestaurar.Click += picRestaurar_Click;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Cursor = Cursors.Hand;
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(1103, 9);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(22, 23);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 19;
            picMaxPantalla.TabStop = false;
            picMaxPantalla.Click += picMaxPantalla_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1074, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += picMinPantalla_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1131, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += picCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(1, 1, 2);
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = SystemColors.ControlLightLight;
            btnMenu.Location = new Point(0, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.Size = new Size(141, 35);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Menu Principal";
            btnMenu.TextAlign = ContentAlignment.MiddleRight;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // PMenuLat
            // 
            PMenuLat.AutoScroll = true;
            PMenuLat.BackColor = Color.FromArgb(17, 17, 27);
            PMenuLat.Controls.Add(panelCrearSolicitud);
            PMenuLat.Controls.Add(btnRegistrarConsultas);
            PMenuLat.Controls.Add(btnRegistroVen);
            PMenuLat.Controls.Add(lblCerrarSesion);
            PMenuLat.Controls.Add(picCerrarSesion);
            PMenuLat.Controls.Add(button5);
            PMenuLat.Controls.Add(btnAbrirClientes);
            PMenuLat.Controls.Add(PLogo);
            PMenuLat.Dock = DockStyle.Left;
            PMenuLat.Location = new Point(0, 39);
            PMenuLat.Name = "PMenuLat";
            PMenuLat.Size = new Size(221, 610);
            PMenuLat.TabIndex = 2;
            // 
            // panelCrearSolicitud
            // 
            panelCrearSolicitud.BackColor = Color.White;
            panelCrearSolicitud.Controls.Add(iconBtnCrearConsulta);
            panelCrearSolicitud.Controls.Add(iconbtnCrearPermiso);
            panelCrearSolicitud.Dock = DockStyle.Top;
            panelCrearSolicitud.Location = new Point(0, 313);
            panelCrearSolicitud.Name = "panelCrearSolicitud";
            panelCrearSolicitud.Size = new Size(221, 66);
            panelCrearSolicitud.TabIndex = 17;
            panelCrearSolicitud.Visible = false;
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
            iconBtnCrearConsulta.Size = new Size(221, 33);
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
            iconbtnCrearPermiso.Size = new Size(221, 33);
            iconbtnCrearPermiso.TabIndex = 17;
            iconbtnCrearPermiso.Text = "Crear un nuevo Permiso";
            iconbtnCrearPermiso.UseVisualStyleBackColor = false;
            iconbtnCrearPermiso.Click += iconbtnCrearPermiso_Click;
            // 
            // btnRegistrarConsultas
            // 
            btnRegistrarConsultas.BackColor = Color.FromArgb(17, 17, 27);
            btnRegistrarConsultas.Cursor = Cursors.Hand;
            btnRegistrarConsultas.Dock = DockStyle.Top;
            btnRegistrarConsultas.FlatStyle = FlatStyle.Popup;
            btnRegistrarConsultas.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarConsultas.Image = (Image)resources.GetObject("btnRegistrarConsultas.Image");
            btnRegistrarConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarConsultas.Location = new Point(0, 268);
            btnRegistrarConsultas.Name = "btnRegistrarConsultas";
            btnRegistrarConsultas.Padding = new Padding(10, 0, 0, 0);
            btnRegistrarConsultas.Size = new Size(221, 45);
            btnRegistrarConsultas.TabIndex = 5;
            btnRegistrarConsultas.Text = "Consultas";
            btnRegistrarConsultas.UseVisualStyleBackColor = false;
            btnRegistrarConsultas.Click += btnRegistrarConsultas_Click_1;
            // 
            // btnRegistroVen
            // 
            btnRegistroVen.BackColor = Color.FromArgb(17, 17, 27);
            btnRegistroVen.Cursor = Cursors.Hand;
            btnRegistroVen.Dock = DockStyle.Top;
            btnRegistroVen.FlatStyle = FlatStyle.Popup;
            btnRegistroVen.ForeColor = SystemColors.ControlLightLight;
            btnRegistroVen.Image = (Image)resources.GetObject("btnRegistroVen.Image");
            btnRegistroVen.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroVen.Location = new Point(0, 223);
            btnRegistroVen.Name = "btnRegistroVen";
            btnRegistroVen.Padding = new Padding(10, 0, 0, 0);
            btnRegistroVen.Size = new Size(221, 45);
            btnRegistroVen.TabIndex = 4;
            btnRegistroVen.Text = "Registro de ventas";
            btnRegistroVen.UseVisualStyleBackColor = false;
            btnRegistroVen.Click += btnRegistroVen_Click;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.Cursor = Cursors.Hand;
            lblCerrarSesion.ForeColor = SystemColors.Window;
            lblCerrarSesion.Location = new Point(38, 583);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new Size(93, 17);
            lblCerrarSesion.TabIndex = 0;
            lblCerrarSesion.Text = "Cerrar sesión";
            lblCerrarSesion.Click += lblCerrarSesion_Click;
            // 
            // picCerrarSesion
            // 
            picCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picCerrarSesion.Cursor = Cursors.Hand;
            picCerrarSesion.Image = (Image)resources.GetObject("picCerrarSesion.Image");
            picCerrarSesion.Location = new Point(10, 583);
            picCerrarSesion.Name = "picCerrarSesion";
            picCerrarSesion.Size = new Size(22, 22);
            picCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrarSesion.TabIndex = 0;
            picCerrarSesion.TabStop = false;
            picCerrarSesion.Click += picCerrarSesion_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(17, 17, 27);
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 178);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(221, 45);
            button5.TabIndex = 2;
            button5.Text = "Ventas";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button4_Click;
            // 
            // btnAbrirClientes
            // 
            btnAbrirClientes.BackColor = Color.FromArgb(17, 17, 27);
            btnAbrirClientes.Cursor = Cursors.Hand;
            btnAbrirClientes.Dock = DockStyle.Top;
            btnAbrirClientes.FlatStyle = FlatStyle.Popup;
            btnAbrirClientes.ForeColor = SystemColors.ControlLightLight;
            btnAbrirClientes.Image = (Image)resources.GetObject("btnAbrirClientes.Image");
            btnAbrirClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirClientes.Location = new Point(0, 133);
            btnAbrirClientes.Name = "btnAbrirClientes";
            btnAbrirClientes.Padding = new Padding(10, 0, 0, 0);
            btnAbrirClientes.Size = new Size(221, 45);
            btnAbrirClientes.TabIndex = 0;
            btnAbrirClientes.Text = "Clientes";
            btnAbrirClientes.UseVisualStyleBackColor = false;
            btnAbrirClientes.Click += btnAbrirClientes_Click;
            // 
            // PLogo
            // 
            PLogo.BackColor = Color.FromArgb(9, 10, 25);
            PLogo.Controls.Add(lblNombreUsuario);
            PLogo.Controls.Add(lblRolUsuario);
            PLogo.Controls.Add(pictureBox1);
            PLogo.Controls.Add(picUsuario);
            PLogo.Dock = DockStyle.Top;
            PLogo.Location = new Point(0, 0);
            PLogo.Name = "PLogo";
            PLogo.Size = new Size(221, 133);
            PLogo.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = SystemColors.ControlLightLight;
            lblNombreUsuario.Location = new Point(10, 98);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(150, 21);
            lblNombreUsuario.TabIndex = 21;
            lblNombreUsuario.Text = "nombre y apellido";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolUsuario.ForeColor = Color.Red;
            lblRolUsuario.Location = new Point(10, 65);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(31, 21);
            lblRolUsuario.TabIndex = 20;
            lblRolUsuario.Text = "rol";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picUsuario
            // 
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(136, 3);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(79, 80);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 0;
            picUsuario.TabStop = false;
            // 
            // PVentana
            // 
            PVentana.BackColor = Color.FromArgb(52, 53, 68);
            PVentana.Dock = DockStyle.Fill;
            PVentana.Location = new Point(221, 39);
            PVentana.Name = "PVentana";
            PVentana.Size = new Size(938, 610);
            PVentana.TabIndex = 3;
            // 
            // MenuVendedo
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 649);
            Controls.Add(PVentana);
            Controls.Add(PMenuLat);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MenuVendedo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MenuVendedo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            PMenuLat.ResumeLayout(false);
            PMenuLat.PerformLayout();
            panelCrearSolicitud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCerrarSesion).EndInit();
            PLogo.ResumeLayout(false);
            PLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel PMenuLat;
        private Button button5;
        private Button btnAbrirClientes;
        private Panel PLogo;
        private Panel PVentana;
        private PictureBox picUsuario;
        private PictureBox picCerrarSesion;
        private Label lblCerrarSesion;
        private Button btnMenu;
        private PictureBox picRestaurar;
        private PictureBox picMaxPantalla;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnRegistroVen;
        private PictureBox pictureBox1;
        private Label lblNombreUsuario;
        private Label lblRolUsuario;
        private Label lblTituloMenu;
        private Button btnRegistrarConsultas;
        private Panel panelCrearSolicitud;
        private FontAwesome.Sharp.IconButton iconBtnCrearConsulta;
        private FontAwesome.Sharp.IconButton iconbtnCrearPermiso;
    }
}