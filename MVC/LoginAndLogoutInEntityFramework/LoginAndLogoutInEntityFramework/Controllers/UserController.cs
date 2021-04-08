using LoginAndLogoutInEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginAndLogoutInEntityFramework.Service;
using System.Web.Security;

namespace LoginAndLogoutInEntityFramework.Controllers
{   //Add this in WebConfig above</system.web>
    //< <authentication mode="Forms">  
   //  <forms loginUrl = "User/Index" ></ forms >
  // </authentication>

     [AllowAnonymous]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Membership u) 
        {
            if (ModelState.IsValid)
            {
                int count = 0;
                foreach (var i in ContactService.members())
                {
                    if (i.password.Equals(u.password) && i.username.Equals(u.username))
                    {
                        count = 1;break;
                       
                    }
                }
                if (count == 1) 
                {
                    FormsAuthentication.SetAuthCookie(u.username,false);
                    return RedirectToAction("Index","Home"); }
                }
            return View();


        }

        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(Models.Membership s)
        {
            if (ModelState.IsValid)
            {
                var member = new Models.Membership { password = s.password, username = s.username };
                ContactService.insertuser(member);
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