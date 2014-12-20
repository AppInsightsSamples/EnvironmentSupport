using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            TelemetryClient tc = new TelemetryClient();

            tc.TrackEvent("HomePage event");

            tc.TrackTrace("HopePage trace");

            return View();
        }
    }
}
