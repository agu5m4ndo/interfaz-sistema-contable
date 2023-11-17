using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_contable
{
    //REVISAR TODA LA LÓGICA DE ESTE ARCHIVO. NO DEBEN EXISTIR LAS CLASES LIBRO DIARIO NI CUENTACONTABLE.
    //CREAR LOS MÉTODOS SOLICITADOS EN LA LÍNEA 106 DE "FILTERASIENTOS" Y EN LA LÍNEA 40 DE "LIBROMAYOR",
    //55 Y 134 DE "ADDASIENTO" Y CONECTARLO CON BLOCKCHAIN.

    //REVISAR LA LÓGICA DEL MINER CON LOS CAMBIOS EFECTUADOS DE LA CLASE ACCOUNT.

    //REVISAR EL ERROR DE LA LINEA 13 Y 26 EN "SEAT".

    //CONSIDERAR ELIMINAR "MOVEMENT" Y "CUENTAMAYOR" (SI SE LES OCURRE UNA LÓGICA PIOLA PARA ESA ÚLTIMA, AGREGUENLA".
    public class ContabilidadService
    {
        public Blockchain blockchain = new Blockchain();

        public ContabilidadService()
        {
            
        }

        //falta guardar con blockchain
        public void GuardarAsiento(Seat asiento)
        {
            Block block = new Block(asiento, this.blockchain);
        }

        //Falta buscar y manejar por blockchain
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

        //Falta buscar por blockchain
        /*public List<Seat> ObtenerTodosLosAsientos()
        {
            return asientos.ToList();
        }*/

        //Falta buscar y manejar por blockchain
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

        //Revisar este código
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
