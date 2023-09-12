namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmGestionarUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            textBox2 = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            lblFiltrar = new Label();
            lblListaEmpleados = new Label();
            dataGridUsuarios = new DataGridView();
            panel2 = new Panel();
            lblDatosUsuario = new Label();
            iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            iconBtnElim = new FontAwesome.Sharp.IconButton();
            iconBtnPermiso = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblFiltrar);
            panel1.Controls.Add(lblListaEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 92);
            panel1.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.Silver;
            txtDni.Location = new Point(211, 58);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(97, 20);
            txtDni.TabIndex = 11;
            txtDni.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Silver;
            txtNombre.Location = new Point(378, 59);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(97, 20);
            txtNombre.TabIndex = 10;
            txtNombre.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(550, 58);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 20);
            textBox2.TabIndex = 9;
            textBox2.Text = "Apellido";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(484, 59);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(314, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlLightLight;
            lblDni.Location = new Point(171, 59);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 17);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI ";
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltrar.ForeColor = SystemColors.ControlLightLight;
            lblFiltrar.Location = new Point(80, 51);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(71, 25);
            lblFiltrar.TabIndex = 1;
            lblFiltrar.Text = "Filtrar:";
            // 
            // lblListaEmpleados
            // 
            lblListaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblListaEmpleados.AutoSize = true;
            lblListaEmpleados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEmpleados.ForeColor = SystemColors.ControlLightLight;
            lblListaEmpleados.ImageAlign = ContentAlignment.TopCenter;
            lblListaEmpleados.Location = new Point(267, 0);
            lblListaEmpleados.Name = "lblListaEmpleados";
            lblListaEmpleados.Size = new Size(276, 45);
            lblListaEmpleados.TabIndex = 0;
            lblListaEmpleados.Text = "Lista De Usuarios";
            lblListaEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.White;
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(80, 161);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridUsuarios.RowTemplate.Height = 25;
            dataGridUsuarios.Size = new Size(427, 277);
            dataGridUsuarios.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblDatosUsuario);
            panel2.Location = new Point(550, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 340);
            panel2.TabIndex = 3;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(32, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(180, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos Del Usuario";
            // 
            // iconBtnAgregar
            // 
            iconBtnAgregar.BackColor = Color.FromArgb(19, 173, 39);
            iconBtnAgregar.Cursor = Cursors.Hand;
            iconBtnAgregar.FlatAppearance.BorderColor = Color.Black;
            iconBtnAgregar.FlatStyle = FlatStyle.Flat;
            iconBtnAgregar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnAgregar.ForeColor = SystemColors.ControlLightLight;
            iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconBtnAgregar.IconColor = Color.White;
            iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregar.IconSize = 30;
            iconBtnAgregar.Location = new Point(80, 99);
            iconBtnAgregar.Name = "iconBtnAgregar";
            iconBtnAgregar.Size = new Size(89, 39);
            iconBtnAgregar.TabIndex = 7;
            iconBtnAgregar.Text = "Agregar";
            iconBtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAgregar.UseVisualStyleBackColor = false;
            iconBtnAgregar.Click += iconBtnAgregar_Click;
            // 
            // iconBtnModif
            // 
            iconBtnModif.BackColor = Color.FromArgb(56, 182, 255);
            iconBtnModif.Cursor = Cursors.Hand;
            iconBtnModif.FlatAppearance.BorderColor = Color.Black;
            iconBtnModif.FlatStyle = FlatStyle.Flat;
            iconBtnModif.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnModif.ForeColor = SystemColors.ControlLightLight;
            iconBtnModif.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconBtnModif.IconColor = Color.White;
            iconBtnModif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnModif.IconSize = 30;
            iconBtnModif.Location = new Point(192, 99);
            iconBtnModif.Name = "iconBtnModif";
            iconBtnModif.Size = new Size(96, 39);
            iconBtnModif.TabIndex = 8;
            iconBtnModif.Text = "Modificar";
            iconBtnModif.TextAlign = ContentAlignment.MiddleRight;
            iconBtnModif.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnModif.UseVisualStyleBackColor = false;
            iconBtnModif.Click += iconBtnModif_Click;
            // 
            // iconBtnElim
            // 
            iconBtnElim.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnElim.Cursor = Cursors.Hand;
            iconBtnElim.FlatAppearance.BorderColor = Color.Black;
            iconBtnElim.FlatStyle = FlatStyle.Flat;
            iconBtnElim.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnElim.ForeColor = SystemColors.ControlLightLight;
            iconBtnElim.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            iconBtnElim.IconColor = Color.White;
            iconBtnElim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnElim.IconSize = 30;
            iconBtnElim.Location = new Point(314, 98);
            iconBtnElim.Name = "iconBtnElim";
            iconBtnElim.Size = new Size(89, 39);
            iconBtnElim.TabIndex = 9;
            iconBtnElim.Text = "Eliminar";
            iconBtnElim.TextAlign = ContentAlignment.MiddleRight;
            iconBtnElim.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnElim.UseVisualStyleBackColor = false;
            iconBtnElim.Click += iconBtnElim_Click;
            // 
            // iconBtnPermiso
            // 
            iconBtnPermiso.BackColor = Color.FromArgb(216, 103, 30);
            iconBtnPermiso.Cursor = Cursors.Hand;
            iconBtnPermiso.FlatAppearance.BorderColor = Color.Black;
            iconBtnPermiso.FlatStyle = FlatStyle.Flat;
            iconBtnPermiso.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnPermiso.ForeColor = SystemColors.ControlLightLight;
            iconBtnPermiso.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconBtnPermiso.IconColor = Color.White;
            iconBtnPermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnPermiso.IconSize = 30;
            iconBtnPermiso.Location = new Point(426, 98);
            iconBtnPermiso.Name = "iconBtnPermiso";
            iconBtnPermiso.Size = new Size(90, 39);
            iconBtnPermiso.TabIndex = 10;
            iconBtnPermiso.Text = "Permiso";
            iconBtnPermiso.TextAlign = ContentAlignment.MiddleRight;
            iconBtnPermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnPermiso.UseVisualStyleBackColor = false;
            iconBtnPermiso.Click += iconBtnPermiso_Click;
            // 
            // FrmGestionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(800, 450);
            Controls.Add(iconBtnPermiso);
            Controls.Add(iconBtnElim);
            Controls.Add(iconBtnModif);
            Controls.Add(iconBtnAgregar);
            Controls.Add(panel2);
            Controls.Add(dataGridUsuarios);
            Controls.Add(panel1);
            Name = "FrmGestionarUsuario";
            Text = "Lista de Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaEmpleados;
        private DataGridView dataGridUsuarios;
        private Label lblDni;
        private Label lblFiltrar;
        private TextBox textBox2;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtDni;
        private TextBox txtNombre;
        private Panel panel2;
        private Label lblDatosUsuario;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private FontAwesome.Sharp.IconButton iconBtnElim;
        private FontAwesome.Sharp.IconButton iconBtnPermiso;
    }
}