using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SimpleEntityFramework
{
    class Program
    {
        public static DemoDbContext db = new DemoDbContext();
        static void Main(string[] args)
        {
            createTable();
            Console.WriteLine("DOne");
            Console.Read();
        }

        private static void createTable()
        {

            Employee e1 = new Employee { id = 101, Name = "Sonam" };
            Employee e2 = new Employee { id = 102, Name = "Rahul" };
            Employee e3 = new Employee { id = 103, Name = "Sumit" };


            db.employees.Add(e1);
            db.employees.Add(e2);
            db.employees.Add(e3);
            db.SaveChanges();
        }
    }
}