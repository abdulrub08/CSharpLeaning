using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSITParse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Salary");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the Bonus");
            string b = Console.ReadLine();
            //Console.WriteLine("Total Sal ="+s+b);
            int i = int.Parse(s);
            int j = int.Parse(b);
            int k = i + j;
            //Console.WriteLine("Total sal="+k);
            Console.WriteLine("Total sal=" + (i+j));
            Console.ReadKey();

        }
    }
}
