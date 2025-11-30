using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.WeatherForcastApp.GoodCode
{
    internal  class WeatherForcase : ISubject
    {
        public float temp { get; set; }

        public List<IObserver> observers = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach(var observer in this.observers)
            {
                observer.Update(this.temp);
            }   
        }

        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
        public void setTemprature(float temp)
        {
            this.temp = temp;
            Console.WriteLine($"The new temparature input has came {temp}");
            notifyObservers();

        }
    }
}
