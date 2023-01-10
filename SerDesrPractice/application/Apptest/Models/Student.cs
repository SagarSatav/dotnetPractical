namespace Iacsd.Models;

[Serializable]
public class Student{

//[Required]
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string College{get;set;}
     public string Email{get;set;}
      public string Password{get;set;}

    public Student(int id,string firstname,string lastname,string college,string email,string password){
        this.Id=id;
        this.FirstName=firstname;
        this.LastName=lastname;
        this.College=college;
        this.Email=email;
        this.Password=password;

    }
}