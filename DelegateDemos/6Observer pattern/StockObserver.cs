using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.Observer_pattern
{
    public class Investor
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Subscribe(Stock stock)
        {
            stock.PriceChanged += Update;
        }

        public void Unsubscribe(Stock stock)
        {
            stock.PriceChanged -= Update;
        }

        private void Update(object sender, StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"Investor {_name} notified. New stock price: {e.Price:C}");
        }
    }
}
