using ContactApi.Controllers;
using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ContactMVCAndDeploy.Vm;
using System.Net.Http;
using Newtonsoft.Json;
using ContactCore.Service;

namespace ContactMVCAndDeploy.Controllers
{
   
    public class ContactController : Controller
    {
        // GET: Contact
        
        HomeController db = new HomeController();
        
        [OutputCache(Duration =10)]
        public ActionResult Index()
        {
            IEnumerable<ContactVm> allcontacts = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382/api/");
               
                var responseTask = client.GetAsync("Home");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    allcontacts = JsonConvert.DeserializeObject<IList<ContactVm>>(readTask);
                    
                
                }
                else 
                {
                    allcontacts = Enumerable.Empty<ContactVm>();

                  
                }
            }



            ViewBag.con = allcontacts;
            return View();

        }
        
        public ActionResult addContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addContact(ContactVm vm)
        {
            if (ModelState.IsValid)
            {
                db.postContact(new Contact { FirstName = vm.FirstName, LastName = vm.LastName, contactNo = vm.contactNo });
               
            }
            return RedirectToAction("Index");
        }
        
        
       


       
        
        public ActionResult deleteContact(int id)
        {
            if (id > 0)
            {
                db.deleteContact(id);
             
            }
         
            return RedirectToAction("Index");

        }

        public ActionResult editContact(int id)
        {
            IEnumerable<ContactVm> allcontacts = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382/api/");

                var responseTask = client.GetAsync("Home");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    allcontacts = JsonConvert.DeserializeObject<IList<ContactVm>>(readTask);
                    allcontacts.Count();
                    ViewBag.message = "Got";
                }
                else
                {
                    allcontacts = Enumerable.Empty<ContactVm>();

                    ViewBag.message = "Not Get";
                }
            }
            ContactVm vm = new ContactVm();
            vm = allcontacts.SingleOrDefault(x => x.Id == id);
            return View(vm);

        }

        [HttpPost]
        public ActionResult editContact(ContactVm vm)
        {
            if (ModelState.IsValid)
            {
                db.editContact(new Contact { Id = vm.Id, FirstName = vm.FirstName, LastName = vm.LastName, contactNo = vm.contactNo });
                
                
            }
            return RedirectToAction("Index");
        }


    }
}