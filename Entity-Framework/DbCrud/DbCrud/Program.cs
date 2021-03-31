using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCrud
{
    class Program
    {
        public static SwabahvDbContext db = new SwabahvDbContext();
        static void Main(string[] args)
        {
            //   Create();
            var emp = db.emps.ToList().Where(e => e.esalary > 5000).Select(e => new { e.ename, e.esalary });
            foreach(var i in emp)
            {
                Console.WriteLine($"{i.ename} {i.esalary}");
            }
            Console.WriteLine("hello");
            var emp1 = db.emps.Where(e => e.esalary > 5000).Select(e => new { e.ename, e.esalary });
            foreach (var i in emp)
            {
                Console.WriteLine($"{i.ename} {i.esalary}");
            }
            
            Console.Read();
        }

        private static void Create()
        {
            try
            {
                Emp e1 = new Emp { eid = 1, ename = "Rahul", esalary = 40000 };
                Emp e2 = new Emp { eid = 2, ename = "Sumit", esalary = 30000 };
                db.emps.Add(e1);
                db.emps.Add(e2);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
