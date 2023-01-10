using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Apptest.Models;
using Iacsd.Models;
namespace Apptest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult Login()
    {
        return View();
    }
//email and password comming from form of name
        public IActionResult Validate(string email,string password){
            List<Student> userData=SerDesr.desrData();

            foreach(Student user in userData){
                if(user.Email==email && user.Password==password){
                return Redirect("/home/welcome");
            }
            }
         
            return View();
        }
    
         public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Register(){
        
        return View();
    }

     public IActionResult Postregister(int id,string firstname,string lastname,string college,string email,string password){
        
        SerDesr.SerData(id,firstname,lastname,college,email,password);
        return Redirect("/Home/Login");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
