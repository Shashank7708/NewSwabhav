using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactCore.Model;
using ContactCore.Service;
namespace ContactWepApi.Controllers
{
    public class HomeController : ApiController
    {
        ContactService service = new ContactService();
        

        [HttpGet]
        public IHttpActionResult getCOntacts()
        {
            return Ok(service.contacts());
        }


        [HttpPost]
        public IHttpActionResult postContact(Contact c)
        {
            if (ModelState.IsValid)
            {
                service.insertContact(c);
                return Ok("Post Successfully");
            }
            return Ok("Post Not Successfull");
        }

        [HttpDelete]
        public IHttpActionResult deleteContact(int id)
        {
            service.deleteContct(id);
            return Ok("Deleted Successfully");
        }

        [HttpPut]
        public IHttpActionResult editContact(Contact c)
        {
            service.editContact(c);
            return Ok("Edited ");
        }

    }
}
