using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Model;
namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> books = new List<Book>() { new Book { id = 1, name = "The Legend Of Mehula",rating=7.5 },
            new Book{ id=2,name="The Immortal Of Shiva",rating=8},{ new Book{id=3,name="Steve Jobs",rating=7 } } };


        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return books;
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = books.SingleOrDefault(x => x.id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }



    }
}
