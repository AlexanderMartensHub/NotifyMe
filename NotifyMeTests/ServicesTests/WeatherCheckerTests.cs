using Moq;
using NotifyMe.Mocks;
using NotifyMe.Models;
using NotifyMe.Services;
using NUnit.Framework;

namespace NotifyMeTests.ServicesTests
{
    [TestFixture]
    public class WeatherCheckerTests : ConditionCheckerBaseTests
    {
        private Mock<IWeatherMock> _weatherMock;

        [SetUp]
        public void Init()
        {
            _weatherMock = new Mock<IWeatherMock>();
        }

        protected override IConditionChecker CreateInstance()
        {
            return new WeatherChecker(_weatherMock.Object);
        }

        [Test]
        public void ChecksForRain_Success_Test()
        {
            var checker = CreateInstance();
            _weatherMock.Setup(w => w.GetWeather()).Returns(WeatherConditions.RAINY);

            var result = checker.Check(WeatherConditions.RAINY);

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(WeatherConditions.CLOUDY)]
        [TestCase(WeatherConditions.SUNNY)]
        public void CheckForRain_Fails_Test(WeatherConditions testCondition)
        {
            var checker = CreateInstance();
            _weatherMock.Setup(w => w.GetWeather()).Returns(testCondition);

            var result = checker.Check(WeatherConditions.RAINY);

            Assert.IsFalse(result);
        }
    }
}
