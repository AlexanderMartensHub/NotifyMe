using NotifyMe.Mocks;
using NotifyMe.Models;

namespace NotifyMe.Services
{
    public class WeatherChecker : IConditionChecker
    {
        public IWeatherMock _source;

        public WeatherChecker(IWeatherMock source)
        {
            _source = source;
        }

        public bool Check(WeatherConditions condition)
        {
            return _source.GetWeather() == condition;
        }
    }
}
