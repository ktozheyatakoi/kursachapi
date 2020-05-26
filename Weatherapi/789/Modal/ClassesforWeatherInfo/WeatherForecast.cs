using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Modal.ClassesforWeatherInfo
{
    public class WeatherForecast
    {
        public Location location { get; set; }

        public Forecast forecast { get; set; }
        public long aqi { get; set; }

    }
}
