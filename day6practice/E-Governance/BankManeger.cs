namespace Banking;
public delegate void TaxOperation1(double amount);
public class BankManager{
   
    public void BlockAcc(double amount){
        Console.WriteLine("Your Account Blocked...");
    }

     public void SendMail(double amount){
        Console.WriteLine("Your Account Balance is low...though mail");
    }
     public void SendSMS(double amount){
        Console.WriteLine("Your Account Balance is low...though sms");
    }
}
