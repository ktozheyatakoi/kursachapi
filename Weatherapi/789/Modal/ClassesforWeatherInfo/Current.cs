using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApi.Modal.ClassesforWeatherInfo;

namespace WeatherApi.Modal
{
    public class Current
    {
        public double temp_c { get; set; }
        public Condition condition { get; set; }
        public double wind_kph { get; set; }
        public int wind_degree { get; set; }
        public double pressure_mb { get; set; }
        public int humidity { get; set; }
        public int cloud { get; set; }
        public double feelslike_c { get; set; }
        public double vis_km { get; set; }
    }
}
