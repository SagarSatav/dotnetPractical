namespace Taxation;

public delegate void TaxOperation(double amount);

public class CentralGov{
  

    public void DeductIncomeTax(double amount){
        Console.WriteLine("15% tax deduction");

    }
     public void DeductServiceTax(double amount){
        Console.WriteLine("10% tax deduction");
    }
     public void DeductProfessionTax(double amount){
        Console.WriteLine("20% tax deduction");
    }

}