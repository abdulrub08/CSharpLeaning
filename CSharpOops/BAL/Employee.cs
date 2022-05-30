using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Employee
    {
        public string name, age, mobil, gender;
        public virtual void DisplayEmp()
        {
            Console.WriteLine("Employee Details  Name:- {0} Age:- {1} Mobile:-{2} Gender:-{3}", name, age, mobil, gender);
        }
    }
}
