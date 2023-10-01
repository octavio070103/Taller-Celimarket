namespace CapaPresentacion.Formularios.Admin.usuario
{
    partial class FrmRegistrarDomicilio
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
            panel2 = new Panel();
            lblLocalidad = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            txtLocalidadDomi = new TextBox();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            txtProvDomi = new TextBox();
            txtNumDomi = new TextBox();
            lblProvincia = new Label();
            lblNumero = new Label();
            txtCodPostalDomi = new TextBox();
            lblCodPostal = new Label();
            txtCalleDomi = new TextBox();
            lblCalle = new Label();
            panel1 = new Panel();
            lblRegistrarDomi = new Label();
            errorProviderDomicilio = new ErrorProvider(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderDomicilio).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(lblLocalidad);
            panel2.Controls.Add(lblDescripcion);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(txtLocalidadDomi);
            panel2.Controls.Add(iconBtnCancelar);
            panel2.Controls.Add(iconbtnGuardar);
            panel2.Controls.Add(iconBtnLimpiarDatos);
            panel2.Controls.Add(txtProvDomi);
            panel2.Controls.Add(txtNumDomi);
            panel2.Controls.Add(lblProvincia);
            panel2.Controls.Add(lblNumero);
            panel2.Controls.Add(txtCodPostalDomi);
            panel2.Controls.Add(lblCodPostal);
            panel2.Controls.Add(txtCalleDomi);
            panel2.Controls.Add(lblCalle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 421);
            panel2.TabIndex = 4;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocalidad.Location = new Point(356, 100);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(88, 19);
            lblLocalidad.TabIndex = 77;
            lblLocalidad.Text = "Localidad";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(99, 216);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(182, 19);
            lblDescripcion.TabIndex = 76;
            lblDescripcion.Text = "Descripcion(opcional)";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Location = new Point(98, 238);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(471, 84);
            txtDescripcion.TabIndex = 75;
            // 
            // txtLocalidadDomi
            // 
            txtLocalidadDomi.Cursor = Cursors.IBeam;
            txtLocalidadDomi.Location = new Point(356, 122);
            txtLocalidadDomi.Multiline = true;
            txtLocalidadDomi.Name = "txtLocalidadDomi";
            txtLocalidadDomi.Size = new Size(213, 23);
            txtLocalidadDomi.TabIndex = 74;
            // 
            // iconBtnCancelar
            // 
            iconBtnCancelar.BackColor = Color.FromArgb(1, 1, 2);
            iconBtnCancelar.Cursor = Cursors.Hand;
            iconBtnCancelar.FlatAppearance.BorderColor = Color.Black;
            iconBtnCancelar.FlatStyle = FlatStyle.Flat;
            iconBtnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(150, 346);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(116, 43);
            iconBtnCancelar.TabIndex = 70;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(47, 33, 75);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 30;
            iconbtnGuardar.Location = new Point(292, 346);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(115, 43);
            iconbtnGuardar.TabIndex = 69;
            iconbtnGuardar.Text = "Guardar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
            // 
            // iconBtnLimpiarDatos
            // 
            iconBtnLimpiarDatos.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnLimpiarDatos.Cursor = Cursors.Hand;
            iconBtnLimpiarDatos.FlatAppearance.BorderColor = Color.Black;
            iconBtnLimpiarDatos.FlatStyle = FlatStyle.Flat;
            iconBtnLimpiarDatos.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnLimpiarDatos.ForeColor = SystemColors.ControlLightLight;
            iconBtnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconBtnLimpiarDatos.IconColor = Color.White;
            iconBtnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnLimpiarDatos.IconSize = 30;
            iconBtnLimpiarDatos.Location = new Point(442, 348);
            iconBtnLimpiarDatos.Name = "iconBtnLimpiarDatos";
            iconBtnLimpiarDatos.Size = new Size(86, 43);
            iconBtnLimpiarDatos.TabIndex = 68;
            iconBtnLimpiarDatos.Text = "Limpiar";
            iconBtnLimpiarDatos.TextAlign = ContentAlignment.MiddleRight;
            iconBtnLimpiarDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnLimpiarDatos.UseVisualStyleBackColor = false;
            // 
            // txtProvDomi
            // 
            txtProvDomi.Cursor = Cursors.IBeam;
            txtProvDomi.Location = new Point(99, 180);
            txtProvDomi.Multiline = true;
            txtProvDomi.Name = "txtProvDomi";
            txtProvDomi.Size = new Size(213, 23);
            txtProvDomi.TabIndex = 11;
            // 
            // txtNumDomi
            // 
            txtNumDomi.Cursor = Cursors.IBeam;
            txtNumDomi.Location = new Point(99, 122);
            txtNumDomi.Multiline = true;
            txtNumDomi.Name = "txtNumDomi";
            txtNumDomi.Size = new Size(213, 23);
            txtNumDomi.TabIndex = 8;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProvincia.Location = new Point(98, 158);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(81, 19);
            lblProvincia.TabIndex = 7;
            lblProvincia.Text = "Provincia";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(99, 100);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(72, 19);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Numero";
            // 
            // txtCodPostalDomi
            // 
            txtCodPostalDomi.Cursor = Cursors.IBeam;
            txtCodPostalDomi.Location = new Point(356, 65);
            txtCodPostalDomi.Multiline = true;
            txtCodPostalDomi.Name = "txtCodPostalDomi";
            txtCodPostalDomi.Size = new Size(213, 23);
            txtCodPostalDomi.TabIndex = 5;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCodPostal.Location = new Point(356, 43);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(115, 19);
            lblCodPostal.TabIndex = 4;
            lblCodPostal.Text = "Codigo Postal";
            // 
            // txtCalleDomi
            // 
            txtCalleDomi.Cursor = Cursors.IBeam;
            txtCalleDomi.Location = new Point(99, 65);
            txtCalleDomi.Multiline = true;
            txtCalleDomi.Name = "txtCalleDomi";
            txtCalleDomi.Size = new Size(213, 23);
            txtCalleDomi.TabIndex = 1;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalle.Location = new Point(99, 43);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(50, 19);
            lblCalle.TabIndex = 0;
            lblCalle.Text = "Calle";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblRegistrarDomi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 61);
            panel1.TabIndex = 3;
            // 
            // lblRegistrarDomi
            // 
            lblRegistrarDomi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRegistrarDomi.AutoSize = true;
            lblRegistrarDomi.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrarDomi.ForeColor = SystemColors.ControlLightLight;
            lblRegistrarDomi.ImageAlign = ContentAlignment.TopCenter;
            lblRegistrarDomi.Location = new Point(130, 9);
            lblRegistrarDomi.Name = "lblRegistrarDomi";
            lblRegistrarDomi.Size = new Size(308, 45);
            lblRegistrarDomi.TabIndex = 0;
            lblRegistrarDomi.Text = "Registrar Domicilio";
            lblRegistrarDomi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProviderDomicilio
            // 
            errorProviderDomicilio.ContainerControl = this;
            // 
            // FrmRegistrarDomicilio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 482);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarDomicilio";
            Text = "FrmRegistrarDomicilio";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderDomicilio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DateTimePicker dateTimePickerNacimiento;
        private Label lblFechaNacimiento;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnLimpiarDatos;
        private FontAwesome.Sharp.IconButton iconBtnDomicilio;
        private PictureBox pciBoxSubirImg;
        private ComboBox comboRolUsu;
        private FontAwesome.Sharp.IconButton contraVisible;
        private Label lblPerfilUsuario;
        private Label lblDomicilio;
        private TextBox txtEmailUsu;
        private TextBox txtPasswordUsu;
        private Label lblPassword;
        private TextBox txtProvDomi;
        private Label lblEmail;
        private TextBox txtNumDomi;
        private Label lblProvincia;
        private Label lblNumero;
        private TextBox txtCodPostalDomi;
        private Label lblCodPostal;
        private PictureBox pictureBox1;
        private TextBox txtCalleDomi;
        private Label lblCalle;
        private Panel panel1;
        private Label lblRegistrarDomi;
        private TextBox txtDescripcion;
        private TextBox txtLocalidadDomi;
        private Label lblDescripcion;
        private Label lblLocalidad;
        private ErrorProvider errorProviderDomicilio;
    }
}