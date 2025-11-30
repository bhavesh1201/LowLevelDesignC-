using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.WeatherForcastApp.GoodCode
{
    internal class IphoneDevice : IObserver
    {
        public void Update(float temprature)
        {
            Console.WriteLine($"Iphone Device: Temperature updated to {temprature} degree celsius.");
        }   
    }
}
