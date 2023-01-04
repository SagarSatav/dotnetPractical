using Membership;
// give reference of Membership to test with commad reference sln
Console.WriteLine("Welcome to IACSD");
Console.WriteLine("=-=-==-==-=-=--==-=-==-=");

////taker i/p from user to check email and pass of Authmember

Console.WriteLine("Enter your email");
string email=Console.ReadLine();

Console.WriteLine("Enter your password");
string password=Console.ReadLine();

//check conditions for autharization from AuthMember
if(AuthMember.ValidateUser(email,password)){
    Console.WriteLine("you are welcome ");
    Console.WriteLine("=-=-==-==-=-=--==-=-==-=");
    Console.WriteLine("user details ");
User details=new User();
    details.display();
   
 }  
 else{
     Console.WriteLine("Invalid information ");
      Console.WriteLine("Please Fill proper Details ");
      User info=new User("Ram","Manjare","pune","545742789");
      info.display();
 }