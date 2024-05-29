using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.Observer_pattern
{
    internal class ObserverPatternMain
    {
        static void Main()
        {
            // Create a new stock and investors
            Stock stock = new Stock();
            Investor investor1 = new Investor("John");
            Investor investor2 = new Investor("Jane");

            // Subscribe investors to the stock's price change event
            investor1.Subscribe(stock);
            investor2.Subscribe(stock);

            // Change the stock price, which will notify the investors
            stock.Price = 120.10m;
            stock.Price = 121.00m;

            // Unsubscribe an investor and change the stock price again
            investor1.Unsubscribe(stock);
            stock.Price = 122.50m;
            Console.ReadLine();
        }
    }
}
