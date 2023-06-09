using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherForecastClean.Application;
using WeatherForecastClean.Core;

namespace WeatherForecastClean.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IActionResult Get()
    {
        var result = _weatherForecastService.ProccesFTemperature();
        return Ok(result);
    }
}
