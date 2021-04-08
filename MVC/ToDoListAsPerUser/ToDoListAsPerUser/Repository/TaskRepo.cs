using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListAsPerUser.Models;

namespace ToDoListAsPerUser.Repository
{
    public class TaskRepo
    {
        static SwabhavDbContext1 db = new SwabhavDbContext1();
        public void Insert(Task t)
        {
            db.tasks.Add(t);
            db.SaveChanges();
        }


        public void InsertSubtask(Subtask t)
        {
            db.subtasks.Add(t);
            db.SaveChanges();
        }

        public void InsertUser(User1 u)
        {
            db.users.Add(u);
            db.SaveChanges();
        }


        public List<Task> gettasks()
        {
            List<Task> li = new List<Task>();
            foreach(var i in db.tasks)
            {
                li.Add(i);
            }
            return li;


        }
        public List<Subtask> getsubtask(int id)
        {
            List<Subtask> subtasks = new List<Subtask>();
            foreach (var i in db.subtasks)
            {
                if (i.Task.id == id)
                {
                    subtasks.Add(i);
                }
            }
            db.SaveChanges();
            return subtasks;

        }


        public bool editTask(Task t)
        {
            var task = db.tasks.SingleOrDefault(x => x.id == t.id);
            if (task != null)
            {
                task.name = t.name;
                task.date = t.date;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool editSubtask(Subtask t)
        {
            var task = db.subtasks.SingleOrDefault(x => x.id == t.id);
            if (task != null)
            {
                task.name = t.name;
                task.date = t.date;
                task.status = t.status;
                db.SaveChanges();
                return true;
            }
            return false;



        }


        public bool deletetask(int id)
        {

            var task = db.tasks.SingleOrDefault(x => x.id == id);
            List<Subtask> subtasklist = new List<Subtask>();
            var subtask = new Subtask();
            if (task != null)
            {
                foreach (var i in db.subtasks)
                {
                    if (i.Task.id == task.id)
                    {
                        subtasklist.Add(i);
                    }

                }
            }
            foreach (var i in subtasklist) { db.subtasks.Remove(i); }

            if (task != null)
            {
                db.tasks.Remove(task);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public bool deletesubtask(Subtask t)
        {
            var task = db.subtasks.SingleOrDefault(x => x.id == t.id);
            if (task != null)
            {
                db.subtasks.Remove(task);
                db.SaveChanges();
                return true;
            }
            return false;

        }


        public List<Subtask> getAllSubtask1()
        {
            return db.subtasks.ToList();
        }


        public List<User1> getusers()
        {
            return db.users.ToList();
        }


    }
}