using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_contable
{
    public partial class mainView : Form
    {
        ContabilidadService service = new ContabilidadService();
        public mainView()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 95, 184);
            button1.ForeColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(0, 95, 184);
            button2.ForeColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(0, 95, 184);
            button3.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
            button3.ForeColor = Color.Black;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddAsiento addAsiento = new AddAsiento(service);
            this.Hide();
            addAsiento.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterAsientos filterAsientos = new FilterAsientos(service);
            this.Hide();
            filterAsientos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LibroMayor libroMayor = new LibroMayor(service);
            this.Hide();
            libroMayor.Show();
        }
    }
}
