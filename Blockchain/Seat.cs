using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sistema_contable
{
    public class Seat
    {
        private DateTime date;
        private List<Account> Accounts;
        private string hashSeat;

        public DateTime Date { get => date; set => date = value; }
        public String _HashSeat { get => hashSeat; set => hashSeat = Miner.CalculateHash(value); }
        public List<Account> _Accounts { get => Accounts; }

        public Seat()
        {

        }

        //falta el name en el constructor
        public Seat(DateTime date, List<Account> account)
        {
            string stringDate = date.ToString();
            Date = date;
            Accounts = account;
            _HashSeat = Miner.CalculateHash(stringDate);
        }



        public double TotalSeat()
        {
            double totalDebe = 0;
            double totalHaber = 0;
            foreach (Account account in Accounts)
            {
                if (account._Tipo == TipoCuenta.Debe)
                {
                    totalDebe += account._Importe;
                }
                else
                {
                    totalHaber += account._Importe;
                }
            }
            return totalDebe - totalHaber;
        }
    }

}