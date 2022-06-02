using CSharpOopsMethodDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOopsDetails
{
   public class A
    {
        public int age ;
        public string name ;
        
        public A()
        {
            age = 20;
            name = "Test Data";
        }
        public A(int age, string name)
        {
            int x = 30;//Local Variable

            this.age = age;
            this.name = name;
        }
        public virtual void TestDate()
        {
            Console.WriteLine("OLD Called");
        }
        
       

    }
}
