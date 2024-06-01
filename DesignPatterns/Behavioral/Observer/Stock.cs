using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IPriceChangeNotifier
    {
        void Notify(string message);
    }
    public class Stock
    {
        public List<IPriceChangeNotifier> priceChangeNotifiers = new List<IPriceChangeNotifier>();
        public decimal? _price;
        public decimal? Price {
            get
            {
                return _price;
            }
            set {
                if(value.HasValue) {

                    _price = value;
                    NotifyObservers($"The price of the stock updated to : {value}" );
                }
            }
        }
        public void Subscribe(IPriceChangeNotifier notifier)
        {
            priceChangeNotifiers.Add(notifier);
        }
        public void UnSubscribe(IPriceChangeNotifier notifier)
        {
            priceChangeNotifiers.Remove(notifier);
        }

        private void NotifyObservers(string message)
        {
            foreach(var p in priceChangeNotifiers)
            {
                p.Notify(message);
            }
        }
    }

    public class Investor: IPriceChangeNotifier
    {
        string _name;
        public Investor(string name) {
            _name = name;
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }

        public void Subscribe(Stock stock)
        {
            stock.Subscribe(this);
        }
        public void UnSubscribe(Stock stock)
        {
            stock.UnSubscribe(this);
        }
    }

    public class PriceChangeNotifier : IPriceChangeNotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
