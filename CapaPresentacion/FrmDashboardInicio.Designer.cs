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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboardInicio));
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStockProductoCateogria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelNroClientes = new Panel();
            lblNroCliente = new Label();
            label17 = new Label();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            panelNroEmpleados = new Panel();
            lblNroEmple = new Label();
            label15 = new Label();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panelNroProveedores = new Panel();
            lblNroProvee = new Label();
            label13 = new Label();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            panelTotalCaja = new Panel();
            lblValorCaja = new Label();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            panelCantPromociones = new Panel();
            lblNroVentas = new Label();
            label9 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panelGastos = new Panel();
            lblValorGasto = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            panelCantidadProductos = new Panel();
            lblNroProduc = new Label();
            label5 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panelTotalVentas = new Panel();
            lblTotalVentas = new Label();
            lblTVent = new Label();
            iconBtnRechazar = new FontAwesome.Sharp.IconButton();
            panelStockDisponible = new Panel();
            lblTotalStock = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblEstadoStock = new Label();
            panel1 = new Panel();
            lblDashInicio = new Label();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chartVentas
            // 
            chartVentas.BackColor = Color.FromArgb(34, 41, 53);
            chartArea4.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartVentas.Legends.Add(legend4);
            chartVentas.Location = new Point(0, 60);
            chartVentas.Name = "chartVentas";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartVentas.Series.Add(series4);
            chartVentas.Size = new Size(430, 182);
            chartVentas.TabIndex = 15;
            chartVentas.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Ventas del Mes ";
            chartVentas.Titles.Add(title4);
            // 
            // chartStockProductoCateogria
            // 
            chartStockProductoCateogria.BackColor = Color.FromArgb(34, 41, 53);
            chartArea5.Name = "ChartArea1";
            chartStockProductoCateogria.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chartStockProductoCateogria.Legends.Add(legend5);
            chartStockProductoCateogria.Location = new Point(0, 248);
            chartStockProductoCateogria.Name = "chartStockProductoCateogria";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chartStockProductoCateogria.Series.Add(series5);
            chartStockProductoCateogria.Size = new Size(430, 203);
            chartStockProductoCateogria.TabIndex = 16;
            chartStockProductoCateogria.Text = "chart2";
            title5.Name = "Title1";
            title5.Text = "Stock Productos por categoria";
            chartStockProductoCateogria.Titles.Add(title5);
            // 
            // chart3
            // 
            chart3.BackColor = Color.FromArgb(34, 41, 53);
            chart3.BorderlineColor = Color.FromArgb(34, 41, 53);
            chartArea6.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chart3.Legends.Add(legend6);
            chart3.Location = new Point(436, 248);
            chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.LabelBackColor = Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chart3.Series.Add(series6);
            chart3.Size = new Size(364, 203);
            chart3.TabIndex = 17;
            chart3.Text = "chartTopProductos";
            title6.Name = "Title1";
            title6.Text = "Productos Mas Vendidos";
            chart3.Titles.Add(title6);
            // 
            // panelNroClientes
            // 
            panelNroClientes.BackColor = Color.FromArgb(34, 41, 53);
            panelNroClientes.Controls.Add(lblNroCliente);
            panelNroClientes.Controls.Add(label17);
            panelNroClientes.Controls.Add(iconButton8);
            panelNroClientes.Location = new Point(680, 60);
            panelNroClientes.Name = "panelNroClientes";
            panelNroClientes.Size = new Size(120, 58);
            panelNroClientes.TabIndex = 20;
            // 
            // lblNroCliente
            // 
            lblNroCliente.AutoSize = true;
            lblNroCliente.ForeColor = Color.White;
            lblNroCliente.Location = new Point(63, 22);
            lblNroCliente.Name = "lblNroCliente";
            lblNroCliente.Size = new Size(33, 15);
            lblNroCliente.TabIndex = 19;
            lblNroCliente.Text = "valor";
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
            panelNroEmpleados.Controls.Add(lblNroEmple);
            panelNroEmpleados.Controls.Add(label15);
            panelNroEmpleados.Controls.Add(iconButton7);
            panelNroEmpleados.Location = new Point(680, 124);
            panelNroEmpleados.Name = "panelNroEmpleados";
            panelNroEmpleados.Size = new Size(120, 58);
            panelNroEmpleados.TabIndex = 21;
            // 
            // lblNroEmple
            // 
            lblNroEmple.AutoSize = true;
            lblNroEmple.ForeColor = Color.White;
            lblNroEmple.Location = new Point(54, 22);
            lblNroEmple.Name = "lblNroEmple";
            lblNroEmple.Size = new Size(33, 15);
            lblNroEmple.TabIndex = 19;
            lblNroEmple.Text = "valor";
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
            panelNroProveedores.Controls.Add(lblNroProvee);
            panelNroProveedores.Controls.Add(label13);
            panelNroProveedores.Controls.Add(iconButton6);
            panelNroProveedores.Location = new Point(680, 188);
            panelNroProveedores.Name = "panelNroProveedores";
            panelNroProveedores.Size = new Size(120, 54);
            panelNroProveedores.TabIndex = 22;
            // 
            // lblNroProvee
            // 
            lblNroProvee.AutoSize = true;
            lblNroProvee.ForeColor = Color.White;
            lblNroProvee.Location = new Point(54, 19);
            lblNroProvee.Name = "lblNroProvee";
            lblNroProvee.Size = new Size(33, 15);
            lblNroProvee.TabIndex = 19;
            lblNroProvee.Text = "valor";
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
            panelTotalCaja.Controls.Add(lblValorCaja);
            panelTotalCaja.Controls.Add(iconButton5);
            panelTotalCaja.Controls.Add(label11);
            panelTotalCaja.Location = new Point(554, 188);
            panelTotalCaja.Name = "panelTotalCaja";
            panelTotalCaja.Size = new Size(120, 54);
            panelTotalCaja.TabIndex = 25;
            // 
            // lblValorCaja
            // 
            lblValorCaja.AutoSize = true;
            lblValorCaja.ForeColor = Color.White;
            lblValorCaja.Location = new Point(54, 19);
            lblValorCaja.Name = "lblValorCaja";
            lblValorCaja.Size = new Size(33, 15);
            lblValorCaja.TabIndex = 19;
            lblValorCaja.Text = "valor";
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
            // panelCantPromociones
            // 
            panelCantPromociones.BackColor = Color.FromArgb(34, 41, 53);
            panelCantPromociones.Controls.Add(lblNroVentas);
            panelCantPromociones.Controls.Add(label9);
            panelCantPromociones.Controls.Add(iconButton4);
            panelCantPromociones.Location = new Point(554, 124);
            panelCantPromociones.Name = "panelCantPromociones";
            panelCantPromociones.Size = new Size(120, 58);
            panelCantPromociones.TabIndex = 24;
            // 
            // lblNroVentas
            // 
            lblNroVentas.AutoSize = true;
            lblNroVentas.ForeColor = Color.White;
            lblNroVentas.Location = new Point(54, 22);
            lblNroVentas.Name = "lblNroVentas";
            lblNroVentas.Size = new Size(33, 15);
            lblNroVentas.TabIndex = 19;
            lblNroVentas.Text = "valor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(42, 3);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 18;
            label9.Text = "N Ventas";
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
            panelGastos.Controls.Add(lblValorGasto);
            panelGastos.Controls.Add(iconButton3);
            panelGastos.Controls.Add(label7);
            panelGastos.Location = new Point(554, 60);
            panelGastos.Name = "panelGastos";
            panelGastos.Size = new Size(120, 58);
            panelGastos.TabIndex = 23;
            // 
            // lblValorGasto
            // 
            lblValorGasto.AutoSize = true;
            lblValorGasto.ForeColor = Color.White;
            lblValorGasto.Location = new Point(54, 22);
            lblValorGasto.Name = "lblValorGasto";
            lblValorGasto.Size = new Size(33, 15);
            lblValorGasto.TabIndex = 19;
            lblValorGasto.Text = "valor";
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
            // panelCantidadProductos
            // 
            panelCantidadProductos.BackColor = Color.FromArgb(34, 41, 53);
            panelCantidadProductos.Controls.Add(lblNroProduc);
            panelCantidadProductos.Controls.Add(label5);
            panelCantidadProductos.Controls.Add(iconButton2);
            panelCantidadProductos.Location = new Point(436, 188);
            panelCantidadProductos.Name = "panelCantidadProductos";
            panelCantidadProductos.Size = new Size(112, 54);
            panelCantidadProductos.TabIndex = 28;
            // 
            // lblNroProduc
            // 
            lblNroProduc.AutoSize = true;
            lblNroProduc.ForeColor = Color.White;
            lblNroProduc.Location = new Point(55, 19);
            lblNroProduc.Name = "lblNroProduc";
            lblNroProduc.Size = new Size(33, 15);
            lblNroProduc.TabIndex = 19;
            lblNroProduc.Text = "valor";
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
            panelTotalVentas.Controls.Add(lblTotalVentas);
            panelTotalVentas.Controls.Add(lblTVent);
            panelTotalVentas.Controls.Add(iconBtnRechazar);
            panelTotalVentas.Location = new Point(436, 60);
            panelTotalVentas.Name = "panelTotalVentas";
            panelTotalVentas.Size = new Size(112, 58);
            panelTotalVentas.TabIndex = 26;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.ForeColor = Color.White;
            lblTotalVentas.Location = new Point(54, 22);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(33, 15);
            lblTotalVentas.TabIndex = 17;
            lblTotalVentas.Text = "valor";
            // 
            // lblTVent
            // 
            lblTVent.AutoSize = true;
            lblTVent.ForeColor = Color.White;
            lblTVent.Location = new Point(42, 3);
            lblTVent.Name = "lblTVent";
            lblTVent.Size = new Size(69, 15);
            lblTVent.TabIndex = 16;
            lblTVent.Text = "Total Ventas";
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
            panelStockDisponible.Controls.Add(lblTotalStock);
            panelStockDisponible.Controls.Add(iconButton1);
            panelStockDisponible.Controls.Add(lblEstadoStock);
            panelStockDisponible.Location = new Point(436, 124);
            panelStockDisponible.Name = "panelStockDisponible";
            panelStockDisponible.Size = new Size(112, 58);
            panelStockDisponible.TabIndex = 29;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.ForeColor = Color.White;
            lblTotalStock.Location = new Point(54, 22);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(33, 15);
            lblTotalStock.TabIndex = 17;
            lblTotalStock.Text = "valor";
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
            // lblEstadoStock
            // 
            lblEstadoStock.AutoSize = true;
            lblEstadoStock.ForeColor = Color.White;
            lblEstadoStock.Location = new Point(34, 3);
            lblEstadoStock.Name = "lblEstadoStock";
            lblEstadoStock.Size = new Size(39, 15);
            lblEstadoStock.TabIndex = 16;
            lblEstadoStock.Text = "Stock ";
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
            lblDashInicio.Location = new Point(152, 0);
            lblDashInicio.Name = "lblDashInicio";
            lblDashInicio.Size = new Size(370, 45);
            lblDashInicio.TabIndex = 0;
            lblDashInicio.Text = "Estadisticas Del Mes De";
            lblDashInicio.TextAlign = ContentAlignment.MiddleCenter;
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboardInicio";
            Text = "DASHBOARD";
            Load += FrmDashboardInicio_Load;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Label lblTotalVentas;
        private Label lblTVent;
        private Label lblNroCliente;
        private Label label17;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Label lblNroEmple;
        private Label label15;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Label lblNroProvee;
        private Label label13;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Label lblValorCaja;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label lblNroVentas;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label lblValorGasto;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label lblNroProduc;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panelStockDisponible;
        private Label lblTotalStock;
        private Label lblEstadoStock;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Label lblDashInicio;
    }
}