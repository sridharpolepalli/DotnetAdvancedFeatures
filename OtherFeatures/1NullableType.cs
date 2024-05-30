using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    public static class NullableType
    {
        public static void Demo()
        {
            int? nullableInt = null;

            // Check if nullableInt has a value
            if (nullableInt.HasValue)
                Console.WriteLine($"nullableInt has a value: {nullableInt.Value}");
            else
                Console.WriteLine("nullableInt is null.");

            int defaultInt = nullableInt == null ? 5 : nullableInt.Value;
            //null - coalescing operator
            //int defaultInt = nullableInt ?? 5;

            Console.WriteLine(defaultInt);         

        }
    }
}
