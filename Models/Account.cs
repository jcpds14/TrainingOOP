using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class Account
    {
        private double Balance { get; set; }
        public double Limit { get; private set; }
        public int Number { get; set; }

        public void Deposit(double value)
        {
            this.Balance += value;
        }

        public bool Withdraw(double value)
        {
            double BalanceAvailable = this.BalanceConsultationAvailable();

            if (value > BalanceAvailable)
            {
                Console.WriteLine("Saque e Saldo indisponível");
                return false;
            }
            this.Balance -= value;
            return true;
        }

        public void AddLimit(double value)
        {
            this.Limit = value;
        }

        public double BalanceConsultationAvailable()
        {
            return this.Balance + this.Limit;
        }

    }
}