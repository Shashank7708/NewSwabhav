using DTOEmployee.Models;
using DTOEmployee.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DTOEmployee.Controllers
{   [RoutePrefix("api/emp")]
    public class EmployeeController : ApiController
    {
        IServiceLayer empService = null;

        public EmployeeController(IServiceLayer service)
        {
            empService = service;
        }
        [Route("insert")]
        public IHttpActionResult insert(Employee e)
        {
            if (ModelState.IsValid)
            {
                empService.insert(e);
                return Ok("Successfully Inserted");
            }
            else
            {
                return BadRequest("Not Inserted");
            }
           
        }


        public IHttpActionResult insertno(int userid)
        {
            return Ok(userid);
        }

        [Route("get")]
        [HttpGet]
        public IHttpActionResult getEmp()
        {
            List<Employee> emp = empService.getEmployee();
            return Ok(emp);
        }

        [Route("delete")]
        [HttpDelete]
        public IHttpActionResult DeleteEp(DtoDeleteEmp e)
        {
            empService.delete(e);
            return Ok("Deleted Successfullully "+e.id);
        }

    }
}
