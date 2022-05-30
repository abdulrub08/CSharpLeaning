using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Zainul= CSharpOopsDetails;
//using Ravish = CSharpOopsMethodDetails;
using CSharpOopsDetails;
using CSharpOops.Memory;
using BAL;

namespace CSharpOops
{
    public class Program
    {

        //Local Variable Stored i Stack Memory

        //Instance variable Stored in Heap Memory

        static void Main(string[] args)
        {
            #region
            // MemoryDetails obj;
            // obj=new MemoryDetails();
            //// obj.age = 20;
            // MemoryDetails m1 = new MemoryDetails(25,"Tom");
            // //m1.age = 40;
            // //m1.name = "Zainul";
            // Console.WriteLine("User Name {0} age is {1}", obj.name, obj.age);
            // Console.WriteLine("User Name {0} age is {1}", m1.name, m1.age);
            #endregion

            #region
           // Employee objs;
           //objs= new Employee();
           //objs.DisplayEmp();

            Employee obj;
            obj=new PartTimeEmployee();
            obj.DisplayEmp();
            //Employee objs = new Employee();
            //objs.DisplayEmp();



            //PartTimeEmployee obj = new PartTimeEmployee();
            //obj.DisplayEmp();
            //obj.DisplayEmpNew();
            #endregion
            Console.ReadKey();
        }
    }
}
