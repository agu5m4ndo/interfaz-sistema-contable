using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_contable
{
    public class ContabilidadService
    {

        public static Blockchain blockchain = new Blockchain();

        public ContabilidadService()
        {
            
        }

        public Block GuardarAsiento(Seat asiento)
        {
            if (blockchain != null && asiento != null)
            {
                Block block = new Block(asiento, blockchain);
                blockchain.Blocks.Add(block);

                Debug.WriteLine("Cantidad de asientos: " + blockchain.Blocks.Count);
                return block;
            }

            return null;
        }


        public void EliminarAsiento(Seat asiento)
        {
            blockchain.Blocks.Remove(blockchain.Blocks.Find(x => x.seat._HashSeat == asiento._HashSeat));
        }

        public Seat ObtenerAsientoPorFecha(DateTime fecha)
        {
            foreach (var block in blockchain.Blocks)
            {
                if (block.seat.Date == fecha)
                {
                    return block.seat;
                }
            }

            return null;
        }

        public List<Seat> ObtenerTodosLosAsientos()
        {
            List<Seat> seats = new List<Seat>();

            foreach (var block in blockchain.Blocks)
            {
                seats.Add(block.seat);
            }

            return seats;
        }

        public List<Seat> FiltrarAsientosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Seat> seatsInRange = new List<Seat>();

            foreach (var block in blockchain.Blocks)
            {
                if (block.seat.Date >= fechaInicio && block.seat.Date <= fechaFin)
                {
                    seatsInRange.Add(block.seat);
                }
            }

            return seatsInRange;
        }

        public List<Account> ObtenerCuentaPorNombre(String nombre)
        {
            List<Account> cuentasNombre = new List<Account>();
            foreach (var block in blockchain.Blocks)
            {
                foreach (var cuenta in block.seat._Accounts)
                {
                    if (nombre.Equals(cuenta._Nombre))
                    {
                        cuentasNombre.Add(cuenta);
                    }
                }
            }

            return cuentasNombre;
        }

        public List<String> ObtenerTodasLasCuentas()
        {
            List<String> nombreCuenta = new List<string>();
            int cont = 0;
            foreach (var block in blockchain.Blocks)
            {
                foreach (var cuenta in block.seat._Accounts)
                {
                    if (!nombreCuenta.Contains(cuenta._Nombre))
                    {
                        nombreCuenta.Add(cuenta._Nombre);
                    }
                }
            }

            return nombreCuenta;
        }

        public List<List<Account>> GenerarLibroMayor()
        {
            List<List<Account>> listaCuentas = new List<List<Account>>();

            List<String> cuentas = ObtenerTodasLasCuentas();

            foreach (var nombre in cuentas)
            {
                listaCuentas.Add(ObtenerCuentaPorNombre(nombre));
            }

            return listaCuentas;
        }
    }
}
