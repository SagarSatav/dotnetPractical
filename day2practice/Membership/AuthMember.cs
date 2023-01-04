namespace Membership;
public class AuthMember
{
    //first validate user with static bool and go to test 
public static bool ValidateUser(string email,string password){
    bool status= false;
    if(email=="satavsagar17@gmail.com" && password=="Sagar@123"){
        Console.WriteLine("Hello Sagar");
        status=true;
    }
        else if(email=="ram.manjare17@gmail.com" && password=="Ram@123"){
               Console.WriteLine("Hello Ram");
               status=true;
        }
         else{
         Console.WriteLine("You are not a student of IACSD ");
    }
    return status;
}
}
