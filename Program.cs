using TrainingOOPBank.Models;

Console.WriteLine("Treinando POO!");

//!AGGREGATION/AGREGAÇÃO
CreditCard creditCard = new CreditCard();

Client client = new Client();

client.Name = "Jean Carlos";

creditCard.Number = "1234567890123";
creditCard.ExpirationDate = "01/2028";

creditCard.Client = client;//This is an aggregation. Isto é uma agregação.


Console.WriteLine($"Nome do cliente: {client.Name}");
Console.WriteLine($"Número do cartão: {creditCard.Number}");
Console.WriteLine($"Data de validade do cartão: {creditCard.ExpirationDate}");
Console.WriteLine($"Nome do cliente agregado ao cartão: {creditCard.Client.Name}");































// Account account = new Account(123);
// Console.WriteLine($"Número da conta: {account.Number}");
// account.AddLimit(2000);

// account.Deposit(1000);
// account.Deposit(2500);
// account.Deposit(3000);

// bool withdraw = account.Withdraw(20000);

// if (withdraw)
// {
//     double balance = account.BalanceConsultationAvailable();

//     Console.WriteLine($"Saldo Atual: {balance.ToString("C2")}");
//     Console.WriteLine($"Limite: {account.Limit.ToString("C2")}");

// }