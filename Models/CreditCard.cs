using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public class CreditCard
    {
        public string Number { get; set; }
        public string ExpirationDate { get; set; }

        public Client Client { get; set; }

    }
}