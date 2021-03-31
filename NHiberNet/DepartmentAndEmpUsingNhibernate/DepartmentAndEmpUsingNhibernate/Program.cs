using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmpUsingNhibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session1 = Helper11.OpenSession())
            {
                using (var transaction1 = session1.BeginTransaction())
                {
                    var department = new Department { id = 4, name ="Geography" };
                    var employee = new Employee { id = 15, name = "Sharon", salary = 26000, position = "" };

                    employee.Department = department;
                    department.Employee.Add(employee);
                    session1.Save(department);
                    transaction1.Commit();
                    Console.WriteLine("Done");



                }

            }
            Console.ReadLine();


        }
    }
}
