using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCrud.Models;
using WebApiCrud.Service;

namespace WebApiCrud.Controllers
{
    public class EmployeeController : ApiController
    {   [HttpGet]
        public IHttpActionResult getEmp()
        {
            List<Employee> emps = ServiceLayer.getEmployee();
            return Ok(emps);
        }

        [HttpPost]
        public IHttpActionResult postEmp(Employee e)
        {
            if (ModelState.IsValid)
            {
                ServiceLayer.insert(e);
                return Ok("Posted Successfully");
            }
            else
            {
                return BadRequest("Invalid data.Please Recheck");
            }
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult putEmp(Employee e)
        {
            if (ModelState.IsValid)
            {
                ServiceLayer.deleteEmployee(2);
                ServiceLayer.editEmployee(e);
                return Ok("Put Successfully");
            }
            else
            {
                return BadRequest("Invalid data.Please Recheck");
            }
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult deleteEmp(int id)
        {
      
            
                
                ServiceLayer.deleteEmployee(id);
                return Ok("Deleted Successfully");
           
          
        }


    }
}
