using EmployeeListUsingMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeListUsingMVC.Repository
{
    public class SwabhavDbContext1:DbContext
    {
        public SwabhavDbContext1() : base("SwabhavDbContext1")
        {

        }

        public DbSet<Task> tasks { get; set; }
        public DbSet<Subtask> subtasks { get; set; }

    }

}