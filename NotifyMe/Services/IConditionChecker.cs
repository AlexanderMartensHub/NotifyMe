using NotifyMe.Models;

namespace NotifyMe.Services
{
    public interface IConditionChecker
    {
        bool Check(WeatherConditions condition);
    }
}
