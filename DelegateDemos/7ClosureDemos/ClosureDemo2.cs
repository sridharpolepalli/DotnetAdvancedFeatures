using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.ClosureDemos
{
    public delegate int CounterDelegate();
    internal class ClosureDemo2
    {
        static CounterDelegate counter = CreateCounter(10);
        public static void Test()
        {
            // Call CreateCounter with an initial value of 10
            //CounterDelegate counter = CreateCounter(10);

            // Use the counter
            Console.WriteLine(counter()); // Output: 11
            Console.WriteLine(counter()); // Output: 12
            Console.WriteLine(counter()); // Output: 13
        }

        // Method that returns a custom delegate which acts as a counter
        public static CounterDelegate CreateCounter(int start)
        {
            // Variable to be captured by the closure
            int count = start;

            // Return a lambda expression that increments and returns the count
            return delegate ()
            {
                start++;
                return start;
            };
        }
    }
}


