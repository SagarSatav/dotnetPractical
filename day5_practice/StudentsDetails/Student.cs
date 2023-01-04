namespace StudentsDetails;
using System.ComponentModel.DataAnnotations;
//create a POCO class
[Serializable]
public class Student
{
    [Required]
        public int RollNo{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string College{get;set;}

//default constructor
    public StudentsDetails(){
        this.RollNo=101;
        this.FirstName="saurav";
        this.LastName="patil";
        this.College="iacsd";

    }
//parameterised constructor
        public StudentsDetails(int rollNo,string fname, string lname,string college){
        this.RollNo=rollNo;
        this.FirstName=fname;
        this.LastName=lname;
        this.College=college;

    }


}
