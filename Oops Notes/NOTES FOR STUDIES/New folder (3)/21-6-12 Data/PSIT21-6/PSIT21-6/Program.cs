using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIT21_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 90;
            //int i = b;
            int i = 90;
            //byte b = i;//error
            byte b = (byte)i;
            Console.Write(b);
            Console.ReadKey();
        }
    }
}
