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

       public void SetID(int id)
       {
           if(id<=0){
               Console.WriteLine("ID is wrong Please Input grater then Zero(0) value");
               id = 0;
           }
           this.Id = id;
       }
       public int GetID()
       {
           return this.Id;
       }
       public void SetName(string name)
       {
           if(string.IsNullOrWhiteSpace(name)){
               name = "No Name";
           }
           this.name = name;
       }
       public string GetName()
       {
          return this.name;
       }
       public float GetPassingMark()
       {
           return this.passinmark;
       }

    }
}
