using TrainingOOPBank.Models;

TIAnalyst ti1 = new TIAnalyst();
Manager m1 = new Manager();
AgencyManager ag1 = new AgencyManager();
TIManager tiM1 = new TIManager();

ti1.Name = "Gustavo Sanches";
ti1.Wage = 4000;

Console.WriteLine($"O salário de {ti1.Name} é {ti1.Wage}");

ti1.Readjust();

Console.WriteLine($"O salário de {ti1.Name} reajustado foi para {ti1.Wage}");

Console.WriteLine("________________________________________________________");

m1.Name = "Ana Marques";
m1.Wage = 9000;

Console.WriteLine($"O salário de {m1.Name} é {m1.Wage}");

m1.Readjust();

Console.WriteLine($"O salário de {m1.Name} reajustado foi para {m1.Wage}");

Console.WriteLine("________________________________________________________");


ag1.Name = "Leandro dos Santos";
ag1.Wage = 10000;

Console.WriteLine($"O salário de {ag1.Name} é {ag1.Wage}");

ag1.Readjust();

Console.WriteLine($"O salário de {ag1.Name} reajustado foi para {ag1.Wage}");

Console.WriteLine("________________________________________________________");

tiM1.Name = "Jean Carlos";
tiM1.Wage = 12000;

Console.WriteLine($"O salário de {tiM1.Name} é {tiM1.Wage}");

tiM1.Readjust();

Console.WriteLine($"O salário de {tiM1.Name} reajustado foi para {tiM1.Wage}");
















/*
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