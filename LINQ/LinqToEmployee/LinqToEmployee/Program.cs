using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEmployee
{
    class Program
    {
        static void Main(string[] args)
        {

         //   List<Employee> employeelist = new List<Employee>()
            
            Employee e1=    new Employee{name="Rahul",Job="manager",salary=40000};
           Employee e2= new Employee { name = "Sumit", Job = "manager", salary = 30000 };
            Employee e3 = new Employee { name = "Vishal", Job = "hr", salary = 40000 };
            Employee e4 = new Employee { name = "Romy", Job = "developer", salary = 25000 };
            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(e1);
            employeelist.Add(e2);
            employeelist.Add(e3);
            employeelist.Add(e3);
            var top3 = employeelist.OrderBy(x => x.salary).Take(3);
            Console.WriteLine("Top 3");
            foreach(Employee i in top3)
            {
                Console.WriteLine(i.FullInfo);
            }
            Console.ReadLine();

        }
    }
}
