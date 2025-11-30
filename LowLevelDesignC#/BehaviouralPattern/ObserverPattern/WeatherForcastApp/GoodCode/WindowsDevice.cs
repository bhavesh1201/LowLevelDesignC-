using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.WeatherForcastApp.GoodCode
{
    internal class WindowsDevice : IObserver
    {
        public void Update(float temprature)
        {
            Console.WriteLine($"Windows Device: Temperature updated to {temprature} degree celsius.");
        }   
    
    }
}
