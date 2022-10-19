using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public abstract class Account : IAccount
    {
        public Account(int number, double limit)
        {
            this.Number = number;
            this.Limit = limit;
            Account.TotalAccounts++;//Chamo pela classe pois TotalAccounts tem o valor static
        }
        private double Balance { get; set; }//Private permite o acesso apenas pela própria classe, Protected permite o acesso pela própria classe e pela classe que faça parte da herança
        public double Limit { get; private set; }
        public int Number { get; private set; }
        public static int TotalAccounts { get; set; }//static o atributo deixa de ser objeto e passa a pertencer a classe
        public static int NextTotalAccounts()
        {
            return Account.TotalAccounts + 1;
        }

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