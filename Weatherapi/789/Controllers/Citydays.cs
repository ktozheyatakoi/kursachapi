using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApi.Modal.ClassesforWeatherInfo;

namespace afdsasf.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Citydays : ControllerBase
    {
        [HttpGet("{city}/{days}")]
        public async Task<WeatherForecast> Get(string city, int days)
        {
            try
            {
                JObject search = JObject.Parse(await Gets($"http://api.weatherapi.com/v1/forecast.json?key=2ea86a94dad94892a1e80923200505&q={city}&days={days}&lang=ru"));
                JObject searchaqi = JObject.Parse(await Gets($"https://api.weatherbit.io/v2.0/current/airquality?&city={city}&key=12a4e67d68a14f2590635e42cc9b547e"));
                Datas agi = JsonConvert.DeserializeObject<Datas>(searchaqi.ToString());
                WeatherForecast weather = JsonConvert.DeserializeObject<WeatherForecast>(search.ToString());
                weather.aqi = agi.Data[0].Aqi;
                return weather;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static async Task<string> Gets(string URL)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(URL);
            HttpContent content = response.Content;
            string result = await content.ReadAsStringAsync();
            return result;
        }
    }
}




