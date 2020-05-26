using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Modal.ClassesforWeatherInfo
{
    public class Day
    {
        public double maxtemp_c { get; set; }
        public double avgtemp_c { get; set; }
        public string daily_chance_of_rain { get; set; }
        public Condition condition { get; set; }
    }
}
