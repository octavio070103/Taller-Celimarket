namespace Proyecto_Taller.Presentacion.Formularios.Admin
{
    partial class FrmRegistrarPerfil
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
            btnAgregar = new Button();
            textBoxNombre = new TextBox();
            lblPerfilID = new Label();
            lblPerfilDescripcion = new Label();
            textBox1 = new TextBox();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(126, 102);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 27);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(126, 72);
            textBoxNombre.Margin = new Padding(4, 3, 4, 3);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(167, 23);
            textBoxNombre.TabIndex = 18;
            // 
            // lblPerfilID
            // 
            lblPerfilID.AutoSize = true;
            lblPerfilID.Location = new Point(160, 53);
            lblPerfilID.Margin = new Padding(4, 0, 4, 0);
            lblPerfilID.Name = "lblPerfilID";
            lblPerfilID.Size = new Size(21, 15);
            lblPerfilID.TabIndex = 17;
            lblPerfilID.Text = "ID:";
            // 
            // lblPerfilDescripcion
            // 
            lblPerfilDescripcion.AutoSize = true;
            lblPerfilDescripcion.Location = new Point(383, 53);
            lblPerfilDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblPerfilDescripcion.Name = "lblPerfilDescripcion";
            lblPerfilDescripcion.Size = new Size(69, 15);
            lblPerfilDescripcion.TabIndex = 20;
            lblPerfilDescripcion.Text = "Descricpion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 72);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 21;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(250, 102);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 27);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(369, 102);
            btnBorrar.Margin = new Padding(4, 3, 4, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(88, 27);
            btnBorrar.TabIndex = 23;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(481, 102);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 53, 68);
            ClientSize = new Size(707, 460);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(textBox1);
            Controls.Add(lblPerfilDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(textBoxNombre);
            Controls.Add(lblPerfilID);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmRegistrarPerfil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox textBoxNombre;
        private Label lblPerfilID;
        private Label lblPerfilDescripcion;
        private TextBox textBox1;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
    }
}