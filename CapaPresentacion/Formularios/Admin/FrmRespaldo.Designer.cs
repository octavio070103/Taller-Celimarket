namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmRespaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRespaldo));
            panel1 = new Panel();
            lblListaEmpleados = new Label();
            lblFiltrar = new Label();
            label1 = new Label();
            panelDatosUsuario = new Panel();
            txtUltimoBackHora = new TextBox();
            txtTablasPrinci = new TextBox();
            txtCanTablaBD = new TextBox();
            lblPassword = new Label();
            lblTelefDato = new Label();
            lbl = new Label();
            txtNombreBD = new TextBox();
            lblApellidoDato = new Label();
            lblNombreDato = new Label();
            txtTamaBD = new TextBox();
            lblDatoDelaBD = new Label();
            iconBtnFolder = new FontAwesome.Sharp.IconButton();
            txtSelectFolderPath = new TextBox();
            lblEstadoDato = new Label();
            iconBtnImportar = new FontAwesome.Sharp.IconButton();
            iconBtnRespaldar = new FontAwesome.Sharp.IconButton();
            txtSeleccionServidor = new TextBox();
            txtSeleccionBase = new TextBox();
            panel1.SuspendLayout();
            panelDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblListaEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 76);
            panel1.TabIndex = 1;
            // 
            // lblListaEmpleados
            // 
            lblListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaEmpleados.AutoSize = true;
            lblListaEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEmpleados.ForeColor = SystemColors.ControlLightLight;
            lblListaEmpleados.ImageAlign = ContentAlignment.TopCenter;
            lblListaEmpleados.Location = new Point(212, 9);
            lblListaEmpleados.Name = "lblListaEmpleados";
            lblListaEmpleados.Size = new Size(384, 45);
            lblListaEmpleados.TabIndex = 0;
            lblListaEmpleados.Text = "Respaldo y Restauracion";
            lblListaEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltrar.ForeColor = SystemColors.ControlLightLight;
            lblFiltrar.Location = new Point(19, 105);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(201, 25);
            lblFiltrar.TabIndex = 2;
            lblFiltrar.Text = "Seleccionar Servidor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(19, 152);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 6;
            label1.Text = "Seleccionar La Base De Datos:";
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(txtUltimoBackHora);
            panelDatosUsuario.Controls.Add(txtTablasPrinci);
            panelDatosUsuario.Controls.Add(txtCanTablaBD);
            panelDatosUsuario.Controls.Add(lblPassword);
            panelDatosUsuario.Controls.Add(lblTelefDato);
            panelDatosUsuario.Controls.Add(lbl);
            panelDatosUsuario.Controls.Add(txtNombreBD);
            panelDatosUsuario.Controls.Add(lblApellidoDato);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(txtTamaBD);
            panelDatosUsuario.Controls.Add(lblDatoDelaBD);
            panelDatosUsuario.Location = new Point(565, 95);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(257, 442);
            panelDatosUsuario.TabIndex = 17;
            // 
            // txtUltimoBackHora
            // 
            txtUltimoBackHora.Enabled = false;
            txtUltimoBackHora.Location = new Point(26, 157);
            txtUltimoBackHora.Name = "txtUltimoBackHora";
            txtUltimoBackHora.ReadOnly = true;
            txtUltimoBackHora.Size = new Size(209, 23);
            txtUltimoBackHora.TabIndex = 35;
            // 
            // txtTablasPrinci
            // 
            txtTablasPrinci.Location = new Point(26, 214);
            txtTablasPrinci.Multiline = true;
            txtTablasPrinci.Name = "txtTablasPrinci";
            txtTablasPrinci.ReadOnly = true;
            txtTablasPrinci.Size = new Size(209, 206);
            txtTablasPrinci.TabIndex = 34;
            // 
            // txtCanTablaBD
            // 
            txtCanTablaBD.Enabled = false;
            txtCanTablaBD.Location = new Point(144, 98);
            txtCanTablaBD.Name = "txtCanTablaBD";
            txtCanTablaBD.ReadOnly = true;
            txtCanTablaBD.Size = new Size(93, 23);
            txtCanTablaBD.TabIndex = 28;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.WindowText;
            lblPassword.Location = new Point(17, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 17);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Cantidad de Tablas ";
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(70, 194);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(118, 17);
            lblTelefDato.TabIndex = 13;
            lblTelefDato.Text = "Tablas principales";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.WindowText;
            lbl.Location = new Point(17, 42);
            lbl.Name = "lbl";
            lbl.Size = new Size(58, 17);
            lbl.TabIndex = 11;
            lbl.Text = "Nombre";
            // 
            // txtNombreBD
            // 
            txtNombreBD.Location = new Point(93, 36);
            txtNombreBD.Name = "txtNombreBD";
            txtNombreBD.ReadOnly = true;
            txtNombreBD.Size = new Size(144, 23);
            txtNombreBD.TabIndex = 10;
            // 
            // lblApellidoDato
            // 
            lblApellidoDato.AutoSize = true;
            lblApellidoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidoDato.ForeColor = SystemColors.WindowText;
            lblApellidoDato.Location = new Point(59, 138);
            lblApellidoDato.Name = "lblApellidoDato";
            lblApellidoDato.Size = new Size(141, 17);
            lblApellidoDato.TabIndex = 8;
            lblApellidoDato.Text = "Ultimo Backup Hecho";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(17, 71);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(57, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Tamaño";
            // 
            // txtTamaBD
            // 
            txtTamaBD.Location = new Point(93, 65);
            txtTamaBD.Name = "txtTamaBD";
            txtTamaBD.ReadOnly = true;
            txtTamaBD.Size = new Size(144, 23);
            txtTamaBD.TabIndex = 1;
            // 
            // lblDatoDelaBD
            // 
            lblDatoDelaBD.AutoSize = true;
            lblDatoDelaBD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatoDelaBD.Location = new Point(0, 3);
            lblDatoDelaBD.Name = "lblDatoDelaBD";
            lblDatoDelaBD.Size = new Size(261, 30);
            lblDatoDelaBD.TabIndex = 0;
            lblDatoDelaBD.Text = "Datos De La Base de datos";
            // 
            // iconBtnFolder
            // 
            iconBtnFolder.BackColor = Color.Orange;
            iconBtnFolder.BackgroundImage = (Image)resources.GetObject("iconBtnFolder.BackgroundImage");
            iconBtnFolder.BackgroundImageLayout = ImageLayout.None;
            iconBtnFolder.Cursor = Cursors.Hand;
            iconBtnFolder.FlatAppearance.BorderColor = Color.Black;
            iconBtnFolder.FlatStyle = FlatStyle.Flat;
            iconBtnFolder.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnFolder.ForeColor = SystemColors.ControlLightLight;
            iconBtnFolder.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnFolder.IconColor = Color.White;
            iconBtnFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnFolder.IconSize = 30;
            iconBtnFolder.Location = new Point(133, 204);
            iconBtnFolder.Name = "iconBtnFolder";
            iconBtnFolder.Size = new Size(144, 26);
            iconBtnFolder.TabIndex = 20;
            iconBtnFolder.Text = "Seleccione Carpeta";
            iconBtnFolder.TextAlign = ContentAlignment.MiddleRight;
            iconBtnFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnFolder.UseVisualStyleBackColor = false;
            iconBtnFolder.Click += iconBtnFolder_Click;
            // 
            // txtSelectFolderPath
            // 
            txtSelectFolderPath.BackColor = SystemColors.Window;
            txtSelectFolderPath.Location = new Point(135, 208);
            txtSelectFolderPath.Name = "txtSelectFolderPath";
            txtSelectFolderPath.Size = new Size(144, 23);
            txtSelectFolderPath.TabIndex = 31;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.Window;
            lblEstadoDato.Location = new Point(29, 208);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(98, 21);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Guardar En:";
            // 
            // iconBtnImportar
            // 
            iconBtnImportar.BackColor = Color.Orange;
            iconBtnImportar.BackgroundImage = (Image)resources.GetObject("iconBtnImportar.BackgroundImage");
            iconBtnImportar.BackgroundImageLayout = ImageLayout.None;
            iconBtnImportar.Cursor = Cursors.Hand;
            iconBtnImportar.FlatAppearance.BorderColor = Color.Black;
            iconBtnImportar.FlatStyle = FlatStyle.Flat;
            iconBtnImportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnImportar.ForeColor = SystemColors.ControlLightLight;
            iconBtnImportar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnImportar.IconColor = Color.White;
            iconBtnImportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnImportar.IconSize = 30;
            iconBtnImportar.Location = new Point(259, 252);
            iconBtnImportar.Name = "iconBtnImportar";
            iconBtnImportar.Size = new Size(123, 38);
            iconBtnImportar.TabIndex = 18;
            iconBtnImportar.Text = "Importar Base ";
            iconBtnImportar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnImportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnImportar.UseVisualStyleBackColor = false;
            iconBtnImportar.Click += iconBtnImportar_Click;
            // 
            // iconBtnRespaldar
            // 
            iconBtnRespaldar.BackColor = Color.Orange;
            iconBtnRespaldar.BackgroundImage = (Image)resources.GetObject("iconBtnRespaldar.BackgroundImage");
            iconBtnRespaldar.BackgroundImageLayout = ImageLayout.None;
            iconBtnRespaldar.Cursor = Cursors.Hand;
            iconBtnRespaldar.FlatAppearance.BorderColor = Color.Black;
            iconBtnRespaldar.FlatStyle = FlatStyle.Flat;
            iconBtnRespaldar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnRespaldar.ForeColor = SystemColors.ControlLightLight;
            iconBtnRespaldar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnRespaldar.IconColor = Color.White;
            iconBtnRespaldar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnRespaldar.IconSize = 30;
            iconBtnRespaldar.Location = new Point(39, 252);
            iconBtnRespaldar.Name = "iconBtnRespaldar";
            iconBtnRespaldar.Size = new Size(129, 38);
            iconBtnRespaldar.TabIndex = 19;
            iconBtnRespaldar.Text = "Respaldar Base";
            iconBtnRespaldar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRespaldar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRespaldar.UseVisualStyleBackColor = false;
            iconBtnRespaldar.Click += iconBtnRespaldar_Click;
            // 
            // txtSeleccionServidor
            // 
            txtSeleccionServidor.Location = new Point(322, 110);
            txtSeleccionServidor.Name = "txtSeleccionServidor";
            txtSeleccionServidor.ReadOnly = true;
            txtSeleccionServidor.Size = new Size(209, 23);
            txtSeleccionServidor.TabIndex = 20;
            // 
            // txtSeleccionBase
            // 
            txtSeleccionBase.Location = new Point(322, 152);
            txtSeleccionBase.Name = "txtSeleccionBase";
            txtSeleccionBase.ReadOnly = true;
            txtSeleccionBase.Size = new Size(209, 23);
            txtSeleccionBase.TabIndex = 21;
            // 
            // FrmRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(txtSeleccionBase);
            Controls.Add(iconBtnFolder);
            Controls.Add(txtSeleccionServidor);
            Controls.Add(iconBtnRespaldar);
            Controls.Add(iconBtnImportar);
            Controls.Add(panelDatosUsuario);
            Controls.Add(txtSelectFolderPath);
            Controls.Add(label1);
            Controls.Add(lblFiltrar);
            Controls.Add(panel1);
            Controls.Add(lblEstadoDato);
            MinimumSize = new Size(838, 604);
            Name = "FrmRespaldo";
            Text = "Base De Datos";
            Load += FrmRespaldo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private Label lblFiltrar;
        private Label label1;
        private Panel panelDatosUsuario;
        private Label lblPassword;
        private TextBox txtCanTablaBD;
        private TextBox txtIdGuardado;
        private Label lblEstadoDato;
        private Label lblTelefDato;
        private Label lblApellidoDato;
        private Label lblNombreDato;
        private TextBox txtTamaBD;
        private Label lblDatoDelaBD;
        private Label lbl;
        private TextBox txtNombreBD;
        private TextBox txtSelectFolderPath;
        private FontAwesome.Sharp.IconButton iconBtnImportar;
        private FontAwesome.Sharp.IconButton iconBtnRespaldar;
        private FontAwesome.Sharp.IconButton iconBtnFolder;
        private TextBox txtSeleccionServidor;
        private TextBox txtSeleccionBase;
        private TextBox txtTablasPrinci;
        private TextBox txtUltimoBackHora;
    }
}