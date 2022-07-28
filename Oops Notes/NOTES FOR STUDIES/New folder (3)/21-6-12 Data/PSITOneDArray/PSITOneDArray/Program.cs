using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSITOneDArray
{
    class Program
    {
        static void Main(string[] args)
        {
//            int[] x = new int[3];
            int[] x = new int[]{8,2,5,9,2};
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);
            }
            Console.ReadKey();
        }
    }
}
