namespace BOL;
using System.ComponentModel.DataAnnotations;

[Serializable]   
public class User
{

[Required]
public int User_Id{get;set;}
public String Name{get;set;}
public double Salary{get;set;}
public String Role{get;set;}
public int Appraiser_Id{get;set;}
public String Address{get;set;}
public String Mail_Id{get;set;}
 


public User(){
    
}


public User(int user_id, String name, double salary, String role, int appraiser_id, String address, String mail_id){

    this.User_Id=user_id;
    this.Name=name;
    this.Salary=salary;
    this.Role=role;
    this.Appraiser_Id=appraiser_id;
    this.Address=address;
    this.Mail_Id=mail_id;

}


}

