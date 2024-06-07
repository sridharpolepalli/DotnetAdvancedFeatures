using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    internal class ContraandCovarianceDemo2
    {
        //public delegate void Action<in T>(T obj);
        //public delegate TResult Func<out TResult>();

        public static IntCollection GetData()
        {
            IntCollection ic = new IntCollection();
            ic.Add(1);
            ic.Add(2);
            return ic;
        }

        //static void Main()
        //{
        //    Action<IntCollection> action = new Action<ArrayList>((i)=>Console.WriteLine(i.Count));
        //    IntCollection ic = GetData();
        //    action(ic);

        //    Func<ArrayList> func = new Func<IntCollection>(GetData);
        //    var data = func();
        //    Console.WriteLine(data.Count);
        //}
    }
}
