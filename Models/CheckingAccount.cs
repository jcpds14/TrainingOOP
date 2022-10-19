using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(int number, double limit) : base(number, limit)
        {
        }
    }
}