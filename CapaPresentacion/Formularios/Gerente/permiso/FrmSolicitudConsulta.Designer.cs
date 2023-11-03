namespace CapaPresentacion.Formularios.Gerente.permiso
{
    partial class FrmSolicitudConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudConsulta));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel8 = new Panel();
            picCerrar = new PictureBox();
            picMinPantalla = new PictureBox();
            pEncabezado = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pDatosEmpleado = new Panel();
            txtTel = new TextBox();
            txtDni = new TextBox();
            pTituloEmpleado = new Panel();
            label5 = new Label();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtRol = new TextBox();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            pDatosConsulta = new Panel();
            label14 = new Label();
            txtComentarioConsulta = new TextBox();
            panel5 = new Panel();
            comboMotivo_consulta = new ComboBox();
            label13 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panelConsulAnteriores = new Panel();
            dataGridConsultas = new DataGridView();
            Col_id_motivo_consulta = new DataGridViewTextBoxColumn();
            Col_motivo_consulta = new DataGridViewTextBoxColumn();
            Col_id_consulta = new DataGridViewTextBoxColumn();
            Col_comentario_consulta = new DataGridViewTextBoxColumn();
            Col_estado_consulta = new DataGridViewTextBoxColumn();
            Col_fecha_consulta = new DataGridViewTextBoxColumn();
            Col_id_usuario = new DataGridViewTextBoxColumn();
            plTituloConsulAntes = new Panel();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).BeginInit();
            pEncabezado.SuspendLayout();
            panel1.SuspendLayout();
            pDatosEmpleado.SuspendLayout();
            pTituloEmpleado.SuspendLayout();
            pDatosConsulta.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panelConsulAnteriores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).BeginInit();
            plTituloConsulAntes.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(207, 211, 217);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(780, 40);
            panel8.TabIndex = 6;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.BackColor = Color.FromArgb(207, 211, 217);
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(743, 3);
            picCerrar.Margin = new Padding(4, 3, 4, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(28, 24);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 3;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinPantalla
            // 
            picMinPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinPantalla.BackColor = Color.FromArgb(207, 211, 217);
            picMinPantalla.Cursor = Cursors.Hand;
            picMinPantalla.Image = (Image)resources.GetObject("picMinPantalla.Image");
            picMinPantalla.Location = new Point(708, 7);
            picMinPantalla.Margin = new Padding(4, 3, 4, 3);
            picMinPantalla.Name = "picMinPantalla";
            picMinPantalla.Size = new Size(27, 24);
            picMinPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMinPantalla.TabIndex = 2;
            picMinPantalla.TabStop = false;
            picMinPantalla.Click += picMinPantalla_Click;
            // 
            // pEncabezado
            // 
            pEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pEncabezado.BorderStyle = BorderStyle.FixedSingle;
            pEncabezado.Controls.Add(panel1);
            pEncabezado.Controls.Add(label1);
            pEncabezado.Location = new Point(41, 47);
            pEncabezado.Name = "pEncabezado";
            pEncabezado.Size = new Size(700, 66);
            pEncabezado.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(144, 178, 246);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 18);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(190, -4);
            label3.Name = "label3";
            label3.Size = new Size(347, 21);
            label3.TabIndex = 1;
            label3.Text = "CONSULTA O MENSAJE AL ADMINISTRADOR";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE DE LA EMPRESA";
            // 
            // pDatosEmpleado
            // 
            pDatosEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pDatosEmpleado.BackColor = Color.FromArgb(254, 254, 254);
            pDatosEmpleado.BorderStyle = BorderStyle.FixedSingle;
            pDatosEmpleado.Controls.Add(txtTel);
            pDatosEmpleado.Controls.Add(txtDni);
            pDatosEmpleado.Controls.Add(pTituloEmpleado);
            pDatosEmpleado.Controls.Add(txtEmail);
            pDatosEmpleado.Controls.Add(txtApellido);
            pDatosEmpleado.Controls.Add(label8);
            pDatosEmpleado.Controls.Add(label7);
            pDatosEmpleado.Controls.Add(txtNombre);
            pDatosEmpleado.Controls.Add(label6);
            pDatosEmpleado.Controls.Add(label4);
            pDatosEmpleado.Controls.Add(label10);
            pDatosEmpleado.Controls.Add(label9);
            pDatosEmpleado.Controls.Add(txtRol);
            pDatosEmpleado.Location = new Point(41, 119);
            pDatosEmpleado.Name = "pDatosEmpleado";
            pDatosEmpleado.Size = new Size(700, 123);
            pDatosEmpleado.TabIndex = 8;
            // 
            // txtTel
            // 
            txtTel.BorderStyle = BorderStyle.FixedSingle;
            txtTel.Location = new Point(408, 59);
            txtTel.Multiline = true;
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(299, 19);
            txtTel.TabIndex = 11;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(408, 78);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(291, 19);
            txtDni.TabIndex = 15;
            // 
            // pTituloEmpleado
            // 
            pTituloEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pTituloEmpleado.BackColor = Color.FromArgb(144, 178, 246);
            pTituloEmpleado.Controls.Add(label5);
            pTituloEmpleado.Location = new Point(0, 9);
            pTituloEmpleado.Name = "pTituloEmpleado";
            pTituloEmpleado.Size = new Size(698, 22);
            pTituloEmpleado.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(305, 2);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 1;
            label5.Text = "MIS DATOS";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(119, 59);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 19);
            txtEmail.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(408, 40);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(291, 19);
            txtApellido.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(346, 59);
            label8.Name = "label8";
            label8.Size = new Size(64, 19);
            label8.TabIndex = 14;
            label8.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(347, 78);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 10;
            label7.Text = "DNI        ";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(119, 40);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 19);
            txtNombre.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(347, 40);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 6;
            label6.Text = "Apellido";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-1, 40);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 3;
            label4.Text = "Nombre               ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(-4, 59);
            label10.Name = "label10";
            label10.Size = new Size(123, 19);
            label10.TabIndex = 8;
            label10.Text = "Correo Electronico";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(-3, 78);
            label9.Name = "label9";
            label9.Size = new Size(122, 19);
            label9.TabIndex = 12;
            label9.Text = "Rol                       ";
            // 
            // txtRol
            // 
            txtRol.BorderStyle = BorderStyle.FixedSingle;
            txtRol.Location = new Point(119, 78);
            txtRol.Multiline = true;
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(229, 19);
            txtRol.TabIndex = 13;
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
            iconBtnCancelar.Location = new Point(388, 494);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(115, 39);
            iconBtnCancelar.TabIndex = 32;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
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
            iconbtnGuardar.Location = new Point(232, 495);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(112, 39);
            iconbtnGuardar.TabIndex = 31;
            iconbtnGuardar.Text = "Confirmar";
            iconbtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            iconbtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnGuardar.UseVisualStyleBackColor = false;
            iconbtnGuardar.Click += iconbtnGuardar_Click;
            // 
            // pDatosConsulta
            // 
            pDatosConsulta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pDatosConsulta.BackColor = Color.White;
            pDatosConsulta.BorderStyle = BorderStyle.FixedSingle;
            pDatosConsulta.Controls.Add(label14);
            pDatosConsulta.Controls.Add(txtComentarioConsulta);
            pDatosConsulta.Controls.Add(panel5);
            pDatosConsulta.Location = new Point(40, 247);
            pDatosConsulta.Name = "pDatosConsulta";
            pDatosConsulta.Size = new Size(700, 107);
            pDatosConsulta.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(379, 38);
            label14.Name = "label14";
            label14.Size = new Size(159, 15);
            label14.TabIndex = 10;
            label14.Text = "CONSULTA O COMENTARIO";
            // 
            // txtComentarioConsulta
            // 
            txtComentarioConsulta.BorderStyle = BorderStyle.None;
            txtComentarioConsulta.Location = new Point(208, 50);
            txtComentarioConsulta.Multiline = true;
            txtComentarioConsulta.Name = "txtComentarioConsulta";
            txtComentarioConsulta.Size = new Size(491, 51);
            txtComentarioConsulta.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel5.BackColor = Color.FromArgb(144, 178, 246);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboMotivo_consulta);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(0, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 71);
            panel5.TabIndex = 7;
            // 
            // comboMotivo_consulta
            // 
            comboMotivo_consulta.FlatStyle = FlatStyle.Popup;
            comboMotivo_consulta.FormattingEnabled = true;
            comboMotivo_consulta.Location = new Point(20, 29);
            comboMotivo_consulta.Name = "comboMotivo_consulta";
            comboMotivo_consulta.Size = new Size(166, 23);
            comboMotivo_consulta.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(20, 11);
            label13.Name = "label13";
            label13.Size = new Size(137, 15);
            label13.TabIndex = 5;
            label13.Text = "MOTIVO DEL PERMISO:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(144, 178, 246);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(40, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 23);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 2);
            label2.Name = "label2";
            label2.Size = new Size(169, 17);
            label2.TabIndex = 1;
            label2.Text = "DATOS DEL LA CONSULTA";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(40, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 12);
            panel2.TabIndex = 5;
            // 
            // panelConsulAnteriores
            // 
            panelConsulAnteriores.BorderStyle = BorderStyle.FixedSingle;
            panelConsulAnteriores.Controls.Add(dataGridConsultas);
            panelConsulAnteriores.Location = new Point(40, 354);
            panelConsulAnteriores.Name = "panelConsulAnteriores";
            panelConsulAnteriores.Size = new Size(700, 134);
            panelConsulAnteriores.TabIndex = 34;
            panelConsulAnteriores.Visible = false;
            // 
            // dataGridConsultas
            // 
            dataGridConsultas.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridConsultas.BackgroundColor = Color.FromArgb(144, 178, 246);
            dataGridConsultas.BorderStyle = BorderStyle.None;
            dataGridConsultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsultas.Columns.AddRange(new DataGridViewColumn[] { Col_id_motivo_consulta, Col_motivo_consulta, Col_id_consulta, Col_comentario_consulta, Col_estado_consulta, Col_fecha_consulta, Col_id_usuario });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridConsultas.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridConsultas.Location = new Point(-2, 17);
            dataGridConsultas.MultiSelect = false;
            dataGridConsultas.Name = "dataGridConsultas";
            dataGridConsultas.ReadOnly = true;
            dataGridConsultas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridConsultas.RowHeadersVisible = false;
            dataGridConsultas.RowTemplate.Height = 28;
            dataGridConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridConsultas.Size = new Size(702, 116);
            dataGridConsultas.TabIndex = 35;
            // 
            // Col_id_motivo_consulta
            // 
            Col_id_motivo_consulta.HeaderText = "id_motivo_consulta";
            Col_id_motivo_consulta.Name = "Col_id_motivo_consulta";
            Col_id_motivo_consulta.ReadOnly = true;
            Col_id_motivo_consulta.Visible = false;
            Col_id_motivo_consulta.Width = 129;
            // 
            // Col_motivo_consulta
            // 
            Col_motivo_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_motivo_consulta.HeaderText = "Motivo Consulta";
            Col_motivo_consulta.Name = "Col_motivo_consulta";
            Col_motivo_consulta.ReadOnly = true;
            Col_motivo_consulta.Width = 150;
            // 
            // Col_id_consulta
            // 
            Col_id_consulta.HeaderText = "id_consulta";
            Col_id_consulta.Name = "Col_id_consulta";
            Col_id_consulta.ReadOnly = true;
            Col_id_consulta.Visible = false;
            Col_id_consulta.Width = 102;
            // 
            // Col_comentario_consulta
            // 
            Col_comentario_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_comentario_consulta.HeaderText = "Comentario Consulta";
            Col_comentario_consulta.Name = "Col_comentario_consulta";
            Col_comentario_consulta.ReadOnly = true;
            Col_comentario_consulta.Width = 290;
            // 
            // Col_estado_consulta
            // 
            Col_estado_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_estado_consulta.HeaderText = "Estado Consulta";
            Col_estado_consulta.Name = "Col_estado_consulta";
            Col_estado_consulta.ReadOnly = true;
            Col_estado_consulta.Width = 130;
            // 
            // Col_fecha_consulta
            // 
            Col_fecha_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_fecha_consulta.HeaderText = "Fecha Consulta";
            Col_fecha_consulta.Name = "Col_fecha_consulta";
            Col_fecha_consulta.ReadOnly = true;
            Col_fecha_consulta.Width = 130;
            // 
            // Col_id_usuario
            // 
            Col_id_usuario.HeaderText = "id_usuario";
            Col_id_usuario.Name = "Col_id_usuario";
            Col_id_usuario.ReadOnly = true;
            Col_id_usuario.Visible = false;
            Col_id_usuario.Width = 95;
            // 
            // plTituloConsulAntes
            // 
            plTituloConsulAntes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            plTituloConsulAntes.BackColor = Color.White;
            plTituloConsulAntes.BorderStyle = BorderStyle.FixedSingle;
            plTituloConsulAntes.Controls.Add(label11);
            plTituloConsulAntes.Location = new Point(40, 355);
            plTituloConsulAntes.Name = "plTituloConsulAntes";
            plTituloConsulAntes.Size = new Size(700, 17);
            plTituloConsulAntes.TabIndex = 34;
            plTituloConsulAntes.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(270, 1);
            label11.Name = "label11";
            label11.Size = new Size(149, 15);
            label11.TabIndex = 34;
            label11.Text = "CONSULTAS ANTERIORES";
            // 
            // FrmSolicitudConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 542);
            Controls.Add(plTituloConsulAntes);
            Controls.Add(panelConsulAnteriores);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(iconBtnCancelar);
            Controls.Add(iconbtnGuardar);
            Controls.Add(pDatosConsulta);
            Controls.Add(pDatosEmpleado);
            Controls.Add(pEncabezado);
            Controls.Add(picMinPantalla);
            Controls.Add(picCerrar);
            Controls.Add(panel8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSolicitudConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSolicitudConsulta";
            Load += FrmSolicitudConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).EndInit();
            pEncabezado.ResumeLayout(false);
            pEncabezado.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pDatosEmpleado.ResumeLayout(false);
            pDatosEmpleado.PerformLayout();
            pTituloEmpleado.ResumeLayout(false);
            pTituloEmpleado.PerformLayout();
            pDatosConsulta.ResumeLayout(false);
            pDatosConsulta.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelConsulAnteriores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).EndInit();
            plTituloConsulAntes.ResumeLayout(false);
            plTituloConsulAntes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private PictureBox picCerrar;
        private PictureBox picMinPantalla;
        private Panel pEncabezado;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel pDatosEmpleado;
        private Label label4;
        private TextBox txtDni;
        private TextBox txtTel;
        private TextBox txtEmail;
        private Panel pTituloEmpleado;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
        private Label label8;
        private TextBox txtApellido;
        private Label label9;
        private Label label7;
        private TextBox txtRol;
        private Label label10;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private Panel pDatosConsulta;
        private Panel panel3;
        private Label label2;
        private Panel panel5;
        private ComboBox comboMotivo_consulta;
        private Label label13;
        private Panel panel2;
        private TextBox txtComentarioConsulta;
        private Label label14;
        private DataGridView datagridConsultas;
        private Panel panelConsulAnteriores;
        private Panel plTituloConsulAntes;
        private Label label11;
        private DataGridViewTextBoxColumn Col_Id_consulta;
        private DataGridView dataGridConsultas;
        private DataGridViewTextBoxColumn Col_id_motivo_consulta;
        private DataGridViewTextBoxColumn Col_motivo_consulta;
        private DataGridViewTextBoxColumn Col_id_consulta;
        private DataGridViewTextBoxColumn Col_comentario_consulta;
        private DataGridViewTextBoxColumn Col_estado_consulta;
        private DataGridViewTextBoxColumn Col_fecha_consulta;
        private DataGridViewTextBoxColumn Col_id_usuario;
    }
}