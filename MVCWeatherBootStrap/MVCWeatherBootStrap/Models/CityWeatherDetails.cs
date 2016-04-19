using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWeatherBootStrap.Models
{
    public class CityWeatherDetails
    {

        public string temp { get; set; }
        public string humidity { get; set; }
    }
    public class Wrapper
    {
        [JsonProperty("main")]
        public CityWeatherDetails CityWeatherDetails { get; set; }
    }
}