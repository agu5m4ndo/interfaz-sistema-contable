namespace Sistema_contable
{
    partial class LibroMayor
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
            dataGridView3 = new DataGridView();
            FechaGrid = new DataGridViewTextBoxColumn();
            DebeGrid = new DataGridViewTextBoxColumn();
            HaberGrid = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Cuentas = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button5 = new Button();
            label5 = new Label();
            label1 = new Label();
            resultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { FechaGrid, DebeGrid, HaberGrid });
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView3.Location = new Point(433, 109);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.ScrollBars = ScrollBars.Vertical;
            dataGridView3.Size = new Size(373, 273);
            dataGridView3.TabIndex = 28;
            // 
            // FechaGrid
            // 
            FechaGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaGrid.HeaderText = "Fecha";
            FechaGrid.Name = "FechaGrid";
            FechaGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(430, 81);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 27;
            label4.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 81);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 26;
            label3.Text = "Cuentas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cuentas });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(30, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(373, 273);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // Cuentas
            // 
            Cuentas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cuentas.HeaderText = "Cuentas";
            Cuentas.Name = "Cuentas";
            Cuentas.ReadOnly = true;
            Cuentas.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            panel1.TabIndex = 29;
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
            label5.Text = "Libro Mayor";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(430, 394);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 30;
            label1.Text = "Diferencia: ";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultado.Location = new Point(509, 394);
            resultado.Name = "resultado";
            resultado.Size = new Size(47, 20);
            resultado.TabIndex = 31;
            resultado.Text = "10000";
            resultado.Visible = false;
            // 
            // LibroMayor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 447);
            Controls.Add(resultado);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "LibroMayor";
            Text = "LibroMayor";
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn NombreGrid;
        private DataGridViewTextBoxColumn DebeGrid;
        private DataGridViewTextBoxColumn HaberGrid;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button5;
        private Label label5;
        private DataGridViewTextBoxColumn Cuentas;
        private DataGridViewButtonColumn deleteSeat;
        private DataGridViewTextBoxColumn FechaGrid;
        private Label label1;
        private Label resultado;
    }
}