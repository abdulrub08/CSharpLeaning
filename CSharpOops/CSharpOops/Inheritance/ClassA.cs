using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops.Inheritance
{
    public class ClassA
    {
        public void TestA()
        {
            Console.Write("From : A");
        }
    }

    public class ClassB:ClassA
    {
        public void TestB()
        {
            Console.Write("From : B");
        }
    }

    public class ClassC: ClassB
    {
        public void TestC()
        {
            Console.Write("From : C");
        }
    }
}
