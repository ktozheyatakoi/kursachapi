using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Modal.ClassesforWeatherInfo
{
    public partial class Datas
    {
        public Data[] Data { get; set; }
    }
    public class Data
    {
        [JsonProperty("aqi")]
        public long Aqi { get; set; }
    }
}