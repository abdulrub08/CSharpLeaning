using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops.Constructor
{
    class ConstrutorDeatils
    {
       public static float _PI = 3.141f;
        int _Radious;
        static ConstrutorDeatils()
        {
            Console.WriteLine("static Construtor Called");
        }
        public ConstrutorDeatils(int _rdious)
        {
            Console.WriteLine("Normal Construtor Called");
            this._Radious = _rdious;
        }
        public float CalculateArea()
        {
            Console.WriteLine("PI Value is {0} ",ConstrutorDeatils._PI);
            return ConstrutorDeatils._PI * this._Radious * this._Radious;
        }
    }
}
