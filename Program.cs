using TrainingOOPBank.Models;

Console.WriteLine("Trainando POO!");

Account account = new Account();

account.AddLimit(2000);

account.Deposit(1000);
account.Deposit(2500);
account.Deposit(3000);

bool withdraw = account.Withdraw(30000);

if (withdraw)
{
    double balance = account.BalanceConsultationAvailable();

    Console.WriteLine($"Saldo: {balance}");
    Console.WriteLine($"Limite: {account.Limit}");
}