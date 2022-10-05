using TrainingOOPBank.Models;

Console.WriteLine("Trainando POO!");

Account account = new Account();

account.AddLimit(2000);

account.Deposit(1000);
account.Deposit(2500);
account.Deposit(3000);