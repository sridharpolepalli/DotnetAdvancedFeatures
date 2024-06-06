using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class IntCollection : ArrayList
    {
        public void Add(int? i)
        {
            if (i.HasValue)
            {
                base.Add(i);
            }
            else
            {
                throw new ApplicationException("Invalid value");
            }
        }
        public void Remove(int? i)
        {
            if (i.HasValue)
            {
                base.Remove(i);
            }
            else
            {
                throw new ApplicationException("Invalid value");
            }
        }
        public int? this[int position]
        {
            get
            {
                try
                {
                    return Convert.ToInt32(base[position]);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            set
            {
                if (value != null)
                    base[position] = value;
            }
        }
    }
    public class GenericCollectionDemo
    {
        //static void Main()
        //{
        //    //Without generic
        //    IntCollection ints = new IntCollection();
        //    ints.Add(10);
        //    ints.Add(12);
        //    ints.Add(34);
        //    Console.WriteLine(ints[0]);
        //    Console.WriteLine(ints.Count);
        //    ints.Remove(12);
        //    Console.WriteLine(ints.Count);
        //    ints[0] = 22;
        //    Console.WriteLine(ints[0]);
        //    Console.WriteLine("----------------------------------");
        //    //with generic
        //    MyCollection<int> ints1 = new MyCollection<int>();
        //    ints1.Add(10);
        //    ints1.Add(12);
        //    ints1.Add(34);
        //    Console.WriteLine(ints1[0]);
        //    Console.WriteLine(ints1.Count);
        //    ints1.Remove(12);
        //    Console.WriteLine(ints1.Count);
        //    ints1[0] = 22;
        //    Console.WriteLine(ints1[0]);

        //    MyCollection<float> floats = new MyCollection<float>();
        //    floats.Add(10);
        //    floats.Add(12);
        //    floats.Add(34);
        //    Console.WriteLine(floats.Count);
        //}
    }
    public class MyCollection<T> : List<T> where T : struct
    {
        public void Add(T? i)
        {
            if (i.HasValue)
            {
                base.Add(i.Value);
            }
            else
            {
                throw new ApplicationException("Invalid value");
            }
        }
        public void Remove(T? i)
        {
            if (i.HasValue)
            {
                base.Remove(i.Value);
            }
            else
            {
                throw new ApplicationException("Invalid value");
            }
        }
        public T? this[int position]
        {
            get
            {
                try
                {
                    return base[position];
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            set
            {
                if (value != null && value.HasValue)
                    base[position] = (T)value;
            }
        }
    }
}
