namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class AdvertenciaDebeCerrarLaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertenciaDebeCerrarLaCaja));
            iconBtnAceptar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconBtnAceptar
            // 
            iconBtnAceptar.BackColor = Color.FromArgb(0, 74, 221);
            iconBtnAceptar.FlatStyle = FlatStyle.Flat;
            iconBtnAceptar.ForeColor = Color.White;
            iconBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAceptar.IconColor = Color.Black;
            iconBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAceptar.Location = new Point(108, 168);
            iconBtnAceptar.Name = "iconBtnAceptar";
            iconBtnAceptar.Size = new Size(75, 23);
            iconBtnAceptar.TabIndex = 12;
            iconBtnAceptar.Text = "Aceptar";
            iconBtnAceptar.UseVisualStyleBackColor = false;
            iconBtnAceptar.Click += iconBtnAceptar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(108, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 78);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 122);
            label2.Name = "label2";
            label2.Size = new Size(178, 21);
            label2.TabIndex = 10;
            label2.Text = "Ya que quedo Abierta ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 90);
            label1.Name = "label1";
            label1.Size = new Size(302, 21);
            label1.TabIndex = 9;
            label1.Text = "Debe de Cerrar La caja del dia Anterior";
            // 
            // AdvertenciaDebeCerrarLaCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 226);
            Controls.Add(iconBtnAceptar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdvertenciaDebeCerrarLaCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdvertenciaDebeCerrarLaCaja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnAceptar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}