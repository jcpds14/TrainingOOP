using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public abstract class Employee //Classe abstrata não pode ser instanciada, apenas herdada
    {
        private string Name { get; set; }
        public double Wage { get; protected set; }

        public abstract void Readjust();//Não precisa construir um corpo pois é uma classe abstrata

        public void AddName(string name, string lastname)
        {
            string fullName = $"{name} {lastname}";
            this.Name = fullName;
        }
        public void AddWage(double wage)
        {
            this.Wage = wage;
        }
    }
}