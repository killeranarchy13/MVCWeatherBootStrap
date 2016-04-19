using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWeatherBootStrap.Controllers
{
    public class WeatherMainController : Controller
    {
        // GET: WeatherMain
        public ActionResult WeatherMainView()
        {
            return View();
        }

        public ActionResult TemperatureDetailsView()
        {
            return PartialView();
        }
    }
}