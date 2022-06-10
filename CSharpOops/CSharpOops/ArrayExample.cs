using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class ArrayExample
    {
        string[] name = new string[3];
        string[] gender = new string[3];
        int[] age = new int[3];
        int[] salary = new int[3];

        public void addEmployee()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter The Name");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter The Gender");
                gender[i] = Console.ReadLine();
                Console.WriteLine("Enter The Age");
                age[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Salary");
                salary[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n............................\n");
            }
        }

        public void Employeedisplay()
        {
            Console.WriteLine("name\tgender\tage\tsalary");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(name[j]+"\t");
                Console.Write(gender[j] + "\t");
                Console.Write(age[j] + "\t");
                Console.WriteLine(salary[j]);
            }
        }
    }
}
