using ContactAddressCore.Model;
using ContactAndAddressApp_data.Repository;
using ContactAndAddressWebAPi.DtoModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAndAddressWebAPi.Controllers
{
    [Route("api/tenents")]
    [ApiController]
    public class TenentController : ControllerBase
    {
        private IContactRepository _db;
        public TenentController(IContactRepository dbContext)
        {
            this._db = dbContext;
        }
        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("register")]
        public ActionResult<Tenent> AddTenet(DtoTenet dtotenent)
        {
            if (ModelState.IsValid)
            {
                Tenent tenet = new Tenent { Name = dtotenent.Name };
                tenet.Id = new Guid();
                _db.AddTenent(tenet);
                return Ok(tenet);
            }
            return BadRequest("Not added Tenent");
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("{tenentId}")]
        public ActionResult<Tenent> GetTenetAsPerId(string tenentId)
        {
            var tenet = this._db.GetTenent(Guid.Parse(tenentId));
            if (tenet.Name != null)
            {
                return Ok(tenet);
            }
            else
            {
                return NotFound("No Such Tenet is Register");
            }
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("")]
        public ActionResult<IQueryable<Tenent>> GetTenents()
        {
            IQueryable<Tenent> tenents=this._db.GetTenents();
            if (tenents.Count() > 0)
            {
                return Ok(tenents);
            }
            else
            {
                return NoContent(); 
            }
        }

        [HttpDelete]
        [EnableCors("CorsPolicy")]
        [Route("{tenentId}/delete")]
        public ActionResult DeleteTenent(Guid tenentId)
        {
            bool result = this._db.DeleteTenent(tenentId);
            if (result)
            {
                return Ok("Deleted Successfully");
            }
           return BadRequest("Not Deleted");
        }

        

    }
}
