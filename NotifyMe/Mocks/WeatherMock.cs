using NotifyMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyMe.Mocks
{
    public interface IWeatherMock
    {
        WeatherConditions GetWeather();
    }

    public class WeatherMock : IWeatherMock
    {
        public WeatherConditions GetWeather()
        {
            Random random = new Random();
            return (WeatherConditions) random.Next(0, 3);
        }
    }
}
