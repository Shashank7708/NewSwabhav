using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoListAsPerUser.Models;

namespace ToDoListAsPerUser.Repository
{
    public class SwabhavDbContext1:DbContext
    {

        public SwabhavDbContext1() : base("SwabhavDbContext1")
        {

        }

        public DbSet<User1> users { get; set; }
        public DbSet<Task> tasks { get; set; }
        public DbSet<Subtask> subtasks { get; set; }



    }
}