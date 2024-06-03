using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("John".GetHashCode());
            string s = "John";
            Console.WriteLine(s);
            string s1 = "Jo" + "hn";
            Console.WriteLine(s1);
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine(s1.GetHashCode());
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("John", "Person");
            Console.WriteLine(pairs.Keys.First().GetHashCode());           
        }
    }
}
