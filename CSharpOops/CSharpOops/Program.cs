using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Zainul= CSharpOopsDetails;
//using Ravish = CSharpOopsMethodDetails;
using CSharpOopsDetails;

namespace CSharpOops
{
    public class Program
    {
        
        //Local Variable Stored i Stack Memory

        //Instance variable Stored in Heap Memory

        static void Main(string[] args)
        {
            MemoryDetails obj;
            obj=new MemoryDetails();
           // obj.age = 20;
            MemoryDetails m1 = new MemoryDetails(25,"Tom");
            //m1.age = 40;
            //m1.name = "Zainul";
            Console.WriteLine("User Name {0} age is {1}", obj.name, obj.age);
            Console.WriteLine("User Name {0} age is {1}", m1.name, m1.age);
            Console.ReadKey();
        }
    }
}
