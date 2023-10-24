namespace CapaPresentacion.Formularios.Admin.usuario
{
    partial class FrmPermisoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisoUsuario));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            iconbtnClean = new FontAwesome.Sharp.IconButton();
            txtEmpleado = new TextBox();
            txtTipo = new TextBox();
            textBox2 = new TextBox();
            lblFecha = new Label();
            lblTipo = new Label();
            lblEmpleado = new Label();
            lblFiltrar = new Label();
            lblPermisoUsu = new Label();
            panel2 = new Panel();
            txtIdPermiso = new TextBox();
            txtJustificacion = new TextBox();
            txtIdEmpleado = new TextBox();
            lblIdEmpleado = new Label();
            lblJustificaion = new Label();
            txtDiasSolciitados = new TextBox();
            lblDomidato = new Label();
            txtRolDato = new TextBox();
            txtDniEmple = new TextBox();
            lblRoldato = new Label();
            lblDiasSolicitados = new Label();
            iconBtnRechaPermiso = new FontAwesome.Sharp.IconButton();
            iconBtnAprobarPermiso = new FontAwesome.Sharp.IconButton();
            txtDomiDato = new TextBox();
            cboTipoPermiso = new ComboBox();
            lblTipoPermi = new Label();
            lblEmailDato = new Label();
            txtEmailDato = new TextBox();
            lblTelefDato = new Label();
            txtTelefDato = new TextBox();
            lblDniEmple = new Label();
            txtApeEmple = new TextBox();
            lblApeEmple = new Label();
            lblNombreEmple = new Label();
            txtNombreEmple = new TextBox();
            label11 = new Label();
            dataGridPermisos = new DataGridView();
            Col_id_permiso = new DataGridViewTextBoxColumn();
            Col_fecha_inicio = new DataGridViewTextBoxColumn();
            Col_fecha_finalizacion = new DataGridViewTextBoxColumn();
            Col_estado_aprobacion = new DataGridViewTextBoxColumn();
            Col_nombre_rol = new DataGridViewTextBoxColumn();
            col_id_persona = new DataGridViewTextBoxColumn();
            Col_Dni_Usuario = new DataGridViewTextBoxColumn();
            Col_Nombre_Usuario = new DataGridViewTextBoxColumn();
            Col_Apellido_Usuario = new DataGridViewTextBoxColumn();
            Col_id_domicilio = new DataGridViewTextBoxColumn();
            Col_estado_permiso = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPermisos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(iconbtnClean);
            panel1.Controls.Add(txtEmpleado);
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(lblEmpleado);
            panel1.Controls.Add(lblFiltrar);
            panel1.Controls.Add(lblPermisoUsu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 92);
            panel1.TabIndex = 1;
            // 
            // iconbtnClean
            // 
            iconbtnClean.BackColor = Color.FromArgb(255, 50, 50);
            iconbtnClean.BackgroundImage = (Image)resources.GetObject("iconbtnClean.BackgroundImage");
            iconbtnClean.BackgroundImageLayout = ImageLayout.Stretch;
            iconbtnClean.Cursor = Cursors.Hand;
            iconbtnClean.FlatAppearance.BorderColor = Color.Black;
            iconbtnClean.FlatStyle = FlatStyle.Flat;
            iconbtnClean.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconbtnClean.ForeColor = SystemColors.ControlLightLight;
            iconbtnClean.IconChar = FontAwesome.Sharp.IconChar.None;
            iconbtnClean.IconColor = Color.White;
            iconbtnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnClean.IconSize = 30;
            iconbtnClean.Location = new Point(697, 62);
            iconbtnClean.Name = "iconbtnClean";
            iconbtnClean.Size = new Size(25, 19);
            iconbtnClean.TabIndex = 17;
            iconbtnClean.TextAlign = ContentAlignment.MiddleRight;
            iconbtnClean.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnClean.UseVisualStyleBackColor = false;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpleado.ForeColor = Color.Silver;
            txtEmpleado.Location = new Point(246, 58);
            txtEmpleado.Multiline = true;
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(97, 20);
            txtEmpleado.TabIndex = 11;
            txtEmpleado.Text = "Empleado";
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.ForeColor = Color.Silver;
            txtTipo.Location = new Point(405, 61);
            txtTipo.Multiline = true;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(102, 20);
            txtTipo.TabIndex = 10;
            txtTipo.Text = "Tipo de Permiso";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(582, 61);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 20);
            textBox2.TabIndex = 9;
            textBox2.Text = "Fecha";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(533, 62);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 17);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = SystemColors.ControlLightLight;
            lblTipo.Location = new Point(363, 61);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 17);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpleado.ForeColor = SystemColors.ControlLightLight;
            lblEmpleado.Location = new Point(171, 59);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(69, 17);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado";
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
            // lblPermisoUsu
            // 
            lblPermisoUsu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPermisoUsu.AutoSize = true;
            lblPermisoUsu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermisoUsu.ForeColor = SystemColors.ControlLightLight;
            lblPermisoUsu.ImageAlign = ContentAlignment.TopCenter;
            lblPermisoUsu.Location = new Point(139, 0);
            lblPermisoUsu.Name = "lblPermisoUsu";
            lblPermisoUsu.Size = new Size(529, 45);
            lblPermisoUsu.TabIndex = 0;
            lblPermisoUsu.Text = "Lista De Permisos De Los Usuarios";
            lblPermisoUsu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtIdPermiso);
            panel2.Controls.Add(txtJustificacion);
            panel2.Controls.Add(txtIdEmpleado);
            panel2.Controls.Add(lblIdEmpleado);
            panel2.Controls.Add(lblJustificaion);
            panel2.Controls.Add(txtDiasSolciitados);
            panel2.Controls.Add(lblDomidato);
            panel2.Controls.Add(txtRolDato);
            panel2.Controls.Add(txtDniEmple);
            panel2.Controls.Add(lblRoldato);
            panel2.Controls.Add(lblDiasSolicitados);
            panel2.Controls.Add(iconBtnRechaPermiso);
            panel2.Controls.Add(iconBtnAprobarPermiso);
            panel2.Controls.Add(txtDomiDato);
            panel2.Controls.Add(cboTipoPermiso);
            panel2.Controls.Add(lblTipoPermi);
            panel2.Controls.Add(lblEmailDato);
            panel2.Controls.Add(txtEmailDato);
            panel2.Controls.Add(lblTelefDato);
            panel2.Controls.Add(txtTelefDato);
            panel2.Controls.Add(lblDniEmple);
            panel2.Controls.Add(txtApeEmple);
            panel2.Controls.Add(lblApeEmple);
            panel2.Controls.Add(lblNombreEmple);
            panel2.Controls.Add(txtNombreEmple);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(572, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 478);
            panel2.TabIndex = 17;
            // 
            // txtIdPermiso
            // 
            txtIdPermiso.BackColor = SystemColors.Window;
            txtIdPermiso.Location = new Point(7, 11);
            txtIdPermiso.Name = "txtIdPermiso";
            txtIdPermiso.Size = new Size(26, 23);
            txtIdPermiso.TabIndex = 108;
            txtIdPermiso.Visible = false;
            // 
            // txtJustificacion
            // 
            txtJustificacion.BackColor = SystemColors.Window;
            txtJustificacion.Location = new Point(19, 394);
            txtJustificacion.Multiline = true;
            txtJustificacion.Name = "txtJustificacion";
            txtJustificacion.ReadOnly = true;
            txtJustificacion.Size = new Size(203, 83);
            txtJustificacion.TabIndex = 107;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.BackColor = SystemColors.Window;
            txtIdEmpleado.Location = new Point(81, 35);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(144, 23);
            txtIdEmpleado.TabIndex = 106;
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdEmpleado.ForeColor = SystemColors.WindowText;
            lblIdEmpleado.Location = new Point(0, 41);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(85, 17);
            lblIdEmpleado.TabIndex = 105;
            lblIdEmpleado.Text = "Id Empleado";
            // 
            // lblJustificaion
            // 
            lblJustificaion.AutoSize = true;
            lblJustificaion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblJustificaion.ForeColor = SystemColors.WindowText;
            lblJustificaion.Location = new Point(7, 374);
            lblJustificaion.Name = "lblJustificaion";
            lblJustificaion.Size = new Size(85, 17);
            lblJustificaion.TabIndex = 103;
            lblJustificaion.Text = "Justificacion";
            // 
            // txtDiasSolciitados
            // 
            txtDiasSolciitados.BackColor = SystemColors.Window;
            txtDiasSolciitados.Location = new Point(78, 348);
            txtDiasSolciitados.Name = "txtDiasSolciitados";
            txtDiasSolciitados.ReadOnly = true;
            txtDiasSolciitados.Size = new Size(144, 23);
            txtDiasSolciitados.TabIndex = 102;
            // 
            // lblDomidato
            // 
            lblDomidato.AutoSize = true;
            lblDomidato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomidato.ForeColor = SystemColors.WindowText;
            lblDomidato.Location = new Point(0, 255);
            lblDomidato.Name = "lblDomidato";
            lblDomidato.Size = new Size(68, 17);
            lblDomidato.TabIndex = 101;
            lblDomidato.Text = "Domicilio";
            // 
            // txtRolDato
            // 
            txtRolDato.BackColor = SystemColors.Window;
            txtRolDato.Location = new Point(81, 220);
            txtRolDato.Name = "txtRolDato";
            txtRolDato.ReadOnly = true;
            txtRolDato.Size = new Size(144, 23);
            txtRolDato.TabIndex = 100;
            // 
            // txtDniEmple
            // 
            txtDniEmple.BackColor = SystemColors.Window;
            txtDniEmple.Location = new Point(81, 64);
            txtDniEmple.Name = "txtDniEmple";
            txtDniEmple.Size = new Size(144, 23);
            txtDniEmple.TabIndex = 99;
            // 
            // lblRoldato
            // 
            lblRoldato.AutoSize = true;
            lblRoldato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoldato.ForeColor = SystemColors.WindowText;
            lblRoldato.Location = new Point(0, 225);
            lblRoldato.Name = "lblRoldato";
            lblRoldato.Size = new Size(28, 17);
            lblRoldato.TabIndex = 86;
            lblRoldato.Text = "Rol";
            // 
            // lblDiasSolicitados
            // 
            lblDiasSolicitados.AutoSize = true;
            lblDiasSolicitados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiasSolicitados.ForeColor = SystemColors.WindowText;
            lblDiasSolicitados.Location = new Point(2, 328);
            lblDiasSolicitados.Name = "lblDiasSolicitados";
            lblDiasSolicitados.Size = new Size(106, 17);
            lblDiasSolicitados.TabIndex = 96;
            lblDiasSolicitados.Text = "Dias Solicitados";
            // 
            // iconBtnRechaPermiso
            // 
            iconBtnRechaPermiso.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnRechaPermiso.Cursor = Cursors.Hand;
            iconBtnRechaPermiso.FlatAppearance.BorderColor = Color.Black;
            iconBtnRechaPermiso.FlatStyle = FlatStyle.Flat;
            iconBtnRechaPermiso.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnRechaPermiso.ForeColor = SystemColors.ControlLightLight;
            iconBtnRechaPermiso.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconBtnRechaPermiso.IconColor = Color.White;
            iconBtnRechaPermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnRechaPermiso.IconSize = 30;
            iconBtnRechaPermiso.Location = new Point(115, 483);
            iconBtnRechaPermiso.Name = "iconBtnRechaPermiso";
            iconBtnRechaPermiso.Size = new Size(101, 39);
            iconBtnRechaPermiso.TabIndex = 85;
            iconBtnRechaPermiso.Text = "Rechazar";
            iconBtnRechaPermiso.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRechaPermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRechaPermiso.UseVisualStyleBackColor = false;
            iconBtnRechaPermiso.Click += iconBtnRechaPermiso_Click;
            // 
            // iconBtnAprobarPermiso
            // 
            iconBtnAprobarPermiso.BackColor = Color.FromArgb(19, 173, 39);
            iconBtnAprobarPermiso.Cursor = Cursors.Hand;
            iconBtnAprobarPermiso.FlatAppearance.BorderColor = Color.Black;
            iconBtnAprobarPermiso.FlatStyle = FlatStyle.Flat;
            iconBtnAprobarPermiso.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnAprobarPermiso.ForeColor = SystemColors.ControlLightLight;
            iconBtnAprobarPermiso.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconBtnAprobarPermiso.IconColor = Color.White;
            iconBtnAprobarPermiso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAprobarPermiso.IconSize = 30;
            iconBtnAprobarPermiso.Location = new Point(19, 483);
            iconBtnAprobarPermiso.Name = "iconBtnAprobarPermiso";
            iconBtnAprobarPermiso.Size = new Size(89, 39);
            iconBtnAprobarPermiso.TabIndex = 79;
            iconBtnAprobarPermiso.Text = "Aprobar";
            iconBtnAprobarPermiso.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAprobarPermiso.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAprobarPermiso.UseVisualStyleBackColor = false;
            iconBtnAprobarPermiso.Click += iconBtnAprobarPermiso_Click;
            // 
            // txtDomiDato
            // 
            txtDomiDato.BackColor = SystemColors.Window;
            txtDomiDato.Location = new Point(81, 249);
            txtDomiDato.Name = "txtDomiDato";
            txtDomiDato.ReadOnly = true;
            txtDomiDato.Size = new Size(144, 23);
            txtDomiDato.TabIndex = 93;
            // 
            // cboTipoPermiso
            // 
            cboTipoPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPermiso.FormattingEnabled = true;
            cboTipoPermiso.Location = new Point(81, 300);
            cboTipoPermiso.Name = "cboTipoPermiso";
            cboTipoPermiso.Size = new Size(144, 23);
            cboTipoPermiso.TabIndex = 92;
            // 
            // lblTipoPermi
            // 
            lblTipoPermi.AutoSize = true;
            lblTipoPermi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoPermi.ForeColor = SystemColors.WindowText;
            lblTipoPermi.Location = new Point(0, 280);
            lblTipoPermi.Name = "lblTipoPermi";
            lblTipoPermi.Size = new Size(176, 17);
            lblTipoPermi.TabIndex = 91;
            lblTipoPermi.Text = "Tipo De Permiso Solicitado";
            // 
            // lblEmailDato
            // 
            lblEmailDato.AutoSize = true;
            lblEmailDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailDato.ForeColor = SystemColors.WindowText;
            lblEmailDato.Location = new Point(0, 161);
            lblEmailDato.Name = "lblEmailDato";
            lblEmailDato.Size = new Size(42, 17);
            lblEmailDato.TabIndex = 88;
            lblEmailDato.Text = "Email";
            // 
            // txtEmailDato
            // 
            txtEmailDato.BackColor = SystemColors.Window;
            txtEmailDato.Location = new Point(81, 155);
            txtEmailDato.Name = "txtEmailDato";
            txtEmailDato.Size = new Size(144, 23);
            txtEmailDato.TabIndex = 87;
            // 
            // lblTelefDato
            // 
            lblTelefDato.AutoSize = true;
            lblTelefDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefDato.ForeColor = SystemColors.WindowText;
            lblTelefDato.Location = new Point(0, 191);
            lblTelefDato.Name = "lblTelefDato";
            lblTelefDato.Size = new Size(62, 17);
            lblTelefDato.TabIndex = 84;
            lblTelefDato.Text = "Telefono";
            // 
            // txtTelefDato
            // 
            txtTelefDato.BackColor = SystemColors.Window;
            txtTelefDato.Location = new Point(81, 185);
            txtTelefDato.Name = "txtTelefDato";
            txtTelefDato.Size = new Size(144, 23);
            txtTelefDato.TabIndex = 83;
            // 
            // lblDniEmple
            // 
            lblDniEmple.AutoSize = true;
            lblDniEmple.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniEmple.ForeColor = SystemColors.WindowText;
            lblDniEmple.Location = new Point(0, 70);
            lblDniEmple.Name = "lblDniEmple";
            lblDniEmple.Size = new Size(74, 17);
            lblDniEmple.TabIndex = 82;
            lblDniEmple.Text = "DNI Emple";
            // 
            // txtApeEmple
            // 
            txtApeEmple.BackColor = SystemColors.Window;
            txtApeEmple.Location = new Point(81, 126);
            txtApeEmple.Name = "txtApeEmple";
            txtApeEmple.Size = new Size(144, 23);
            txtApeEmple.TabIndex = 80;
            // 
            // lblApeEmple
            // 
            lblApeEmple.AutoSize = true;
            lblApeEmple.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApeEmple.ForeColor = SystemColors.WindowText;
            lblApeEmple.Location = new Point(0, 132);
            lblApeEmple.Name = "lblApeEmple";
            lblApeEmple.Size = new Size(60, 17);
            lblApeEmple.TabIndex = 78;
            lblApeEmple.Text = "Apellido";
            // 
            // lblNombreEmple
            // 
            lblNombreEmple.AutoSize = true;
            lblNombreEmple.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreEmple.ForeColor = SystemColors.WindowText;
            lblNombreEmple.Location = new Point(0, 103);
            lblNombreEmple.Name = "lblNombreEmple";
            lblNombreEmple.Size = new Size(58, 17);
            lblNombreEmple.TabIndex = 77;
            lblNombreEmple.Text = "Nombre";
            // 
            // txtNombreEmple
            // 
            txtNombreEmple.BackColor = SystemColors.Window;
            txtNombreEmple.Location = new Point(81, 97);
            txtNombreEmple.Name = "txtNombreEmple";
            txtNombreEmple.Size = new Size(144, 23);
            txtNombreEmple.TabIndex = 76;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(32, 4);
            label11.Name = "label11";
            label11.Size = new Size(183, 30);
            label11.TabIndex = 0;
            label11.Text = "Datos Del Permiso";
            // 
            // dataGridPermisos
            // 
            dataGridPermisos.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridPermisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridPermisos.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridPermisos.BorderStyle = BorderStyle.None;
            dataGridPermisos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPermisos.Columns.AddRange(new DataGridViewColumn[] { Col_id_permiso, Col_fecha_inicio, Col_fecha_finalizacion, Col_estado_aprobacion, Col_nombre_rol, col_id_persona, Col_Dni_Usuario, Col_Nombre_Usuario, Col_Apellido_Usuario, Col_id_domicilio, Col_estado_permiso });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridPermisos.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridPermisos.Location = new Point(11, 116);
            dataGridPermisos.MultiSelect = false;
            dataGridPermisos.Name = "dataGridPermisos";
            dataGridPermisos.ReadOnly = true;
            dataGridPermisos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridPermisos.RowHeadersVisible = false;
            dataGridPermisos.RowTemplate.Height = 28;
            dataGridPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPermisos.Size = new Size(555, 427);
            dataGridPermisos.TabIndex = 18;
            dataGridPermisos.CellContentClick += dataGridPermisos_CellContentClick;
            // 
            // Col_id_permiso
            // 
            Col_id_permiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Col_id_permiso.HeaderText = "id_permiso";
            Col_id_permiso.Name = "Col_id_permiso";
            Col_id_permiso.ReadOnly = true;
            Col_id_permiso.Visible = false;
            // 
            // Col_fecha_inicio
            // 
            Col_fecha_inicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_fecha_inicio.HeaderText = "Fecha Inicio";
            Col_fecha_inicio.Name = "Col_fecha_inicio";
            Col_fecha_inicio.ReadOnly = true;
            Col_fecha_inicio.Width = 80;
            // 
            // Col_fecha_finalizacion
            // 
            Col_fecha_finalizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_fecha_finalizacion.HeaderText = "Fecha Finalizacion";
            Col_fecha_finalizacion.Name = "Col_fecha_finalizacion";
            Col_fecha_finalizacion.ReadOnly = true;
            Col_fecha_finalizacion.Width = 90;
            // 
            // Col_estado_aprobacion
            // 
            Col_estado_aprobacion.HeaderText = "Estado Aprobacion";
            Col_estado_aprobacion.Name = "Col_estado_aprobacion";
            Col_estado_aprobacion.ReadOnly = true;
            Col_estado_aprobacion.Width = 136;
            // 
            // Col_nombre_rol
            // 
            Col_nombre_rol.HeaderText = "Rol";
            Col_nombre_rol.Name = "Col_nombre_rol";
            Col_nombre_rol.ReadOnly = true;
            Col_nombre_rol.Width = 54;
            // 
            // col_id_persona
            // 
            col_id_persona.HeaderText = "id_persona";
            col_id_persona.Name = "col_id_persona";
            col_id_persona.ReadOnly = true;
            col_id_persona.Visible = false;
            col_id_persona.Width = 101;
            // 
            // Col_Dni_Usuario
            // 
            Col_Dni_Usuario.HeaderText = "DNI";
            Col_Dni_Usuario.Name = "Col_Dni_Usuario";
            Col_Dni_Usuario.ReadOnly = true;
            Col_Dni_Usuario.Width = 57;
            // 
            // Col_Nombre_Usuario
            // 
            Col_Nombre_Usuario.HeaderText = "Nombre";
            Col_Nombre_Usuario.Name = "Col_Nombre_Usuario";
            Col_Nombre_Usuario.ReadOnly = true;
            Col_Nombre_Usuario.Width = 84;
            // 
            // Col_Apellido_Usuario
            // 
            Col_Apellido_Usuario.HeaderText = "Apellido";
            Col_Apellido_Usuario.Name = "Col_Apellido_Usuario";
            Col_Apellido_Usuario.ReadOnly = true;
            Col_Apellido_Usuario.Width = 86;
            // 
            // Col_id_domicilio
            // 
            Col_id_domicilio.HeaderText = "Id_domicilio";
            Col_id_domicilio.Name = "Col_id_domicilio";
            Col_id_domicilio.ReadOnly = true;
            Col_id_domicilio.Visible = false;
            Col_id_domicilio.Width = 109;
            // 
            // Col_estado_permiso
            // 
            Col_estado_permiso.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_estado_permiso.HeaderText = "Estado Permiso";
            Col_estado_permiso.Name = "Col_estado_permiso";
            Col_estado_permiso.ReadOnly = true;
            Col_estado_permiso.Width = 80;
            // 
            // FrmPermisoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(822, 565);
            Controls.Add(dataGridPermisos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPermisoUsuario";
            Text = "Permiso de Usuario";
            Load += FrmPermisoUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPermisos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmpleado;
        private TextBox txtTipo;
        private TextBox textBox2;
        private Label lblFecha;
        private Label lblTipo;
        private Label lblEmpleado;
        private Label lblFiltrar;
        private Label lblPermisoUsu;
        private FontAwesome.Sharp.IconButton iconbtnClean;
        private Panel panel2;
        private Label lblDiasSolicitados;
        private FontAwesome.Sharp.IconButton iconBtnRechaPermiso;
        private FontAwesome.Sharp.IconButton iconBtnAprobarPermiso;
        private TextBox txtDomiDato;
        private ComboBox cboTipoPermiso;
        private Label lblTipoPermi;
        private Label lblEmailDato;
        private TextBox txtEmailDato;
        private Label lblRoldato;
        private Label lblTelefDato;
        private TextBox txtTelefDato;
        private Label lblDniEmple;
        private TextBox txtApeEmple;
        private Label lblApeEmple;
        private Label lblNombreEmple;
        private TextBox txtNombreEmple;
        private Label label11;
        private DataGridView dataGridPermisos;
        private DataGridViewTextBoxColumn Col_comentario_just;
        private DataGridViewTextBoxColumn Col_id_usuario;
        private DataGridViewTextBoxColumn Col_id_rol;
        private DataGridViewTextBoxColumn Col_telefono;
        private DataGridViewTextBoxColumn Col_calle;
        private DataGridViewTextBoxColumn Col_numero;
        private TextBox txtDniEmple;
        private Label lblDomidato;
        private TextBox txtRolDato;
        private TextBox txtComentario;
        private Label lblJustificaion;
        private TextBox txtDiasSolciitados;
        private TextBox txtIdEmpleado;
        private Label lblIdEmpleado;
        private TextBox textBox3;
        private TextBox txtJustificacion;
        private DataGridViewTextBoxColumn Col_id_permiso;
        private DataGridViewTextBoxColumn Col_fecha_inicio;
        private DataGridViewTextBoxColumn Col_fecha_finalizacion;
        private DataGridViewTextBoxColumn Col_estado_aprobacion;
        private DataGridViewTextBoxColumn Col_nombre_rol;
        private DataGridViewTextBoxColumn col_id_persona;
        private DataGridViewTextBoxColumn Col_Dni_Usuario;
        private DataGridViewTextBoxColumn Col_Nombre_Usuario;
        private DataGridViewTextBoxColumn Col_Apellido_Usuario;
        private DataGridViewTextBoxColumn Col_id_domicilio;
        private DataGridViewTextBoxColumn Col_estado_permiso;
        private TextBox txtIdPermiso;
    }
}