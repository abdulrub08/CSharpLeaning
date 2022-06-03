using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;

namespace CSharpOops.Memory
{
    

    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            this.name = "Abdul Rub";
            this.age = "24 Year";
            this.mobil = "32424242424";
            this.gender = "Male";
        }

        public override void DisplayEmp()
        {
            Console.WriteLine("Employee Details\n  Name:- {0}\n Age:- {1}\n Mobile:-{2}\n Gender:-{3}", name, age, mobil, gender);
        }
        public void Test()
        {
            
        }
       
        //public void DisplayEmpNew()
        //{
        //    Console.WriteLine("Employee Details\n  Name:- {0}\n Age:- {1}\n Mobile:-{2}\n Gender:-{3}", name, age, mobil, gender);
        //}
    }
}
