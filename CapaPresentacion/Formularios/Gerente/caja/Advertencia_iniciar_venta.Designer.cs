namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class Advertencia_iniciar_venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advertencia_iniciar_venta));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            iconBtnAceptar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 103);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 0;
            label1.Text = "Para Iniciar la Venta tiene que ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 131);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 1;
            label2.Text = "Realizar la Apertura De La Caja";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(97, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 78);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // iconBtnAceptar
            // 
            iconBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAceptar.IconColor = Color.Black;
            iconBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAceptar.Location = new Point(89, 164);
            iconBtnAceptar.Name = "iconBtnAceptar";
            iconBtnAceptar.Size = new Size(75, 23);
            iconBtnAceptar.TabIndex = 3;
            iconBtnAceptar.Text = "Aceptar";
            iconBtnAceptar.UseVisualStyleBackColor = true;
            // 
            // Advertencia_iniciar_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 224);
            Controls.Add(iconBtnAceptar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Advertencia_iniciar_venta";
            Text = "Advertencia_iniciar_venta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconBtnAceptar;
    }
}