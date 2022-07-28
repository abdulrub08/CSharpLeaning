using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCD
{
    class Program
    {
        //GD
        class Test
        {
            public void P1()
            {
                Console.Write("GM");
            }
            public void P2()
            {
                Console.WriteLine("    GA");
            }
        }//test
        public delegate void Dname();
        static void Main(string[] args)
        {
            Test t = new Test();
            Dname d1, d2, d3, d4, d5;
            d1 = new Dname(t.P1);
            Console.WriteLine("From d1 :");
            d1();//SCD

            //d1 = d1 + d1;


            d2 = new Dname(t.P2);
            Console.WriteLine("From d2 :");
            d2();//SCD

            d3 = d1 + d2;
            Console.WriteLine("From d3 :");
            d3();//MCD

            d4 = d3 + d3;
            Console.WriteLine("From d4 :");
            d4();//MCD

            d5 = d4 - d1;
            Console.WriteLine("From d5 :");
            d5();//MCD

            Console.ReadKey();
        }
    }
}
