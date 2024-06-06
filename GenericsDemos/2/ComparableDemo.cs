using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person other)
        {
            Console.WriteLine(this.Name + ":" + this.Age + "-" + other.Name + ":" + other.Age);
            if (other == null) return 1;

            // Comparison logic goes here. For instance, you could compare based on age:
            return this.Age.CompareTo(other.Age);
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Person> people = new List<Person>
        //    {
        //    new Person { Name = "John", Age = 30 },
        //    new Person { Name = "Jane", Age = 25 },
        //    new Person { Name = "Alice", Age = 27 },
        //    new Person { Name = "sss", Age = 22 },
        //    new Person { Name = "ggg", Age = 34 },
        //    new Person { Name = "hhh", Age = 56 },
        //    new Person { Name = "nnn", Age = 27 }
        //    };

        //    // Sort the list
        //    people.Sort();

        //    foreach (var person in people)
        //    {
        //        Console.WriteLine($"{person.Name}, {person.Age}");
        //    }
        //}
    }
}
