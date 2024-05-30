using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{    
    internal static class YieldDemo
    {        
        public static IEnumerable GetNumbers()
        {
            yield return 1;
            Console.WriteLine("Returned 1");
            yield return 2;
            Console.WriteLine("Returned 2");
            yield return 3;
            Console.WriteLine("Returned 3");
            yield return 4;
            Console.WriteLine("Returned 4");
            yield return 5;
            Console.WriteLine("Returned 5");
        }

        public static IEnumerable GetEvenNumbers(int max)
        {

            List<int> evenNumbers = new List<int>();
            for (int i = 0; i <= max; i++)
            {
                if ((i % 2) == 0)
                {
                    evenNumbers.Add(i);
                    Console.WriteLine($"Returned {i}");
                }
            }
            return evenNumbers;


            //for (int i = 0; i <= max; i++)
            //{
            //    if ((i % 2) == 0)
            //    {
            //        yield return i;
            //        Console.WriteLine($"Returned {i}");
            //    }
            //    if (i >= 25)
            //        yield break;
            //}
        }
    }
}
