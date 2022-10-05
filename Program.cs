using TrainingOOPBank.Models;

Console.WriteLine("Treinando POO!");

Account account = new Account(123);
Console.WriteLine($"Número da conta: {account.Number}");

account.AddLimit(2000);

account.Deposit(1000);
account.Deposit(2500);
account.Deposit(3000);

bool withdraw = account.Withdraw(20000);

if (withdraw)
{
    double balance = account.BalanceConsultationAvailable();

    Console.WriteLine($"Saldo Atual: {balance.ToString("C2")}");
    Console.WriteLine($"Limite: {account.Limit.ToString("C2")}");

}