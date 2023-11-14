namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
{
    partial class ModuloEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloEstadisticas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            pnlModuloEstadis = new Panel();
            pnlFiltro = new Panel();
            pnlBotones = new Panel();
            btnFiltroHisto = new Button();
            btnFiltroSiete = new Button();
            btnFiltroNove = new Button();
            btnFiltroTreinta = new Button();
            label5 = new Label();
            btnAplicar = new Button();
            label4 = new Label();
            label3 = new Label();
            dtpFechaFin = new DateTimePicker();
            label2 = new Label();
            dtpFechaInicio = new DateTimePicker();
            pnlContenedor = new Panel();
            chartVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlProductos = new Panel();
            lblNroProdu = new Label();
            picProductos = new PictureBox();
            lblProductos = new Label();
            pnlEmpleados = new Panel();
            lblNroEmpleados = new Label();
            picEmpleados = new PictureBox();
            lblEmpleados = new Label();
            pnlProveedores = new Panel();
            lblNroProve = new Label();
            picProveedores = new PictureBox();
            lblProveedores = new Label();
            pnlClientes = new Panel();
            lblNroClientes = new Label();
            picClientes = new PictureBox();
            lblClientes = new Label();
            pnlRecaudado = new Panel();
            label1 = new Label();
            lblTotalRecau = new Label();
            picRecaudado = new PictureBox();
            lblRecaudado = new Label();
            pnlNroVentas = new Panel();
            lblCantVentas = new Label();
            lblNroVentas = new Label();
            picNroVentas = new PictureBox();
            chartCategoriasVen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartProductosVen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlEncabezadoEsta = new Panel();
            btnReiniciar = new Button();
            label11 = new Label();
            pnlModuloEstadis.SuspendLayout();
            pnlFiltro.SuspendLayout();
            pnlBotones.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVendedores).BeginInit();
            pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductos).BeginInit();
            pnlEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmpleados).BeginInit();
            pnlProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProveedores).BeginInit();
            pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClientes).BeginInit();
            pnlRecaudado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRecaudado).BeginInit();
            pnlNroVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNroVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCategoriasVen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProductosVen).BeginInit();
            pnlEncabezadoEsta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlModuloEstadis
            // 
            pnlModuloEstadis.BackColor = Color.FromArgb(67, 68, 89);
            pnlModuloEstadis.Controls.Add(pnlFiltro);
            pnlModuloEstadis.Controls.Add(pnlContenedor);
            pnlModuloEstadis.Controls.Add(pnlEncabezadoEsta);
            pnlModuloEstadis.Dock = DockStyle.Fill;
            pnlModuloEstadis.Location = new Point(0, 0);
            pnlModuloEstadis.Name = "pnlModuloEstadis";
            pnlModuloEstadis.Size = new Size(822, 565);
            pnlModuloEstadis.TabIndex = 1;
            // 
            // pnlFiltro
            // 
            pnlFiltro.Anchor = AnchorStyles.Top;
            pnlFiltro.BackColor = SystemColors.GradientActiveCaption;
            pnlFiltro.Controls.Add(pnlBotones);
            pnlFiltro.Controls.Add(label5);
            pnlFiltro.Controls.Add(btnAplicar);
            pnlFiltro.Controls.Add(label4);
            pnlFiltro.Controls.Add(label3);
            pnlFiltro.Controls.Add(dtpFechaFin);
            pnlFiltro.Controls.Add(label2);
            pnlFiltro.Controls.Add(dtpFechaInicio);
            pnlFiltro.Location = new Point(3, 48);
            pnlFiltro.Name = "pnlFiltro";
            pnlFiltro.Size = new Size(816, 38);
            pnlFiltro.TabIndex = 4;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = SystemColors.Window;
            pnlBotones.Controls.Add(btnFiltroHisto);
            pnlBotones.Controls.Add(btnFiltroSiete);
            pnlBotones.Controls.Add(btnFiltroNove);
            pnlBotones.Controls.Add(btnFiltroTreinta);
            pnlBotones.Location = new Point(509, 6);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(291, 28);
            pnlBotones.TabIndex = 7;
            // 
            // btnFiltroHisto
            // 
            btnFiltroHisto.BackColor = Color.DarkCyan;
            btnFiltroHisto.FlatAppearance.BorderColor = Color.White;
            btnFiltroHisto.FlatAppearance.BorderSize = 0;
            btnFiltroHisto.FlatStyle = FlatStyle.Flat;
            btnFiltroHisto.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroHisto.ForeColor = SystemColors.ControlLightLight;
            btnFiltroHisto.Location = new Point(219, 0);
            btnFiltroHisto.Name = "btnFiltroHisto";
            btnFiltroHisto.Size = new Size(72, 28);
            btnFiltroHisto.TabIndex = 3;
            btnFiltroHisto.Text = "HISTORICO";
            btnFiltroHisto.UseVisualStyleBackColor = false;
            btnFiltroHisto.Click += btnFiltroHisto_Click;
            // 
            // btnFiltroSiete
            // 
            btnFiltroSiete.BackColor = Color.DarkCyan;
            btnFiltroSiete.FlatAppearance.BorderColor = Color.White;
            btnFiltroSiete.FlatAppearance.BorderSize = 0;
            btnFiltroSiete.FlatStyle = FlatStyle.Flat;
            btnFiltroSiete.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroSiete.ForeColor = SystemColors.ControlLightLight;
            btnFiltroSiete.Location = new Point(0, 0);
            btnFiltroSiete.Name = "btnFiltroSiete";
            btnFiltroSiete.Size = new Size(72, 28);
            btnFiltroSiete.TabIndex = 0;
            btnFiltroSiete.Text = "7 DIAS";
            btnFiltroSiete.UseVisualStyleBackColor = false;
            btnFiltroSiete.Click += btnFiltroSiete_Click;
            // 
            // btnFiltroNove
            // 
            btnFiltroNove.BackColor = Color.DarkCyan;
            btnFiltroNove.FlatAppearance.BorderColor = Color.White;
            btnFiltroNove.FlatAppearance.BorderSize = 0;
            btnFiltroNove.FlatStyle = FlatStyle.Flat;
            btnFiltroNove.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroNove.ForeColor = SystemColors.ControlLightLight;
            btnFiltroNove.Location = new Point(146, 0);
            btnFiltroNove.Name = "btnFiltroNove";
            btnFiltroNove.Size = new Size(72, 28);
            btnFiltroNove.TabIndex = 2;
            btnFiltroNove.Text = "90 DIAS";
            btnFiltroNove.UseVisualStyleBackColor = false;
            btnFiltroNove.Click += btnFiltroNove_Click;
            // 
            // btnFiltroTreinta
            // 
            btnFiltroTreinta.BackColor = Color.DarkCyan;
            btnFiltroTreinta.FlatAppearance.BorderColor = Color.White;
            btnFiltroTreinta.FlatAppearance.BorderSize = 0;
            btnFiltroTreinta.FlatStyle = FlatStyle.Flat;
            btnFiltroTreinta.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltroTreinta.ForeColor = SystemColors.ControlLightLight;
            btnFiltroTreinta.Location = new Point(73, 0);
            btnFiltroTreinta.Name = "btnFiltroTreinta";
            btnFiltroTreinta.Size = new Size(72, 28);
            btnFiltroTreinta.TabIndex = 1;
            btnFiltroTreinta.Text = "30 DIAS";
            btnFiltroTreinta.UseVisualStyleBackColor = false;
            btnFiltroTreinta.Click += btnFiltroTreinta_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(447, 9);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 10;
            label5.Text = "Últimos:";
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.DarkCyan;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAplicar.ForeColor = SystemColors.ControlLightLight;
            btnAplicar.Location = new Point(375, 8);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(59, 23);
            btnAplicar.TabIndex = 9;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 8);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 8;
            label4.Text = "PERIODO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(237, 7);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 7;
            label3.Text = "Fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(274, 8);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(95, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 8);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Inicio:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(136, 8);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(95, 23);
            dtpFechaInicio.TabIndex = 4;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnlContenedor.BackColor = Color.DimGray;
            pnlContenedor.Controls.Add(chartVendedores);
            pnlContenedor.Controls.Add(pnlProductos);
            pnlContenedor.Controls.Add(pnlEmpleados);
            pnlContenedor.Controls.Add(pnlProveedores);
            pnlContenedor.Controls.Add(pnlClientes);
            pnlContenedor.Controls.Add(pnlRecaudado);
            pnlContenedor.Controls.Add(pnlNroVentas);
            pnlContenedor.Controls.Add(chartCategoriasVen);
            pnlContenedor.Controls.Add(chartProductosVen);
            pnlContenedor.Location = new Point(8, 92);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(804, 461);
            pnlContenedor.TabIndex = 3;
            // 
            // chartVendedores
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartArea1";
            chartVendedores.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartVendedores.Legends.Add(legend1);
            chartVendedores.Location = new Point(14, 13);
            chartVendedores.Name = "chartVendedores";
            chartVendedores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            chartVendedores.Series.Add(series1);
            chartVendedores.Size = new Size(382, 195);
            chartVendedores.TabIndex = 7;
            chartVendedores.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Top vendedores";
            chartVendedores.Titles.Add(title1);
            // 
            // pnlProductos
            // 
            pnlProductos.BackColor = Color.White;
            pnlProductos.Controls.Add(lblNroProdu);
            pnlProductos.Controls.Add(picProductos);
            pnlProductos.Controls.Add(lblProductos);
            pnlProductos.Location = new Point(598, 152);
            pnlProductos.Name = "pnlProductos";
            pnlProductos.Size = new Size(188, 56);
            pnlProductos.TabIndex = 6;
            // 
            // lblNroProdu
            // 
            lblNroProdu.AutoSize = true;
            lblNroProdu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroProdu.Location = new Point(69, 30);
            lblNroProdu.Name = "lblNroProdu";
            lblNroProdu.Size = new Size(37, 20);
            lblNroProdu.TabIndex = 7;
            lblNroProdu.Text = "xxxx";
            lblNroProdu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picProductos
            // 
            picProductos.BackColor = Color.White;
            picProductos.Image = (Image)resources.GetObject("picProductos.Image");
            picProductos.Location = new Point(7, 6);
            picProductos.Name = "picProductos";
            picProductos.Size = new Size(56, 44);
            picProductos.SizeMode = PictureBoxSizeMode.Zoom;
            picProductos.TabIndex = 6;
            picProductos.TabStop = false;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(69, 6);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(106, 15);
            lblProductos.TabIndex = 4;
            lblProductos.Text = "Nro. de Productos:";
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.BackColor = Color.White;
            pnlEmpleados.Controls.Add(lblNroEmpleados);
            pnlEmpleados.Controls.Add(picEmpleados);
            pnlEmpleados.Controls.Add(lblEmpleados);
            pnlEmpleados.Location = new Point(598, 83);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(188, 56);
            pnlEmpleados.TabIndex = 6;
            // 
            // lblNroEmpleados
            // 
            lblNroEmpleados.AutoSize = true;
            lblNroEmpleados.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroEmpleados.Location = new Point(69, 29);
            lblNroEmpleados.Name = "lblNroEmpleados";
            lblNroEmpleados.Size = new Size(37, 20);
            lblNroEmpleados.TabIndex = 5;
            lblNroEmpleados.Text = "xxxx";
            lblNroEmpleados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picEmpleados
            // 
            picEmpleados.BackColor = Color.White;
            picEmpleados.Image = (Image)resources.GetObject("picEmpleados.Image");
            picEmpleados.Location = new Point(7, 5);
            picEmpleados.Name = "picEmpleados";
            picEmpleados.Size = new Size(56, 44);
            picEmpleados.SizeMode = PictureBoxSizeMode.Zoom;
            picEmpleados.TabIndex = 5;
            picEmpleados.TabStop = false;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(69, 5);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(110, 15);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.Text = "Nro. de Empleados:";
            // 
            // pnlProveedores
            // 
            pnlProveedores.BackColor = Color.White;
            pnlProveedores.Controls.Add(lblNroProve);
            pnlProveedores.Controls.Add(picProveedores);
            pnlProveedores.Controls.Add(lblProveedores);
            pnlProveedores.Location = new Point(404, 153);
            pnlProveedores.Name = "pnlProveedores";
            pnlProveedores.Size = new Size(188, 56);
            pnlProveedores.TabIndex = 5;
            // 
            // lblNroProve
            // 
            lblNroProve.AutoSize = true;
            lblNroProve.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroProve.Location = new Point(65, 29);
            lblNroProve.Name = "lblNroProve";
            lblNroProve.Size = new Size(37, 20);
            lblNroProve.TabIndex = 6;
            lblNroProve.Text = "xxxx";
            lblNroProve.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picProveedores
            // 
            picProveedores.BackColor = Color.White;
            picProveedores.Image = (Image)resources.GetObject("picProveedores.Image");
            picProveedores.Location = new Point(3, 5);
            picProveedores.Name = "picProveedores";
            picProveedores.Size = new Size(56, 44);
            picProveedores.SizeMode = PictureBoxSizeMode.Zoom;
            picProveedores.TabIndex = 4;
            picProveedores.TabStop = false;
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.Location = new Point(65, 5);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(117, 15);
            lblProveedores.TabIndex = 3;
            lblProveedores.Text = "Nro. de Proveedores:";
            // 
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.White;
            pnlClientes.Controls.Add(lblNroClientes);
            pnlClientes.Controls.Add(picClientes);
            pnlClientes.Controls.Add(lblClientes);
            pnlClientes.Location = new Point(404, 83);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(188, 56);
            pnlClientes.TabIndex = 5;
            // 
            // lblNroClientes
            // 
            lblNroClientes.AutoSize = true;
            lblNroClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroClientes.Location = new Point(65, 29);
            lblNroClientes.Name = "lblNroClientes";
            lblNroClientes.Size = new Size(37, 20);
            lblNroClientes.TabIndex = 4;
            lblNroClientes.Text = "xxxx";
            lblNroClientes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picClientes
            // 
            picClientes.BackColor = Color.White;
            picClientes.Image = (Image)resources.GetObject("picClientes.Image");
            picClientes.Location = new Point(3, 5);
            picClientes.Name = "picClientes";
            picClientes.Size = new Size(56, 44);
            picClientes.SizeMode = PictureBoxSizeMode.Zoom;
            picClientes.TabIndex = 2;
            picClientes.TabStop = false;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(65, 5);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(94, 15);
            lblClientes.TabIndex = 2;
            lblClientes.Text = "Nro. de Clientes:";
            // 
            // pnlRecaudado
            // 
            pnlRecaudado.BackColor = Color.White;
            pnlRecaudado.Controls.Add(label1);
            pnlRecaudado.Controls.Add(lblTotalRecau);
            pnlRecaudado.Controls.Add(picRecaudado);
            pnlRecaudado.Controls.Add(lblRecaudado);
            pnlRecaudado.Location = new Point(598, 13);
            pnlRecaudado.Name = "pnlRecaudado";
            pnlRecaudado.Size = new Size(188, 56);
            pnlRecaudado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 27);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 4;
            label1.Text = "$";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalRecau
            // 
            lblTotalRecau.AutoSize = true;
            lblTotalRecau.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRecau.Location = new Point(83, 27);
            lblTotalRecau.Name = "lblTotalRecau";
            lblTotalRecau.Size = new Size(37, 20);
            lblTotalRecau.TabIndex = 3;
            lblTotalRecau.Text = "xxxx";
            lblTotalRecau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picRecaudado
            // 
            picRecaudado.BackColor = Color.White;
            picRecaudado.Image = (Image)resources.GetObject("picRecaudado.Image");
            picRecaudado.Location = new Point(7, 3);
            picRecaudado.Name = "picRecaudado";
            picRecaudado.Size = new Size(56, 44);
            picRecaudado.SizeMode = PictureBoxSizeMode.Zoom;
            picRecaudado.TabIndex = 2;
            picRecaudado.TabStop = false;
            // 
            // lblRecaudado
            // 
            lblRecaudado.AutoSize = true;
            lblRecaudado.Location = new Point(69, 5);
            lblRecaudado.Name = "lblRecaudado";
            lblRecaudado.Size = new Size(94, 15);
            lblRecaudado.TabIndex = 2;
            lblRecaudado.Text = "Total recaudado:";
            // 
            // pnlNroVentas
            // 
            pnlNroVentas.BackColor = Color.White;
            pnlNroVentas.Controls.Add(lblCantVentas);
            pnlNroVentas.Controls.Add(lblNroVentas);
            pnlNroVentas.Controls.Add(picNroVentas);
            pnlNroVentas.Location = new Point(404, 13);
            pnlNroVentas.Name = "pnlNroVentas";
            pnlNroVentas.Size = new Size(188, 56);
            pnlNroVentas.TabIndex = 4;
            // 
            // lblCantVentas
            // 
            lblCantVentas.AutoSize = true;
            lblCantVentas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantVentas.Location = new Point(65, 27);
            lblCantVentas.Name = "lblCantVentas";
            lblCantVentas.Size = new Size(37, 20);
            lblCantVentas.TabIndex = 2;
            lblCantVentas.Text = "xxxx";
            lblCantVentas.TextAlign = ContentAlignment.MiddleRight;
            lblCantVentas.TextChanged += lblCantVentas_TextChanged;
            // 
            // lblNroVentas
            // 
            lblNroVentas.AutoSize = true;
            lblNroVentas.Location = new Point(65, 5);
            lblNroVentas.Name = "lblNroVentas";
            lblNroVentas.Size = new Size(86, 15);
            lblNroVentas.TabIndex = 1;
            lblNroVentas.Text = "Nro. de Ventas:";
            // 
            // picNroVentas
            // 
            picNroVentas.BackColor = Color.White;
            picNroVentas.Image = (Image)resources.GetObject("picNroVentas.Image");
            picNroVentas.Location = new Point(3, 5);
            picNroVentas.Name = "picNroVentas";
            picNroVentas.Size = new Size(56, 44);
            picNroVentas.SizeMode = PictureBoxSizeMode.Zoom;
            picNroVentas.TabIndex = 0;
            picNroVentas.TabStop = false;
            // 
            // chartCategoriasVen
            // 
            chartCategoriasVen.Anchor = AnchorStyles.Bottom;
            chartArea2.Name = "ChartArea1";
            chartCategoriasVen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartCategoriasVen.Legends.Add(legend2);
            chartCategoriasVen.Location = new Point(406, 221);
            chartCategoriasVen.Name = "chartCategoriasVen";
            chartCategoriasVen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartCategoriasVen.Series.Add(series2);
            chartCategoriasVen.Size = new Size(382, 237);
            chartCategoriasVen.TabIndex = 1;
            chartCategoriasVen.Text = "chart1";
            title2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Categorias más vendidas";
            chartCategoriasVen.Titles.Add(title2);
            // 
            // chartProductosVen
            // 
            chartProductosVen.Anchor = AnchorStyles.Bottom;
            chartArea3.Name = "ChartArea1";
            chartProductosVen.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartProductosVen.Legends.Add(legend3);
            chartProductosVen.Location = new Point(14, 221);
            chartProductosVen.Name = "chartProductosVen";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartProductosVen.Series.Add(series3);
            chartProductosVen.Size = new Size(382, 237);
            chartProductosVen.TabIndex = 2;
            chartProductosVen.Text = "chart2";
            title3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            title3.Name = "Title1";
            title3.Text = "Productos mas vendidos";
            chartProductosVen.Titles.Add(title3);
            // 
            // pnlEncabezadoEsta
            // 
            pnlEncabezadoEsta.BackColor = Color.FromArgb(47, 33, 75);
            pnlEncabezadoEsta.Controls.Add(btnReiniciar);
            pnlEncabezadoEsta.Controls.Add(label11);
            pnlEncabezadoEsta.Dock = DockStyle.Top;
            pnlEncabezadoEsta.Location = new Point(0, 0);
            pnlEncabezadoEsta.Name = "pnlEncabezadoEsta";
            pnlEncabezadoEsta.Size = new Size(822, 49);
            pnlEncabezadoEsta.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Anchor = AnchorStyles.None;
            btnReiniciar.BackColor = Color.BlueViolet;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = SystemColors.HighlightText;
            btnReiniciar.Location = new Point(12, 12);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(65, 30);
            btnReiniciar.TabIndex = 24;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.ImageAlign = ContentAlignment.TopCenter;
            label11.Location = new Point(234, 0);
            label11.Name = "label11";
            label11.Size = new Size(341, 45);
            label11.TabIndex = 1;
            label11.Text = "Estadísticas de ventas";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModuloEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 565);
            Controls.Add(pnlModuloEstadis);
            Name = "ModuloEstadisticas";
            Text = "ModuloEstadisticas";
            Load += ModuloEstadisticas_Load;
            pnlModuloEstadis.ResumeLayout(false);
            pnlFiltro.ResumeLayout(false);
            pnlFiltro.PerformLayout();
            pnlBotones.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVendedores).EndInit();
            pnlProductos.ResumeLayout(false);
            pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductos).EndInit();
            pnlEmpleados.ResumeLayout(false);
            pnlEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmpleados).EndInit();
            pnlProveedores.ResumeLayout(false);
            pnlProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProveedores).EndInit();
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClientes).EndInit();
            pnlRecaudado.ResumeLayout(false);
            pnlRecaudado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRecaudado).EndInit();
            pnlNroVentas.ResumeLayout(false);
            pnlNroVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNroVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCategoriasVen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProductosVen).EndInit();
            pnlEncabezadoEsta.ResumeLayout(false);
            pnlEncabezadoEsta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlModuloEstadis;
        private Panel pnlEncabezadoEsta;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosVen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoriasVen;
        private Panel pnlContenedor;
        private Panel pnlNroVentas;
        private PictureBox picNroVentas;
        private Panel pnlProductos;
        private Panel pnlEmpleados;
        private Panel pnlProveedores;
        private Panel pnlClientes;
        private Panel pnlRecaudado;
        private Label lblNroVentas;
        private Label lblProductos;
        private Label lblEmpleados;
        private Label lblProveedores;
        private Label lblClientes;
        private Label lblRecaudado;
        private PictureBox picProveedores;
        private PictureBox picClientes;
        private PictureBox picProductos;
        private PictureBox picEmpleados;
        private PictureBox picRecaudado;
        private Label lblCantVentas;
        private Label lblTotalRecau;
        private Label lblNroProdu;
        private Label lblNroEmpleados;
        private Label lblNroProve;
        private Label lblNroClientes;
        private Label label1;
        private Panel pnlFiltro;
        private DateTimePicker dtpFechaInicio;
        private Label label3;
        private DateTimePicker dtpFechaFin;
        private Label label2;
        private Label label4;
        private Button btnAplicar;
        private Panel pnlBotones;
        private Button btnFiltroNove;
        private Button btnFiltroTreinta;
        private Button btnFiltroSiete;
        private Button btnFiltroHisto;
        private Label label5;
        private Button btnReiniciar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedores;
    }
}