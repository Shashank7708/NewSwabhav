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
      public static List<string> logincredentials = new List<string>();
        
        
       public HomeController()
        {
            
        }
        
        //Display name
        
       public ActionResult Index()
        {
            return View();
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



        //Display Date
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


        //ForM Validation
        public ActionResult validate()
        {
            return View();
        }

       [HttpPost]
        public ActionResult submit()
        {
            Login svm;
            if (Session["CurrentSession"] != null)
            {
                svm = (Login)Session["CurrentSession"];
            }
            else { svm = new Login(); }

            svm.counter++;
            svm.a = svm.counter;
            ViewBag.aa = svm.a;
                return View();
            
         //   return View("validate");
        }


        //Create Account
        public ActionResult loginToAuthenticate()
        {
            return View();
        }

        public ActionResult authenticate(Login login)
        {
            
            if (ModelState.IsValid)
            {
                //  if (login.name.ToLower().Equals(name.ToLower()) && login.email.Equals("sndc@gmail.com") && login.password.Equals("shashank1"))
                // {
                //     return View("submit");
                // }
                string str = login.name+login.password;
                logincredentials.Add(str);
                Content("Account Created Successfully"); 

            }
            return View("accountcreated");
        }

        //Login after Creating An Account
        public ActionResult login()
        {  
            return View();
        }
        public ActionResult loginresult(Login log)
        {
            logincredentials.Add("Shashankshashank1");
            if (ModelState.IsValid)
            {
                int count = 0;
                string str = log.name+log.password;
                foreach(string i in logincredentials)
                {
                    if (i.Equals(str))
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        break;
                    }
                }
                if (count == 1) { return View("submit"); }
                

            }
            return View("loginfailed");
        }


        //Alert If Incorrect information
        public ActionResult loginfailed()
        {
            return View();
        }

        


    }
}