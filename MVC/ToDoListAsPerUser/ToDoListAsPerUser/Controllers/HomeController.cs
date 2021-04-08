using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListAsPerUser.Models;
using ToDoListAsPerUser.Service;
using ToDoListAsPerUser.ViewModel;

namespace ToDoListAsPerUser.Controllers
{   [Authorize]
    public class HomeController : Controller
    {
      
        public ActionResult insert(int? id)
        {
            ViewBag.userid = id;
            
            return View();
        }

        [HttpPost]
      
      [ValidateAntiForgeryToken]
        public ActionResult insert(TaskVm t)
        {
          
            if (ModelState.IsValid)
            {
                List<User1> users = TaskService.users();
                User1 user = new User1();
                foreach(var i in users)
                {
                    if (i.id == t.user) { user = i; }
                }
                TaskService.insert(new Task { name = t.name, date = t.date ,user=user});
            }
           
            return View("insert");
        }


        public ActionResult Gettasks(int? id)
        {

            List<Task> tasks = TaskService.tasks();
          List<Task> filteredtask = new List<Task>();
            foreach (var i in tasks)
            {
                if (i.user.id == id)
                {
                    filteredtask.Add(i);
                }                
            }
            ViewBag.userid = id;
            return View(filteredtask);
        }

     
        public ActionResult Edit(int id)
        {
            TaskOperation task = new TaskOperation();
            foreach (var i in TaskService.tasks())
            {
                if (i.id == id)
                {
                    task.name = i.name;task.date = i.name;task.id = id;task.user = i.user.id;

                }
            }
            
            return View(task);
        }
        [HttpPost]
  
        public ActionResult Edit(TaskOperation t)
        {
            

            if (ModelState.IsValid)
            {
                Task task = new Task { id = t.id, name = t.name, date = t.date };
                bool result = TaskService.edittask(task);
                if (result == true) { ViewBag.message = "Edited Successfully"; }
                else { ViewBag.message = "Edited not Possible"; }
            }
            return RedirectToAction("Gettasks",new { id=t.user});

        }

   
        public ActionResult Delete(int id)
        {
            TaskOperation task = new TaskOperation();
            foreach (var i in TaskService.tasks())
            {
                if (i.id == id)
                {
                    task.id = i.id;task.name = i.name;task.date = i.date;task.user = i.user.id;

                }
            }
            
           
            return View(task);
        }
        [HttpPost]
    
        public ActionResult Delete(TaskOperation t)
        {
           TaskService.deletetask(t.id);
           
            return RedirectToAction("Gettasks",new { id = t.user });
        }



        public ActionResult getsubtask(int id)
        {
           
            List<Subtask> subtask = TaskService.subtasks(id);
            ViewBag.id = id;
            return View(subtask);

        }

        public ActionResult insertsubtask(int id)
        {

            ViewBag.id = id;
            return View();

        }

        [HttpPost]
     
        public ActionResult insertsubtask(SubtaskVm subtask)
        {

            Task t = new Task();
            foreach (var i in TaskService.tasks())
            {
                if (i.id == subtask.id) { t = i; }
            }
            TaskService.insertsubTask(new Subtask { name = subtask.name, date = subtask.date, status = subtask.status, Task = t });
            return RedirectToAction("getsubtask", new { id = t.id });


        }

        public ActionResult Edit1(int id)
        {
            SubTaskOperation task = new SubTaskOperation();
            foreach (var i in TaskService.getAllSubtask())
            {
                if (i.id == id) { task.id = i.id; task.date=i.date; task.name = i.name;task.status = i.status;task.parentname = i.Task.name; }
            }
            return View(task);
        }

        [HttpPost]
       
        public ActionResult Edit1(SubTaskOperation t)
        {
            Task task = new Task();
            if (ModelState.IsValid)
            {

                foreach (var i in TaskService.tasks()) { if (i.name.Equals(t.parentname)) task = i; }

                Subtask subtask = new Subtask { id = t.id, name = t.name, date = t.date, status = t.status, Task = task };
                TaskService.editsubtask(subtask);
            }
            return RedirectToAction("getsubtask", new { id=task.id});

        }



     
        public ActionResult Delete1(int id)
        {

            SubTaskOperation task = new SubTaskOperation();
            foreach (var i in TaskService.getAllSubtask())
            {
                if (i.id == id)
                {
                    task.id = i.id; task.date=i.date; task.name = i.name; task.status = i.status; task.parentname = i.Task.name;
                }
            }
            return View(task);
        }

        [HttpPost]
   
        public ActionResult Delete1(SubTaskOperation t)
        {
            Task task = new Task();
            Subtask subtask = new Subtask();
            if (ModelState.IsValid)
            {
                foreach (var i in TaskService.tasks()) { if (i.name.Equals(t.parentname)) task = i; }
                foreach (var i in TaskService.getAllSubtask()) { if (i.id == t.id) subtask = i; }


                bool result = TaskService.delesubtask(subtask);
                if (result == true) { ViewBag.message = "Edited Successfully"; }
                else { ViewBag.message = "Edited not Possible"; }
            }
            return Redirect("~/Home/getsubtask/"+task.id);
        }



      
        public ActionResult Index()
        {
            return View();
        }

    }
}