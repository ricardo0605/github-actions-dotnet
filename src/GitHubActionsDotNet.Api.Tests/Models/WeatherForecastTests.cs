namespace GitHubActionsDotNet.Api.Tests.Models;

using FluentAssertions;
using GitHubActionsDotNet.Api.Models;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureFShouldReturnCorrectValueBasedOnTemperatureC()
    {
        var weatherForecast = new WeatherForecast
        {
            TemperatureC = 0
        };

        weatherForecast.TemperatureF.Should().Be(31);
    }
}
