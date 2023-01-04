namespace Membership;
public  class User{
    /*autoproperties users user details go to test*/
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Address{get;set;}
    public string MobileNo{get;set;}

    public User(string fname, string lname, string addr, string mobNo){
        this.FirstName=fname;
        this.LastName=lname;
        this.Address=addr;
        this.MobileNo=mobNo;

    }
public User(){
    FirstName="sagar";
    LastName="satav";
    Address="pune";
    MobileNo="6234555687";
}
 public void display(){
    Console.WriteLine("Firstname :"+FirstName);
     Console.WriteLine("LastName :"+LastName);
     Console.WriteLine("Address :"+Address);
      Console.WriteLine("MobileNo :"+MobileNo);
 }
}