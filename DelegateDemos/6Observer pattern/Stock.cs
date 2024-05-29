using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos.Observer_pattern
{
    public delegate void StockPriceChangedHandler(object sender, StockPriceChangedEventArgs e);

    public class StockPriceChangedEventArgs : EventArgs
    {
        public decimal Price { get; }

        public StockPriceChangedEventArgs(decimal price)
        {
            Price = price;
        }
    }

    public class Stock
    {
        private decimal _price;

        // Define the event using the custom delegate
        public event StockPriceChangedHandler PriceChanged;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPriceChanged(new StockPriceChangedEventArgs(_price));
                }
            }
        }

        protected virtual void OnPriceChanged(StockPriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }
}
