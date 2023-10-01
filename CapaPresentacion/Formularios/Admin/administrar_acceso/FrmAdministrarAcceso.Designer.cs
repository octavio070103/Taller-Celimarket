namespace CapaPresentacion.Formularios.Admin.administrar_acceso
{
    partial class FrmAdministrarAcceso
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            panel1 = new Panel();
            checkTodosFiltro = new CheckBox();
            comboEstadoFiltro = new ComboBox();
            txtFuncionalidadFiltro = new TextBox();
            lblEstadoFiltro = new Label();
            lblFuncionalidadFiltro = new Label();
            panel2 = new Panel();
            label3 = new Label();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridView1 = new DataGridView();
            colum_Visualizar = new DataGridViewTextBoxColumn();
            column_check = new DataGridViewCheckBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(229, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lista de Funcionalidades";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(checkTodosFiltro);
            panel1.Controls.Add(comboEstadoFiltro);
            panel1.Controls.Add(txtFuncionalidadFiltro);
            panel1.Controls.Add(lblEstadoFiltro);
            panel1.Controls.Add(lblFuncionalidadFiltro);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 101);
            panel1.TabIndex = 1;
            // 
            // checkTodosFiltro
            // 
            checkTodosFiltro.AutoSize = true;
            checkTodosFiltro.Location = new Point(525, 72);
            checkTodosFiltro.Name = "checkTodosFiltro";
            checkTodosFiltro.Size = new Size(97, 19);
            checkTodosFiltro.TabIndex = 39;
            checkTodosFiltro.Text = "Marcar Todos";
            checkTodosFiltro.UseVisualStyleBackColor = true;
            // 
            // comboEstadoFiltro
            // 
            comboEstadoFiltro.FormattingEnabled = true;
            comboEstadoFiltro.Location = new Point(253, 70);
            comboEstadoFiltro.Name = "comboEstadoFiltro";
            comboEstadoFiltro.Size = new Size(238, 23);
            comboEstadoFiltro.TabIndex = 38;
            comboEstadoFiltro.TextChanged += comboEstadoFiltro_TextChanged;
            // 
            // txtFuncionalidadFiltro
            // 
            txtFuncionalidadFiltro.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionalidadFiltro.ForeColor = Color.Silver;
            txtFuncionalidadFiltro.Location = new Point(12, 70);
            txtFuncionalidadFiltro.Multiline = true;
            txtFuncionalidadFiltro.Name = "txtFuncionalidadFiltro";
            txtFuncionalidadFiltro.PlaceholderText = "Nombre";
            txtFuncionalidadFiltro.Size = new Size(222, 20);
            txtFuncionalidadFiltro.TabIndex = 36;
            txtFuncionalidadFiltro.TextChanged += txtFuncionalidadFiltro_TextChanged;
            // 
            // lblEstadoFiltro
            // 
            lblEstadoFiltro.AutoSize = true;
            lblEstadoFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoFiltro.ForeColor = SystemColors.ControlLightLight;
            lblEstadoFiltro.Location = new Point(253, 53);
            lblEstadoFiltro.Name = "lblEstadoFiltro";
            lblEstadoFiltro.Size = new Size(49, 17);
            lblEstadoFiltro.TabIndex = 34;
            lblEstadoFiltro.Text = "Estado";
            // 
            // lblFuncionalidadFiltro
            // 
            lblFuncionalidadFiltro.AutoSize = true;
            lblFuncionalidadFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFuncionalidadFiltro.ForeColor = SystemColors.ControlLightLight;
            lblFuncionalidadFiltro.Location = new Point(12, 53);
            lblFuncionalidadFiltro.Name = "lblFuncionalidadFiltro";
            lblFuncionalidadFiltro.Size = new Size(95, 17);
            lblFuncionalidadFiltro.TabIndex = 31;
            lblFuncionalidadFiltro.Text = "Funcionalidad";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView4);
            panel2.Controls.Add(dataGridView3);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 349);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(23, 284);
            label3.Name = "label3";
            label3.Size = new Size(743, 10);
            label3.TabIndex = 6;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewCheckBoxColumn3 });
            dataGridView4.Location = new Point(577, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(189, 278);
            dataGridView4.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Eliminar";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            dataGridViewCheckBoxColumn3.HeaderText = "";
            dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            dataGridViewCheckBoxColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewCheckBoxColumn3.Width = 50;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewCheckBoxColumn2 });
            dataGridView3.Location = new Point(392, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(189, 278);
            dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Editar";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            dataGridViewCheckBoxColumn2.HeaderText = "";
            dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            dataGridViewCheckBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewCheckBoxColumn1 });
            dataGridView2.Location = new Point(208, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(189, 278);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Registrar";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colum_Visualizar, column_check });
            dataGridView1.Location = new Point(23, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(189, 278);
            dataGridView1.TabIndex = 2;
            // 
            // colum_Visualizar
            // 
            colum_Visualizar.HeaderText = "Visualizar";
            colum_Visualizar.Name = "colum_Visualizar";
            // 
            // column_check
            // 
            column_check.HeaderText = "";
            column_check.Name = "column_check";
            column_check.Resizable = DataGridViewTriState.True;
            column_check.SortMode = DataGridViewColumnSortMode.Automatic;
            column_check.Width = 50;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmAdministrarAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministrarAcceso";
            Text = "FrmAdministrarAcceso";
            Load += FrmAdministrarAcceso_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ComboBox comboEstadoFiltro;
        private TextBox txtFuncionalidadFiltro;
        private Label lblEstadoFiltro;
        private Label lblFuncionalidadFiltro;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colum_Visualizar;
        private DataGridViewCheckBoxColumn column_check;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Label label3;
        private CheckBox checkTodosFiltro;
        private ErrorProvider errorProvider1;
    }
}