
using MVCandEntityFramework.Repository;
using MVCandEntityFramework.Models;
using MVCandEntityFramework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCandEntityFramework.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Membership u)
        {
          //  var user = new Membership { username = u.username, password = u.password };
           // ContactService.insertuser(user);
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(User u)
        {
            //  var user = new Membership { username = u.username, password = u.password };
            // ContactService.insertuser(user);
            SwabhavDbContext db=new SwabhavDbContext();
            db.users.Add(u);
            return RedirectToAction("Index");
        }


    }
}