using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelDesignC_.BehaviouralPattern.ObserverPattern.WeatherForcastApp.GoodCode
{
    internal interface IObserver
    {
        void Update(float temprature);
    }
}
