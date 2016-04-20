using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWeatherBootStrap.HelperClasses;
using MVCWeatherBootStrap.Models;

namespace MVCWeatherBootStrap.Controllers
{
    public class WeatherMainController : Controller
    {
        public ActionResult WeatherMainView()
        {
            PopulateTheModel obj = new PopulateTheModel();
            CityWeatherDetails model = new CityWeatherDetails();
            obj.PopulateTheCityWeatherObject(ref model);
            return PartialView(model);
        }

        public ActionResult TemperatureDetailsView()
        {
            return PartialView();
        }

        public ActionResult IndexView()
        {
            return View();
        }
    }
}