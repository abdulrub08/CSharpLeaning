using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                char c = Convert.ToChar(i);
                Console.Write(c);
            }
            Console.ReadKey();
        }
    }
}
