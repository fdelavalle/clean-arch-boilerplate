using System.Collections.Generic;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Application;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;

    public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }
    public List<WeatherForecast> ProccesFTemperature()
    {
        var forecasts = _weatherForecastRepository.GetForecasts();
        var processed = new List<WeatherForecast>();
        foreach (var f in forecasts)
        {
            f.TemperatureF = 32 + (int)(f.TemperatureC / 0.5556);
            processed.Add(f);
        }
        return processed;
    }
}
