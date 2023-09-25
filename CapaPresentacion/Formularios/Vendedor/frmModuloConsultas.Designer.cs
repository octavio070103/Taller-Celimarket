namespace CapaPresentacion.Formularios.Vendedor
{
    partial class frmModuloConsultas
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
            pnlModuloConsultas = new Panel();
            btnEnviarConsulta = new Button();
            label7 = new Label();
            lblSeleccionar = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            cboConsultante = new ComboBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCorreo = new TextBox();
            txtAsunto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtConsulta = new TextBox();
            pnlModuloConsultas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlModuloConsultas
            // 
            pnlModuloConsultas.BackColor = Color.FromArgb(88, 89, 150);
            pnlModuloConsultas.Controls.Add(btnEnviarConsulta);
            pnlModuloConsultas.Controls.Add(label7);
            pnlModuloConsultas.Controls.Add(lblSeleccionar);
            pnlModuloConsultas.Controls.Add(txtApellido);
            pnlModuloConsultas.Controls.Add(label6);
            pnlModuloConsultas.Controls.Add(cboConsultante);
            pnlModuloConsultas.Controls.Add(txtTelefono);
            pnlModuloConsultas.Controls.Add(label5);
            pnlModuloConsultas.Controls.Add(label4);
            pnlModuloConsultas.Controls.Add(txtCorreo);
            pnlModuloConsultas.Controls.Add(txtAsunto);
            pnlModuloConsultas.Controls.Add(label3);
            pnlModuloConsultas.Controls.Add(label2);
            pnlModuloConsultas.Controls.Add(label1);
            pnlModuloConsultas.Controls.Add(txtNombre);
            pnlModuloConsultas.Controls.Add(txtConsulta);
            pnlModuloConsultas.Dock = DockStyle.Fill;
            pnlModuloConsultas.Location = new Point(0, 0);
            pnlModuloConsultas.Name = "pnlModuloConsultas";
            pnlModuloConsultas.Size = new Size(795, 571);
            pnlModuloConsultas.TabIndex = 0;
            // 
            // btnEnviarConsulta
            // 
            btnEnviarConsulta.Anchor = AnchorStyles.None;
            btnEnviarConsulta.BackColor = Color.FromArgb(56, 182, 255);
            btnEnviarConsulta.FlatAppearance.BorderSize = 0;
            btnEnviarConsulta.FlatStyle = FlatStyle.Flat;
            btnEnviarConsulta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviarConsulta.ForeColor = SystemColors.HighlightText;
            btnEnviarConsulta.Location = new Point(91, 506);
            btnEnviarConsulta.Name = "btnEnviarConsulta";
            btnEnviarConsulta.Size = new Size(134, 39);
            btnEnviarConsulta.TabIndex = 15;
            btnEnviarConsulta.Text = "ENVIAR";
            btnEnviarConsulta.UseVisualStyleBackColor = false;
            btnEnviarConsulta.Click += btnEnviarConsulta_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(469, 260);
            label7.Name = "label7";
            label7.Size = new Size(83, 19);
            label7.TabIndex = 14;
            label7.Text = "Consultante";
            // 
            // lblSeleccionar
            // 
            lblSeleccionar.Anchor = AnchorStyles.None;
            lblSeleccionar.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblSeleccionar.ForeColor = SystemColors.ControlLightLight;
            lblSeleccionar.Location = new Point(91, 47);
            lblSeleccionar.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionar.Name = "lblSeleccionar";
            lblSeleccionar.Size = new Size(324, 39);
            lblSeleccionar.TabIndex = 13;
            lblSeleccionar.Text = "Registrar Consulta";
            lblSeleccionar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Location = new Point(150, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(177, 23);
            txtApellido.TabIndex = 12;
            txtApellido.KeyPress += soloLetras_KeyPress;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(374, 122);
            label6.Name = "label6";
            label6.Size = new Size(59, 19);
            label6.TabIndex = 11;
            label6.Text = "Nombre";
            // 
            // cboConsultante
            // 
            cboConsultante.Anchor = AnchorStyles.None;
            cboConsultante.FormattingEnabled = true;
            cboConsultante.Items.AddRange(new object[] { "Cliente", "Vendedor", "Gerente" });
            cboConsultante.Location = new Point(558, 260);
            cboConsultante.Name = "cboConsultante";
            cboConsultante.Size = new Size(152, 23);
            cboConsultante.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Location = new Point(150, 170);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 23);
            txtTelefono.TabIndex = 9;
            txtTelefono.KeyPress += soloNumeros_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(91, 170);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(91, 264);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 7;
            label4.Text = "Consulta:";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.Location = new Point(501, 169);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(209, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtAsunto
            // 
            txtAsunto.Anchor = AnchorStyles.None;
            txtAsunto.Location = new Point(150, 215);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(177, 23);
            txtAsunto.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(374, 170);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 4;
            label3.Text = "Correo electrónico";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(91, 215);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 3;
            label2.Text = "Asunto";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(91, 122);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 2;
            label1.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(439, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(271, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += soloLetras_KeyPress;
            // 
            // txtConsulta
            // 
            txtConsulta.Anchor = AnchorStyles.None;
            txtConsulta.Location = new Point(91, 295);
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(619, 194);
            txtConsulta.TabIndex = 0;
            // 
            // frmModuloConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 571);
            Controls.Add(pnlModuloConsultas);
            Name = "frmModuloConsultas";
            Text = "frmModuloConsultas";
            pnlModuloConsultas.ResumeLayout(false);
            pnlModuloConsultas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlModuloConsultas;
        private TextBox txtConsulta;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtCorreo;
        private TextBox txtAsunto;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtApellido;
        private Label label6;
        private ComboBox cboConsultante;
        private Label lblSeleccionar;
        private Button btnEnviarConsulta;
        private Label label7;
    }
}