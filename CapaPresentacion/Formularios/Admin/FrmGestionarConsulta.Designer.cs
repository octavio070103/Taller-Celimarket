﻿namespace CapaPresentacion.Formularios.Admin
{
    partial class FrmGestionarConsulta
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtNombre = new TextBox();
            textBox2 = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            lblFiltrar = new Label();
            lblListaConsultas = new Label();
            dataGridUsuarios = new DataGridView();
            panel2 = new Panel();
            lblDatosUsuario = new Label();
            btnResponder = new FontAwesome.Sharp.IconButton();
            iconBtnMarcar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconBtnEliminar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblFiltrar);
            panel1.Controls.Add(lblListaConsultas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 92);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(687, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 20);
            textBox1.TabIndex = 12;
            textBox1.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(616, 59);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 11;
            label1.Text = "Prioridad";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(220, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(88, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Silver;
            txtNombre.Location = new Point(356, 58);
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
            textBox2.Location = new Point(513, 58);
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
            lblApellido.Location = new Point(459, 59);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(48, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Buscar";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(314, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(36, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Tipo";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlLightLight;
            lblDni.Location = new Point(171, 59);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 17);
            lblDni.TabIndex = 4;
            lblDni.Text = "Fecha";
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
            // lblListaConsultas
            // 
            lblListaConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblListaConsultas.AutoSize = true;
            lblListaConsultas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaConsultas.ForeColor = SystemColors.ControlLightLight;
            lblListaConsultas.ImageAlign = ContentAlignment.TopCenter;
            lblListaConsultas.Location = new Point(267, 0);
            lblListaConsultas.Name = "lblListaConsultas";
            lblListaConsultas.Size = new Size(291, 45);
            lblListaConsultas.TabIndex = 0;
            lblListaConsultas.Text = "Lista De Consultas";
            lblListaConsultas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridUsuarios.BackgroundColor = Color.White;
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(80, 144);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridUsuarios.RowHeadersVisible = false;
            dataGridUsuarios.RowTemplate.Height = 25;
            dataGridUsuarios.Size = new Size(427, 269);
            dataGridUsuarios.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblDatosUsuario);
            panel2.Location = new Point(550, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 315);
            panel2.TabIndex = 4;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.Location = new Point(75, 10);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(87, 30);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Detalles";
            // 
            // btnResponder
            // 
            btnResponder.BackColor = Color.FromArgb(19, 173, 39);
            btnResponder.Cursor = Cursors.Hand;
            btnResponder.FlatAppearance.BorderColor = Color.Black;
            btnResponder.FlatStyle = FlatStyle.Flat;
            btnResponder.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResponder.ForeColor = SystemColors.ControlLightLight;
            btnResponder.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            btnResponder.IconColor = Color.White;
            btnResponder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResponder.IconSize = 30;
            btnResponder.Location = new Point(123, 99);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(103, 39);
            btnResponder.TabIndex = 8;
            btnResponder.Text = "Responder";
            btnResponder.TextAlign = ContentAlignment.MiddleRight;
            btnResponder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResponder.UseVisualStyleBackColor = false;
            btnResponder.Click += btnResponder_Click;
            // 
            // iconBtnMarcar
            // 
            iconBtnMarcar.BackColor = Color.DarkGray;
            iconBtnMarcar.Cursor = Cursors.Hand;
            iconBtnMarcar.FlatAppearance.BorderColor = Color.Black;
            iconBtnMarcar.FlatStyle = FlatStyle.Flat;
            iconBtnMarcar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnMarcar.ForeColor = SystemColors.ControlLightLight;
            iconBtnMarcar.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            iconBtnMarcar.IconColor = Color.White;
            iconBtnMarcar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnMarcar.IconSize = 30;
            iconBtnMarcar.Location = new Point(267, 99);
            iconBtnMarcar.Name = "iconBtnMarcar";
            iconBtnMarcar.Size = new Size(83, 39);
            iconBtnMarcar.TabIndex = 9;
            iconBtnMarcar.Text = "Marcar Leido";
            iconBtnMarcar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnMarcar.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(255, 222, 89);
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlLightLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(198, 419);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(192, 39);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Ver Papelera";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconBtnEliminar
            // 
            iconBtnEliminar.BackColor = Color.FromArgb(250, 21, 21);
            iconBtnEliminar.Cursor = Cursors.Hand;
            iconBtnEliminar.FlatAppearance.BorderColor = Color.Black;
            iconBtnEliminar.FlatStyle = FlatStyle.Flat;
            iconBtnEliminar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnEliminar.ForeColor = SystemColors.ControlLightLight;
            iconBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconBtnEliminar.IconColor = Color.White;
            iconBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnEliminar.IconSize = 30;
            iconBtnEliminar.Location = new Point(387, 99);
            iconBtnEliminar.Name = "iconBtnEliminar";
            iconBtnEliminar.Size = new Size(88, 39);
            iconBtnEliminar.TabIndex = 11;
            iconBtnEliminar.Text = "Eliminar";
            iconBtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmGestionarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(800, 471);
            Controls.Add(iconBtnEliminar);
            Controls.Add(iconButton2);
            Controls.Add(iconBtnMarcar);
            Controls.Add(btnResponder);
            Controls.Add(panel2);
            Controls.Add(dataGridUsuarios);
            Controls.Add(panel1);
            Name = "FrmGestionarConsulta";
            Text = "Gestionar Consultas ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombre;
        private TextBox textBox2;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDni;
        private Label lblFiltrar;
        private Label lblListaConsultas;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridUsuarios;
        private Panel panel2;
        private Label lblDatosUsuario;
        private FontAwesome.Sharp.IconButton btnResponder;
        private FontAwesome.Sharp.IconButton iconBtnMarcar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconBtnEliminar;
    }
}