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
        private Dictionary<int, CuentaContable> cuentas;
        private List<Seat> asientos;

        public ContabilidadService()
        {
            librosDiarios = new List<LibroDiario>();
            cuentas = new Dictionary<int, CuentaContable>();
            asientos = new List<Seat>();
        }

        //falta guardar con blockchain
        public void GuardarAsiento(Seat asiento)
        {
            asientos.Add(asiento);
            ObtenerLibroDiarioActual().AgregarAsiento(asiento);
        }

        //Falta buscar y manejar por blockchain
        public List<Seat> ObtenerAsientoPorFecha(DateTime fecha)
        {
            return asientos.Where(a => a.Date.Date == fecha.Date).ToList();
        }

        //Falta buscar por blockchain
        /*public List<Seat> ObtenerTodosLosAsientos()
        {
            return asientos.ToList();
        }*/

        //Falta buscar y manejar por blockchain
        public List<Seat> FiltrarAsientosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return asientos.Where(a => a.Date >= fechaInicio && a.Date <= fechaFin).ToList();
        }

        //Falta buscar y manejar por blockchain
        public void GuardarCuenta(CuentaContable cuenta)
        {
            cuentas[cuenta.CuentaId] = cuenta;
        }

        public CuentaContable ObtenerCuentaPorId(int cuentaId)
        {
            if (cuentas.ContainsKey(cuentaId))
            {
                return cuentas[cuentaId];
            }
            return null;
        }

        public List<CuentaContable> ObtenerTodasLasCuentas()
        {
            return cuentas.Values.ToList();
        }

        //Revisar este código
        public Dictionary<int, decimal> GenerarLibroMayor(int cuentaId)
        {
            Dictionary<int, decimal> libroMayor = new Dictionary<int, decimal>();

            foreach (var libroDiario in librosDiarios)
            {
                foreach (var asiento in libroDiario.Asientos)
                {
                    // Verificar si CuentaId tiene un valor antes de acceder a su propiedad Value.
                    if (asiento.CuentaId.HasValue && asiento.CuentaId.Value == cuentaId)
                    {
                        if (!libroMayor.ContainsKey(asiento.CuentaId.Value))
                        {
                            libroMayor[asiento.CuentaId.Value] = 0;
                        }

                        // Sumar al debe o al haber según el tipo de asiento.
                        libroMayor[asiento.CuentaId.Value] += asiento.Tipo == TipoCuenta.Debe ? asiento.Importe : -asiento.Importe;
                    }
                }
            }
            return libroMayor;
        }

        //Revisar este código
        private LibroDiario ObtenerLibroDiarioActual()
        {
           

            // Por ahora, simplemente crearemos un nuevo libro diario si no hay ninguno
            if (librosDiarios.Count == 0 || librosDiarios.Last().Asientos.Count >= 100) // Por ejemplo, cada libro diario tiene 100 asientos
            {
                var nuevoLibroDiario = new LibroDiario();
                librosDiarios.Add(nuevoLibroDiario);
                return nuevoLibroDiario;
            }

            return librosDiarios.Last();
        }
        public int ObtenerIdPorNombreDeCuenta(string nombreCuenta)
        {
            // Buscar en el diccionario de cuentas por nombre
            var cuenta = cuentas.Values.FirstOrDefault(c => c.Nombre == nombreCuenta);

            // Devolver el ID si se encuentra la cuenta, o un valor predeterminado si no se encuentra
            return cuenta?.CuentaId ?? -1;
        }
        public List<Account> ObtenerCuentasDeAsiento(DateTime fecha)
        {
            var asiento = asientos.FirstOrDefault(a => a.Date.Date == fecha.Date);

            if (asiento != null)
            {
                // Obtener las cuentas asociadas al asiento
                var cuentasAsiento = asiento.CuentaId == null
                    ? new List<Account>()  // En caso de que no haya ID de cuenta
                    : new List<Account> { new Account { Cuenta = ObtenerCuentaPorId(asiento.CuentaId.Value), Importe = asiento.Importe } };

                return cuentasAsiento;
            }

            return new List<Account>();
        }
    }
}
