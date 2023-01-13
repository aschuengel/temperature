using System;
using Model;

namespace temperature.Services;

public class WeatherService
{
    private readonly IList<WeatherData> _data = new List<WeatherData>
    {
        new WeatherData
        {
            Temperature = 21.0,
            Pressure = 22.0
        }
    };

    public IEnumerable<WeatherData> GetData()
    {
        return _data;
    }

    public void Add(WeatherData data) {
        _data.Add(data);
    }
}

