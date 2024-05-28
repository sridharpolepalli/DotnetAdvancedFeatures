using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public delegate int ArithDelegate(int i, int j);
    public class MulticastDelegateWithReturnType
    {
        public void DisplayAllReturnValues()
        {
            ArithDelegate ad1 = (i, j) => i + j;
            ad1 += (i, j) => i * j;
            ad1 += (i, j) =>
            {
                if (i > j)
                    return i - j;
                else
                    return j - i;
            };
            Console.WriteLine(ad1(12,13));
            Console.WriteLine("-----------------------------");
            List<int> list = new List<int>();
            foreach(ArithDelegate ad in ad1.GetInvocationList())
            {
                list.Add(ad(12,13));
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
