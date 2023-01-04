using StudentsDetails;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Student s1 = new Student { RollNo = 12, FirstName = "Sagar", LastName = "Satav", College = "Iacsd" };
Student s2 = new Student { RollNo = 13, FirstName = "Ram", LastName = "Manjare", College = "Iacsd" };
Student s3 = new Student { RollNo = 14, FirstName = "Saurav", LastName = "Patil", College = "Iacsd" };
Student s4 = new Student { RollNo = 15, FirstName = "Abhishek", LastName = "Shinde", College = "Iacsd" };
Boolean exit = false;
while (!exit)
{
    Console.WriteLine("1: Insert Students \n 2: Update Students \n 3: Delete Students \n 4: search Students By rollno  ");


    Console.WriteLine("Enter Choice");
    int Choice = Console.ReadLine();
    switch (Choice)
    {
        case 1:
            Console.WriteLine("Enter students details: ");
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            break;
        case 5:
            Console.WriteLine("Display all students");
            try{
            // dynamic data type variable
            var options=new JsonSerializerOptions {IncludeFields=true};
            var studentsjson=JsonSerializer.Serialize<List<Product>>(students,options);
            string fileName=@"D:\Ram_Sagar\students.json";
            //Serialize all Flowers into json file

            File.WriteAllText(fileName,studentsjson);
            //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Student> jsonStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);
            Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Student students in jsonStudents)
            {
                Console.WriteLine($"{students.FirstName} : {students.LastName}");   
            }   
    }
   catch(Exception exp){
    
    }
    finally{ }
            break;



    }








    Console.WriteLine("Enter Students Details");
    int Roll = Console.ReadLine();

    //Student p1=new Student{ RollNo=1, Title="Gerbera", Description="Wedding flower", UnitPrice=12};
}