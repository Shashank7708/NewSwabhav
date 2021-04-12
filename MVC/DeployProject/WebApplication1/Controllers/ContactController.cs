using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeployProject;
using ContactApi;
using ContactApi.Controllers;
using DeployProject.Model;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        HomeController db = new HomeController();
        public ActionResult Index()
        {   

            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(db.getCOntacts().ToString());
            return View(contacts);

        }

        public ActionResult addContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addContact(Contact c)
        {
            if (ModelState.IsValid)
            {
                db.postContact(c);
            }
            return View();
        }

        public ActionResult deleteContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult deleteContact(int id)
        {
            if (id > 0)
            {
                ViewBag.message = db.deleteContact(id);

            }
            else
            {
                ViewBag.message = "Not Deleted Successfully";

            }
            return View();

        }
    }
}