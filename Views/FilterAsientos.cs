using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_contable
{
    public partial class FilterAsientos : Form
    {
        List<Seat> seat;
        ContabilidadService servicio;
        public FilterAsientos(ContabilidadService servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void Cargar_datos_asientos(List<Seat> seat)
        {
            foreach (Seat asiento in seat)
            {
                dataGridView1.Rows.Add(asiento.Date);
            }
        }
        private void Cargar_datos_cuentas(Seat seat)
        {
            borrar_cuentas();
             
            foreach (Account cuenta in seat._Accounts)
            {
                DataGridViewRow nuevaFila = new DataGridViewRow();

                DataGridViewCell celdaNombre = new DataGridViewTextBoxCell();
                DataGridViewCell celdaDebe = new DataGridViewTextBoxCell();
                DataGridViewCell celdaHaber = new DataGridViewTextBoxCell();

                celdaNombre.Value = cuenta._Nombre;
                celdaDebe.Value = cuenta._Tipo == TipoCuenta.Debe ? cuenta._Importe : " ";
                celdaHaber.Value = cuenta._Tipo == TipoCuenta.Haber ? cuenta._Importe : " ";

                nuevaFila.Cells.Add(celdaNombre);
                nuevaFila.Cells.Add(celdaDebe);
                nuevaFila.Cells.Add(celdaHaber);

                dataGridView3.Rows.Add(nuevaFila);
            }
        }

        private void borrar_cuentas()
        {
            int totalFilas = dataGridView3.Rows.Count;
            if (totalFilas > 1)
            {
                for (int i = 0; i < totalFilas; i++)
                {
                    dataGridView3.Rows.RemoveAt(0);
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FilterAsientos_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainView main = new mainView();
            this.Close();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1 && dataGridView1.Rows[0].Cells[0].Value != null)
            {
                DataGridViewRow filaClicada = dataGridView1.Rows[e.RowIndex];
                borrar_cuentas();
                 
                dataGridView1.Rows.Remove(filaClicada);

                //FALTA MÉTODO PARA ELIMINAR UN ASIENTO DE LA BLOCKCHAIN DESDE EL SERVICIO
                servicio.EliminarAsiento(seat[e.RowIndex]);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dataGridView1.Rows[0].Cells[0].Value != null)
            {
                Cargar_datos_cuentas(seat[e.RowIndex]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                ErrorMessage.Visible = true;
            }
            else
            {
                ErrorMessage.Visible = false;
                borrar_cuentas();
                 
                dataGridView1.Rows.Clear();
                seat = servicio.FiltrarAsientosEntreFechas(dateTimePicker1.Value, dateTimePicker2.Value);
                foreach (Seat asiento in seat)
                {
                    Debug.WriteLine(asiento._Accounts[0]._Nombre);
                }
/*
                List<Seat> asientosFiltrados = new List<Seat>();
                foreach (Seat asiento in seat)
                {
                    if (asiento.Date >= dateTimePicker1.Value && asiento.Date <= dateTimePicker2.Value)
                    {
                        asientosFiltrados.Add(asiento);
                    }
                }
*/
                Cargar_datos_asientos(seat);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
