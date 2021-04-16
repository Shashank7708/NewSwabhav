using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ContactWebApiAndDeploy.Vm;
using ContactWepApi.Controllers;
using Newtonsoft.Json;
using ContactWepApi;
using ContactCore.Model;

namespace ContactWebApiAndDeploy.Controllers

{
    public class ContactController : Controller
    {
        // GET: Contact
       

        HomeController db = new HomeController();

        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            IEnumerable<ContactVm> allcontacts = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44322/api/");

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
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44322/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ContactVm>("Home", vm);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            
            return RedirectToAction("Index");
        }







        public ActionResult deleteContact(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44322/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Home/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                
            }

            return RedirectToAction("Index");

        }

        public ActionResult editContact(int id)
        {
            IEnumerable<ContactVm> allcontacts = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44322//api/");

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
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44322/api/student");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<ContactVm>("home",vm );
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }


    }
}