using Appraisee;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


Employee e1=new Employee{ Id=11, FirstName="sagar", LastName="satav"};
Employee e2=new Employee{ Id=12, FirstName="ram", LastName="manjare"};
Employee e3=new Employee{ Id=13, FirstName="shubham", LastName="gudekar"};
Employee e4=new Employee{ Id=14, FirstName="saurav", LastName="patil"};

List<Employee> emp=new List<Employee>();
emp.Add(e1);
emp.Add(e2);
emp.Add(e3);
emp.Add(e4);
    try
    {
        
        Boolean exist=false;
               Console.WriteLine("1 :insert");
        while (true)
        {
            var options=new JsonSerializerOptions {IncludeFields=true};
            var empJson=JsonSerializer.Serialize<List<Employee>>(emp,options);
            string fileName=@"I:\DOTNET\practicals\day5_practice\emp.json";
             //Serializer JSON file

            File.WriteAllText(fileName,empJson);
            //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Employee> jsonemp = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            //Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
      



              Console.WriteLine("enter choice");
        
              switch (int.Parse(Console.ReadLine()))
              {
                case 1:
                 foreach( Employee emps in jsonemp)
            {
                Console.WriteLine($"{emps.Id} : {emps.FirstName} :{emps.LastName}");   
            } 
                break;
                
               default:
               break;
              }
            
        }
      
    }
    catch (Exception exp)
    {
        
       
    }
      finally{ }