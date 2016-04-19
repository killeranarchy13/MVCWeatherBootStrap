using MVCWeatherBootStrap.DAL;
using MVCWeatherBootStrap.Models;
using Newtonsoft.Json;
using System;

namespace MVCWeatherBootStrap.HelperClasses
{
    public class PopulateTheModel
    {
        public void PopulateTheCityWeatherObject(ref CityWeatherDetails objCity)
        {
            try
            {
                string WeatherInfo;
                GetWeatherDataFromAPI gt = new GetWeatherDataFromAPI();
                WeatherInfo = gt.GetWeatherDataFromWebAPI("Bangalore");

                objCity = JsonConvert.DeserializeObject<Wrapper>(WeatherInfo).CityWeatherDetails;
                objCity.temp = (Convert.ToDouble(objCity.temp) - 273.15).ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}