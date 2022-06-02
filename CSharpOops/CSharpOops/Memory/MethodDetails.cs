using CSharpOopsDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOopsMethodDetails
{
   public class B:A
    {
       int _a = 10;
       public B()
       {

       }
       public void Display(int a, int b)
       {
           this._a = a + b;
       }
       public override void TestDate()
       {
           base.TestDate();
           Console.WriteLine("NEW Called");
       }
    }
}
