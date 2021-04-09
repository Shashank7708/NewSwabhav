using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiCrud.Models;

namespace WebApiCrud.Service
{
    public static class ServiceLayer
    {

        static List<Employee> employees = new List<Employee>();

        public static List<Employee> getEmployee()
        {
            return employees.ToList();
        }
        public static void insert(Employee e)
        {
            var e1 = new Employee { id = 1, name = "Romy", designation = "Manager", salary = 40000 };
            var e2 = new Employee { id = 2, name = "Roy", designation = "Developer", salary = 1000 };

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e);
        }

        public static void editEmployee(Employee e)
        {
            var employee = employees.SingleOrDefault(x => x.id == e.id);
            if (employee != null)
            {
                employee.name = e.name;
                employee.designation = e.designation;
                employee.salary = e.salary;
            }
        }

        public static void deleteEmployee(int id)
        {
            var employee = employees.Where(x=>x.id==id).FirstOrDefault();
            if (employee != null)
            {
                employees.Remove(employee);
            }

        }
    }
}