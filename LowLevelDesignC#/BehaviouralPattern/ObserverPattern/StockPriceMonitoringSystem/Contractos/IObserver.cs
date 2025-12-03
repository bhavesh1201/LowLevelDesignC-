using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.StockPriceMonitoringSystem.Contractos
{
    internal interface IObserver
    {
        void update(StockClass sc);
    }
}
