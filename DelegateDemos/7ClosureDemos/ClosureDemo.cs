using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.ClosureDemos
{
    public delegate void CustomDelegate();
    public class ClosureDemo
    {
        public static void Test()
        {
            List<CustomDelegate> delegateList = new List<CustomDelegate>();

            // Add delegate instances to the list with captured variable values
            for (int i = 0; i < 5; i++)
            {
                int capturedValue = i; // Capture the loop variable
                delegateList.Add(delegate
                {
                    //Console.WriteLine($"Captured value: {i}");
                    Console.WriteLine($"Captured value: {capturedValue}");
                });
            }

            // Invoke each delegate in the list
            foreach (var customDelegate in delegateList)
            {
                customDelegate();
            }
        }
    }
}

    
