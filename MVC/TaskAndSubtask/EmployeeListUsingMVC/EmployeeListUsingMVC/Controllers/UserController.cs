using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EmployeeListUsingMVC.Models;
using EmployeeListUsingMVC.Service;

namespace EmployeeListUsingMVC.Controllers
{   [AllowAnonymous]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            Console.WriteLine("Index Authenticate");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.Membership1 u)
        {
            if (ModelState.IsValid)
            {
                List<Membership1> members = TaskService.members();
                foreach (var i in members)
                {
                    if (i.txtlogin.Equals(u.txtlogin) && i.txtpassword.Equals(u.txtpassword))
                    {
                        FormsAuthentication.SetAuthCookie(u.txtlogin, false);
                        return RedirectToAction("Gettasks", "Home");
                    }
                }
            }
            return View();
        }


        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult SignUp(Membership1 m)
        {
            if (ModelState.IsValid)
            {
                TaskService.insertmembers(m);
                return RedirectToAction("Index");
            }
            return View();

        }

        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "User");
        }

    }
}