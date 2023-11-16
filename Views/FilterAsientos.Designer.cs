namespace Sistema_contable
{
    partial class FilterAsientos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button5 = new Button();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Asientos = new DataGridViewTextBoxColumn();
            deleteSeat = new DataGridViewButtonColumn();
            label3 = new Label();
            label4 = new Label();
            dataGridView3 = new DataGridView();
            NombreGrid = new DataGridViewTextBoxColumn();
            DebeGrid = new DataGridViewTextBoxColumn();
            HaberGrid = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ErrorMessage = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(0, 95, 184);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(2000, 60);
            panel1.MinimumSize = new Size(768, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 60);
            panel1.TabIndex = 15;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Wingdings 3", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(0, 3, 0, 0);
            button5.Size = new Size(46, 60);
            button5.TabIndex = 1;
            button5.Text = "f";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(324, 0);
            label5.Name = "label5";
            label5.Size = new Size(192, 60);
            label5.TabIndex = 0;
            label5.Text = "Filtrar Asientos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseWaitCursor = true;
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 88);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 16;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 88);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 17;
            label2.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(71, 84);
            dateTimePicker1.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(216, 84);
            dateTimePicker2.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 23);
            dateTimePicker2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Asientos, deleteSeat });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(28, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(373, 273);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Asientos
            // 
            Asientos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Asientos.HeaderText = "Asientos";
            Asientos.Name = "Asientos";
            Asientos.ReadOnly = true;
            Asientos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // deleteSeat
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Webdings", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.NullValue = "r";
            dataGridViewCellStyle1.Padding = new Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            deleteSeat.DefaultCellStyle = dataGridViewCellStyle1;
            deleteSeat.FlatStyle = FlatStyle.Flat;
            deleteSeat.HeaderText = "";
            deleteSeat.Name = "deleteSeat";
            deleteSeat.ReadOnly = true;
            deleteSeat.Resizable = DataGridViewTriState.True;
            deleteSeat.SortMode = DataGridViewColumnSortMode.Automatic;
            deleteSeat.Width = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 120);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 22;
            label3.Text = "Asientos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(428, 120);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 23;
            label4.Text = "Cuentas";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { NombreGrid, DebeGrid, HaberGrid });
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView3.Location = new Point(431, 148);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.ScrollBars = ScrollBars.Vertical;
            dataGridView3.Size = new Size(373, 273);
            dataGridView3.TabIndex = 24;
            // 
            // NombreGrid
            // 
            NombreGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreGrid.HeaderText = "Nombre";
            NombreGrid.Name = "NombreGrid";
            NombreGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DebeGrid
            // 
            DebeGrid.HeaderText = "Debe";
            DebeGrid.Name = "DebeGrid";
            DebeGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
            DebeGrid.Width = 50;
            // 
            // HaberGrid
            // 
            HaberGrid.HeaderText = "Haber";
            HaberGrid.Name = "HaberGrid";
            HaberGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
            HaberGrid.Width = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(334, 78);
            button1.Name = "button1";
            button1.Size = new Size(84, 34);
            button1.TabIndex = 27;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.BackColor = Color.Transparent;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(434, 88);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(211, 15);
            ErrorMessage.TabIndex = 28;
            ErrorMessage.Text = "El rango de fechas elegido no es válido";
            ErrorMessage.Visible = false;
            // 
            // FilterAsientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(833, 447);
            Controls.Add(ErrorMessage);
            Controls.Add(button1);
            Controls.Add(dataGridView3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FilterAsientos";
            Text = "FilterAsientos";
            Load += FilterAsientos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Label label5;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Asientos;
        private DataGridViewButtonColumn deleteSeat;
        private DataGridViewTextBoxColumn NombreGrid;
        private DataGridViewTextBoxColumn DebeGrid;
        private DataGridViewTextBoxColumn HaberGrid;
        private Button button1;
        private Label ErrorMessage;
    }
}