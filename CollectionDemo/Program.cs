using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            //HashtableDemo();

            //StackDemo();

            //QueueDemo();
        }

        private static void QueueDemo()
        {
            Queue q = new Queue();
            q.Enqueue("one");
            q.Enqueue("two");
            q.Enqueue("three");
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }

        private static void StackDemo()
        {
            Stack stack = new Stack();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
        }

        private static void HashtableDemo()
        {
            //Hashtable Months = new Hashtable();
            SortedList Months = new SortedList();
            Months.Add(1, "Jan");
            Months.Add(2, "Feb");
            Months.Add(3, "Mar");

            Console.WriteLine(Months.Count);
            Object o = Months[2];
            Console.WriteLine(o.ToString());

            IEnumerator ie = Months.Keys.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }

            IEnumerator ie1 = Months.Values.GetEnumerator();
            while (ie1.MoveNext())
            {
                Console.WriteLine(ie1.Current);
            }
            Console.WriteLine("---------------------------------------------");

            var ide = Months.GetEnumerator();

            while (ide.MoveNext())
            {
                Object o1 = ide.Current;
                if (o1 is DictionaryEntry)
                {
                    DictionaryEntry de = (DictionaryEntry)o1;
                    Console.WriteLine(de.Key + ":" + de.Value);
                }
            }
        }

        private static void ArrayListDemo()
        {
            ArrayList al = new ArrayList();
            al.Add("Product1");
            al.Add(10);
            al.Add("Product3");

            Object o = al[1];
            Console.WriteLine(o.ToString());
            object[] oa = new object[al.Count];
            al.CopyTo(oa);
            foreach (object obj in oa)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine("-------------------------");
            IEnumerator ie = al.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current.ToString());
            }

            Console.WriteLine("-------------------------");
            foreach (object obj in al)
            {
                Console.WriteLine(obj.ToString());
            }
            al.Remove(10);
            Console.WriteLine(al.Count);
            al.RemoveAt(1);
            Console.WriteLine(al.Count);
        }
    }
}
