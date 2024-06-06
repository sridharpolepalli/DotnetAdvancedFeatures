using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    internal class GenericMethodDemo
    {        
        public static void Swap<T1, T2>(T1 a, T2 b)
        {
            Console.WriteLine($"{a}:{b}");
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x + ":" + y);
        }
        //static void Main()
        //{
        //    GenericMethodDemo.Swap<int, string>(10, "test");
        //}
    }
}
