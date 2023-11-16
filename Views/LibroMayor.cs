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
    public partial class LibroMayor : Form
    {
        List<List<Account>> listaDeListas = new List<List<Account>>();
        List<Account> listaCaja = new List<Account>();
        List<Account> listaBanco = new List<Account>();
        List<Account> listaProveedores = new List<Account>();
        public LibroMayor()
        {
            InitializeComponent();

            /*
            EJEMPLO:
            listaCaja.Add(new Account("Caja", 100.0, TipoCuenta.Debe, DateTime.Now.AddDays(-5)));
            listaCaja.Add(new Account("Caja", 50.0, TipoCuenta.Haber, DateTime.Now.AddDays(-3)));
            listaCaja.Add(new Account("Caja", 75.0, TipoCuenta.Debe, DateTime.Now.AddDays(-1)));

            listaBanco.Add(new Account("Banco", 100.0, TipoCuenta.Debe, DateTime.Now.AddDays(-10)));
            listaBanco.Add(new Account("Banco", 50.0, TipoCuenta.Haber, DateTime.Now.AddDays(-5)));

            listaProveedores.Add(new Account("Proveedores", 75.0, TipoCuenta.Debe, DateTime.Now.AddDays(-3)));
            listaProveedores.Add(new Account("Proveedores", 75.0, TipoCuenta.Haber, DateTime.Now.AddDays(-1)));

            listaDeListas.Add(listaCaja);
            listaDeListas.Add(listaBanco);
            listaDeListas.Add(listaProveedores);
            */

            //FALTA CREAR MÉTODO EN SERVICIOS PARA CARGAR DATOS DE LOS ASIENTOS GUARDADOS, FILTRAR SUS CUENTAS
            //Y COLOCARLO ACÁ

            Cargar_cuentas(listaDeListas);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainView main = new mainView();
            this.Close();
            main.Show();
        }

        private void Cargar_cuentas(List<List<Account>> cuentas)
        {
            foreach (List<Account> lista in cuentas)
            {
                DataGridViewRow nuevaFila = new DataGridViewRow();
                DataGridViewCell celdaNombre = new DataGridViewTextBoxCell();

                celdaNombre.Value = lista[0]._Nombre;

                nuevaFila.Cells.Add(celdaNombre);
                dataGridView1.Rows.Add(nuevaFila);
            }
        }
        private void Cargar_datos_cuentas(int index, List<List<Account>> cuentas)
        {
            borrar_cuentas();
            double diferencia = 0;

            foreach (Account cuenta in cuentas[index])
            {
                DataGridViewRow nuevaFila = new DataGridViewRow();

                DataGridViewCell celdaFecha = new DataGridViewTextBoxCell();
                DataGridViewCell celdaDebe = new DataGridViewTextBoxCell();
                DataGridViewCell celdaHaber = new DataGridViewTextBoxCell();

                celdaFecha.Value = cuenta._Fecha;
                celdaDebe.Value = cuenta._Tipo == TipoCuenta.Debe ? cuenta._Importe : " ";
                celdaHaber.Value = cuenta._Tipo == TipoCuenta.Haber ? cuenta._Importe : " ";

                nuevaFila.Cells.Add(celdaFecha);
                nuevaFila.Cells.Add(celdaDebe);
                nuevaFila.Cells.Add(celdaHaber);

                dataGridView3.Rows.Add(nuevaFila);

                if (cuenta._Tipo == TipoCuenta.Debe)
                {
                    diferencia += cuenta._Importe;
                }
                else
                {
                    diferencia -= cuenta._Importe;
                }
            }

            if (diferencia == 0)
            {
                resultado.Text = "0";
                resultado.ForeColor = Color.Black;
                resultado.Visible = true;
            }
            else
            {
                resultado.Text = diferencia.ToString() + " - Resultado no balanceado";
                resultado.ForeColor = Color.Red;
                resultado.Visible = true;
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
            resultado.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1 && dataGridView1.Rows[0].Cells[0].Value != null)
            {
                //asiento.eliminarCuenta(e.RowIndex);
                DataGridViewRow filaClicada = dataGridView1.Rows[e.RowIndex];
                borrar_cuentas();
                dataGridView1.Rows.Remove(filaClicada);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dataGridView1.Rows[0].Cells[0].Value != null)
            {
                Cargar_datos_cuentas(e.RowIndex, listaDeListas);
            }
        }
    }
}
