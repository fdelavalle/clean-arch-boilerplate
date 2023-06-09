using WeatherForecastClean.Core;
namespace WeatherForecastClean.Application;

public interface IWeatherForecastRepository
{
    WeatherForecast[] GetForecasts();
}