using Microsoft.AspNetCore.Mvc;
using Model;
using temperature.Services;

namespace Controllers;

[ApiController]
[Route("api/v1/weather")]
public class WeatherController
{

    private readonly WeatherService _weatherService;

    public WeatherController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpPost]
    public void PostData(WeatherData data) => _weatherService.Add(data);

    [HttpGet]
    public IEnumerable<WeatherData> GetData() => _weatherService.GetData();
}