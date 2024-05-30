using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    internal class ObjectDemo
    {
        public static void EqualsDemo1()
        {
            Person person1 = new Person { FirstName = "John", LastName = "Doe" };
            Person person2 = new Person { FirstName = "John", LastName = "Doe" };
            Person person3 = person1;

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));

            Console.WriteLine("person1:" + person1.GetHashCode());
            Console.WriteLine("person2:" + person2.GetHashCode());
            Console.WriteLine("person3:" + person3.GetHashCode());

        }

        public static void EqualsDemo2()
        {
            Employee employee1 = new Employee { FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { FirstName = "John", LastName = "Doe" };
            Employee employee3 = employee1;

            Console.WriteLine(employee1.Equals(employee2));
            Console.WriteLine(employee1.Equals(employee3));

            Console.WriteLine("employee1:" + employee1.GetHashCode());
            Console.WriteLine("employee2:" + employee2.GetHashCode());
            Console.WriteLine("employee3:" + employee3.GetHashCode());

            Employee employee4 = new Employee { FirstName = "Scott", LastName = "T" };
            Console.WriteLine(employee1.Equals(employee4));
        }

        public static void GetTypeDemo()
        {
            int number = 42;
            Type t = number.GetType();
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Assembly.FullName);
            MethodInfo[] methodInfo = t.GetMethods();
            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine(method.Name);
                var PI = method.GetParameters();
                foreach (var param in PI)
                {
                    Console.WriteLine($"----Name:{param.Name}---Type:{param.ParameterType.Name}");
                }
            }
        }

        public static void ReferenceEqualsDemo()
        {
            Person person1 = new Person { FirstName = "John", LastName = "Doe" };
            Person person2 = new Person { FirstName = "John", LastName = "Doe" };
            Person person3 = person1;

            Console.WriteLine(Object.ReferenceEquals(person1, person2));
            Console.WriteLine(Object.ReferenceEquals(person1, person3));
        }
        public static void MemberwiseCloneDemo()
        {
            Book book1 = new Book { Title = "Original Title", Author = new Author { Name = "Original Author" } };
            Book book2 = book1.ShallowCopy();

            Console.WriteLine($"Book1 Title: {book1.Title}, Author: {book1.Author.Name}");
            Console.WriteLine($"Book2 Title: {book2.Title}, Author: {book2.Author.Name}");

            book2.Title = "Modified Title";
            book2.Author.Name = "Modified Author";

            Console.WriteLine($"Book1 Title: {book1.Title}, Author: {book1.Author.Name}");
            Console.WriteLine($"Book2 Title: {book2.Title}, Author: {book2.Author.Name}");
        }
    }
}
