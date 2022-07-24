using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProj.Models;

namespace MVCProj.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Display()
    {
        return View(GetData());
    }
    private List<Employee> GetData()
        {
            List<Employee> _obj = new List<Employee>();
            for (int i = 0; i < 100; i++)
            {
                Employee emp = new Employee();
                emp.ID = (i + 1);
                emp.Name = "Test Data "+ (i + 1);
                emp.Designation = "Test Data Post " + (i + 1);
                emp.Salary = "Test Data Post " + (i + 1);
                emp.Department = (i + 1)%2==0?"IT":"RND";
                _obj.Add(emp);
            }
            return _obj;
        }


}
