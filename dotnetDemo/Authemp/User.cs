namespace Authemp;
public class User{
    
    public string FirstName{get;set;}
    
    public string LastName{get;set;}
    
    public string Address{get;set;}
    
    public string MobNo{get;set;}

    public User(){
        FirstName="sagar";
        LastName="satav";
        Address="buldana";
        MobNo="9552177430";
    }

    
    public void display(){
        Console.WriteLine("FirstName :"+FirstName +" "+ "LastName : "+LastName +" "+ "Address :"+ Address + " "+"MobNo :"+MobNo);
    }

}