using EmployeeListUsingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;

namespace EmployeeListUsingMVC.Repository
{
    public class SwabhavRepo
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


        public List<Task> gettasks()
        {
            List<Task> list = new List<Task>();
            foreach(var i in db.tasks)
            {
                list.Add(i);
            }
            return list;

        }
        public List<Subtask> getsubtask(int id)
        {
            List<Subtask> subtasks = new List<Subtask>();
            foreach(var i in db.subtasks)
            {
                if (i.Task.id == id)
                {
                    subtasks.Add(i);
                }
            }
            return subtasks;
        }


        public  bool editTask(Task t)
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


        public bool deletetask(Task t)
        {
            
            var task = db.tasks.SingleOrDefault(x => x.id == t.id);
          List<Subtask> subtasklist=new List<Subtask>();
            var subtask = new Subtask();
           if (task != null)
            {
                foreach(var i in db.subtasks){
                    if (i.Task.id == task.id)
                    {
                        subtasklist.Add(i);
                    }
                    
                }
            }
           foreach(var i in subtasklist) { db.subtasks.Remove(i); }
         
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


       static UserRepo userdb = new UserRepo();

        public void insermembers(Membership1 u)
        {
            userdb.memberships.Add(u);
            userdb.SaveChanges();
        }

        public List<Membership1> getmembers()
        {
            return userdb.memberships.ToList();
        }


    }

}