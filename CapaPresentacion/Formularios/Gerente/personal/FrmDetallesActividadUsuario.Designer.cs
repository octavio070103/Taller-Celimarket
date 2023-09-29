namespace CapaPresentacion.Formularios.Gerente.personal
{
    partial class FrmDetallesActividadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesActividadUsuario));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelBarraSuperior = new Panel();
            picRestaurar = new PictureBox();
            lblTituloMenu = new Label();
            btnMenu = new Button();
            picMinPantalla = new PictureBox();
            picMaxPantalla = new PictureBox();
            picCerrar = new PictureBox();
            panel2 = new Panel();
            panel7 = new Panel();
            textBox4 = new TextBox();
            label7 = new Label();
            panel6 = new Panel();
            textBox3 = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            textBox5 = new TextBox();
            label6 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            label9 = new Label();
            panel3 = new Panel();
            textBox6 = new TextBox();
            label10 = new Label();
            panel8 = new Panel();
            textBox1 = new TextBox();
            label11 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.BackColor = Color.FromArgb(1, 1, 2);
            panelBarraSuperior.Controls.Add(picRestaurar);
            panelBarraSuperior.Controls.Add(lblTituloMenu);
            panelBarraSuperior.Controls.Add(btnMenu);
            panelBarraSuperior.Controls.Add(picMinPantalla);
            panelBarraSuperior.Controls.Add(picMaxPantalla);
            panelBarraSuperior.Controls.Add(picCerrar);
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Margin = new Padding(4, 3, 4, 3);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(780, 45);
            panelBarraSuperior.TabIndex = 7;
            panelBarraSuperior.MouseDown += panelBarraSuperior_MouseDown;
            // 
            // picRestaurar
            // 
            picRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRestaurar.Cursor = Cursors.Hand;
            picRestaurar.Image = (Image)resources.GetObject("picRestaurar.Image");
            picRestaurar.Location = new Point(718, 0);
            picRestaurar.Margin = new Padding(4, 3, 4, 3);
            picRestaurar.Name = "picRestaurar";
            picRestaurar.Size = new Size(26, 28);
            picRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurar.TabIndex = 0;
            picRestaurar.TabStop = false;
            picRestaurar.Visible = false;
            picRestaurar.Click += picRestaurar_Click;
            // 
            // lblTituloMenu
            // 
            lblTituloMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTituloMenu.AutoSize = true;
            lblTituloMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMenu.ForeColor = SystemColors.ControlLightLight;
            lblTituloMenu.Location = new Point(273, 7);
            lblTituloMenu.Name = "lblTituloMenu";
            lblTituloMenu.Size = new Size(180, 25);
            lblTituloMenu.TabIndex = 15;
            lblTituloMenu.Text = "Detalle de Actividad";
            lblTituloMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(1, 1, 2);
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = SystemColors.ControlLightLight;
            btnMenu.Location = new Point(0, 2);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(12, 0, 0, 0);
            btnMenu.Size = new Size(123, 40);
            btnMenu.TabIndex = 14;
            btnMenu.Text = "Menu Principal";
            btnMenu.TextAlign = ContentAlignment.MiddleRight;
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // picMinPantalla
            // 
            picMinPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinPantalla.Cursor = Cursors.Hand;
            picMinPantalla.Image = (Image)resources.GetObject("picMinPantalla.Image");
            picMinPantalla.Location = new Point(683, 2);
            picMinPantalla.Margin = new Padding(4, 3, 4, 3);
            picMinPantalla.Name = "picMinPantalla";
            picMinPantalla.Size = new Size(27, 24);
            picMinPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMinPantalla.TabIndex = 1;
            picMinPantalla.TabStop = false;
            picMinPantalla.Click += picMinPantalla_Click;
            // 
            // picMaxPantalla
            // 
            picMaxPantalla.BackColor = Color.FromArgb(1, 1, 2);
            picMaxPantalla.Image = (Image)resources.GetObject("picMaxPantalla.Image");
            picMaxPantalla.Location = new Point(718, 0);
            picMaxPantalla.Margin = new Padding(4, 3, 4, 3);
            picMaxPantalla.Name = "picMaxPantalla";
            picMaxPantalla.Size = new Size(26, 27);
            picMaxPantalla.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxPantalla.TabIndex = 8;
            picMaxPantalla.TabStop = false;
            picMaxPantalla.Click += picMaxPantalla_Click;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(749, 2);
            picCerrar.Margin = new Padding(4, 3, 4, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(28, 24);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 0;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(chart2);
            panel2.Controls.Add(chart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 444);
            panel2.TabIndex = 27;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(textBox4);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(633, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(144, 55);
            panel7.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(22, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 16);
            textBox4.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 3;
            label7.Text = "Inasistencia";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textBox3);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(483, 125);
            panel6.Name = "panel6";
            panel6.Size = new Size(144, 55);
            panel6.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(23, 18);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Estado";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(633, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 55);
            panel5.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(22, 19);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 16);
            textBox5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 2);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 2;
            label6.Text = "Asistencia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 2);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(483, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 55);
            panel4.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(23, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 1;
            label9.Text = "Nombre y Apellido";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(633, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 55);
            panel3.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ScrollBar;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(22, 19);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 16);
            textBox6.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 0;
            label10.Text = "Nº Ventas realizadas";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(483, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(144, 55);
            panel8.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(23, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 0);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 1;
            label11.Text = "DNI";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(3, 212);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(474, 227);
            chart2.TabIndex = 19;
            chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(3, 3);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(474, 208);
            chart1.TabIndex = 18;
            chart1.Text = "chart1";
            // 
            // FrmDetallesActividadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 68, 89);
            ClientSize = new Size(780, 489);
            Controls.Add(panel2);
            Controls.Add(panelBarraSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(780, 700);
            MinimumSize = new Size(780, 489);
            Name = "FrmDetallesActividadUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDetallesActividadUsuario";
            panelBarraSuperior.ResumeLayout(false);
            panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaxPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelBarraSuperior;
        private Label lblTituloMenu;
        private Button btnMenu;
        private PictureBox picMinPantalla;
        private PictureBox picMaxPantalla;
        private PictureBox picCerrar;
        private Panel panel2;
        private Panel panel7;
        private Label label7;
        private Panel panel6;
        private Label label1;
        private Panel panel5;
        private Label label6;
        private Label label8;
        private Panel panel4;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private Panel panel8;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private PictureBox picRestaurar;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox1;
    }
}