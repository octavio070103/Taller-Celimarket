namespace CapaPresentacion.Formularios.Admin.Categoria
{
    partial class prueba
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prueba));
            dataGridConsultas = new DataGridView();
            Col_id_motivo_consulta = new DataGridViewTextBoxColumn();
            Col_motivo_consulta = new DataGridViewTextBoxColumn();
            Col_id_consulta = new DataGridViewTextBoxColumn();
            Col_comentario_consulta = new DataGridViewTextBoxColumn();
            Col_fecha_consulta = new DataGridViewTextBoxColumn();
            Col_estado_consulta = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Col_id_Rol = new DataGridViewTextBoxColumn();
            Col_nombre_rol = new DataGridViewTextBoxColumn();
            Col_id_persona = new DataGridViewTextBoxColumn();
            Col_Dni = new DataGridViewTextBoxColumn();
            Col_nombre_persona = new DataGridViewTextBoxColumn();
            Col_Apellido_persona = new DataGridViewTextBoxColumn();
            Responder_Consulta = new DataGridViewImageColumn();
            MarcarLeido = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).BeginInit();
            SuspendLayout();
            // 
            // dataGridConsultas
            // 
            dataGridConsultas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridConsultas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridConsultas.BackgroundColor = Color.FromArgb(67, 68, 89);
            dataGridConsultas.BorderStyle = BorderStyle.None;
            dataGridConsultas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsultas.Columns.AddRange(new DataGridViewColumn[] { Col_id_motivo_consulta, Col_motivo_consulta, Col_id_consulta, Col_comentario_consulta, Col_fecha_consulta, Col_estado_consulta, dataGridViewTextBoxColumn1, Col_id_Rol, Col_nombre_rol, Col_id_persona, Col_Dni, Col_nombre_persona, Col_Apellido_persona, Responder_Consulta, MarcarLeido });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridConsultas.GridColor = SystemColors.ActiveCaptionText;
            dataGridConsultas.Location = new Point(3, 49);
            dataGridConsultas.MultiSelect = false;
            dataGridConsultas.Name = "dataGridConsultas";
            dataGridConsultas.ReadOnly = true;
            dataGridConsultas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(119, 105, 178);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 33, 75);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridConsultas.RowHeadersVisible = false;
            dataGridConsultas.RowTemplate.Height = 28;
            dataGridConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridConsultas.Size = new Size(795, 353);
            dataGridConsultas.TabIndex = 37;
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
            Col_motivo_consulta.Width = 120;
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
            Col_comentario_consulta.Width = 260;
            // 
            // Col_fecha_consulta
            // 
            Col_fecha_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_fecha_consulta.HeaderText = "Fecha Consulta";
            Col_fecha_consulta.Name = "Col_fecha_consulta";
            Col_fecha_consulta.ReadOnly = true;
            Col_fecha_consulta.Width = 120;
            // 
            // Col_estado_consulta
            // 
            Col_estado_consulta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_estado_consulta.HeaderText = "Estado Consulta";
            Col_estado_consulta.Name = "Col_estado_consulta";
            Col_estado_consulta.ReadOnly = true;
            Col_estado_consulta.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "id_usuario";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 95;
            // 
            // Col_id_Rol
            // 
            Col_id_Rol.HeaderText = "id_rol";
            Col_id_Rol.Name = "Col_id_Rol";
            Col_id_Rol.ReadOnly = true;
            Col_id_Rol.Visible = false;
            Col_id_Rol.Width = 68;
            // 
            // Col_nombre_rol
            // 
            Col_nombre_rol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_nombre_rol.HeaderText = "Rol";
            Col_nombre_rol.Name = "Col_nombre_rol";
            Col_nombre_rol.ReadOnly = true;
            // 
            // Col_id_persona
            // 
            Col_id_persona.HeaderText = "id_persona";
            Col_id_persona.Name = "Col_id_persona";
            Col_id_persona.ReadOnly = true;
            Col_id_persona.Visible = false;
            Col_id_persona.Width = 101;
            // 
            // Col_Dni
            // 
            Col_Dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_Dni.HeaderText = "DNI";
            Col_Dni.Name = "Col_Dni";
            Col_Dni.ReadOnly = true;
            Col_Dni.Width = 120;
            // 
            // Col_nombre_persona
            // 
            Col_nombre_persona.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_nombre_persona.HeaderText = "Nombre";
            Col_nombre_persona.Name = "Col_nombre_persona";
            Col_nombre_persona.ReadOnly = true;
            Col_nombre_persona.Width = 120;
            // 
            // Col_Apellido_persona
            // 
            Col_Apellido_persona.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Col_Apellido_persona.HeaderText = "Apellido";
            Col_Apellido_persona.Name = "Col_Apellido_persona";
            Col_Apellido_persona.ReadOnly = true;
            Col_Apellido_persona.Width = 120;
            // 
            // Responder_Consulta
            // 
            Responder_Consulta.HeaderText = "Responder";
            Responder_Consulta.Image = (Image)resources.GetObject("Responder_Consulta.Image");
            Responder_Consulta.Name = "Responder_Consulta";
            Responder_Consulta.ReadOnly = true;
            Responder_Consulta.Width = 80;
            // 
            // MarcarLeido
            // 
            MarcarLeido.HeaderText = "Marca Como Leido";
            MarcarLeido.Image = (Image)resources.GetObject("MarcarLeido.Image");
            MarcarLeido.Name = "MarcarLeido";
            MarcarLeido.ReadOnly = true;
            MarcarLeido.Width = 89;
            // 
            // prueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridConsultas);
            Name = "prueba";
            Text = "prueba";
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridConsultas;
        private DataGridViewTextBoxColumn Col_id_motivo_consulta;
        private DataGridViewTextBoxColumn Col_motivo_consulta;
        private DataGridViewTextBoxColumn Col_id_consulta;
        private DataGridViewTextBoxColumn Col_comentario_consulta;
        private DataGridViewTextBoxColumn Col_fecha_consulta;
        private DataGridViewTextBoxColumn Col_estado_consulta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Col_id_Rol;
        private DataGridViewTextBoxColumn Col_nombre_rol;
        private DataGridViewTextBoxColumn Col_id_persona;
        private DataGridViewTextBoxColumn Col_Dni;
        private DataGridViewTextBoxColumn Col_nombre_persona;
        private DataGridViewTextBoxColumn Col_Apellido_persona;
        private DataGridViewImageColumn Responder_Consulta;
        private DataGridViewImageColumn MarcarLeido;
    }
}