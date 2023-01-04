using Bank;

Account1 acct12=new Account1(2000);

acct12.Deposit(23242000);
float currentBalance=acct12.GetBalance1();
Console.WriteLine("current balance {0}", currentBalance);
Account1 acct=new Account1();
acct.Deposit(5);
float cB=acct.GetBalance1();
Console.WriteLine("current balance is {0}", cB);