using System;

namespace Sistema_contable

{
    [Serializable]
    public class Account
    {
        private String nombre;
        private int? CuentaId;
        private double Importe;
        private TipoCuenta Tipo;
        private DateTime Fecha;
        private static int contadorId = 1;

        public string _Nombre { get => nombre; set => nombre = value; }
        public int? _CuentaId { get => CuentaId; set => CuentaId = value; }
        public TipoCuenta _Tipo { get => Tipo; }
        public double _Importe { get => Importe; set => Importe = value; }
        public DateTime _Fecha { get => Fecha; set => Fecha = value; }


        //Tipo, importe
        public Account()
        {
            this.CuentaId = contadorId++;
        }

        public Account(string nombre, double importe, TipoCuenta tipo, DateTime fecha)
        {
            this.nombre = nombre;
            this.Importe = importe;
            this.CuentaId = contadorId++;
            this.Tipo = tipo;
            this.Fecha = fecha;
        }
    }

    public enum TipoCuenta
    {
        Debe,
        Haber
    }
}