using EGovernance;
using Taxation;
using Banking;

CentralGov gov=new CentralGov();
//gov.DeductIncomeTax;

BankManager Bm= new BankManager();
TaxOperation itOperation= new TaxOperation(gov.DeductIncomeTax);
TaxOperation stOperation= new TaxOperation(gov.DeductServiceTax);
TaxOperation proOperation= new TaxOperation(gov.DeductProfessionTax);

TaxOperation1 baOperation= new TaxOperation1(Bm.BlockAcc);
TaxOperation1 smOperation= new TaxOperation1(Bm.SendMail);
TaxOperation1 ssOperation= new TaxOperation1(Bm.SendSMS);


Account acc1=new Account(10000);
acc1.overBalance+=itOperation;
acc1.overBalance+=stOperation;
acc1.overBalance+=proOperation;


Account acc2=new Account(10000);
acc2.underBalance+=smOperation;
acc2.underBalance+=ssOperation;
acc2.underBalance+=baOperation;





Console.WriteLine("Enter Amount to be deposited");
double amount=double.Parse(Console.ReadLine());
acc1.Deposit(amount);

Console.WriteLine("Before Tax processing");
Console.WriteLine(acc1);

acc1.ProcessTax();
Console.WriteLine("After Tax processing");
Console.WriteLine(acc1);

Console.WriteLine("Enter Amount to be withdrawl");
double amount1=double.Parse(Console.ReadLine());

Console.WriteLine("after withdrawl");
acc2.Withdraw(amount1);

//performing action
