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
            listBox1 = new ListBox();
            iconBtnFolder = new FontAwesome.Sharp.IconButton();
            txtCanTablaBD = new TextBox();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            txtSelectFolderPath = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblPassword = new Label();
            lblEstadoDato = new Label();
            lblTelefDato = new Label();
            lbl = new Label();
            txtNombreBD = new TextBox();
            lblApellidoDato = new Label();
            lblNombreDato = new Label();
            txtTamaBD = new TextBox();
            lblDatoDelaBD = new Label();
            iconBtnImportar = new FontAwesome.Sharp.IconButton();
            iconBtnRespaldar = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            panel1.Size = new Size(822, 65);
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
            panelDatosUsuario.Controls.Add(listBox1);
            panelDatosUsuario.Controls.Add(iconBtnFolder);
            panelDatosUsuario.Controls.Add(txtCanTablaBD);
            panelDatosUsuario.Controls.Add(iconbtnGuardar);
            panelDatosUsuario.Controls.Add(iconBtnCancelar);
            panelDatosUsuario.Controls.Add(txtSelectFolderPath);
            panelDatosUsuario.Controls.Add(dateTimePicker1);
            panelDatosUsuario.Controls.Add(lblPassword);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Controls.Add(lblTelefDato);
            panelDatosUsuario.Controls.Add(lbl);
            panelDatosUsuario.Controls.Add(txtNombreBD);
            panelDatosUsuario.Controls.Add(lblApellidoDato);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(txtTamaBD);
            panelDatosUsuario.Controls.Add(lblDatoDelaBD);
            panelDatosUsuario.Location = new Point(565, 71);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(257, 482);
            panelDatosUsuario.TabIndex = 17;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(30, 255);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(204, 94);
            listBox1.TabIndex = 20;
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
            iconBtnFolder.Location = new Point(79, 131);
            iconBtnFolder.Name = "iconBtnFolder";
            iconBtnFolder.Size = new Size(144, 26);
            iconBtnFolder.TabIndex = 20;
            iconBtnFolder.Text = "Seleccione Carpeta";
            iconBtnFolder.TextAlign = ContentAlignment.MiddleRight;
            iconBtnFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnFolder.UseVisualStyleBackColor = false;
            iconBtnFolder.Click += iconBtnFolder_Click;
            // 
            // txtCanTablaBD
            // 
            txtCanTablaBD.Enabled = false;
            txtCanTablaBD.Location = new Point(130, 98);
            txtCanTablaBD.Name = "txtCanTablaBD";
            txtCanTablaBD.ReadOnly = true;
            txtCanTablaBD.Size = new Size(93, 23);
            txtCanTablaBD.TabIndex = 28;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(56, 182, 255);
            iconbtnGuardar.BackgroundImageLayout = ImageLayout.Center;
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 36;
            iconbtnGuardar.Location = new Point(35, 362);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(188, 39);
            iconbtnGuardar.TabIndex = 33;
            iconbtnGuardar.Text = "Confirmar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            // 
            // iconBtnCancelar
            // 
            iconBtnCancelar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnCancelar.Cursor = Cursors.Hand;
            iconBtnCancelar.FlatAppearance.BorderColor = Color.Black;
            iconBtnCancelar.FlatStyle = FlatStyle.Flat;
            iconBtnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(35, 407);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(188, 39);
            iconBtnCancelar.TabIndex = 32;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtSelectFolderPath
            // 
            txtSelectFolderPath.BackColor = SystemColors.Window;
            txtSelectFolderPath.Location = new Point(81, 135);
            txtSelectFolderPath.Name = "txtSelectFolderPath";
            txtSelectFolderPath.Size = new Size(144, 23);
            txtSelectFolderPath.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(79, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.WindowText;
            lblPassword.Location = new Point(3, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 17);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Cantidad de Tablas ";
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(3, 136);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(80, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Guardar En:";
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(14, 235);
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
            lbl.Location = new Point(3, 42);
            lbl.Name = "lbl";
            lbl.Size = new Size(58, 17);
            lbl.TabIndex = 11;
            lbl.Text = "Nombre";
            // 
            // txtNombreBD
            // 
            txtNombreBD.Location = new Point(79, 36);
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
            lblApellidoDato.Location = new Point(3, 170);
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
            lblNombreDato.Location = new Point(3, 71);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(57, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Tamaño";
            // 
            // txtTamaBD
            // 
            txtTamaBD.Location = new Point(79, 65);
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
            iconBtnImportar.Location = new Point(298, 197);
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
            iconBtnRespaldar.Location = new Point(78, 197);
            iconBtnRespaldar.Name = "iconBtnRespaldar";
            iconBtnRespaldar.Size = new Size(129, 38);
            iconBtnRespaldar.TabIndex = 19;
            iconBtnRespaldar.Text = "Respaldar Base";
            iconBtnRespaldar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRespaldar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRespaldar.UseVisualStyleBackColor = false;
            iconBtnRespaldar.Click += iconBtnRespaldar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 110);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 152);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 21;
            // 
            // FrmRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(iconBtnRespaldar);
            Controls.Add(iconBtnImportar);
            Controls.Add(panelDatosUsuario);
            Controls.Add(label1);
            Controls.Add(lblFiltrar);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmRespaldo";
            Text = "Base De Datos";
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
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnImportar;
        private FontAwesome.Sharp.IconButton iconBtnRespaldar;
        private FontAwesome.Sharp.IconButton iconBtnFolder;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}