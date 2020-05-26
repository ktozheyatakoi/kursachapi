using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi.Modal.Picture
{
    public class PicturesByTopic
    {
        public List<Picture> hits { get; set; }
        public PicturesByTopic()
        {
            hits = new List<Picture>();
        }
    }
}
