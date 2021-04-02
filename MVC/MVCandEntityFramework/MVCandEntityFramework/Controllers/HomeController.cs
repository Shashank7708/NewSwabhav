using MVCandEntityFramework.Models;
using MVCandEntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCandEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ContactRepo contact = new ContactRepo();
            List<Contact> con= contact.GetContact();
            ViewBag.contacts = con;
            return View();
        }
    }
}