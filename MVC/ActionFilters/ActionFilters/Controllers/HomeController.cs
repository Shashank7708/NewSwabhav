using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilters.Controllers
{
    public class HomeController : Controller
    { 
        [OutputCache(Duration =30)]
        public ActionResult Index()
        {
            ViewBag.time = DateTime.Now;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}