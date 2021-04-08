using MVCandEntityFramework.Models;
using MVCandEntityFramework.Repository;
using MVCandEntityFramework.Service;
using MVCandEntityFramework.ViewModels;
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
            ContactRepo c = new ContactRepo();
            List<Contact> con = c.GetContact();
            ViewBag.contacts = con;
            return View();
        }

        
        public ActionResult insert()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult insert(ContactVm c)
        {
            // ContactRepo c = new ContactRepo();
            Contact contact = new Contact { fname = c.fname, lname = c.lname, phoneno = c.phoneno, address = c.address };
           ContactService.insert(contact);

            return View();

        }

        public ActionResult Delete(string fname)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(ContactVm c)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact { fname = c.fname, lname = c.lname, phoneno = c.phoneno, address = c.address };
                ContactService.delete(contact);
            }
            return Redirect("~/Home/Index");
        }

        public ActionResult Edit(string fname)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(ContactVm c)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact { fname = c.fname, lname = c.lname, phoneno = c.phoneno, address = c.address };
                ContactService.update(contact);
            }
            return Redirect("~/Home/Index");
        }

    }
}