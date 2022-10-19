using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingOOPBank.Models
{
    public interface IAccount //Vai criar um padrão de contrato onde obriga todas as classes que impletam a interface a seguir essas assinaturas
    {
        void Deposit(double value);
        bool Withdraw(double value);
        void AddLimit(double value);
        double BalanceConsultationAvailable();
    }
}