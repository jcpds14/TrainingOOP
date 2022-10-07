using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class SavingsAccount : Account//Inherit
    {
        //Fixed Account constructor
        //Em SavingsAccount (Conta poupança) foi passado os valores como parametro necessários para o próximo construtor base que é o construtor da Account
        public SavingsAccount(int number, double limit) : base(number, limit)
        {
        }
    }
}