using EmployeeListUsingMVC.Models;
using EmployeeListUsingMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeListUsingMVC.Service
{
    public static class TaskService
    {
      static  SwabhavRepo taskdb = new SwabhavRepo();

        public static bool Validate(string login, string password)
        {
           
            if (login == "admin" && password == "admin")
            {
                return true;
            }
            return false;
        }

        public static void insert(Task t)
        {
           // Task t = new Task { id = 1, name = "dummy", date = "25-10-21" };
            //Subtask subtask = new Subtask { id = 2, name = "dumm2", date = "25-10-21", status = "undone" };
           // subtask.Task = t;
           // t.subtasklist.Add(subtask);
            taskdb.Insert(t);
        }

       public static List<Task> tasks()
        {
            return taskdb.gettasks();
        }


        public static void insertsubTask(Subtask t)
        {
            taskdb.InsertSubtask(t);
        }



        public static List<Subtask> subtasks(int id)
        {
            return taskdb.getsubtask(id);
        }

        public static bool edittask(Task t)
        {
            return taskdb.editTask(t);
        }

        public static bool editsubtask(Subtask t)
        {
            return taskdb.editSubtask(t);
        }

        public static bool deletetask(Task t)
        {
          return  taskdb.deletetask(t);
        }

        public static bool delesubtask(Subtask t)
        {
            return taskdb.deletesubtask(t);
        }


        public static List<Subtask> getAllSubtask()
        {
            return taskdb.getAllSubtask1();
        }

        public static void insertmembers(Membership1 m)
        {
            taskdb.insermembers(m);
        }

        public static List<Membership1> members()
        {
            return taskdb.getmembers();
        }

    }
}