using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class TIAnalyst : Employee
    {
        public override void Readjust()
        {
            this.Wage += 1000;
        }

    }
}