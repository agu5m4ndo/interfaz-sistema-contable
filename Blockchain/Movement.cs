namespace Sistema_contable { 
    public class Movement
    {
        public Account Account { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        public Movement()
        {
        }

        public Movement(decimal debit, decimal credit, Account account)
        {
            Debit = debit;
            Credit = credit;
            Account = account;
        }
    }
}