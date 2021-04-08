using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListAsPerUser.Models;
using ToDoListAsPerUser.Repository;

namespace ToDoListAsPerUser.Service
{
    public static class TaskService
    {

        static TaskRepo taskRepo = new TaskRepo();

        public static void insert(Task t)
        {
            // Task t = new Task { id = 1, name = "dummy", date = "25-10-21" };
            //Subtask subtask = new Subtask { id = 2, name = "dumm2", date = "25-10-21", status = "undone" };
            // subtask.Task = t;
            // t.subtasklist.Add(subtask);
            taskRepo.Insert(t);
        }

        public static List<Task> tasks()
        {
            return taskRepo.gettasks();
        }


        public static void insertsubTask(Subtask t)
        {
           taskRepo.InsertSubtask(t);
        }



        public static List<Subtask> subtasks(int id)
        {
            return taskRepo.getsubtask(id);
        }

        public static bool edittask(Task t)
        {
            return taskRepo.editTask(t);
        }

        public static bool editsubtask(Subtask t)
        {
            return taskRepo.editSubtask(t);
        }

        public static bool deletetask(int id)
        {
            return taskRepo.deletetask(id);
        }

        public static bool delesubtask(Subtask t)
        {
            return taskRepo.deletesubtask(t);
        }


        public static List<Subtask> getAllSubtask()
        {
            return taskRepo.getAllSubtask1();
        }

        public static void insertuser(User1 m)
        {
            taskRepo.InsertUser(m);
        }

        public static List<User1> users()
        {
            return taskRepo.getusers();
        }

    }
}