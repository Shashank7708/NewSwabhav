using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class HomeController : ApiController
    {   [HttpGet]
        public IHttpActionResult GetAnything()
        {
            return Ok("Get is Working");
        }

        [HttpPost]
        public IHttpActionResult PostAnything()
        {
            return Ok("Post is Working");
        }
        [HttpPut]
        public  IHttpActionResult PutAnything()
        {
            return Ok("Put Anything");
        }
        [HttpDelete]
        public IHttpActionResult DeleteAnything()
        {
            return Ok("Delete is Working");
        }

    }
}
