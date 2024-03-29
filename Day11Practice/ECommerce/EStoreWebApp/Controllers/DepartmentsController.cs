using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class DepartmentsController : Controller
{
    private readonly ILogger<DepartmentsController> _logger;

    public DepartmentsController(ILogger<DepartmentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        HRManager mgr=new HRManager();
        List<Department> departments=mgr.GetAllDepartments();
        this.ViewData["departments"]=departments;

        return View();
    }

      public IActionResult Details(int id)
    {
        
        HRManager mgr1=new HRManager();
        List<Employee> employees=mgr1.GetallEmployees(id);
        this.ViewData["employees"]=employees;

        return View();
    }


     
}
