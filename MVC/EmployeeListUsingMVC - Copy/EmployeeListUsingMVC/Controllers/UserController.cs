using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EmployeeListUsingMVC.Models;

namespace EmployeeListUsingMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u)
        {
            if (u.txtlogin == "admin" && u.txtpassword == "admin")
            {
                FormsAuthentication.SetAuthCookie(u.txtlogin, false);
                return RedirectToAction("insert","Home");
            }
            return View();
        }

    }
}