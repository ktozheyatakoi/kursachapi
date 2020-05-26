using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Modal
{
    public class Weather
    {
        public Location location { get; set; }
        public Current current { get; set; }
        public long aqi { get; set; }
    }
}
