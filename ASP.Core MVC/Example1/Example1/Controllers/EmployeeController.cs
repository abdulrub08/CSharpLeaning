using Microsoft.AspNetCore.Mvc;
using Example1.Models;

namespace Example1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult ViewEmployee()
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
                _obj.Add(emp);
            }
            return _obj;
        }
    }
}
