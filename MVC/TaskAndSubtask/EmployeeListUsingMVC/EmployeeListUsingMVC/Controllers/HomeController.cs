using EmployeeListUsingMVC.Filter;
using EmployeeListUsingMVC.Models;
using EmployeeListUsingMVC.Service;
using EmployeeListUsingMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Diagnostics;
namespace EmployeeListUsingMVC.Controllers
{   
    public class HomeController : Controller
    {

        //[Authorize]
        public ActionResult insert()
        {
            Debug.WriteLine("Insert Authorize");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
     //   [Authorize]
        public ActionResult insert(TaskVM t)
        {
            Debug.WriteLine("Insert save Authorize");

            if (ModelState.IsValid)
            {
                TaskService.insert(new Task { name = t.name, date =t.date });
                
                ViewBag.message = "Added Successfully";
            }
            else { ViewBag.message = "Not Added"; }
            
            return View("insert");
        }


        public ActionResult Gettasks()
        {
           
            List<Task> tasks = new List<Task>();
            foreach(var i in TaskService.tasks())
            {
                tasks.Add(i);
            }
           
            return View(tasks);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {

            Debug.WriteLine("Edit Authorize");
            Task task = new Task();
            foreach(var i in TaskService.tasks())
            {
                if (i.id == id)
                {
                    task = i;
                    
                }
            }

            return View(task);
        }
        [HttpPost]
        [Authorize]
        public ActionResult Edit(Task t)
        {
            Console.WriteLine("Edit save Authorize");

            if (ModelState.IsValid)
            {
               bool result= TaskService.edittask(t);
                if (result == true) { ViewBag.message = "Edited Successfully"; }
                else { ViewBag.message = "Edited not Possible"; }
            }
            return Redirect("~/Home/Gettasks");

        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            Console.WriteLine("Delete Authorize");

            Task task = new Task();
            foreach (var i in TaskService.tasks())
            {
                if (i.id == id)
                {
                    task = i;

                }
            }
            
            return View(task);
        }
        [HttpPost]
        [Authorize]
        public ActionResult Delete(Task t)
        {
            Console.WriteLine("Delete save Authorize");

            if (TaskService.deletetask(t))
            {
                ViewBag.message = "Deleted Successfully";
            }
            else { ViewBag.message = "Not Deleted"; }
          ViewBag.taskdelete = true;
            return Redirect("~/Home/Gettasks");
        } 



        public ActionResult getsubtask(int id)
        {
            List<Subtask> tasks = new List<Subtask>();
            foreach(var i in TaskService.subtasks(id))
            {
                tasks.Add(i);
            }
            return View(tasks);

        }

      public ActionResult insertsubtask(int id)
        {
           
            ViewBag.id = id;
            return View();

        }

        [HttpPost]
        [Authorize]
        public ActionResult insertsubtask(AddSubTask subtask)
        {
           
            Task t = new Task();
            foreach(var i in TaskService.tasks())
            {
                if (i.id == subtask.id) { t = i; }
            }
            TaskService.insertsubTask(new Subtask { name = subtask.name, date = subtask.date, status = subtask.status, Task = t });
            return Redirect("~/Home/Gettasks");


        }

        public ActionResult Edit1(int id)
        {
            Subtask task = new Subtask();
            foreach (var i in TaskService.getAllSubtask())
            {
                if (i.id == id) { task = i; }
            }
            return View(task);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Edit1(SubtaskVM t)
        {
            Task task = new Task();
            if (ModelState.IsValid)
            {
                
                foreach(var i in TaskService.tasks()) { if (i.name.Equals(t.parentname)) task = i; }

                Subtask subtask = new Subtask { id = t.id, name = t.name, date = t.date, status = t.status, Task = task };


                bool result = TaskService.editsubtask(subtask);
                if (result == true) { ViewBag.message = "Edited Successfully"; }
                else { ViewBag.message = "Edited not Possible"; }
            }
            return Redirect("~/Home/getsubtask/"+task.id);

        }



        [Authorize]
        public ActionResult Delete1(int id)
        {

            Subtask task = new Subtask();
            foreach (var i in TaskService.getAllSubtask())
            {
                if (i.id == id)
                {
                    task = i;
                }
            }
            return View(task);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Delete1(SubtaskVM t)
        {
            Task task = new Task();
            Subtask subtask = new Subtask();
            if (ModelState.IsValid)
            {   foreach(var i in TaskService.tasks()) { if (i.name.Equals(t.parentname)) task = i; }
                foreach(var i in TaskService.getAllSubtask()) { if (i.id == t.id) subtask = i; }
               

                bool result = TaskService.delesubtask(subtask);
                if (result == true) { ViewBag.message = "Edited Successfully"; }
                else { ViewBag.message = "Edited not Possible"; }
            }
            return Redirect("~/Home/getsubtask/" + task.id);
        }



        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

       

    }


}