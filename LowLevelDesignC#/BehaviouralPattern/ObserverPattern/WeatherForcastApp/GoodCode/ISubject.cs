using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.WeatherForcastApp.GoodCode
{
    internal interface ISubject
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers();
    }
}
