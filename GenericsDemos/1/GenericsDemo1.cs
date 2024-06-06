using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class Class1
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public float Add(float i, float j)
        {

            return i + j;
        }
    }
    public class Class1<T> 
    {
        public T Add(T t1, T t2) 
        {
            dynamic x = t1;
            dynamic y = t2;
            return x + y;
        }
    }
    
    public class MainClass
    {
        
        //static void Main()
        //{
        //    Class1 class1 = new Class1();
        //    Console.WriteLine(class1.Add(1, 2));
        //    Console.WriteLine(class1.Add(1.1f, 1.2f));

        //    Class1<int> c2 = new Class1<int>();
        //    Console.WriteLine(c2.Add(1, 2));

        //    Class1<float> c3 = new Class1<float>();
        //    Console.WriteLine(c3.Add(1.1f, 1.2f));
        //}
    }
}
