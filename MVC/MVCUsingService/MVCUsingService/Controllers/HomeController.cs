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
                eobj.age = empobj.age;
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
    [HttpGet]
      public ActionResult Edit(int Id)
        {
            ServiceLayer service = new ServiceLayer();
            var e = service.getAEmployee(Id);
            var emp = new EmpEditVm{ id = e.id, name = e.name, position = e.position, salary = e.salary, age = e.age };
            
            ViewBag.emp = emp; 
            return View();
        }
        [HttpPost]
      public ActionResult Edit(EmpEditVm e)
        {
            ServiceLayer service = new ServiceLayer();
            if (ModelState.IsValid)
            {
                var emp = new Employee { id = e.id, name = e.name, position = e.position, salary = e.salary, age = e.age };
                service.Edit(emp);
                ViewBag.name = e.name;
            }
            return View("submit");
        }

        public ActionResult Delete(int Id)
        {
            ServiceLayer service = new ServiceLayer();
            service.Delete(Id);
           
            return RedirectToAction("submit", new { Message = "Deleted Successfully" });
        }
     

    }
}