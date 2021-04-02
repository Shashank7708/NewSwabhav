using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVC3.Models;

namespace WelcomeMVC3.Controllers
{
    public class HomeController : Controller
    {   


        // GET: Home
        public ActionResult Index(User user1)
        {
            ViewBag.name = user1.name;
            ViewBag.id = user1.id;
            return View(user1);
           
        }
        public ActionResult Submit(int? id,string name)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }
        //public ActionResult Submit2()
       // {

      //  }
    }
}