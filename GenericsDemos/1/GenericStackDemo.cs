using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class GenericStack<T>
    {
        private T[] elements;
        private int position = -1;

        public GenericStack(int size)
        {
            elements = new T[size];
        }

        public void Push(T element)
        {
            elements[++position] = element;
        }

        public T Pop()
        {
            return elements[position--];
        }
    }
    public class GenericStackDemo
    {
        //static void Main()
        //{
        //    GenericStack<int> intStack = new GenericStack<int>(10);
        //    intStack.Push(1);
        //    intStack.Push(2);
        //    int value = intStack.Pop();
        //    Console.WriteLine(value);
        //    Console.WriteLine(intStack.Pop());
        //}
    }
}
