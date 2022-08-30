using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops.PolyMorphish
{
    #region Polymorphishm
    /* Polymorphism is one of the most important OOPs concepts.
     * Its is a concept by which we can perform single task in multiple ways.
     * There are two types of polymorphism one is Compile-time polymorphism 
     * and another is run-time polymorphism.*/

    /* Method overloading is the example of compile time polymorphism and method 
     * overriding is the example of run-time polymorphism.*/
    #endregion

    internal class PolyClass
    {
        #region Function OverLoading // Compile-time Polymorphism //static binding
        public void Test(string args,string args2)
        {
            Console.WriteLine(args + " " + args2);
        }
        public string Test(string args, int args3)
        {
            return args + " " + args3;
        }
        public string Test()
        {
            return "Blank";
        }
        #endregion

        #region Function can be Override in Child Class 
        public void display()
        {
            Console.WriteLine("Overridden Method");
        }
        #endregion
    }
    internal class PolyClass2: PolyClass
    {
        #region Runtime polymorphism // dynamic binding
        public void display()
        {
            Console.WriteLine("Overridden Method");
        }
        public void update(out int a)
        {
            /*out keyword is used when a called method has to update multiple parameter passed.*/
            a = 10;
            Console.WriteLine(a);
        }
        public void change(ref int d)
        {
            d = 11;
        }        
        #endregion
    }
}

