using SessionApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StateViewModel svm;

            if (HttpContext.Application["CurrentSession"] != null)
            {
                svm = (StateViewModel)HttpContext.Application["CurrentSession"];
            }
            else
            {
                svm = new StateViewModel();
            }

            svm.oldvalue = svm.Counter;
            svm.Counter++;
            svm.newvalue = svm.Counter;

            HttpContext.Application["CurrentSession"] = svm;
            ViewBag.old = svm.oldvalue;
            ViewBag.new1= svm.newvalue;
            return View(svm);



        }
    }
}