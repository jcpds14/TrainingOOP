using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double Wage { get; set; }

        public abstract void Readjust();//Não precisa construir um corpo pois é uma classe abstrata
    }
}