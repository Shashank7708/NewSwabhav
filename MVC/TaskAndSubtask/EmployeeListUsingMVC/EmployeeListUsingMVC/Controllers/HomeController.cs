using EmployeeListUsingMVC.Models;
using EmployeeListUsingMVC.Service;
using EmployeeListUsingMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeListUsingMVC.Controllers
{
    public class HomeController : Controller
    {


     


       public ActionResult Login()
        {
            return View();
        }    
    
        [HttpPost]
        public ActionResult Login2(User user)
        {
            if (TaskService.Validate(user.txtlogin, user.txtpassword))
            {
                Session["login"] = user.txtlogin;
                return Redirect("~/Home/Gettasks");
            }
            else
            {
                ViewBag.message = "Invalid User";
            }
            return View("Login");
        }

       


        public ActionResult insert()
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
         
            return View();
        }

        [HttpPost]
        public ActionResult insert(TaskVM t)
        {
           

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
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
            List<Task> tasks = new List<Task>();
            foreach(var i in TaskService.tasks())
            {
                tasks.Add(i);
            }
           
            return View(tasks);
        }

        public ActionResult Edit(int id)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }

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
        public ActionResult Edit(Task t)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }

            if (ModelState.IsValid)
            {
               bool result= TaskService.edittask(t);
                if (result == true) { ViewBag.message = "Edited Successfully"; }
                else { ViewBag.message = "Edited not Possible"; }
            }
            return Redirect("~/Home/Gettasks");

        }

       
        public ActionResult Delete(int id)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
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
        public ActionResult Delete(Task t)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }

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
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }


            List<Subtask> tasks = new List<Subtask>();
            foreach(var i in TaskService.subtasks(id))
            {
                tasks.Add(i);
            }
            return View(tasks);

        }

      public ActionResult insertsubtask(int id)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
            ViewBag.id = id;
            return View();

        }

        [HttpPost]
        public ActionResult insertsubtask(AddSubTask subtask)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
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
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }

            Subtask task = new Subtask();
            foreach (var i in TaskService.getAllSubtask())
            {
                if (i.id == id) { task = i; }
            }
            return View(task);
        }

        [HttpPost]
        public ActionResult Edit1(SubtaskVM t)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
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




        public ActionResult Delete1(int id)
        {
            if (Session["login"] == null)
            {
                return Redirect("~/Home/Login");
            }
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

      

        public ActionResult logout()
        {
            Session["login"] = null;
            Session.Abandon();
            return Redirect("~/Home/Login");
            
        }
        public ActionResult Index()
        {
            return View();
        }

       

    }


}