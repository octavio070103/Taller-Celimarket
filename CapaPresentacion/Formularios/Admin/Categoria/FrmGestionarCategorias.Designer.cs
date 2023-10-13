namespace CapaPresentacion.Formularios.Admin.Categoria
{
    partial class FrmGestionarCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarCategorias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblListaCategoria = new Label();
            panel2 = new Panel();
            iconBtnProducto = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconBtnAgregarCateg = new FontAwesome.Sharp.IconButton();
            panelDatosUsuario = new Panel();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconBtnModif = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblDniDato = new Label();
            txtDniDato = new TextBox();
            txtApeDato = new TextBox();
            txtNombreDato = new TextBox();
            lblDatosUsuario = new Label();
            lblNombreDato = new Label();
            lblApellidoDato = new Label();
            lblEstadoDato = new Label();
            dataGridCategoria = new DataGridView();
            col_id_categoria = new DataGridViewTextBoxColumn();
            col_nombre_categ = new DataGridViewTextBoxColumn();
            col_descrip_categ = new DataGridViewTextBoxColumn();
            col_estado_categoria = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblListaCategoria);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 1;
            // 
            // lblListaCategoria
            // 
            lblListaCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaCategoria.AutoSize = true;
            lblListaCategoria.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaCategoria.ForeColor = SystemColors.ControlLightLight;
            lblListaCategoria.ImageAlign = ContentAlignment.TopCenter;
            lblListaCategoria.Location = new Point(278, 0);
            lblListaCategoria.Name = "lblListaCategoria";
            lblListaCategoria.Size = new Size(306, 45);
            lblListaCategoria.TabIndex = 0;
            lblListaCategoria.Text = "Lista De Categorias";
            lblListaCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 68, 89);
            panel2.Controls.Add(iconBtnProducto);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconBtnAgregarCateg);
            panel2.Controls.Add(panelDatosUsuario);
            panel2.Controls.Add(dataGridCategoria);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 473);
            panel2.TabIndex = 2;
            // 
            // iconBtnProducto
            // 
            iconBtnProducto.BackColor = Color.Navy;
            iconBtnProducto.BackgroundImage = (Image)resources.GetObject("iconBtnProducto.BackgroundImage");
            iconBtnProducto.BackgroundImageLayout = ImageLayout.None;
            iconBtnProducto.Cursor = Cursors.Hand;
            iconBtnProducto.FlatAppearance.BorderColor = Color.Black;
            iconBtnProducto.FlatStyle = FlatStyle.Flat;
            iconBtnProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnProducto.ForeColor = SystemColors.ControlLightLight;
            iconBtnProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnProducto.IconColor = Color.White;
            iconBtnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnProducto.IconSize = 30;
            iconBtnProducto.Location = new Point(431, 6);
            iconBtnProducto.Name = "iconBtnProducto";
            iconBtnProducto.Size = new Size(103, 39);
            iconBtnProducto.TabIndex = 22;
            iconBtnProducto.Text = "Productos";
            iconBtnProducto.TextAlign = ContentAlignment.MiddleRight;
            iconBtnProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnProducto.UseVisualStyleBackColor = false;
            iconBtnProducto.Click += iconBtnProducto_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(246, 69, 32);
            iconButton3.BackgroundImage = (Image)resources.GetObject("iconButton3.BackgroundImage");
            iconButton3.BackgroundImageLayout = ImageLayout.None;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderColor = Color.Black;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = SystemColors.ControlLightLight;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(278, 6);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(109, 38);
            iconButton3.TabIndex = 21;
            iconButton3.Text = "Dar De Baja";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Orange;
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(278, 6);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(89, 38);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "Dar Alta";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBtnAgregarCateg
            // 
            iconBtnAgregarCateg.BackColor = Color.FromArgb(118, 254, 64);
            iconBtnAgregarCateg.BackgroundImage = (Image)resources.GetObject("iconBtnAgregarCateg.BackgroundImage");
            iconBtnAgregarCateg.BackgroundImageLayout = ImageLayout.None;
            iconBtnAgregarCateg.Cursor = Cursors.Hand;
            iconBtnAgregarCateg.FlatAppearance.BorderColor = Color.Black;
            iconBtnAgregarCateg.FlatStyle = FlatStyle.Flat;
            iconBtnAgregarCateg.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAgregarCateg.ForeColor = SystemColors.ControlLightLight;
            iconBtnAgregarCateg.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAgregarCateg.IconColor = Color.White;
            iconBtnAgregarCateg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAgregarCateg.IconSize = 30;
            iconBtnAgregarCateg.Location = new Point(147, 6);
            iconBtnAgregarCateg.Name = "iconBtnAgregarCateg";
            iconBtnAgregarCateg.Size = new Size(89, 39);
            iconBtnAgregarCateg.TabIndex = 18;
            iconBtnAgregarCateg.Text = "Agregar";
            iconBtnAgregarCateg.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAgregarCateg.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAgregarCateg.UseVisualStyleBackColor = false;
            iconBtnAgregarCateg.Click += iconBtnAgregarCateg_Click;
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(iconbtnGuardar);
            panelDatosUsuario.Controls.Add(iconBtnCancelar);
            panelDatosUsuario.Controls.Add(iconBtnModif);
            panelDatosUsuario.Controls.Add(comboEstadoDato);
            panelDatosUsuario.Controls.Add(lblDniDato);
            panelDatosUsuario.Controls.Add(txtDniDato);
            panelDatosUsuario.Controls.Add(txtApeDato);
            panelDatosUsuario.Controls.Add(txtNombreDato);
            panelDatosUsuario.Controls.Add(lblDatosUsuario);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(lblApellidoDato);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Location = new Point(584, 29);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(238, 362);
            panelDatosUsuario.TabIndex = 13;
            // 
            // iconbtnGuardar
            // 
            iconbtnGuardar.BackColor = Color.FromArgb(56, 182, 255);
            iconbtnGuardar.Cursor = Cursors.Hand;
            iconbtnGuardar.FlatAppearance.BorderColor = Color.Black;
            iconbtnGuardar.FlatStyle = FlatStyle.Flat;
            iconbtnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnGuardar.ForeColor = SystemColors.ControlLightLight;
            iconbtnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconbtnGuardar.IconColor = Color.White;
            iconbtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnGuardar.IconSize = 36;
            iconbtnGuardar.Location = new Point(21, 193);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(202, 39);
            iconbtnGuardar.TabIndex = 25;
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
            iconBtnCancelar.Location = new Point(21, 238);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(202, 39);
            iconBtnCancelar.TabIndex = 11;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // iconBtnModif
            // 
            iconBtnModif.BackColor = Color.FromArgb(255, 222, 89);
            iconBtnModif.Cursor = Cursors.Hand;
            iconBtnModif.FlatAppearance.BorderColor = Color.Black;
            iconBtnModif.FlatStyle = FlatStyle.Flat;
            iconBtnModif.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnModif.ForeColor = Color.White;
            iconBtnModif.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconBtnModif.IconColor = Color.White;
            iconBtnModif.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnModif.IconSize = 30;
            iconBtnModif.Location = new Point(21, 193);
            iconBtnModif.Name = "iconBtnModif";
            iconBtnModif.Size = new Size(202, 39);
            iconBtnModif.TabIndex = 24;
            iconBtnModif.Text = "Modificar";
            iconBtnModif.TextAlign = ContentAlignment.MiddleRight;
            iconBtnModif.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnModif.UseVisualStyleBackColor = false;
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 139);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            comboEstadoDato.Text = "Seleccione un Estado";
            // 
            // lblDniDato
            // 
            lblDniDato.AutoSize = true;
            lblDniDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniDato.ForeColor = SystemColors.WindowText;
            lblDniDato.Location = new Point(3, 61);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new Size(32, 17);
            lblDniDato.TabIndex = 11;
            lblDniDato.Text = "DNI";
            // 
            // txtDniDato
            // 
            txtDniDato.Location = new Point(79, 55);
            txtDniDato.Name = "txtDniDato";
            txtDniDato.Size = new Size(144, 23);
            txtDniDato.TabIndex = 10;
            // 
            // txtApeDato
            // 
            txtApeDato.Location = new Point(79, 113);
            txtApeDato.Name = "txtApeDato";
            txtApeDato.Size = new Size(144, 23);
            txtApeDato.TabIndex = 9;
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 84);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(10, 9);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(216, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Datos De la Categoria";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(0, 90);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(58, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Nombre";
            // 
            // lblApellidoDato
            // 
            lblApellidoDato.AutoSize = true;
            lblApellidoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidoDato.ForeColor = SystemColors.WindowText;
            lblApellidoDato.Location = new Point(0, 119);
            lblApellidoDato.Name = "lblApellidoDato";
            lblApellidoDato.Size = new Size(80, 17);
            lblApellidoDato.TabIndex = 8;
            lblApellidoDato.Text = "Descripcion";
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(0, 139);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(49, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Estado";
            // 
            // dataGridCategoria
            // 
            dataGridCategoria.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridCategoria.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridCategoria.BorderStyle = BorderStyle.None;
            dataGridCategoria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategoria.Columns.AddRange(new DataGridViewColumn[] { col_id_categoria, col_nombre_categ, col_descrip_categ, col_estado_categoria });
            dataGridCategoria.Location = new Point(22, 90);
            dataGridCategoria.MultiSelect = false;
            dataGridCategoria.Name = "dataGridCategoria";
            dataGridCategoria.ReadOnly = true;
            dataGridCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCategoria.RowHeadersVisible = false;
            dataGridCategoria.RowTemplate.Height = 28;
            dataGridCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCategoria.Size = new Size(556, 301);
            dataGridCategoria.TabIndex = 12;
            dataGridCategoria.CellContentClick += dataGridCategoria_CellContentClick;
            // 
            // col_id_categoria
            // 
            col_id_categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col_id_categoria.HeaderText = "Id_categoria";
            col_id_categoria.MinimumWidth = 100;
            col_id_categoria.Name = "col_id_categoria";
            col_id_categoria.ReadOnly = true;
            col_id_categoria.Width = 112;
            // 
            // col_nombre_categ
            // 
            col_nombre_categ.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            col_nombre_categ.HeaderText = "Nombre";
            col_nombre_categ.Name = "col_nombre_categ";
            col_nombre_categ.ReadOnly = true;
            col_nombre_categ.Width = 84;
            // 
            // col_descrip_categ
            // 
            col_descrip_categ.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_descrip_categ.HeaderText = "Descripcion";
            col_descrip_categ.MinimumWidth = 25;
            col_descrip_categ.Name = "col_descrip_categ";
            col_descrip_categ.ReadOnly = true;
            // 
            // col_estado_categoria
            // 
            col_estado_categoria.HeaderText = "Estado";
            col_estado_categoria.Name = "col_estado_categoria";
            col_estado_categoria.ReadOnly = true;
            col_estado_categoria.Width = 74;
            // 
            // FrmGestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmGestionarCategorias";
            Text = "FrmGestionarCategorias";
            Load += FrmGestionarCategorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaCategoria;
        private Panel panel2;
        private Panel panelDatosUsuario;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnModif;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private Label lblDniDato;
        private TextBox txtDniDato;
        private TextBox txtApeDato;
        private Label lblApellidoDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatosUsuario;
        private DataGridView dataGridCategoria;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconBtnAgregarCateg;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconBtnProducto;
        private DataGridViewTextBoxColumn col_id_categoria;
        private DataGridViewTextBoxColumn col_nombre_categ;
        private DataGridViewTextBoxColumn col_descrip_categ;
        private DataGridViewTextBoxColumn col_estado_categoria;
    }
}