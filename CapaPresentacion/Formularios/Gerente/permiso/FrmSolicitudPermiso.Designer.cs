namespace CapaPresentacion.Formularios.Gerente.permiso
{
    partial class FrmSolicitudPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudPermiso));
            pEncabezado = new Panel();
            pSubtitulo = new Panel();
            label2 = new Label();
            label1 = new Label();
            pDatosEmpleado = new Panel();
            lblNombre = new Label();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtEmail = new TextBox();
            pTituloEmpleado = new Panel();
            label3 = new Label();
            txtNombre = new TextBox();
            lblApelle = new Label();
            lblTel = new Label();
            txtApellido = new TextBox();
            lblRol = new Label();
            lblDni = new Label();
            txtRol = new TextBox();
            lblCorreo = new Label();
            pDatosPermiso = new Panel();
            txtJustificacion = new TextBox();
            label14 = new Label();
            panel5 = new Panel();
            comboMotivo_permiso = new ComboBox();
            label13 = new Label();
            panel4 = new Panel();
            panelEstadoPermiso = new Panel();
            lblEstadoPermiso = new Label();
            paneltituEstado = new Panel();
            label18 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label11 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            label17 = new Label();
            panel6 = new Panel();
            dateTimeHasta = new DateTimePicker();
            lblHasta = new Label();
            dateTimePickerDesde = new DateTimePicker();
            lblDesde = new Label();
            panel8 = new Panel();
            picCerrar = new PictureBox();
            picMinPantalla = new PictureBox();
            iconbtnGuardar = new FontAwesome.Sharp.IconButton();
            iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            pEncabezado.SuspendLayout();
            pSubtitulo.SuspendLayout();
            pDatosEmpleado.SuspendLayout();
            pTituloEmpleado.SuspendLayout();
            pDatosPermiso.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panelEstadoPermiso.SuspendLayout();
            paneltituEstado.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pEncabezado
            // 
            pEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pEncabezado.BorderStyle = BorderStyle.FixedSingle;
            pEncabezado.Controls.Add(pSubtitulo);
            pEncabezado.Controls.Add(label1);
            pEncabezado.Location = new Point(41, 42);
            pEncabezado.Name = "pEncabezado";
            pEncabezado.Size = new Size(700, 66);
            pEncabezado.TabIndex = 0;
            // 
            // pSubtitulo
            // 
            pSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pSubtitulo.BackColor = Color.FromArgb(167, 210, 143);
            pSubtitulo.Controls.Add(label2);
            pSubtitulo.Location = new Point(0, 46);
            pSubtitulo.Name = "pSubtitulo";
            pSubtitulo.Size = new Size(698, 18);
            pSubtitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, -2);
            label2.Name = "label2";
            label2.Size = new Size(385, 21);
            label2.TabIndex = 1;
            label2.Text = "SOLICITUD DE PERMISO POR AUSENCIA LABORAL";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 9);
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
            pDatosEmpleado.Controls.Add(lblNombre);
            pDatosEmpleado.Controls.Add(txtTelefono);
            pDatosEmpleado.Controls.Add(txtDni);
            pDatosEmpleado.Controls.Add(txtEmail);
            pDatosEmpleado.Controls.Add(pTituloEmpleado);
            pDatosEmpleado.Controls.Add(txtNombre);
            pDatosEmpleado.Controls.Add(lblApelle);
            pDatosEmpleado.Controls.Add(lblTel);
            pDatosEmpleado.Controls.Add(txtApellido);
            pDatosEmpleado.Controls.Add(lblRol);
            pDatosEmpleado.Controls.Add(lblDni);
            pDatosEmpleado.Controls.Add(txtRol);
            pDatosEmpleado.Controls.Add(lblCorreo);
            pDatosEmpleado.Location = new Point(41, 114);
            pDatosEmpleado.Name = "pDatosEmpleado";
            pDatosEmpleado.Size = new Size(700, 123);
            pDatosEmpleado.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(-1, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 19);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre               ";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(408, 78);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(292, 19);
            txtTelefono.TabIndex = 15;
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(408, 59);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(293, 19);
            txtDni.TabIndex = 11;
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
            // pTituloEmpleado
            // 
            pTituloEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pTituloEmpleado.BackColor = Color.FromArgb(167, 210, 143);
            pTituloEmpleado.Controls.Add(label3);
            pTituloEmpleado.Location = new Point(0, 9);
            pTituloEmpleado.Name = "pTituloEmpleado";
            pTituloEmpleado.Size = new Size(698, 22);
            pTituloEmpleado.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(220, 4);
            label3.Name = "label3";
            label3.Size = new Size(238, 17);
            label3.TabIndex = 1;
            label3.Text = "DATOS DEL EMPLEADO SOLICITANTE";
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
            // lblApelle
            // 
            lblApelle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblApelle.AutoSize = true;
            lblApelle.BorderStyle = BorderStyle.FixedSingle;
            lblApelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApelle.Location = new Point(347, 40);
            lblApelle.Name = "lblApelle";
            lblApelle.Size = new Size(62, 19);
            lblApelle.TabIndex = 6;
            lblApelle.Text = "Apellido";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTel.Location = new Point(347, 78);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(64, 19);
            lblTel.TabIndex = 14;
            lblTel.Text = "Telefono";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(407, 40);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(294, 19);
            txtApellido.TabIndex = 7;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BorderStyle = BorderStyle.FixedSingle;
            lblRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRol.Location = new Point(-3, 78);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(122, 19);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol                       ";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BorderStyle = BorderStyle.FixedSingle;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(346, 59);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(66, 19);
            lblDni.TabIndex = 10;
            lblDni.Text = "DNI        ";
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
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.Location = new Point(-4, 59);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(123, 19);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo Electronico";
            // 
            // pDatosPermiso
            // 
            pDatosPermiso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pDatosPermiso.BorderStyle = BorderStyle.FixedSingle;
            pDatosPermiso.Controls.Add(txtJustificacion);
            pDatosPermiso.Controls.Add(label14);
            pDatosPermiso.Controls.Add(panel5);
            pDatosPermiso.Controls.Add(panel4);
            pDatosPermiso.Controls.Add(panel1);
            pDatosPermiso.Location = new Point(40, 240);
            pDatosPermiso.Name = "pDatosPermiso";
            pDatosPermiso.Size = new Size(700, 209);
            pDatosPermiso.TabIndex = 2;
            // 
            // txtJustificacion
            // 
            txtJustificacion.BorderStyle = BorderStyle.None;
            txtJustificacion.Location = new Point(213, 148);
            txtJustificacion.Multiline = true;
            txtJustificacion.Name = "txtJustificacion";
            txtJustificacion.Size = new Size(484, 58);
            txtJustificacion.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(350, 130);
            label14.Name = "label14";
            label14.Size = new Size(185, 15);
            label14.TabIndex = 7;
            label14.Text = "JUSTIFICACION O COMENTARIO";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel5.BackColor = Color.FromArgb(167, 210, 143);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboMotivo_permiso);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(0, 124);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 83);
            panel5.TabIndex = 6;
            // 
            // comboMotivo_permiso
            // 
            comboMotivo_permiso.FlatStyle = FlatStyle.Popup;
            comboMotivo_permiso.FormattingEnabled = true;
            comboMotivo_permiso.Location = new Point(20, 29);
            comboMotivo_permiso.Name = "comboMotivo_permiso";
            comboMotivo_permiso.Size = new Size(166, 23);
            comboMotivo_permiso.TabIndex = 7;
            comboMotivo_permiso.Text = "Seleccione el Motivo";
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
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panelEstadoPermiso);
            panel4.Controls.Add(paneltituEstado);
            panel4.Location = new Point(350, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 75);
            panel4.TabIndex = 5;
            // 
            // panelEstadoPermiso
            // 
            panelEstadoPermiso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelEstadoPermiso.BackColor = Color.FromArgb(167, 210, 143);
            panelEstadoPermiso.Controls.Add(lblEstadoPermiso);
            panelEstadoPermiso.Location = new Point(-1, 28);
            panelEstadoPermiso.Name = "panelEstadoPermiso";
            panelEstadoPermiso.Size = new Size(349, 25);
            panelEstadoPermiso.TabIndex = 9;
            panelEstadoPermiso.Visible = false;
            // 
            // lblEstadoPermiso
            // 
            lblEstadoPermiso.AutoSize = true;
            lblEstadoPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstadoPermiso.Location = new Point(135, 3);
            lblEstadoPermiso.Name = "lblEstadoPermiso";
            lblEstadoPermiso.Size = new Size(78, 21);
            lblEstadoPermiso.TabIndex = 1;
            lblEstadoPermiso.Text = "Pendiente";
            // 
            // paneltituEstado
            // 
            paneltituEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paneltituEstado.BackColor = Color.FromArgb(167, 210, 143);
            paneltituEstado.Controls.Add(label18);
            paneltituEstado.Location = new Point(0, 0);
            paneltituEstado.Name = "paneltituEstado";
            paneltituEstado.Size = new Size(349, 18);
            paneltituEstado.TabIndex = 8;
            paneltituEstado.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(125, 2);
            label18.Name = "label18";
            label18.Size = new Size(103, 15);
            label18.TabIndex = 0;
            label18.Text = "Estado del Perniso";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(167, 210, 143);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 50);
            panel1.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(235, 9);
            label10.Name = "label10";
            label10.Size = new Size(219, 17);
            label10.TabIndex = 1;
            label10.Text = "DATOS DEL PERMISO SOLICITADO";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(40, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 23);
            panel2.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(31, 5);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 4;
            label12.Text = "IMPORTANTE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(110, 6);
            label11.Name = "label11";
            label11.Size = new Size(562, 13);
            label11.TabIndex = 2;
            label11.Text = " Si el permiso es unicamente de horas en el mismo dia, asignar la misma fecha en las celdas \"desde\" y \"hasta\"";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(40, 292);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 75);
            panel3.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(167, 210, 143);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(349, 18);
            panel7.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 2);
            label17.Name = "label17";
            label17.Size = new Size(328, 15);
            label17.TabIndex = 0;
            label17.Text = "Marque Desde que Fecha Hasta que Fecha requeir el permiso";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(167, 210, 143);
            panel6.Controls.Add(dateTimeHasta);
            panel6.Controls.Add(lblHasta);
            panel6.Controls.Add(dateTimePickerDesde);
            panel6.Controls.Add(lblDesde);
            panel6.Location = new Point(1, 28);
            panel6.Name = "panel6";
            panel6.Size = new Size(349, 25);
            panel6.TabIndex = 6;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(236, 1);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(86, 23);
            dateTimeHasta.TabIndex = 8;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHasta.Location = new Point(185, 7);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(41, 15);
            lblHasta.TabIndex = 7;
            lblHasta.Text = "Hasta:";
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Format = DateTimePickerFormat.Short;
            dateTimePickerDesde.Location = new Point(71, 2);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(86, 23);
            dateTimePickerDesde.TabIndex = 6;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesde.Location = new Point(20, 8);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(45, 15);
            lblDesde.TabIndex = 5;
            lblDesde.Text = "Desde:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(207, 211, 217);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(picCerrar);
            panel8.Controls.Add(picMinPantalla);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(780, 40);
            panel8.TabIndex = 5;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            iconbtnGuardar.Location = new Point(241, 453);
            iconbtnGuardar.Name = "iconbtnGuardar";
            iconbtnGuardar.Size = new Size(112, 39);
            iconbtnGuardar.TabIndex = 26;
            iconbtnGuardar.Text = "Confirmar";
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
            iconBtnCancelar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCancelar.ForeColor = SystemColors.ControlLightLight;
            iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnCancelar.IconColor = Color.White;
            iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCancelar.IconSize = 30;
            iconBtnCancelar.Location = new Point(381, 453);
            iconBtnCancelar.Name = "iconBtnCancelar";
            iconBtnCancelar.Size = new Size(115, 39);
            iconBtnCancelar.TabIndex = 27;
            iconBtnCancelar.Text = "Cancelar";
            iconBtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCancelar.UseVisualStyleBackColor = false;
            iconBtnCancelar.Click += iconBtnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmSolicitudPermiso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            ClientSize = new Size(780, 495);
            Controls.Add(iconBtnCancelar);
            Controls.Add(iconbtnGuardar);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pDatosPermiso);
            Controls.Add(pDatosEmpleado);
            Controls.Add(pEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(780, 495);
            Name = "FrmSolicitudPermiso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSolicitudPermiso";
            Load += FrmSolicitudPermiso_Load;
            pEncabezado.ResumeLayout(false);
            pEncabezado.PerformLayout();
            pSubtitulo.ResumeLayout(false);
            pSubtitulo.PerformLayout();
            pDatosEmpleado.ResumeLayout(false);
            pDatosEmpleado.PerformLayout();
            pTituloEmpleado.ResumeLayout(false);
            pTituloEmpleado.PerformLayout();
            pDatosPermiso.ResumeLayout(false);
            pDatosPermiso.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panelEstadoPermiso.ResumeLayout(false);
            panelEstadoPermiso.PerformLayout();
            paneltituEstado.ResumeLayout(false);
            paneltituEstado.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pEncabezado;
        private Label label2;
        private Label label1;
        private Panel pDatosEmpleado;
        private Panel pDatosPermiso;
        private Panel pSubtitulo;
        private Panel pTituloEmpleado;
        private Label label3;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblCorreo;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private Label lblApelle;
        private Label lblTel;
        private TextBox txtTelefono;
        private Label lblRol;
        private TextBox txtRol;
        private Panel panel1;
        private Label label10;
        private Panel panel2;
        private Label label12;
        private Label label11;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label13;
        private ComboBox comboMotivo_permiso;
        private Label label14;
        private TextBox txtJustificacion;
        private Panel panel6;
        private Label lblDesde;
        private Label label17;
        private Panel panel7;
        private DateTimePicker dateTimeHasta;
        private Label lblHasta;
        private DateTimePicker dateTimePickerDesde;
        private Panel panel8;
        private PictureBox picMinPantalla;
        private PictureBox picCerrar;
        private FontAwesome.Sharp.IconButton iconbtnGuardar;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private Panel panelEstadoPermiso;
        private Panel paneltituEstado;
        private Label label18;
        private Label lblEstadoPermiso;
        private ErrorProvider errorProvider1;
    }
}