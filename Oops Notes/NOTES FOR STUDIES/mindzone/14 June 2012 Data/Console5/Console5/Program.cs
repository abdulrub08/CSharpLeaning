using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Subject1 Marks");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the Subject2 Marks");
            string s2 = Console.ReadLine();
            //Console.WriteLine("Total Marks : "+s1+s2);
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            int c = a + b;
            //Console.WriteLine("Total Marks : " + c);
            Console.WriteLine("Total Marks : " + (a+b));
            Console.ReadKey();

        }
    }
}
