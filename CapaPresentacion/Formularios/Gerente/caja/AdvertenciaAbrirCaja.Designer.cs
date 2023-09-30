namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class AdvertenciaAbrirCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertenciaAbrirCaja));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            iconBtnAceptar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 206);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 22;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 201);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 21;
            label6.Text = "Monto Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 180);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 151);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 19;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 145);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 18;
            label3.Text = "Usuario de Turno:";
            // 
            // iconBtnAceptar
            // 
            iconBtnAceptar.BackColor = Color.FromArgb(0, 74, 221);
            iconBtnAceptar.FlatStyle = FlatStyle.Flat;
            iconBtnAceptar.ForeColor = Color.White;
            iconBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAceptar.IconColor = Color.Black;
            iconBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAceptar.Location = new Point(114, 234);
            iconBtnAceptar.Name = "iconBtnAceptar";
            iconBtnAceptar.Size = new Size(75, 23);
            iconBtnAceptar.TabIndex = 17;
            iconBtnAceptar.Text = "Aceptar";
            iconBtnAceptar.UseVisualStyleBackColor = false;
            iconBtnAceptar.Click += iconBtnAceptar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(114, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 78);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 175);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 15;
            label2.Text = "Fecha de Apertural: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 104);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 14;
            label1.Text = "Caja Abierta Correctamente";
            // 
            // AdvertenciaAbrirCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 269);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(iconBtnAceptar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdvertenciaAbrirCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdvertenciaAbrirCaja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconBtnAceptar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}