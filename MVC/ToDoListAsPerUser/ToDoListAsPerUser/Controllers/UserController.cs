using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ToDoListAsPerUser.Models;
using ToDoListAsPerUser.Service;
using ToDoListAsPerUser.ViewModel;

namespace ToDoListAsPerUser.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login1 u)
        {
            if (ModelState.IsValid)
            {
                List<User1> members = TaskService.users();
                foreach (var i in members)
                {
                    if (i.login.Equals(u.UserName) && i.password.Equals(u.Password))
                    {
                       FormsAuthentication.SetAuthCookie(i.login, false);
                        return Redirect("~/Home/Gettasks/"+i.id);
                    }
                }

                ViewBag.message = "Invalid Username Or Password";
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
        public ActionResult SignUp(SignupVm m)
        {
            if (ModelState.IsValid)
            {   if(m.Password.Equals(m.Confirm))
                TaskService.insertuser(new User1 {login=m.Username,password=m.Password });
                ViewBag.message="Added Successfully";
                return RedirectToAction("Index");
            }
            ViewBag.message = "Not Added";
            return View();

        }

        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "User");
        }

        
    }
}