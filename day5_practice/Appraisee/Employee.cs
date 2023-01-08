namespace Appraisee;
using System.ComponentModel.DataAnnotations;

[Serializable] 
public class Employee
{
     [Required]
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}

    public Employee(){
        Id=1;
        FirstName="sagar";
        LastName="satav";

    }
    public Employee(int id,string firstName,string lastName){
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=lastName;
    }

}
