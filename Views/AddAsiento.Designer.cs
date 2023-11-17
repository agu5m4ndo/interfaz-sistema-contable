namespace Sistema_contable
{
    partial class AddAsiento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            addAccountingSeat = new Button();
            dataGridView1 = new DataGridView();
            NombreGrid = new DataGridViewTextBoxColumn();
            DebeGrid = new DataGridViewTextBoxColumn();
            HaberGrid = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            button5 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            AccountName = new ComboBox();
            AccountAmount = new TextBox();
            AddAccountButton = new Button();
            radioButton1 = new RadioButton();
            label4 = new Label();
            radioButton2 = new RadioButton();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            AccountDate = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            ErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // addAccountingSeat
            // 
            addAccountingSeat.BackColor = Color.FromArgb(0, 95, 184);
            addAccountingSeat.Cursor = Cursors.Hand;
            addAccountingSeat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addAccountingSeat.ForeColor = Color.White;
            addAccountingSeat.Location = new Point(27, 352);
            addAccountingSeat.Name = "addAccountingSeat";
            addAccountingSeat.Padding = new Padding(10);
            addAccountingSeat.Size = new Size(126, 45);
            addAccountingSeat.TabIndex = 5;
            addAccountingSeat.Text = "Añadir Asiento";
            addAccountingSeat.UseVisualStyleBackColor = false;
            addAccountingSeat.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreGrid, DebeGrid, HaberGrid, delete });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(27, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(422, 248);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NombreGrid
            // 
            NombreGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreGrid.HeaderText = "Nombre";
            NombreGrid.Name = "NombreGrid";
            NombreGrid.ReadOnly = true;
            NombreGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DebeGrid
            // 
            DebeGrid.HeaderText = "Debe";
            DebeGrid.Name = "DebeGrid";
            DebeGrid.ReadOnly = true;
            DebeGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
            DebeGrid.Width = 50;
            // 
            // HaberGrid
            // 
            HaberGrid.HeaderText = "Haber";
            HaberGrid.Name = "HaberGrid";
            HaberGrid.ReadOnly = true;
            HaberGrid.SortMode = DataGridViewColumnSortMode.NotSortable;
            HaberGrid.Width = 50;
            // 
            // delete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Webdings", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.NullValue = "r";
            dataGridViewCellStyle1.Padding = new Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            delete.DefaultCellStyle = dataGridViewCellStyle1;
            delete.FlatStyle = FlatStyle.Flat;
            delete.HeaderText = "";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Resizable = DataGridViewTriState.True;
            delete.Text = "";
            delete.Width = 27;
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
            panel1.TabIndex = 14;
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
            label5.Text = "Agregar Asiento";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AccountName);
            groupBox1.Controls.Add(AccountAmount);
            groupBox1.Controls.Add(AddAccountButton);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(478, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 205);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la cuenta";
            // 
            // AccountName
            // 
            AccountName.AllowDrop = true;
            AccountName.BackColor = Color.White;
            AccountName.Cursor = Cursors.Hand;
            AccountName.FormattingEnabled = true;
            AccountName.Items.AddRange(new object[] { "Caja", "Banco", "Mercadería", "Deudores Varios", "Rodados", "Proveedores", "Instalaciones", "Muebles y Útiles", "Ventas", "Documentos a Pagar", "Alquileres", "Seguros", "Impuestos", "Valores a Depositar" });
            AccountName.Location = new Point(96, 22);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(203, 23);
            AccountName.TabIndex = 0;
            AccountName.Text = "Seleccionar cuenta";
            AccountName.SelectedIndexChanged += AccountName_SelectedIndexChanged;
            // 
            // AccountAmount
            // 
            AccountAmount.Cursor = Cursors.Hand;
            AccountAmount.Location = new Point(96, 62);
            AccountAmount.Name = "AccountAmount";
            AccountAmount.Size = new Size(203, 23);
            AccountAmount.TabIndex = 2;
            // 
            // AddAccountButton
            // 
            AddAccountButton.FlatAppearance.BorderColor = Color.Silver;
            AddAccountButton.FlatStyle = FlatStyle.Flat;
            AddAccountButton.Location = new Point(22, 142);
            AddAccountButton.Name = "AddAccountButton";
            AddAccountButton.Size = new Size(113, 42);
            AddAccountButton.TabIndex = 13;
            AddAccountButton.Text = "Agregar Cuenta";
            AddAccountButton.UseVisualStyleBackColor = true;
            AddAccountButton.Click += button4_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Location = new Point(96, 104);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Debe";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 104);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 12;
            label4.Text = "Destino";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.Location = new Point(157, 104);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Haber";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 64);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "Importe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 91);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 17;
            label2.Text = "Fecha del asiento contable";
            label2.Click += label2_Click_1;
            // 
            // AccountDate
            // 
            AccountDate.Cursor = Cursors.Hand;
            AccountDate.Format = DateTimePickerFormat.Short;
            AccountDate.Location = new Point(638, 88);
            AccountDate.MaxDate = new DateTime(2099, 1, 19, 0, 0, 0, 0);
            AccountDate.MinDate = new DateTime(1970, 1, 19, 0, 0, 0, 0);
            AccountDate.Name = "AccountDate";
            AccountDate.Size = new Size(95, 23);
            AccountDate.TabIndex = 16;
            AccountDate.Value = new DateTime(2023, 11, 13, 0, 0, 0, 0);
            AccountDate.ValueChanged += AccountDate_ValueChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(170, 367);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancelar";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(240, 367);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(162, 15);
            ErrorMessage.TabIndex = 19;
            ErrorMessage.Text = "El asiento no está balanceado";
            ErrorMessage.Visible = false;
            // 
            // AddAsiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(832, 416);
            Controls.Add(ErrorMessage);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(AccountDate);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(addAccountingSeat);
            Name = "AddAsiento";
            Padding = new Padding(40);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Contable";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addAccountingSeat;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label5;
        private Button button5;
        private GroupBox groupBox1;
        private ComboBox AccountName;
        private TextBox AccountAmount;
        private Button AddAccountButton;
        private RadioButton radioButton1;
        private Label label4;
        private RadioButton radioButton2;
        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker AccountDate;
        private LinkLabel linkLabel1;
        private Label ErrorMessage;
        private DataGridViewTextBoxColumn NombreGrid;
        private DataGridViewTextBoxColumn DebeGrid;
        private DataGridViewTextBoxColumn HaberGrid;
        private DataGridViewButtonColumn delete;
    }
}