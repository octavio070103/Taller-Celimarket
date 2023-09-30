namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class AdvertenciaCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertenciaCierreCaja));
            iconBtnAceptar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            iconBtnAceptar.Location = new Point(45, 234);
            iconBtnAceptar.Name = "iconBtnAceptar";
            iconBtnAceptar.Size = new Size(75, 23);
            iconBtnAceptar.TabIndex = 7;
            iconBtnAceptar.Text = "Aceptar";
            iconBtnAceptar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(119, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 78);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 175);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 5;
            label2.Text = "Efectivo Real: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 4;
            label1.Text = "Esta Seguro de Cerrar Caja?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 145);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 8;
            label3.Text = "Balance Teorico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 151);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 181);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(57, 201);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 11;
            label6.Text = "Diferencia:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 207);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "label7";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(209, 29, 29);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(138, 234);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 23);
            iconButton1.TabIndex = 13;
            iconButton1.Text = "Cancelar";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // AdvertenciaCierreCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 269);
            Controls.Add(iconButton1);
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
            Name = "AdvertenciaCierreCaja";
            Text = "AdvertenciaCierreCaja";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnAceptar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}