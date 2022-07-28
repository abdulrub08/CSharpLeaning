using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEWEVEOne_DArray
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] x = new int[3];
            int[] x = new int[] { 10, 3, 4 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i].ToString()+",");

            }
            Console.ReadKey();
        }
    }
}
