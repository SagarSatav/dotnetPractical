namespace Iacsd.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


public class SerDesr{

    public static string fileName=@"I:\DOTNET\practicals\day8Practice\application\Apptest\student.json";

    public static List<Student>stud =new List<Student>();
    public static string SerData(int id,string firstname,string lastname,string college,string email,string password){
        stud.Add(new Student(id,firstname,lastname,college,email,password));
        var options=new JsonSerializerOptions { IncludeFields = true };
        var studentsJson = JsonSerializer.Serialize<List<Student>>(stud, options);
        System.IO.File.WriteAllText(fileName, studentsJson);
        return studentsJson;

    }

    
    public static List<Student> desrData()
    {
        string jsonString = File.ReadAllText(fileName);
        List<Student> userData = JsonSerializer.Deserialize<List<Student>>(jsonString);
        return userData;
    }
}