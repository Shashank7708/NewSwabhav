using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        bool flag = false;
        
       public HomeController()
        {
            
        }
        
        public void Index(string value)
        {   for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}",value);
            }
        }



       
        public ActionResult hello(string name)
        {
            ViewBag.MyString = name;
            return View();
        }

        
        public ActionResult print()
        {
            ViewBag.flag = flag;
            return View();
        }
        [HttpPost]
        public ActionResult print(FormCollection frm)
        {
            flag = true;
            ViewBag.flag = flag;
              ViewBag.tech = frm["Technology"].ToString();
            //  ViewBag.id = int.Parse(frm["id"]);
            var user = new User() { id = int.Parse(frm["id"]), Name = frm["name"].ToString() };
          //  ViewBag.name =frm["name"].ToString() ;
            return View(user);
        }

        public ActionResult displayDate()
        {
            ViewBag.flag = flag;
            return View();
        }

            [HttpPost]
        public ActionResult displayDate(FormCollection frm)
        {
            flag = true;
            ViewBag.flag = flag;
            ViewBag.name = frm["name"].ToString();
            return View();
        }
    }
}