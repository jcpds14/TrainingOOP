using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class Account
    {
        public Account(int number)
        {
            this.Number = number;
        }
        private double Balance { get; set; }
        public double Limit { get; private set; }
        public int Number { get; private set; }

        public void Deposit(double value)
        {
            this.Balance += value;
        }

        public bool Withdraw(double value)
        {
            double BalanceAvailable = this.BalanceConsultationAvailable();

            if (value > BalanceAvailable)
            {
                Console.WriteLine($"Saque acima do valor disponível em saldo.\nVocê pode sacar até: {Balance.ToString("C2")}");
                return false;
            }
            this.Balance -= value;
            Console.WriteLine($"Saque no valor de {value.ToString("C2")} efetuado com sucesso!");
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