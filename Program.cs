using TrainingOOPBank.Models;

SavingsAccount cp1 = new SavingsAccount(001, 100);

cp1.Deposit(100);
cp1.Withdraw(10);

double balance = cp1.BalanceConsultationAvailable();

Console.WriteLine($"O Saldo da conta poupança é: {balance.ToString("C2")}");

Account ac1 = new Account(002, 200);

ac1.Deposit(600);
ac1.Withdraw(200);

double balanceCorrentAccount = ac1.BalanceConsultationAvailable();

Console.WriteLine($"Saldo conta corrente: {balanceCorrentAccount.ToString("C2")}");




















/*

Console.WriteLine("Treinando POO!");

Account account1 = new Account(123, 500);
Account account2 = new Account(456, 600);
Account account3 = new Account(789, 700);
Account account4 = new Account(012, 800);

Console.WriteLine($"Total de contas criadas: {Account.TotalAccounts}");

int total = Account.NextTotalAccounts();

Console.WriteLine($"Próximo conta será: {total}");



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

*/