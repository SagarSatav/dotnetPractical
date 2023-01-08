namespace Iacsd;
public class Student{
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string College{get;set;}

    public Student(int id,string fn,string ln,string clg){
        this.Id=id;
        this.FirstName=fn;
        this.LastName=ln;
        this.College=clg;

    }
}