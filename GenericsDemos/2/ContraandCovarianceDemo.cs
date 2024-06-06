using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    internal class ContraandCovarianceDemo
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
