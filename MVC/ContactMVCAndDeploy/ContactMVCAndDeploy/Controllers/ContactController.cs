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

namespace ContactMVCAndDeploy.Controllers
{
   
    public class ContactController : Controller
    {
        // GET: Contact
        
        HomeController db = new HomeController();
        
        public ActionResult Index()
        {
            IEnumerable<Contact> allcontacts = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382/api/");
               
                var responseTask = client.GetAsync("Home");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    allcontacts = JsonConvert.DeserializeObject<IList<Contact>>(readTask);
                    allcontacts.Count();
                    ViewBag.message = "Got";
                }
                else 
                {
                    allcontacts = Enumerable.Empty<Contact>();

                    ViewBag.message = "Not Get";
                }
            }



            ViewBag.con = allcontacts;
            return View();

        }
        [Route("add")]
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
        [Route("delete")]
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