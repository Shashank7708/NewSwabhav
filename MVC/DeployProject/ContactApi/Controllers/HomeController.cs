using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DeployProject.Service;
using DeployProject.Model;

namespace ContactApi.Controllers
{
    public class HomeController : ApiController
    {
        Service service = new Service();

        [HttpGet]
        public IHttpActionResult getCOntacts()
        {
            return Ok( service.Contacts());
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

    }
}
