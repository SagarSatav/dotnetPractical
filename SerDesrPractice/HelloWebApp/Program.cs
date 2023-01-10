using Iacsd;
;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
  
   List<Student>students=new List<Student>();

//   students.Add(new Student(){Id=101,FirstName="sagar",LastName="satav",College="ycce"});
//this is for annonymous classnkonwn"));

 students.Add(new Student(101,"sagar","satav","iacsd"));


//this is for constructor class



app.MapGet("/", () => "Hello World!");
 app.MapGet("/api",()=>students);
app.Run();
