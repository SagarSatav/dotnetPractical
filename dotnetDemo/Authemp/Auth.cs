namespace Authemp;
public class Auth
{
public static bool ValidateEmp(string email,string password){
    bool status=false;

    if(email=="satavsagar17@gmail.com" && password=="Sagar123"){
     status= true;
    }

    return status;

}
}
