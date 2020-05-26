using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApi.Modal.Picture;

namespace afdsasf.Controllers
{
    [Route("[controller]")]
[ApiController]
public class PictureController : ControllerBase
{
    [HttpGet("{topic}")]
    public async Task<string> Get(string topic)
    {
        try
        {
            JObject search = JObject.Parse(await Gets($"https://pixabay.com/api/?key=11670931-bb66861cd97f09841fe543406&q={topic}+город&image_type=photo&orientation=horizontal&category=places&pretty=true"));
            PicturesByTopic picturesByTopic = JsonConvert.DeserializeObject<PicturesByTopic>(search.ToString());
            if (picturesByTopic.hits.Count == 0) return "null";
            Random rnd = new Random();
            return (picturesByTopic.hits.Count > 0) ? picturesByTopic.hits[rnd.Next(0, picturesByTopic.hits.Count)].webformatURL : picturesByTopic.hits.First().webformatURL;
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
