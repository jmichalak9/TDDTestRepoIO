using sale_system;
using System;
using Xunit;

namespace SaleSystemUnitTests
{
    public class WeatherForecastTest
    {
        [Fact]
        public void ConstructorTest()
        {
            WeatherForecast weatherForecast = new WeatherForecast
            {
                TemperatureC = 0,
                Summary = "test",
                Date = new DateTime()
            };
            Assert.NotNull(weatherForecast);
            Assert.Equal(0, weatherForecast.TemperatureC);
            Assert.Equal(32, weatherForecast.TemperatureF);
            Assert.Equal("test", weatherForecast.Summary);
        }
    }
}
