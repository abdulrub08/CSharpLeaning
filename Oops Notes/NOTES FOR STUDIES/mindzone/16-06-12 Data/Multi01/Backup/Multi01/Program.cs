using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multi01
{
    class Program
    {
        //GD
        class Test
        {
            public static void P1()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                    //1000=1 sec.

                }
            }
            public static void P2()
            {
                for (int i = 11; i <= 20; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                    //1000=1 sec.

                }
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(Test.P1);
            ThreadStart ts2 = new ThreadStart(Test.P2);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
