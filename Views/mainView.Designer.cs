namespace Sistema_contable
{
    partial class mainView
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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 141);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(315, 95);
            button1.Name = "button1";
            button1.Size = new Size(147, 34);
            button1.TabIndex = 2;
            button1.Text = "Agregar Asiento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(411, 30);
            label2.TabIndex = 1;
            label2.Text = "Registra un nuevo asiento en una fecha determinada. Los valores ingresados \r\nafectarán los resultados en el libro mayor.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar un nuevo asiento";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-2, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 130);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(315, 81);
            button2.Name = "button2";
            button2.Size = new Size(147, 34);
            button2.TabIndex = 2;
            button2.Text = "Filtrar Asientos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 39);
            label3.Name = "label3";
            label3.Size = new Size(394, 15);
            label3.TabIndex = 1;
            label3.Text = "Obtiene y administra aquellos asientos efectuados en un rango de fechas.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 9);
            label4.Name = "label4";
            label4.Size = new Size(190, 21);
            label4.TabIndex = 0;
            label4.Text = "Filtrar asientos por fecha";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 130);
            panel3.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(315, 81);
            button3.Name = "button3";
            button3.Size = new Size(147, 34);
            button3.TabIndex = 2;
            button3.Text = "Filtrar Asientos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 39);
            label5.Name = "label5";
            label5.Size = new Size(416, 15);
            label5.TabIndex = 1;
            label5.Text = "Muestra los resultados individuales de las cuentas registradas en cada asiento.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 9);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 0;
            label6.Text = "Ver libro mayor";
            // 
            // mainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(474, 401);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "mainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Contable";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Button button3;
        private Label label5;
        private Label label6;
    }
}