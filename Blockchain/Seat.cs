using System;
using System.Collections.Generic;

namespace Sistema_contable
{
    public class Seat
    {
        private DateTime date;
        private List<Account> Accounts = new List<Account>();


        public DateTime Date { get => date; set => date = value; }
        public string HashSeat { get => Miner.CalculateHash(hashSeat); }


        public Seat()
        {

        }

        //falta el name en el constructor
        public Seat(DateTime date, int? cuentaID, double importe)
        {
            Date = date;
            Accounts = new List<Account>();
            HashSeat = Miner.CalculateHash(name);
        }

        public Seat(DateTime _date, List<Account> _accounts)
        {
            Accounts = _accounts;
            Date = _date;
        }

        public void AgregarAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void EliminarAccount(int id)
        {
            Accounts.RemoveAt(id);
        }

        public List<Account> GetAccounts()
        {
            return Accounts;
        }

        public double TotalSeat()
        {
            double totalDebe = 0;
            double totalHaber = 0;
            foreach (Account account in Accounts)
            {
                if (account._Tipo == Tipo.Debe)
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