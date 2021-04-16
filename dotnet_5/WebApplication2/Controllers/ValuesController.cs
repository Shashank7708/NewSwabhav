using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Rohan", "Vishal", "Sumit", "Shashank" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "The Id is " + id;
        }

    }
}
