using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOopsDetails
{
    class MemoryDetails
    {
        public int age ;
        public string name ;
        
        public MemoryDetails()
        {
            age = 20;
            name = "Test Data";
        }
        public MemoryDetails(int age, string name)
        {
            int x = 30;//Local Variable

            this.age = age;
            this.name = name;
        }
        public void TestDate()
        {

        }
        
       

    }
}
