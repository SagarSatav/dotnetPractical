using Authemp;
Console.WriteLine("Hello, World!");

Console.WriteLine("enter email");
string email=Console.ReadLine();
Console.WriteLine("enter password");
string password=Console.ReadLine();

if(Auth.ValidateEmp(email,password)){
    User details=new User();
    details.display();
}