using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BOL;
using BLL;
namespace EStoreWebApp.Controllers;

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



    public IActionResult Login()
    {
        return View();
    }
    // public IActionResult Validate(int id,string email, string password)
    // {
        
    //     HRManager mgr1=new HRManager();
    //     List<Employee> employees=mgr1.GetallEmployees(id);
        
    //     foreach (Employee user in employees)
    //     {
    //         if (user.Email == email && user.Password == password)
    //         {
    //             return Redirect("/home/welcome");
    //         }
    //     }

    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
