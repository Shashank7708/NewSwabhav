using ContactAddressCore.Model;
using ContactAndAddressApp_data.Repository;
using ContactAndAddressWebAPi.DtoModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAndAddressWebAPi.Controllers
{
    [Route("api/tenents/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IContactRepository _db;
        public UserController(IContactRepository dbContext)
        {
            this._db = dbContext;
        }
        [Route("{tenentId}/user/register")]
        [HttpPost]
        public ActionResult AddUser(DtoUser dtouser, string tenentId)
        {
            if (ModelState.IsValid)
            {
                User user = new User { Name = dtouser.Name, Password = dtouser.Password };
                user.Id = new Guid();
                user.Tenent = _db.GetTenent(Guid.Parse(tenentId));
                this._db.AddUser(user);
                return Ok(user);
            }
            return BadRequest("Post Not Successfull");
        }

        [HttpGet]
        [Route("{tenentId}/user/{userId}")]
        public ActionResult<User> GetUserAsPerId(Guid tenentId, Guid userId)
        {
            var user = this._db.GetUser(tenentId,userId);
            if (user.Name != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound("No Such Tenet is Register");
            }
        }

        [HttpGet]
        [Route("{tenentId}/users")]
        public ActionResult<IQueryable<User>> GetUsersOfATenent(Guid tenentId)
        {
            IQueryable<User> users=this._db.GetUsers(tenentId);
            if (users.Count()>0)
            {
                return Ok(users);
            }
            return NoContent();
        }
    }
}
