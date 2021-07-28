using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS2021.DI.Weather.Services
{
    public class WeatherApi
    {
        public WeatherApi()
        {

        }
        public WeatherForecast GetWeather(string city) 
            => city == "Rome" ? new WeatherForecast(DateTime.UtcNow, 34, "Sun") : new WeatherForecast(DateTime.UtcNow, 28, "Cloudy");
    }
}