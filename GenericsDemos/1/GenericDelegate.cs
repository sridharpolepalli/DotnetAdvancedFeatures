using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public delegate void ArithDelegate<T1,T2>(T1 arg1, T2 arg2);
    internal class GenericDelegate
    {
        public static void Add(int i1, int i2)
        {
            Console.WriteLine(i1 + i2);
        }
        public static void Add(float i1, float i2)
        {
            Console.WriteLine(i1 + i2);
        }
        //static void Main()
        //{
        //    ArithDelegate<int, int> intAddDelegate = new ArithDelegate<int, int>(Add);
        //    intAddDelegate(10, 20);
        //    ArithDelegate<float, float> floatAddDelegate = new ArithDelegate<float, float>(Add);
        //    floatAddDelegate(12.1f, 12.2f);
        //}
    }
}
