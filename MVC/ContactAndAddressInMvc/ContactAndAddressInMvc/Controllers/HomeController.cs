using ContactAndAddressInMvc.Models;
using ContactAndAddressInMvc.Service;
using ContactAndAddressInMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactAndAddressInMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Contact> con =TaskService.contacts();

            
            return View(con);
        }

        public ActionResult insertContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertContact(ContactVm c)
        {
            if (ModelState.IsValid)
            {
                TaskService.insertContact(new Contact { FirstName = c.FirstName, LastName = c.LastName, contactNo = c.contactNo });
            }
            return RedirectToAction("Index");
        }


        public ActionResult deletecontact(int id)
        { List<Contact> con = TaskService.contacts();
            ContactVm vm = new ContactVm();
            foreach(var i in con)
            {
                if (i.Id == id) { vm.Id = i.Id;vm.FirstName = i.FirstName;vm.LastName = i.LastName;vm.contactNo = i.contactNo; }
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult deletecontact(ContactVm vm)
        {
            
                TaskService.deleteContct(vm.Id);
            
            return RedirectToAction("Index");

        }


        public ActionResult editcontact(int id)
        {
            List<Contact> con = TaskService.contacts();
            ContactVm vm = new ContactVm();
            foreach (var i in con)
            {
                if (i.Id == id) { vm.Id = i.Id; vm.FirstName = i.FirstName; vm.LastName = i.LastName; vm.contactNo = i.contactNo; }
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult editcontact(ContactVm c)
        {
            
                Contact contact = new Contact { Id = c.Id, FirstName = c.FirstName, LastName = c.LastName, contactNo = c.contactNo };
                TaskService.editContact(contact);
            
            return Redirect("~/Home/Index");
        }


        public ActionResult getaddress(int id)
        {
            List<Address> con = TaskService.address();


            return View(con);
        }

        public ActionResult addadress(int id)
        {
            ViewBag.contact = id;
            return View();
        }

        [HttpPost]
        public ActionResult addadress(AddressVm vm)
        { List<Contact> contact = TaskService.contacts();
            Contact c = new Contact();
            if (ModelState.IsValid)
            {   foreach(var i in contact) { if (i.Id == vm.Id) { c = i; } }
                TaskService.insertAddress(new Address { address = vm.address,Contact=c});
            }
            return RedirectToAction("Index");
        }


        public ActionResult deleteaddress(int id)
        {
            List<Address> address = TaskService.address();
            AddressVm vm = new AddressVm();
            foreach(var i in address) { if (i.Id == id) { vm.Id = i.Id;vm.address = i.address;vm.Contact = i.Contact.Id; } }
            return View(vm);
        }

        [HttpPost]
        public ActionResult deleteaddress(AddressVm vm)
        {
            TaskService.deleteAddress(vm.Id);
            return Redirect("~/Home/getaddress/" + vm.Contact);
        }

        public ActionResult editaddress(int id)
        {
            List<Address> con = TaskService.address();
            AddressVm vm = new AddressVm();
            foreach (var i in con)
            {
                if (i.Id == id) { vm.Id = i.Id;vm.address = i.address;vm.Contact = i.Contact.Id; }
            }
            return View(vm);
        }

        public ActionResult editaddress(AddressVm vm)
        {
            if (ModelState.IsValid)
            {
                TaskService.editAddess(new Address { Id = vm.Id, address = vm.address });
            }
            return Redirect("~/Home/getaddress/" + vm.Contact);
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




    }
}