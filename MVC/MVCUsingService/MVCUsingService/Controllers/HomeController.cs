using MVCUsingService.Models;
using MVCUsingService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUsingService.Controllers
{
    public class HomeController : Controller
    {
        // ServiceLayer service = new ServiceLayer();
       static int id = 0;
        // GET: Home
       
        public ActionResult getEmp()
        {
            ServiceLayer service = new ServiceLayer();
            List<Employee> emplist = service.GetPerson().ToList();
            //ViewBag.li = emplist;
            List<EmployeeVM> empvm = new List<EmployeeVM>();
            foreach(var empobj in emplist)
            {
                EmployeeVM eobj = new EmployeeVM();
                eobj.name = empobj.name;

                eobj.position = empobj.position;
                eobj.salary = empobj.salary;
                if (empobj.salary < 20000)
                {
                    eobj.salaryCol = "red";
                }
                else
                {
                    eobj.salaryCol = "green";
                }
                empvm.Add(eobj);

            }

            ViewBag.li = empvm;
          
            return View();
        }
        public ActionResult insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submit(EmployeeVM e)
        {
            ServiceLayer service = new ServiceLayer();
            if (ModelState.IsValid)
            {
                e.id = ++id;
                var emp = new Employee { id = e.id, name = e.name, position = e.position, salary = e.salary, age = e.age };
                service.insertEmp(emp);
                ViewBag.name = e.name;
                
            }
            return View();        

        }
        
      

    }
}