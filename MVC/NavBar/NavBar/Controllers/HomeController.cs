using NavBar.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NavBar.Models;
namespace NavBar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
            var students = StudentService.getstudents();
            return View(students);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
     //   [ActionName("Login")]
        public ActionResult Login2(User user)
        {
            if (StudentService.Validate(user.txtlogin,user.txtpassword))
            {
                //ViewBag.message = "Login Successfull";
                //ViewBag.txtlogin = user.txtpassword;
                Session["login"] = user.txtlogin;
                return Redirect("~/Home/Show");
            }
            else
            {
                ViewBag.message = "Login Invalid";
            }
            return View("Login");
        }

        public ActionResult logout()
        {
            Session["login"] = null;
            Session.Abandon();
            return Redirect("~/Home/Login");
        }
    }
}