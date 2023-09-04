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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.lblPerfilID = new System.Windows.Forms.Label();
            this.lblPerfilDescripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(108, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(108, 62);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(144, 20);
            this.textBoxNombre.TabIndex = 18;
            // 
            // lblPerfilID
            // 
            this.lblPerfilID.AutoSize = true;
            this.lblPerfilID.Location = new System.Drawing.Point(137, 46);
            this.lblPerfilID.Name = "lblPerfilID";
            this.lblPerfilID.Size = new System.Drawing.Size(21, 13);
            this.lblPerfilID.TabIndex = 17;
            this.lblPerfilID.Text = "ID:";
            // 
            // lblPerfilDescripcion
            // 
            this.lblPerfilDescripcion.AutoSize = true;
            this.lblPerfilDescripcion.Location = new System.Drawing.Point(328, 46);
            this.lblPerfilDescripcion.Name = "lblPerfilDescripcion";
            this.lblPerfilDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblPerfilDescripcion.TabIndex = 20;
            this.lblPerfilDescripcion.Text = "Descricpion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 21;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(214, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(316, 88);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(84, 141);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(465, 230);
            this.dataGridViewUsuario.TabIndex = 25;
            // 
            // FrmRegistrarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPerfilDescripcion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblPerfilID);
            this.Name = "FrmRegistrarPerfil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label lblPerfilID;
        private System.Windows.Forms.Label lblPerfilDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
    }
}