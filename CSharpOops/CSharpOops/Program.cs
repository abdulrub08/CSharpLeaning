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
using CSharpOops.Constructor;
using CSharpOopsMethodDetails;
using CSharpOops.Property;

namespace CSharpOops
{
    public class Program
    {
        int z = 10;
        //Local Variable Stored i Stack Memory

        //Instance variable Stored in Heap Memory


        static void Main(string[] args)
        {
            //A obj = new B();
            //obj.TestDate();
            LearnProp objProp = new LearnProp();
            objProp.SetID(Int32.Parse(Console.ReadLine()));
            objProp.SetName(Console.ReadLine());

            Console.WriteLine("ID:- {0} Name:- {1} PassingMark:- {2} ",objProp.GetID(),objProp.GetName(),objProp.GetPassingMark());
            Console.ReadLine();

            #region Static Class Member
            //ConstrutorDeatils obj = new ConstrutorDeatils(5);
            //ConstrutorDeatils._PI = 4.555f;
            //float _Area1 = obj.CalculateArea();
            //Console.WriteLine(_Area1);

            //ConstrutorDeatils obj2 = new ConstrutorDeatils(6);
            //float _Area2 = obj2.CalculateArea();
            //Console.WriteLine(_Area2);


            Console.ReadKey();


            #endregion

            #region
            //MemoryDetails obj;
            //obj = new MemoryDetails();
            //// obj.age = 20;
            //MemoryDetails m1 = new MemoryDetails(25, "Tom");
            ////m1.age = 40;
            ////m1.name = "Zainul";
            //Console.WriteLine("User Name {0} age is {1}", obj.name, obj.age);
            //Console.WriteLine("User Name {0} age is {1}", m1.name, m1.age);
            #endregion

            #region
            // Employee objs;
            //objs= new Employee();
            //objs.DisplayEmp();

            //Employee obj;
            //obj=new PartTimeEmployee();
            //obj.DisplayEmp();
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
