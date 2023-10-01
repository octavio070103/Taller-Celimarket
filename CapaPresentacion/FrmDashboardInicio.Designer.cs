namespace CapaPresentacion
{
    partial class FrmDashboardInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardInicio));
            panel1 = new Panel();
            lblDashInicio = new Label();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStockProductoCateogria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelNroClientes = new Panel();
            label16 = new Label();
            label17 = new Label();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            panelNroEmpleados = new Panel();
            label14 = new Label();
            label15 = new Label();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panelNroProveedores = new Panel();
            label12 = new Label();
            label13 = new Label();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            panelTotalCaja = new Panel();
            label10 = new Label();
            label11 = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panelCantPromociones = new Panel();
            label8 = new Label();
            label9 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panelGastos = new Panel();
            label6 = new Label();
            label7 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panelCantidadProductos = new Panel();
            label4 = new Label();
            label5 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panelTotalVentas = new Panel();
            label2 = new Label();
            lblTotalVentas = new Label();
            iconBtnRechazar = new FontAwesome.Sharp.IconButton();
            panelStockDisponible = new Panel();
            label1 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStockProductoCateogria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            panelNroClientes.SuspendLayout();
            panelNroEmpleados.SuspendLayout();
            panelNroProveedores.SuspendLayout();
            panelTotalCaja.SuspendLayout();
            panelCantPromociones.SuspendLayout();
            panelGastos.SuspendLayout();
            panelCantidadProductos.SuspendLayout();
            panelTotalVentas.SuspendLayout();
            panelStockDisponible.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 33, 75);
            panel1.Controls.Add(lblDashInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 14;
            // 
            // lblDashInicio
            // 
            lblDashInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDashInicio.AutoSize = true;
            lblDashInicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDashInicio.ForeColor = SystemColors.ControlLightLight;
            lblDashInicio.ImageAlign = ContentAlignment.TopCenter;
            lblDashInicio.Location = new Point(137, 9);
            lblDashInicio.Name = "lblDashInicio";
            lblDashInicio.Size = new Size(223, 45);
            lblDashInicio.TabIndex = 0;
            lblDashInicio.Text = "DASHBOARD";
            lblDashInicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartVentas
            // 
            chartVentas.BackColor = Color.FromArgb(34, 41, 53);
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentas.Legends.Add(legend1);
            chartVentas.Location = new Point(0, 60);
            chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(430, 182);
            chartVentas.TabIndex = 15;
            chartVentas.Text = "chart1";
            // 
            // chartStockProductoCateogria
            // 
            chartStockProductoCateogria.BackColor = Color.FromArgb(34, 41, 53);
            chartArea2.Name = "ChartArea1";
            chartStockProductoCateogria.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStockProductoCateogria.Legends.Add(legend2);
            chartStockProductoCateogria.Location = new Point(0, 248);
            chartStockProductoCateogria.Name = "chartStockProductoCateogria";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartStockProductoCateogria.Series.Add(series2);
            chartStockProductoCateogria.Size = new Size(430, 203);
            chartStockProductoCateogria.TabIndex = 16;
            chartStockProductoCateogria.Text = "chart2";
            // 
            // chart3
            // 
            chart3.BackColor = Color.FromArgb(34, 41, 53);
            chart3.BorderlineColor = Color.FromArgb(34, 41, 53);
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(436, 248);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.LabelBackColor = Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(364, 203);
            chart3.TabIndex = 17;
            chart3.Text = "chartTopProductos";
            // 
            // panelNroClientes
            // 
            panelNroClientes.BackColor = Color.FromArgb(34, 41, 53);
            panelNroClientes.Controls.Add(label16);
            panelNroClientes.Controls.Add(label17);
            panelNroClientes.Controls.Add(iconButton8);
            panelNroClientes.Location = new Point(680, 60);
            panelNroClientes.Name = "panelNroClientes";
            panelNroClientes.Size = new Size(120, 58);
            panelNroClientes.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(38, 31);
            label16.Name = "label16";
            label16.Size = new Size(33, 15);
            label16.TabIndex = 19;
            label16.Text = "valor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(47, 3);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 18;
            label17.Text = "N Clientes";
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(34, 41, 53);
            iconButton8.BackgroundImage = (Image)resources.GetObject("iconButton8.BackgroundImage");
            iconButton8.BackgroundImageLayout = ImageLayout.Center;
            iconButton8.Cursor = Cursors.Hand;
            iconButton8.Dock = DockStyle.Left;
            iconButton8.FlatAppearance.BorderColor = Color.Black;
            iconButton8.FlatStyle = FlatStyle.Popup;
            iconButton8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.ForeColor = SystemColors.ControlLightLight;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 30;
            iconButton8.Location = new Point(0, 0);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(36, 58);
            iconButton8.TabIndex = 16;
            iconButton8.TextAlign = ContentAlignment.MiddleRight;
            iconButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton8.UseVisualStyleBackColor = false;
            // 
            // panelNroEmpleados
            // 
            panelNroEmpleados.BackColor = Color.FromArgb(34, 41, 53);
            panelNroEmpleados.Controls.Add(label14);
            panelNroEmpleados.Controls.Add(label15);
            panelNroEmpleados.Controls.Add(iconButton7);
            panelNroEmpleados.Location = new Point(680, 124);
            panelNroEmpleados.Name = "panelNroEmpleados";
            panelNroEmpleados.Size = new Size(120, 58);
            panelNroEmpleados.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(54, 22);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 19;
            label14.Text = "valor";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(42, 3);
            label15.Name = "label15";
            label15.Size = new Size(77, 15);
            label15.TabIndex = 18;
            label15.Text = "N Empleados";
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(34, 41, 53);
            iconButton7.BackgroundImage = (Image)resources.GetObject("iconButton7.BackgroundImage");
            iconButton7.BackgroundImageLayout = ImageLayout.Center;
            iconButton7.Cursor = Cursors.Hand;
            iconButton7.Dock = DockStyle.Left;
            iconButton7.FlatAppearance.BorderColor = Color.Black;
            iconButton7.FlatStyle = FlatStyle.Popup;
            iconButton7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton7.ForeColor = SystemColors.ControlLightLight;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 30;
            iconButton7.Location = new Point(0, 0);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(36, 58);
            iconButton7.TabIndex = 16;
            iconButton7.TextAlign = ContentAlignment.MiddleRight;
            iconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // panelNroProveedores
            // 
            panelNroProveedores.BackColor = Color.FromArgb(34, 41, 53);
            panelNroProveedores.Controls.Add(label12);
            panelNroProveedores.Controls.Add(label13);
            panelNroProveedores.Controls.Add(iconButton6);
            panelNroProveedores.Location = new Point(680, 188);
            panelNroProveedores.Name = "panelNroProveedores";
            panelNroProveedores.Size = new Size(120, 54);
            panelNroProveedores.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(54, 19);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 19;
            label12.Text = "valor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(38, 0);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 18;
            label13.Text = "N proveedores";
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.FromArgb(34, 41, 53);
            iconButton6.BackgroundImage = (Image)resources.GetObject("iconButton6.BackgroundImage");
            iconButton6.BackgroundImageLayout = ImageLayout.Center;
            iconButton6.Cursor = Cursors.Hand;
            iconButton6.Dock = DockStyle.Left;
            iconButton6.FlatAppearance.BorderColor = Color.Black;
            iconButton6.FlatStyle = FlatStyle.Popup;
            iconButton6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton6.ForeColor = SystemColors.ControlLightLight;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.Location = new Point(0, 0);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(36, 54);
            iconButton6.TabIndex = 16;
            iconButton6.TextAlign = ContentAlignment.MiddleRight;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // panelTotalCaja
            // 
            panelTotalCaja.BackColor = Color.FromArgb(34, 41, 53);
            panelTotalCaja.Controls.Add(label10);
            panelTotalCaja.Controls.Add(iconButton5);
            panelTotalCaja.Controls.Add(label11);
            panelTotalCaja.Location = new Point(554, 188);
            panelTotalCaja.Name = "panelTotalCaja";
            panelTotalCaja.Size = new Size(120, 54);
            panelTotalCaja.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(54, 19);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 19;
            label10.Text = "valor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(57, 0);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 18;
            label11.Text = "Caja";
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(34, 41, 53);
            iconButton5.BackgroundImage = (Image)resources.GetObject("iconButton5.BackgroundImage");
            iconButton5.BackgroundImageLayout = ImageLayout.Center;
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.Dock = DockStyle.Left;
            iconButton5.FlatAppearance.BorderColor = Color.Black;
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.ForeColor = SystemColors.ControlLightLight;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(0, 0);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(36, 54);
            iconButton5.TabIndex = 16;
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // panelCantPromociones
            // 
            panelCantPromociones.BackColor = Color.FromArgb(34, 41, 53);
            panelCantPromociones.Controls.Add(label8);
            panelCantPromociones.Controls.Add(label9);
            panelCantPromociones.Controls.Add(iconButton4);
            panelCantPromociones.Location = new Point(554, 124);
            panelCantPromociones.Name = "panelCantPromociones";
            panelCantPromociones.Size = new Size(120, 58);
            panelCantPromociones.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(54, 22);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 19;
            label8.Text = "valor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(42, 3);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 18;
            label9.Text = "N Promocion";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(34, 41, 53);
            iconButton4.BackgroundImage = (Image)resources.GetObject("iconButton4.BackgroundImage");
            iconButton4.BackgroundImageLayout = ImageLayout.Center;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.Dock = DockStyle.Left;
            iconButton4.FlatAppearance.BorderColor = Color.Black;
            iconButton4.FlatStyle = FlatStyle.Popup;
            iconButton4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = SystemColors.ControlLightLight;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.Location = new Point(0, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(36, 58);
            iconButton4.TabIndex = 16;
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // panelGastos
            // 
            panelGastos.BackColor = Color.FromArgb(34, 41, 53);
            panelGastos.Controls.Add(label6);
            panelGastos.Controls.Add(iconButton3);
            panelGastos.Controls.Add(label7);
            panelGastos.Location = new Point(554, 60);
            panelGastos.Name = "panelGastos";
            panelGastos.Size = new Size(120, 58);
            panelGastos.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(54, 22);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 19;
            label6.Text = "valor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(54, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 18;
            label7.Text = "Gastos";
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(34, 41, 53);
            iconButton3.BackgroundImage = (Image)resources.GetObject("iconButton3.BackgroundImage");
            iconButton3.BackgroundImageLayout = ImageLayout.Center;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Dock = DockStyle.Left;
            iconButton3.FlatAppearance.BorderColor = Color.Black;
            iconButton3.FlatStyle = FlatStyle.Popup;
            iconButton3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = SystemColors.ControlLightLight;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(0, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(36, 58);
            iconButton3.TabIndex = 16;
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // panelCantidadProductos
            // 
            panelCantidadProductos.BackColor = Color.FromArgb(34, 41, 53);
            panelCantidadProductos.Controls.Add(label4);
            panelCantidadProductos.Controls.Add(label5);
            panelCantidadProductos.Controls.Add(iconButton2);
            panelCantidadProductos.Location = new Point(436, 188);
            panelCantidadProductos.Name = "panelCantidadProductos";
            panelCantidadProductos.Size = new Size(112, 54);
            panelCantidadProductos.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 19);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 19;
            label4.Text = "valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 18;
            label5.Text = "Nº Productos";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(34, 41, 53);
            iconButton2.BackgroundImage = (Image)resources.GetObject("iconButton2.BackgroundImage");
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Dock = DockStyle.Left;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlLightLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(36, 54);
            iconButton2.TabIndex = 16;
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panelTotalVentas
            // 
            panelTotalVentas.BackColor = Color.FromArgb(34, 41, 53);
            panelTotalVentas.Controls.Add(label2);
            panelTotalVentas.Controls.Add(lblTotalVentas);
            panelTotalVentas.Controls.Add(iconBtnRechazar);
            panelTotalVentas.Location = new Point(436, 60);
            panelTotalVentas.Name = "panelTotalVentas";
            panelTotalVentas.Size = new Size(112, 58);
            panelTotalVentas.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 22);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 17;
            label2.Text = "valor";
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.ForeColor = Color.White;
            lblTotalVentas.Location = new Point(42, 3);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(69, 15);
            lblTotalVentas.TabIndex = 16;
            lblTotalVentas.Text = "Total Ventas";
            // 
            // iconBtnRechazar
            // 
            iconBtnRechazar.BackColor = Color.FromArgb(34, 41, 53);
            iconBtnRechazar.BackgroundImage = (Image)resources.GetObject("iconBtnRechazar.BackgroundImage");
            iconBtnRechazar.BackgroundImageLayout = ImageLayout.Center;
            iconBtnRechazar.Cursor = Cursors.Hand;
            iconBtnRechazar.Dock = DockStyle.Left;
            iconBtnRechazar.FlatAppearance.BorderColor = Color.Black;
            iconBtnRechazar.FlatStyle = FlatStyle.Popup;
            iconBtnRechazar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtnRechazar.ForeColor = SystemColors.ControlLightLight;
            iconBtnRechazar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconBtnRechazar.IconColor = Color.White;
            iconBtnRechazar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnRechazar.IconSize = 30;
            iconBtnRechazar.Location = new Point(0, 0);
            iconBtnRechazar.Name = "iconBtnRechazar";
            iconBtnRechazar.Size = new Size(36, 58);
            iconBtnRechazar.TabIndex = 15;
            iconBtnRechazar.TextAlign = ContentAlignment.MiddleRight;
            iconBtnRechazar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnRechazar.UseVisualStyleBackColor = false;
            // 
            // panelStockDisponible
            // 
            panelStockDisponible.BackColor = Color.FromArgb(34, 41, 53);
            panelStockDisponible.Controls.Add(label1);
            panelStockDisponible.Controls.Add(iconButton1);
            panelStockDisponible.Controls.Add(label3);
            panelStockDisponible.Location = new Point(436, 124);
            panelStockDisponible.Name = "panelStockDisponible";
            panelStockDisponible.Size = new Size(112, 58);
            panelStockDisponible.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 22);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 17;
            label1.Text = "valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 16;
            label3.Text = "Stock ";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(34, 41, 53);
            iconButton1.BackgroundImage = (Image)resources.GetObject("iconButton1.BackgroundImage");
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 58);
            iconButton1.TabIndex = 15;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // FrmDashboardInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 48, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(panelStockDisponible);
            Controls.Add(panelCantidadProductos);
            Controls.Add(panelTotalVentas);
            Controls.Add(panelTotalCaja);
            Controls.Add(panelNroProveedores);
            Controls.Add(panelCantPromociones);
            Controls.Add(panelNroEmpleados);
            Controls.Add(panelGastos);
            Controls.Add(panelNroClientes);
            Controls.Add(chart3);
            Controls.Add(chartStockProductoCateogria);
            Controls.Add(chartVentas);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmDashboardInicio";
            Text = "Form1";
            Load += FrmDashboardInicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStockProductoCateogria).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panelNroClientes.ResumeLayout(false);
            panelNroClientes.PerformLayout();
            panelNroEmpleados.ResumeLayout(false);
            panelNroEmpleados.PerformLayout();
            panelNroProveedores.ResumeLayout(false);
            panelNroProveedores.PerformLayout();
            panelTotalCaja.ResumeLayout(false);
            panelTotalCaja.PerformLayout();
            panelCantPromociones.ResumeLayout(false);
            panelCantPromociones.PerformLayout();
            panelGastos.ResumeLayout(false);
            panelGastos.PerformLayout();
            panelCantidadProductos.ResumeLayout(false);
            panelCantidadProductos.PerformLayout();
            panelTotalVentas.ResumeLayout(false);
            panelTotalVentas.PerformLayout();
            panelStockDisponible.ResumeLayout(false);
            panelStockDisponible.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDashInicio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockProductoCateogria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Panel panelNroClientes;
        private Panel panelNroEmpleados;
        private Panel panelNroProveedores;
        private Panel panelTotalCaja;
        private Panel panelCantPromociones;
        private Panel panelGastos;
        private Panel panelCantidadProductos;
        private Panel panelTotalVentas;
        private FontAwesome.Sharp.IconButton iconBtnRechazar;
        private Label label2;
        private Label lblTotalVentas;
        private Label label16;
        private Label label17;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Label label14;
        private Label label15;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Label label12;
        private Label label13;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Label label10;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label label8;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panelStockDisponible;
        private Label label1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}