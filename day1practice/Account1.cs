namespace Bank;
public class Account1 {
    private  float balance1;
    public Account1(){
        balance1=1000;
    }
public Account1(float Amount){
    this.balance1=Amount;
}
    // public float Balance1{
    //     get{return this.balance1;}
    //     set{this.balance1=value;}
    // }
    public void SetBalance1( float Amount){
        this.balance1=Amount;
    }
    public float GetBalance1(){
        return this.balance1;
    }
 public void Deposit(float Amount){
        this.balance1+=Amount;
    }

    

}