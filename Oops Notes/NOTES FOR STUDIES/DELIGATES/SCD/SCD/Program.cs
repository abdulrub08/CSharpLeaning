using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCD
{
    class Program
    {
        //GD
        //GD
        class Test
        {
            public void Print()
            {
                Console.Write("From Print");

            }
        }
        //In GD
        public delegate void xyz();
        static void Main(string[] args)
        {
            Test t = new Test();
            xyz x = new xyz(t.Print);
            x();
            Console.ReadKey();
        }
    }
}
