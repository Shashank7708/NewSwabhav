using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndDept
{
    class Program
    {
        public static Swabhav1Db db = new Swabhav1Db();
        static void Main(string[] args)
        {
          /*  var d1 = new Dept { Deptid = 101, Name = "IT", Location = "Mumbai" };
             var e1 = new Emp { EmpId = 1, Name = "Rahul", Salary = 40000 };
             var e2 = new Emp { EmpId = 2, Name = "Romy", Salary = 30000 };
             var e3 = new Emp { EmpId = 3, Name = "Rohan", Salary = 25000 };
             e1.dept = d1;
             e2.dept = d1;
             e3.dept = d1;

             d1.DeptEmployee.Add(e1);
             d1.DeptEmployee.Add(e2);
             d1.DeptEmployee.Add(e3);

             db.Departments.Add(d1);
             db.SaveChanges();
          */
            
         Delete();
            Operations();
            Console.WriteLine("Success");
            Console.Read();
        }

        private static void Operations()
        {   //Print all Employees
            var emp1 = from emp7 in db.Employees
                       select new
                       {
                           emp7.EmpId,
                           emp7.Name,
                           emp7.Salary,
                           emp7.dept
                       };
            emp1.ToList();
            foreach(var emp6 in emp1)
            {
                Console.WriteLine($"{emp6.Name} {emp6.Name} {emp6.Salary} {emp6.dept.Deptid}");
            }
            
            //Count no of emp in each dept Using Groupby
            Console.WriteLine("\nCount Emp based on deptid");
            var empGroupbydept = from emp10 in emp1
                                 group emp10 by emp10.dept;
            foreach(var emp10 in empGroupbydept)
            {
                Console.WriteLine($"{emp10.Key.Name} {emp10.Count()}");
            }

            //Count No of employee Employees
            var noofemployee = db.Employees.Count();
            Console.WriteLine("\nTotl no of Emp in Company: " + noofemployee);

            //Order emp by names
            var emporderbynames = from emp3 in db.Employees
                                  orderby emp3.Name
                                  select new
                                  {
                                      emp3.EmpId,
                                      emp3.Name,
                                      emp3.Salary
                                  };
            var emplist = db.Employees.ToList();
            Console.WriteLine("\nOrder BY names");
            foreach(var i in emporderbynames) 
            {
                Console.WriteLine($"{i.EmpId} {i.Name} {i.Salary}");
            }

            //search and print an employee
            Console.WriteLine("\nSearch Result:");
            var emp = db.Employees.SingleOrDefault(x => x.EmpId == 1);
            if (emp != null)
            {
                Console.WriteLine($"{emp.EmpId} {emp.Name} {emp.Salary}");
            }
           


        }

        public static void Delete()
        {
            foreach(var d in db.Employees)
            {
                if (d.EmpId==2||d.EmpId==4||d.EmpId==6)
                {
                    db.Employees.Remove(d);
                    
                }
            }
            var result = db.Departments.SingleOrDefault(b => b.Deptid == 2);
           if (result != null)
            {
                result.Name = "HR";
            }
            db.SaveChanges();

        }
    }
}
