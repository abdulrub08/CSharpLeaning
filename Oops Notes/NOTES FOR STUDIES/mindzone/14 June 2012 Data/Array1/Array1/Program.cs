using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] x = new int[3];
            int[] x = new int[] { 4, 7, 2, 3 };

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);

            }
            Console.ReadKey();
        }
    }
}
