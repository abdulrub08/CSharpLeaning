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
using CSharpOops.Inheritance;
using CSharpOops.PolyMorphish;

namespace CSharpOops
{
    public class Program
    {
        int z = 10;
        //Local Variable Stored i Stack Memory

        //Instance variable Stored in Heap Memory


        static void Main(string[] args)
        {
            int b;
            int c = 9;
            PolyClass2 p1 = new PolyClass2();
            p1.change(ref c);
            /* Use of unassigned local variable 'b'
             * it is not required to initialize the parameter passed as ref
             * Before passing a variable as ref, it is required to be initialized otherwise compiler will throw error
             * ref keyword is used to pass data in bi-directional way.
             * ref keyword is used when a called method has to update the passed parameter.*/

            p1.update(out b);
            /* it is required to initialize the parameter passed as out.
             * No need to initialize variable if out keyword is used.
             * out keyword is used to get data in uni-directional way.
             * out keyword is used when a called method has to update multiple parameter passed.*/
            Console.WriteLine("Updated value is: {0}", b);
            Console.WriteLine("Changed value is: {0}", c);

            Console.ReadLine();
            ClassC obj = new ClassC();
            obj.TestA();
            obj.TestB();
            obj.TestC();

            Console.ReadLine();
            ArrayExample objemp = new ArrayExample();
            objemp.addEmployee();
            objemp.Employeedisplay();
            Console.ReadKey();
            //A obj = new B();
            //obj.TestDate();
            LearnProp objProp = new LearnProp();
            //objProp._PassingMark = 2323.434f;

            objProp.ID = 10; Console.WriteLine(objProp.ID);
            objProp.Name = "Abdul";
            //objProp.PassingMark = 19.44f; Cannot Insert cause this is Read Only Property

            //objProp.SetID(Int32.Parse(Console.ReadLine()));
            //objProp.SetName(Console.ReadLine());


            Console.WriteLine("ID:- {0} \nName:- {1} \nPassingMark:- {2} \n___passingMark:-{3}",
                objProp.ID,objProp.Name,objProp.PassingMark,objProp._PassingMark);
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

            
        }
    }
}
