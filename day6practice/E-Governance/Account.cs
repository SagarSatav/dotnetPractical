namespace EGovernance;
using Taxation;
 using Banking;
public class Account{

    public double Balance{get;set;}

    public event TaxOperation1 underBalance;
    
    public event TaxOperation overBalance;

    public Account(double amount)
    {this.Balance=amount;

    }

    public void Withdraw(double amount){
        
        this.Balance-=amount;
       
        if(this.Balance <=5000){
            //raise an event   
               Console.WriteLine("you current balance :"+this.Balance);
            underBalance(this.Balance);  
            
        }
        else{
            Console.WriteLine("you current balance :"+this.Balance);
        }
        
    }


    

     public void Deposit(double amount){
        this.Balance+=amount;
    }


    public override string ToString(){
        return "Balance : "+this.Balance;
    }

 public void ProcessTax(){
        if(this.Balance >250000){
            //raise an event   
            overBalance(this.Balance);    
        }
    }

}