using LoginAndLogoutInEntityFramework.CustomAuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginAndLogoutInEntityFramework.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User1 u) 
        {
            if (u.username == "admin" && u.password == "admin")
            {
                FormsAuthentication.SetAuthCookie(u.username, false);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

    }
}