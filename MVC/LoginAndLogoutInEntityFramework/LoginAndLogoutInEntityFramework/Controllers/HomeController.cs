using LoginAndLogoutInEntityFramework.FIlter;
using LoginAndLogoutInEntityFramework.Models;
using LoginAndLogoutInEntityFramework.Service;
using LoginAndLogoutInEntityFramework.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAndLogoutInEntityFramework.Controllers
{ //[Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        [MyAuthentication]
        public ActionResult Index()
        {
          
            List<Contact> con = ContactService.getContacts();
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

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(EditAndDeleteContact c)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact { id=c.id,fname = c.fname, lname = c.lname, phoneno = c.phoneno, address = c.address };
                ContactService.delete(contact);
            }
            return Redirect("~/Home/Index");
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EditAndDeleteContact c)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact { id=c.id,fname = c.fname, lname = c.lname, phoneno = c.phoneno, address = c.address };
                ContactService.update(contact);
            }
            return Redirect("~/Home/Index");
        }
    }
}