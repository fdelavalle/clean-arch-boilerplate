using System.Collections.Generic;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application;

public interface IWeatherForecastService
{
    List<WeatherForecast> ProccesFTemperature();
}
