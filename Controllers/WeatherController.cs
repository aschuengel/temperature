using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers;

[ApiController]
[Route("api/v1/weather")]
public class WeatherController
{

    [HttpPost]
    public void PostData(WeatherData data)
    {

    }

    [HttpGet]
    public IEnumerable<WeatherData> GetData()
    {
        return new List<WeatherData>() {
new WeatherData{
    Temperature = 21.0,
    Pressure = 22.0
}
        };
    }
}