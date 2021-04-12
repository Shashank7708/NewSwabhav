using DTOEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTOEmployee.Service
{
    public class ServiceLayer:IServiceLayer
    {
        static List<Employee> employees = new List<Employee>();

        public List<Employee> getEmployee()
        {
            var e1 = new Employee { id = 1, name = "Romy", designation = "Manager", salary = 40000 };
            var e2 = new Employee { id = 2, name = "Roy", designation = "Developer", salary = 1000 };

            employees.Add(e1);
            employees.Add(e2);
          
            return employees;
        }
        public void insert(Employee e)
        {

            employees.Add(e);
        }

        public void delete(DtoDeleteEmp e)
        {
            var emp = employees.SingleOrDefault(x => x.id == e.id);
            employees.Remove(emp);
        }

        
    }
}