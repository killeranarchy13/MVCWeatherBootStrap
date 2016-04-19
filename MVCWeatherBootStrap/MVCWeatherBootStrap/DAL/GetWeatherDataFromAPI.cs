using System;
using System.Net;

namespace MVCWeatherBootStrap.DAL
{
    public class GetWeatherDataFromAPI
    {
        public string GetWeatherDataFromWebAPI(string CityName)
        {
            try
            {
                string WeatherData;
                using (var client = new WebClient())
                {
                    WeatherData = client.DownloadString("http://api.openweathermap.org/data/2.5/weather?q={" + CityName + "}");
                    return WeatherData;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}