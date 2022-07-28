using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSITMultiDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] x=new int[3,3];
            int[,] x = new int[,]
{
{5,6,7,8},
{1,4,2,3},
{3,8,7,2}
};
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
