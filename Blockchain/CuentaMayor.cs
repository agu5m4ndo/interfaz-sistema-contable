namespace Sistema_contable
{ 
    public class CuentaMayor
    {
        private float debe;
        private float haber;

        public float _Debe { get => debe; set => debe = value; }
        public float _Haber { get => haber; set => haber = value; }

        public CuentaMayor(float debe, float haber)
        {
            _Debe = debe;
            _Haber = haber;
        }
    }
}