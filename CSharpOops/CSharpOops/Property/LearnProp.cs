using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops.Property
{
   public class LearnProp
    {
       private int Id;
       private string name;
       private float passinmark=33.3f;
       public float ___passingMark;
       

       public string Name
       {
           set
           {
               if(string.IsNullOrWhiteSpace(value)){
                   Console.WriteLine("Name Canno Be Null");
                   this.name = "No Name";
               }
               else
               {
                   this.name = value;
               }
           }
           get
           {
               return this.name;
           }
       }

       public int ID
       {
           set
           {
               if (value<=0)
               {
                   Console.WriteLine("ID Cannot be Less Then or Equal to Zero(0)!");
                   this.Id = 0;
               }
               else
               {
                   this.Id = value;
               }
           }
           get
           {
               return this.Id;
           }
       }

       public float _PassingMark 
       {
           set{
               this.___passingMark = 32.444f;
           }
           get
           {
               return this.___passingMark;
               
           }
       }
       public float PassingMark
       {
           get
           {
             return  this.passinmark;
           }
       }
      

       #region
       //public void SetID(int id)
       //{
       //    if(id<=0){
       //        Console.WriteLine("ID is wrong Please Input grater then Zero(0) value");
       //        id = 0;
       //    }
       //    this.Id = id;
       //}
       //public int GetID()
       //{
       //    return this.Id;
       //}
       //public void SetName(string name)
       //{
       //    if(string.IsNullOrWhiteSpace(name)){
       //        name = "No Name";
       //    }
       //    this.name = name;
       //}
       //public string GetName()
       //{
       //   return this.name;
       //}
       //public float GetPassingMark()
       //{
       //    return this.passinmark;
       //}
       #endregion

    }
}
