using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Modal.ClassesforWeatherInfo
{
    public class Forecast
    {
        public IList<Forecastday> forecastday { get; set; }
    }
}
