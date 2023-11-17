using System.Diagnostics;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_contable
{
    public partial class AddAsiento : Form
    {
        ContabilidadService service;
        List<Account> accounts = new List<Account>();
        List<String> nombreCuentas = new List<String>{"Caja", "Banco", "Mercadería", "Deudores Varios", "Rodados", "Proveedores", "Instalaciones", "Muebles y Útiles", "Ventas", "Documentos a Pagar", "Alquileres", "Seguros", "Seguros", "Impuestos", "Valores a Depositar"};
        //Crear lista de strings con elementos previos
        
        public AddAsiento(ContabilidadService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainView main = new mainView();
            this.Close();
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3 && dataGridView1.Rows[0].Cells[0].Value != null)
            {
                accounts.RemoveAt(e.RowIndex);
                DataGridViewRow filaClicada = dataGridView1.Rows[e.RowIndex];
                dataGridView1.Rows.Remove(filaClicada);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AccountName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            string nombre = AccountName.Text;
            if (nombre == "" || nombre == "Seleccionar cuenta")
            {
                ErrorMessage.Text = "Debe ingresar un nombre de cuenta";
                ErrorMessage.Visible = true;
                return;
            }
            if (!nombreCuentas.Contains(nombre))
            {
                ErrorMessage.Text = "Debe ingresar un nombre de cuenta válido";
                ErrorMessage.Visible = true;
                return;
            }
            string importe = AccountAmount.Text;
            if (importe == "")
            {
                ErrorMessage.Text = "Debe ingresar un importe";
                ErrorMessage.Visible = true;
                return;
            }
            ErrorMessage.Visible = false;
            DateTime fecha = AccountDate.Value.ToUniversalTime();

            TipoCuenta destino = (TipoCuenta)(radioButton1.Checked ? TipoCuenta.Debe : TipoCuenta.Haber);

            AccountName.Text = "Seleccionar cuenta";
            AccountAmount.Text = "";
            radioButton1.Checked = true;
            accounts.Add(new Account(nombre, double.Parse(importe), destino, fecha));

            agregarFila(nombre, importe, destino);
        }

        private void agregarFila(string nombre, string importe, TipoCuenta destino)
        {
            DataGridViewRow nuevaFila = new DataGridViewRow();

            DataGridViewCell celdaNombre = new DataGridViewTextBoxCell();
            DataGridViewCell celdaDebe = new DataGridViewTextBoxCell();
            DataGridViewCell celdaHaber = new DataGridViewTextBoxCell();

            celdaNombre.Value = nombre;
            celdaDebe.Value = destino == TipoCuenta.Debe ? importe : " ";
            celdaHaber.Value = destino == TipoCuenta.Haber ? importe : " ";

            nuevaFila.Cells.Add(celdaNombre);
            nuevaFila.Cells.Add(celdaDebe);
            nuevaFila.Cells.Add(celdaHaber);

            dataGridView1.Rows.Add(nuevaFila);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seat seat = new Seat(AccountDate.Value.ToUniversalTime(), accounts);
            if (seat.TotalSeat() != 0)
            {
                ErrorMessage.Text = "El seat no está balanceado";
                ErrorMessage.Visible = true;
            }
            else
            {
                Block bloque = service.GuardarAsiento(seat);
                foreach (Account c in bloque.seat._Accounts)
                {
                    ErrorMessage.Visible = false;
                }
                mainView main = new mainView();
                this.Close();
                main.Show();
            }
        }

        private void AccountDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}