using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-----------Nullable demo------------");
            //NullableType.Demo();


            //Console.WriteLine("-----------yield return demo------------");
            //foreach (int number in YieldDemo.GetNumbers())
            //{
            //    Console.WriteLine(number);
            //}


            //Console.WriteLine("-----------yield break demo------------");
            //IEnumerable values = YieldDemo.GetEvenNumbers(10);
            //foreach (int number in values)
            //{
            //    Console.WriteLine(number);
            //}


            //Console.WriteLine("-----------Equals Demo------------");
            //ObjectDemo.EqualsDemo1();

            //Console.WriteLine("------------Equals Demo2----------");
            //ObjectDemo.EqualsDemo2();

            //Console.WriteLine("-----------GetType Demo------------");
            //ObjectDemo.GetTypeDemo();

            //Console.WriteLine("-----------ReferenceEquals Demo------------");
            //ObjectDemo.ReferenceEqualsDemo();

            Console.WriteLine("-----------MemberwiseClone Demo (Shallow copy)------------");
            ObjectDemo.MemberwiseCloneDemo();
        }
    }
}
