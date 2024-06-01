using DesignPatterns.Behavioral.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InterfaceCallbacks
            Stock stock = new Stock();
            Investor investor1 = new Investor("SSS");
            investor1.Subscribe(stock);
            Investor investor2 = new Investor("HHH");
            investor2.Subscribe(stock);

            stock.Price = 1000;
            Console.WriteLine(stock.Price);
            #endregion
            Console.ReadLine();
        }
    }
}
