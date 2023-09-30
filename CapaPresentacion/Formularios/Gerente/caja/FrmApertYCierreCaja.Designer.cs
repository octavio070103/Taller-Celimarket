namespace CapaPresentacion.Formularios.Gerente.caja
{
    partial class FrmApertYCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApertYCierreCaja));
            panel1 = new Panel();
            lblListaConsultas = new Label();
            tabControl1 = new TabControl();
            tabPageCaja = new TabPage();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconBtnAbrirCaja = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            tabPageCerrarCaja = new TabPage();
            panel4 = new Panel();
            iconBtnImprimir = new FontAwesome.Sharp.IconButton();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView3 = new DataGridView();
            Column_Forma_Pago = new DataGridViewTextBoxColumn();
            Column_total = new DataGridViewTextBoxColumn();
            label14 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            iconBtnRegresar = new FontAwesome.Sharp.IconButton();
            iconBtnCerrarCaja = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCaja.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageCerrarCaja.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 68, 89);
            panel1.Controls.Add(lblListaConsultas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 72);
            panel1.TabIndex = 1;
            // 
            // lblListaConsultas
            // 
            lblListaConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblListaConsultas.AutoSize = true;
            lblListaConsultas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaConsultas.ForeColor = SystemColors.ControlLightLight;
            lblListaConsultas.ImageAlign = ContentAlignment.TopCenter;
            lblListaConsultas.Location = new Point(233, 15);
            lblListaConsultas.Name = "lblListaConsultas";
            lblListaConsultas.Size = new Size(282, 45);
            lblListaConsultas.TabIndex = 1;
            lblListaConsultas.Text = "Apertura de Caja ";
            lblListaConsultas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCaja);
            tabControl1.Controls.Add(tabPageCerrarCaja);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(839, 607);
            tabControl1.TabIndex = 4;
            // 
            // tabPageCaja
            // 
            tabPageCaja.Controls.Add(panel2);
            tabPageCaja.Controls.Add(panel1);
            tabPageCaja.Location = new Point(4, 24);
            tabPageCaja.Name = "tabPageCaja";
            tabPageCaja.Padding = new Padding(3);
            tabPageCaja.Size = new Size(831, 579);
            tabPageCaja.TabIndex = 0;
            tabPageCaja.Text = "Caja";
            tabPageCaja.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconBtnAbrirCaja);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 501);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridView1.Location = new Point(385, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(542, 227);
            dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Movimiento";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Monto";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Tipo Documento";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Serie";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Correlativo";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Observacion";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(385, 21);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 15;
            label1.Text = "Detalle de Movimientos";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Orange;
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(184, 353);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(105, 38);
            iconButton1.TabIndex = 14;
            iconButton1.Text = "Regresar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBtnAbrirCaja
            // 
            iconBtnAbrirCaja.BackColor = Color.LightGreen;
            iconBtnAbrirCaja.BackgroundImage = (Image)resources.GetObject("iconBtnAbrirCaja.BackgroundImage");
            iconBtnAbrirCaja.BackgroundImageLayout = ImageLayout.None;
            iconBtnAbrirCaja.Cursor = Cursors.Hand;
            iconBtnAbrirCaja.FlatAppearance.BorderColor = Color.Black;
            iconBtnAbrirCaja.FlatStyle = FlatStyle.Flat;
            iconBtnAbrirCaja.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnAbrirCaja.ForeColor = Color.Black;
            iconBtnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnAbrirCaja.IconColor = Color.White;
            iconBtnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnAbrirCaja.IconSize = 30;
            iconBtnAbrirCaja.Location = new Point(44, 353);
            iconBtnAbrirCaja.Name = "iconBtnAbrirCaja";
            iconBtnAbrirCaja.Size = new Size(105, 38);
            iconBtnAbrirCaja.TabIndex = 13;
            iconBtnAbrirCaja.Text = "Abrir Caja";
            iconBtnAbrirCaja.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAbrirCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAbrirCaja.UseVisualStyleBackColor = false;
            iconBtnAbrirCaja.Click += iconBtnAbrirCaja_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 21);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 10;
            label2.Text = "Usuario de Turno";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 219);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Movimiento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 310);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 282);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 6;
            label4.Text = "Monto de Apertura";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 23);
            textBox4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 151);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha y Hora de Apertura";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CAJA-01", "CAJA-02", "CAJA-03" });
            comboBox1.Location = new Point(44, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "   Seleccione una caja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 86);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 2;
            label6.Text = "Caja";
            // 
            // tabPageCerrarCaja
            // 
            tabPageCerrarCaja.Controls.Add(panel4);
            tabPageCerrarCaja.Controls.Add(panel3);
            tabPageCerrarCaja.Location = new Point(4, 24);
            tabPageCerrarCaja.Name = "tabPageCerrarCaja";
            tabPageCerrarCaja.Padding = new Padding(3);
            tabPageCerrarCaja.Size = new Size(831, 579);
            tabPageCerrarCaja.TabIndex = 1;
            tabPageCerrarCaja.Text = "Cerrar Caja";
            tabPageCerrarCaja.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(iconBtnImprimir);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(iconButton5);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(dataGridView3);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(iconBtnRegresar);
            panel4.Controls.Add(iconBtnCerrarCaja);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(825, 523);
            panel4.TabIndex = 4;
            // 
            // iconBtnImprimir
            // 
            iconBtnImprimir.BackColor = SystemColors.ControlDark;
            iconBtnImprimir.BackgroundImage = (Image)resources.GetObject("iconBtnImprimir.BackgroundImage");
            iconBtnImprimir.BackgroundImageLayout = ImageLayout.None;
            iconBtnImprimir.Cursor = Cursors.Hand;
            iconBtnImprimir.FlatAppearance.BorderColor = Color.Black;
            iconBtnImprimir.FlatStyle = FlatStyle.Flat;
            iconBtnImprimir.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnImprimir.ForeColor = Color.Black;
            iconBtnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnImprimir.IconColor = Color.White;
            iconBtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnImprimir.IconSize = 30;
            iconBtnImprimir.Location = new Point(566, 445);
            iconBtnImprimir.Name = "iconBtnImprimir";
            iconBtnImprimir.Size = new Size(105, 38);
            iconBtnImprimir.TabIndex = 33;
            iconBtnImprimir.Text = "Imprimir";
            iconBtnImprimir.TextAlign = ContentAlignment.MiddleRight;
            iconBtnImprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnImprimir.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(222, 296);
            label20.Name = "label20";
            label20.Size = new Size(154, 21);
            label20.TabIndex = 32;
            label20.Text = "label saldo Ingreso";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(17, 296);
            label19.Name = "label19";
            label19.Size = new Size(182, 21);
            label19.TabIndex = 31;
            label19.Text = "Transacciones / Ventas";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(222, 255);
            label18.Name = "label18";
            label18.Size = new Size(154, 21);
            label18.TabIndex = 30;
            label18.Text = "label saldo Ingreso";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(17, 255);
            label17.Name = "label17";
            label17.Size = new Size(67, 21);
            label17.TabIndex = 29;
            label17.Text = "Ingreso";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(222, 213);
            label16.Name = "label16";
            label16.Size = new Size(165, 21);
            label16.TabIndex = 28;
            label16.Text = "label saldo de salida";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(17, 213);
            label15.Name = "label15";
            label15.Size = new Size(57, 21);
            label15.TabIndex = 27;
            label15.Text = "Salida";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(222, 171);
            label13.Name = "label13";
            label13.Size = new Size(93, 21);
            label13.TabIndex = 26;
            label13.Text = "label saldo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(17, 171);
            label12.Name = "label12";
            label12.Size = new Size(124, 21);
            label12.TabIndex = 25;
            label12.Text = "Saldo Apertura";
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Green;
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.Location = new Point(88, 135);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(75, 23);
            iconButton5.TabIndex = 24;
            iconButton5.Text = "Abierto";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(17, 134);
            label11.Name = "label11";
            label11.Size = new Size(65, 21);
            label11.TabIndex = 23;
            label11.Text = "Estado:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 96);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(233, 23);
            textBox5.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(17, 72);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 21;
            label10.Text = "Usuario de Turno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 10);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 20;
            label9.Text = "Fecha de Caja";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column_Forma_Pago, Column_total });
            dataGridView3.Location = new Point(405, 289);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(410, 144);
            dataGridView3.TabIndex = 18;
            // 
            // Column_Forma_Pago
            // 
            Column_Forma_Pago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_Forma_Pago.HeaderText = "Forma de Pago";
            Column_Forma_Pago.MinimumWidth = 100;
            Column_Forma_Pago.Name = "Column_Forma_Pago";
            // 
            // Column_total
            // 
            Column_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column_total.HeaderText = "Total";
            Column_total.MinimumWidth = 100;
            Column_total.Name = "Column_total";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(405, 261);
            label14.Name = "label14";
            label14.Size = new Size(266, 25);
            label14.TabIndex = 17;
            label14.Text = "Resumen de Metodos de Pago";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(405, 34);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(410, 210);
            dataGridView2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Movimiento";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Monto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tipo Documento";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Serie";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Correlativo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Observacion";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(415, 6);
            label8.Name = "label8";
            label8.Size = new Size(277, 25);
            label8.TabIndex = 15;
            label8.Text = "Detalle de Movimientos Del Dia";
            // 
            // iconBtnRegresar
            // 
            iconBtnRegresar.BackColor = Color.Orange;
            iconBtnRegresar.BackgroundImage = (Image)resources.GetObject("iconBtnRegresar.BackgroundImage");
            iconBtnRegresar.BackgroundImageLayout = ImageLayout.None;
            iconBtnRegresar.Cursor = Cursors.Hand;
            iconBtnRegresar.FlatAppearance.BorderColor = Color.Black;
            iconBtnRegresar.FlatStyle = FlatStyle.Flat;
            iconBtnRegresar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnRegresar.ForeColor = Color.Black;
            iconBtnRegresar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnRegresar.IconColor = Color.White;
            iconBtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnRegresar.IconSize = 30;
            iconBtnRegresar.Location = new Point(210, 445);
            iconBtnRegresar.Name = "iconBtnRegresar";
            iconBtnRegresar.Size = new Size(105, 38);
            iconBtnRegresar.TabIndex = 14;
            iconBtnRegresar.Text = "Regresar";
            iconBtnRegresar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRegresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRegresar.UseVisualStyleBackColor = false;
            // 
            // iconBtnCerrarCaja
            // 
            iconBtnCerrarCaja.BackColor = Color.LightGreen;
            iconBtnCerrarCaja.BackgroundImage = (Image)resources.GetObject("iconBtnCerrarCaja.BackgroundImage");
            iconBtnCerrarCaja.BackgroundImageLayout = ImageLayout.None;
            iconBtnCerrarCaja.Cursor = Cursors.Hand;
            iconBtnCerrarCaja.FlatAppearance.BorderColor = Color.Black;
            iconBtnCerrarCaja.FlatStyle = FlatStyle.Flat;
            iconBtnCerrarCaja.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnCerrarCaja.ForeColor = Color.Black;
            iconBtnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnCerrarCaja.IconColor = Color.White;
            iconBtnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnCerrarCaja.IconSize = 30;
            iconBtnCerrarCaja.Location = new Point(75, 445);
            iconBtnCerrarCaja.Name = "iconBtnCerrarCaja";
            iconBtnCerrarCaja.Size = new Size(105, 38);
            iconBtnCerrarCaja.TabIndex = 13;
            iconBtnCerrarCaja.Text = "Cerrar Caja";
            iconBtnCerrarCaja.TextAlign = ContentAlignment.MiddleRight;
            iconBtnCerrarCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnCerrarCaja.UseVisualStyleBackColor = false;
            iconBtnCerrarCaja.Click += iconBtnCerrarCaja_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 68, 89);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 50);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(240, -3);
            label7.Name = "label7";
            label7.Size = new Size(227, 45);
            label7.TabIndex = 1;
            label7.Text = "Cierre de Caja";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmApertYCierreCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 604);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(838, 604);
            Name = "FrmApertYCierreCaja";
            Text = "Administrar Caja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCaja.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageCerrarCaja.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblListaConsultas;
        private TabControl tabControl1;
        private TabPage tabPageCaja;
        private TabPage tabPageCerrarCaja;
        private Panel panel3;
        private Label label7;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconBtnAbrirCaja;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Panel panel4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column_Forma_Pago;
        private DataGridViewTextBoxColumn Column_total;
        private Label label14;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconBtnRegresar;
        private FontAwesome.Sharp.IconButton iconBtnCerrarCaja;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label label11;
        private TextBox textBox5;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label12;
        private FontAwesome.Sharp.IconButton iconBtnImprimir;
    }
}