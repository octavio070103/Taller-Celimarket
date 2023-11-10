namespace CapaPresentacion.Formularios.Admin.Producto
{
    partial class FrmRegistrarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarMarca));
            panelProductos = new Panel();
            txtNombreMarca = new TextBox();
            lblNombreCate = new Label();
            panel2 = new Panel();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            picCerrar = new PictureBox();
            picRestaurar = new PictureBox();
            picMinimizar = new PictureBox();
            picMaxPantalla = new PictureBox();
            lblRegistrarUsuario = new Label();
            panelProductos.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            SuspendLayout();
            // 
            // panelProductos
            // 
            panelProductos.BackColor = Color.FromArgb(67, 68, 89);
            panelProductos.Controls.Add(txtNombreMarca);
            panelProductos.Controls.Add(lblNombreCate);
            panelProductos.Controls.Add(panel2);
            panelProductos.Dock = DockStyle.Fill;
            panelProductos.Location = new Point(0, 61);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(274, 137);
            panelProductos.TabIndex = 7;
            // 
            // txtNombreMarca
            // 
            txtNombreMarca.Cursor = Cursors.IBeam;
            txtNombreMarca.Location = new Point(38, 36);
            txtNombreMarca.Multiline = true;
            txtNombreMarca.Name = "txtNombreMarca";
            txtNombreMarca.Size = new Size(180, 23);
            txtNombreMarca.TabIndex = 77;
            // 
            // lblNombreCate
            // 
            lblNombreCate.AutoSize = true;
            lblNombreCate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCate.Location = new Point(38, 14);
            lblNombreCate.Name = "lblNombreCate";
            lblNombreCate.Size = new Size(73, 19);
            lblNombreCate.TabIndex = 76;
            lblNombreCate.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 17, 27);
            panel2.Controls.Add(iconbtnGuardar);
            panel2.Controls.Add(iconBtnCancelar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 61);
            panel2.TabIndex = 75;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(47, 33, 75);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 30;
            iconbtnGuardar.Location = new Point(162, 5);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(98, 35);
            iconbtnGuardar.TabIndex = 69;
            iconbtnGuardar.Text = "Guardar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
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
            iconBtnCancelar.Location = new Point(27, 8);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(102, 32);
            iconBtnCancelar.TabIndex = 70;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            iconBtnCancelar.Click += iconBtnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 27);
            panel1.Controls.Add(picCerrar);
            panel1.Controls.Add(picRestaurar);
            panel1.Controls.Add(picMinimizar);
            panel1.Controls.Add(picMaxPantalla);
            panel1.Controls.Add(lblRegistrarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 61);
            panel1.TabIndex = 6;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(251, 3);
            picCerrar.Margin = new Padding(4, 3, 4, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(17, 17);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 19;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(226, 3);
            picRestaurar.Margin = new Padding(4, 3, 4, 3);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(17, 17);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 17;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            picRestaurar.Click += picRestaurar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinimizar.Cursor = Cursors.Hand;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(203, 3);
            picMinimizar.Margin = new Padding(4, 3, 4, 3);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(15, 17);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 20;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(226, 3);
            picMaxPantalla.Margin = new Padding(4, 3, 4, 3);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(17, 17);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 18;
            picMaxPantalla.TabStop = false;
            picMaxPantalla.Click += picMaxPantalla_Click;
            // 
            // lblRegistrarUsuario
            // 
            lblRegistrarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRegistrarUsuario.AutoSize = true;
            lblRegistrarUsuario.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrarUsuario.ForeColor = SystemColors.ControlLightLight;
            lblRegistrarUsuario.ImageAlign = ContentAlignment.TopCenter;
            lblRegistrarUsuario.Location = new Point(27, 18);
            lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            lblRegistrarUsuario.Size = new Size(223, 40);
            lblRegistrarUsuario.TabIndex = 0;
            lblRegistrarUsuario.Text = "Agregar Marca";
            lblRegistrarUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmRegistrarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 198);
            Controls.Add(panelProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistrarMarca";
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProductos;
        private TextBox txtNombreMarca;
        private Label lblNombreCate;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private Panel panel1;
        private PictureBox picCerrar;
        private PictureBox picRestaurar;
        private PictureBox picMinimizar;
        private PictureBox picMaxPantalla;
        private Label lblRegistrarUsuario;
    }
}