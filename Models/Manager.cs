using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class Manager : Employee
    {
        public override void Readjust()
        {
            this.Wage += 1150;
        }
    }
}