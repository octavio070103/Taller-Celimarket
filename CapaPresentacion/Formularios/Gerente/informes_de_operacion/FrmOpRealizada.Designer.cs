namespace CapaPresentacion.Formularios.Gerente.informes_de_operacion
{
    partial class FrmOpRealizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpRealizada));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            iconBtnAlta = new FontAwesome.Sharp.IconButton();
            IconBtnExportar = new FontAwesome.Sharp.IconButton();
            panelDatosUsuario = new Panel();
            label7 = new Label();
            lblFecha = new Label();
            textBox5 = new TextBox();
            dateTimePickerNacimientoDato = new DateTimePicker();
            lblPassword = new Label();
            txtPasswordDato = new TextBox();
            txtDomiciliodato = new TextBox();
            iconBtnAprobado = new FontAwesome.Sharp.IconButton();
            iconBtnIrregular = new FontAwesome.Sharp.IconButton();
            comboEstadoDato = new ComboBox();
            lblEstadoDato = new Label();
            lblDomicilioDato = new Label();
            lblEmailDato = new Label();
            txtEmailDato = new TextBox();
            lblTelefDato = new Label();
            txtTelefDato = new TextBox();
            lblDniDato = new Label();
            txtDniDato = new TextBox();
            lblNombreDato = new Label();
            txtNombreDato = new TextBox();
            lblDatosUsuario = new Label();
            dataGridOperaciones = new DataGridView();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblOperacionRealizadas = new Label();
            iconBtnDevolucion = new FontAwesome.Sharp.IconButton();
            iconBtnPago = new FontAwesome.Sharp.IconButton();
            iconBtnCompras = new FontAwesome.Sharp.IconButton();
            iconBtnVenta = new FontAwesome.Sharp.IconButton();
            panelDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOperaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconBtnAlta
            // 
            iconBtnAlta.BackColor = Color.Goldenrod;
            iconBtnAlta.BackgroundImage = (Image)resources.GetObject("iconBtnAlta.BackgroundImage");
            iconBtnAlta.BackgroundImageLayout = ImageLayout.None;
            iconBtnAlta.Cursor = Cursors.Hand;
            iconBtnAlta.FlatAppearance.BorderColor = Color.Black;
            iconBtnAlta.FlatStyle = FlatStyle.Flat;
            iconBtnAlta.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAlta.ForeColor = SystemColors.ControlLightLight;
            iconBtnAlta.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAlta.IconColor = Color.White;
            iconBtnAlta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAlta.IconSize = 30;
            iconBtnAlta.Location = new Point(444, 97);
            iconBtnAlta.Name = "iconBtnAlta";
            iconBtnAlta.Size = new Size(99, 38);
            iconBtnAlta.TabIndex = 18;
            iconBtnAlta.Text = "Historial";
            iconBtnAlta.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAlta.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAlta.UseVisualStyleBackColor = false;
            iconBtnAlta.Click += iconBtnAlta_Click;
            // 
            // IconBtnExportar
            // 
            IconBtnExportar.BackColor = Color.FromArgb(216, 103, 30);
            IconBtnExportar.BackgroundImage = (Image)resources.GetObject("IconBtnExportar.BackgroundImage");
            IconBtnExportar.BackgroundImageLayout = ImageLayout.None;
            IconBtnExportar.Cursor = Cursors.Hand;
            IconBtnExportar.FlatAppearance.BorderColor = Color.Black;
            IconBtnExportar.FlatStyle = FlatStyle.Flat;
            IconBtnExportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            IconBtnExportar.ForeColor = SystemColors.ControlLightLight;
            IconBtnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            IconBtnExportar.IconColor = Color.White;
            IconBtnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconBtnExportar.IconSize = 30;
            IconBtnExportar.Location = new Point(79, 417);
            IconBtnExportar.Name = "IconBtnExportar";
            IconBtnExportar.Size = new Size(114, 36);
            IconBtnExportar.TabIndex = 17;
            IconBtnExportar.Text = "Exportar ";
            IconBtnExportar.TextAlign = ContentAlignment.MiddleRight;
            IconBtnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconBtnExportar.UseVisualStyleBackColor = false;
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDatosUsuario.BackColor = Color.White;
            panelDatosUsuario.Controls.Add(label7);
            panelDatosUsuario.Controls.Add(lblFecha);
            panelDatosUsuario.Controls.Add(textBox5);
            panelDatosUsuario.Controls.Add(dateTimePickerNacimientoDato);
            panelDatosUsuario.Controls.Add(lblPassword);
            panelDatosUsuario.Controls.Add(txtPasswordDato);
            panelDatosUsuario.Controls.Add(txtDomiciliodato);
            panelDatosUsuario.Controls.Add(IconBtnExportar);
            panelDatosUsuario.Controls.Add(iconBtnAprobado);
            panelDatosUsuario.Controls.Add(iconBtnIrregular);
            panelDatosUsuario.Controls.Add(comboEstadoDato);
            panelDatosUsuario.Controls.Add(lblEstadoDato);
            panelDatosUsuario.Controls.Add(lblDomicilioDato);
            panelDatosUsuario.Controls.Add(lblEmailDato);
            panelDatosUsuario.Controls.Add(txtEmailDato);
            panelDatosUsuario.Controls.Add(lblTelefDato);
            panelDatosUsuario.Controls.Add(txtTelefDato);
            panelDatosUsuario.Controls.Add(lblDniDato);
            panelDatosUsuario.Controls.Add(txtDniDato);
            panelDatosUsuario.Controls.Add(lblNombreDato);
            panelDatosUsuario.Controls.Add(txtNombreDato);
            panelDatosUsuario.Controls.Add(lblDatosUsuario);
            panelDatosUsuario.Location = new Point(582, 97);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(240, 456);
            panelDatosUsuario.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(3, 179);
            label7.Name = "label7";
            label7.Size = new Size(140, 17);
            label7.TabIndex = 77;
            label7.Text = "Listado De Productos";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.WindowText;
            lblFecha.Location = new Point(3, 96);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(39, 15);
            lblFecha.TabIndex = 75;
            lblFecha.Text = "Fecha";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(79, 199);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(144, 45);
            textBox5.TabIndex = 76;
            // 
            // dateTimePickerNacimientoDato
            // 
            dateTimePickerNacimientoDato.Format = DateTimePickerFormat.Short;
            dateTimePickerNacimientoDato.Location = new Point(79, 91);
            dateTimePickerNacimientoDato.MaxDate = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            dateTimePickerNacimientoDato.Name = "dateTimePickerNacimientoDato";
            dateTimePickerNacimientoDato.Size = new Size(144, 23);
            dateTimePickerNacimientoDato.TabIndex = 74;
            dateTimePickerNacimientoDato.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.WindowText;
            lblPassword.Location = new Point(3, 155);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 17);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Vendedor";
            // 
            // txtPasswordDato
            // 
            txtPasswordDato.Location = new Point(79, 149);
            txtPasswordDato.Name = "txtPasswordDato";
            txtPasswordDato.Size = new Size(144, 23);
            txtPasswordDato.TabIndex = 28;
            // 
            // txtDomiciliodato
            // 
            txtDomiciliodato.BackColor = SystemColors.Window;
            txtDomiciliodato.Location = new Point(79, 275);
            txtDomiciliodato.Name = "txtDomiciliodato";
            txtDomiciliodato.ReadOnly = true;
            txtDomiciliodato.Size = new Size(144, 23);
            txtDomiciliodato.TabIndex = 27;
            // 
            // iconBtnAprobado
            // 
            iconBtnAprobado.BackColor = Color.FromArgb(56, 182, 255);
            iconBtnAprobado.Cursor = Cursors.Hand;
            iconBtnAprobado.FlatAppearance.BorderColor = Color.Black;
            iconBtnAprobado.FlatStyle = FlatStyle.Flat;
            iconBtnAprobado.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAprobado.ForeColor = SystemColors.ControlLightLight;
            iconBtnAprobado.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconBtnAprobado.IconColor = Color.White;
            iconBtnAprobado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAprobado.IconSize = 36;
            iconBtnAprobado.Location = new Point(26, 331);
            iconBtnAprobado.Name = "iconBtnAprobado";
            iconBtnAprobado.Size = new Size(202, 39);
            iconBtnAprobado.TabIndex = 25;
            iconBtnAprobado.Text = "Aprobado";
            iconBtnAprobado.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAprobado.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAprobado.UseVisualStyleBackColor = false;
            // 
            // iconBtnIrregular
            // 
            iconBtnIrregular.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnIrregular.Cursor = Cursors.Hand;
            iconBtnIrregular.FlatAppearance.BorderColor = Color.Black;
            iconBtnIrregular.FlatStyle = FlatStyle.Flat;
            iconBtnIrregular.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnIrregular.ForeColor = SystemColors.ControlLightLight;
            iconBtnIrregular.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnIrregular.IconColor = Color.White;
            iconBtnIrregular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnIrregular.IconSize = 30;
            iconBtnIrregular.Location = new Point(26, 373);
            iconBtnIrregular.Name = "iconBtnIrregular";
            iconBtnIrregular.Size = new Size(202, 39);
            iconBtnIrregular.TabIndex = 11;
            iconBtnIrregular.Text = "Irregular";
            iconBtnIrregular.TextAlign = ContentAlignment.MiddleRight;
            iconBtnIrregular.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnIrregular.UseVisualStyleBackColor = false;
            // 
            // comboEstadoDato
            // 
            comboEstadoDato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoDato.FlatStyle = FlatStyle.Popup;
            comboEstadoDato.FormattingEnabled = true;
            comboEstadoDato.Location = new Point(79, 304);
            comboEstadoDato.Name = "comboEstadoDato";
            comboEstadoDato.Size = new Size(144, 23);
            comboEstadoDato.TabIndex = 23;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.AutoSize = true;
            lblEstadoDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = SystemColors.WindowText;
            lblEstadoDato.Location = new Point(10, 310);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(49, 17);
            lblEstadoDato.TabIndex = 22;
            lblEstadoDato.Text = "Estado";
            // 
            // lblDomicilioDato
            // 
            lblDomicilioDato.AutoSize = true;
            lblDomicilioDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomicilioDato.ForeColor = SystemColors.WindowText;
            lblDomicilioDato.Location = new Point(10, 285);
            lblDomicilioDato.Name = "lblDomicilioDato";
            lblDomicilioDato.Size = new Size(39, 17);
            lblDomicilioDato.TabIndex = 18;
            lblDomicilioDato.Text = "Total";
            // 
            // lblEmailDato
            // 
            lblEmailDato.AutoSize = true;
            lblEmailDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailDato.ForeColor = SystemColors.WindowText;
            lblEmailDato.Location = new Point(3, 126);
            lblEmailDato.Name = "lblEmailDato";
            lblEmailDato.Size = new Size(51, 17);
            lblEmailDato.TabIndex = 17;
            lblEmailDato.Text = "Cliente";
            // 
            // txtEmailDato
            // 
            txtEmailDato.Location = new Point(79, 120);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 16;
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(8, 256);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(61, 17);
            lblTelefDato.TabIndex = 13;
            lblTelefDato.Text = "subTotal";
            // 
            // txtTelefDato
            // 
            txtTelefDato.Location = new Point(79, 250);
            txtTelefDato.Name = "txtTelefDato";
            txtTelefDato.Size = new Size(144, 23);
            txtTelefDato.TabIndex = 12;
            // 
            // lblDniDato
            // 
            lblDniDato.AutoSize = true;
            lblDniDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniDato.ForeColor = SystemColors.WindowText;
            lblDniDato.Location = new Point(3, 39);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new Size(124, 17);
            lblDniDato.TabIndex = 11;
            lblDniDato.Text = "num. de operacion";
            // 
            // txtDniDato
            // 
            txtDniDato.Location = new Point(137, 33);
            txtDniDato.Name = "txtDniDato";
            txtDniDato.Size = new Size(86, 23);
            txtDniDato.TabIndex = 10;
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreDato.ForeColor = SystemColors.WindowText;
            lblNombreDato.Location = new Point(3, 68);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(36, 17);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "Tipo";
            // 
            // txtNombreDato
            // 
            txtNombreDato.Location = new Point(79, 62);
            txtNombreDato.Name = "txtNombreDato";
            txtNombreDato.Size = new Size(144, 23);
            txtNombreDato.TabIndex = 1;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(0, 1);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(248, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Detalles De La Operacion";
            lblDatosUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridOperaciones
            // 
            dataGridOperaciones.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridOperaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridOperaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOperaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridOperaciones.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridOperaciones.BorderStyle = BorderStyle.None;
            dataGridOperaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridOperaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridOperaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOperaciones.Location = new Point(18, 159);
            dataGridOperaciones.MultiSelect = false;
            dataGridOperaciones.Name = "dataGridOperaciones";
            dataGridOperaciones.ReadOnly = true;
            dataGridOperaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridOperaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridOperaciones.RowHeadersVisible = false;
            dataGridOperaciones.RowTemplate.Height = 28;
            dataGridOperaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOperaciones.Size = new Size(554, 363);
            dataGridOperaciones.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblOperacionRealizadas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(63, 58);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "cod. operacion";
            textBox2.Size = new Size(97, 20);
            textBox2.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(239, 59);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Dni";
            textBox1.Size = new Size(97, 20);
            textBox1.TabIndex = 38;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Silver;
            textBox3.Location = new Point(425, 59);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Dni";
            textBox3.Size = new Size(97, 20);
            textBox3.TabIndex = 37;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 50, 50);
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.BackgroundImageLayout = ImageLayout.Stretch;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(684, 63);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(25, 23);
            iconButton1.TabIndex = 36;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 35;
            label1.Text = "codigo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(582, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(88, 23);
            dateTimePicker1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(342, 59);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 34;
            label2.Text = "Comprador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(166, 59);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 33;
            label3.Text = "Vendedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 33);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 30;
            label5.Text = "Filtrar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(533, 61);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 32;
            label4.Text = "Fecha";
            // 
            // lblOperacionRealizadas
            // 
            lblOperacionRealizadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOperacionRealizadas.AutoSize = true;
            lblOperacionRealizadas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacionRealizadas.ForeColor = SystemColors.ControlLightLight;
            lblOperacionRealizadas.ImageAlign = ContentAlignment.TopCenter;
            lblOperacionRealizadas.Location = new Point(129, 0);
            lblOperacionRealizadas.Name = "lblOperacionRealizadas";
            lblOperacionRealizadas.Size = new Size(553, 45);
            lblOperacionRealizadas.TabIndex = 0;
            lblOperacionRealizadas.Text = "Registro De Operaciones Realizadas";
            lblOperacionRealizadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconBtnDevolucion
            // 
            iconBtnDevolucion.BackColor = Color.Orange;
            iconBtnDevolucion.BackgroundImage = (Image)resources.GetObject("iconBtnDevolucion.BackgroundImage");
            iconBtnDevolucion.BackgroundImageLayout = ImageLayout.None;
            iconBtnDevolucion.Cursor = Cursors.Hand;
            iconBtnDevolucion.FlatAppearance.BorderColor = Color.Black;
            iconBtnDevolucion.FlatStyle = FlatStyle.Flat;
            iconBtnDevolucion.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnDevolucion.ForeColor = SystemColors.ControlLightLight;
            iconBtnDevolucion.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnDevolucion.IconColor = Color.White;
            iconBtnDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDevolucion.IconSize = 30;
            iconBtnDevolucion.Location = new Point(210, 98);
            iconBtnDevolucion.Name = "iconBtnDevolucion";
            iconBtnDevolucion.Size = new Size(123, 38);
            iconBtnDevolucion.TabIndex = 19;
            iconBtnDevolucion.Text = "Devoluciones";
            iconBtnDevolucion.TextAlign = ContentAlignment.MiddleRight;
            iconBtnDevolucion.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnDevolucion.UseVisualStyleBackColor = false;
            iconBtnDevolucion.Click += iconBtnDevolucion_Click;
            // 
            // iconBtnPago
            // 
            iconBtnPago.BackColor = Color.Orange;
            iconBtnPago.BackgroundImage = (Image)resources.GetObject("iconBtnPago.BackgroundImage");
            iconBtnPago.BackgroundImageLayout = ImageLayout.None;
            iconBtnPago.Cursor = Cursors.Hand;
            iconBtnPago.FlatAppearance.BorderColor = Color.Black;
            iconBtnPago.FlatStyle = FlatStyle.Flat;
            iconBtnPago.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnPago.ForeColor = SystemColors.ControlLightLight;
            iconBtnPago.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnPago.IconColor = Color.White;
            iconBtnPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnPago.IconSize = 30;
            iconBtnPago.Location = new Point(121, 97);
            iconBtnPago.Name = "iconBtnPago";
            iconBtnPago.Size = new Size(83, 38);
            iconBtnPago.TabIndex = 20;
            iconBtnPago.Text = "Pagos";
            iconBtnPago.TextAlign = ContentAlignment.MiddleRight;
            iconBtnPago.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnPago.UseVisualStyleBackColor = false;
            iconBtnPago.Click += iconBtnPago_Click;
            // 
            // iconBtnCompras
            // 
            iconBtnCompras.BackColor = Color.Orange;
            iconBtnCompras.BackgroundImage = (Image)resources.GetObject("iconBtnCompras.BackgroundImage");
            iconBtnCompras.BackgroundImageLayout = ImageLayout.None;
            iconBtnCompras.Cursor = Cursors.Hand;
            iconBtnCompras.FlatAppearance.BorderColor = Color.Black;
            iconBtnCompras.FlatStyle = FlatStyle.Flat;
            iconBtnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCompras.ForeColor = SystemColors.ControlLightLight;
            iconBtnCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCompras.IconColor = Color.White;
            iconBtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCompras.IconSize = 30;
            iconBtnCompras.Location = new Point(339, 97);
            iconBtnCompras.Name = "iconBtnCompras";
            iconBtnCompras.Size = new Size(99, 38);
            iconBtnCompras.TabIndex = 21;
            iconBtnCompras.Text = "Compras";
            iconBtnCompras.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCompras.UseVisualStyleBackColor = false;
            iconBtnCompras.Click += iconBtnCompras_Click;
            // 
            // iconBtnVenta
            // 
            iconBtnVenta.BackColor = Color.Orange;
            iconBtnVenta.BackgroundImage = (Image)resources.GetObject("iconBtnVenta.BackgroundImage");
            iconBtnVenta.BackgroundImageLayout = ImageLayout.None;
            iconBtnVenta.Cursor = Cursors.Hand;
            iconBtnVenta.FlatAppearance.BorderColor = Color.Black;
            iconBtnVenta.FlatStyle = FlatStyle.Flat;
            iconBtnVenta.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnVenta.ForeColor = SystemColors.ControlLightLight;
            iconBtnVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnVenta.IconColor = Color.White;
            iconBtnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnVenta.IconSize = 30;
            iconBtnVenta.Location = new Point(33, 97);
            iconBtnVenta.Name = "iconBtnVenta";
            iconBtnVenta.Size = new Size(82, 38);
            iconBtnVenta.TabIndex = 22;
            iconBtnVenta.Text = "Ventas";
            iconBtnVenta.TextAlign = ContentAlignment.MiddleRight;
            iconBtnVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnVenta.UseVisualStyleBackColor = false;
            iconBtnVenta.Click += iconBtnVenta_Click;
            // 
            // FrmOpRealizada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(iconBtnVenta);
            Controls.Add(iconBtnCompras);
            Controls.Add(iconBtnPago);
            Controls.Add(iconBtnDevolucion);
            Controls.Add(iconBtnAlta);
            Controls.Add(panelDatosUsuario);
            Controls.Add(dataGridOperaciones);
            Controls.Add(panel1);
            MinimumSize = new Size(838, 604);
            Name = "FrmOpRealizada";
            Text = "Operaciones ";
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOperaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnAlta;
        private FontAwesome.Sharp.IconButton IconBtnExportar;
        private Panel panelDatosUsuario;
        private Label lblFecha;
        private DateTimePicker dateTimePickerNacimientoDato;
        private Label lblPassword;
        private TextBox txtPasswordDato;
        private TextBox txtDomiciliodato;
        private FontAwesome.Sharp.IconButton iconBtnAprobado;
        private FontAwesome.Sharp.IconButton iconBtnIrregular;
        private ComboBox comboEstadoDato;
        private Label lblEstadoDato;
        private Label lblDomicilioDato;
        private Label lblEmailDato;
        private TextBox txtEmailDato;
        private Label lblTelefDato;
        private TextBox txtTelefDato;
        private Label lblDniDato;
        private TextBox txtDniDato;
        private Label lblNombreDato;
        private TextBox txtNombreDato;
        private Label lblDatosUsuario;
        private DataGridView dataGridOperaciones;
        private Panel panel1;
        private Label lblOperacionRealizadas;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconBtnDevolucion;
        private FontAwesome.Sharp.IconButton iconBtnPago;
        private FontAwesome.Sharp.IconButton iconBtnCompras;
        private FontAwesome.Sharp.IconButton iconBtnVenta;
        private Label label7;
        private TextBox textBox5;
    }
}