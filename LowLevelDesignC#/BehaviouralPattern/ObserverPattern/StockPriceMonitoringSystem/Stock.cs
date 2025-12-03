using LowLevelDesignC_.BehaviouralPattern.ObserverPattern.StockPriceMonitoringSystem.Contractos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.StockPriceMonitoringSystem
{


    public class StockClass

    {

        public string stockSymbol;
        public double currentPrice;
        public double threesholdPrice;
        public StockClass(string symbol, double currenprice, double pric)
        {
            stockSymbol = symbol;
            currentPrice = currenprice;
            threesholdPrice= pric;
        }
    }
    internal class Stock : ISubject
    {
        public List<IObserver> listeners = new List<IObserver>();
        // public double threeSholdPricefe;
        StockClass stock;
       

        public Stock(string symbol , double currenprice ,double  price)
        {
            stock = new StockClass(symbol,price,currenprice);
            
              
        }

     
        public void AddObserver(IObserver observer)
        {
            listeners.Add(observer);
        }

        public void NotifyObserver()
        {
            throw new NotImplementedException();
        }


        public void RemoveObserver(IObserver observer)
        {
            listeners.Remove(observer);
        }
    }
}
