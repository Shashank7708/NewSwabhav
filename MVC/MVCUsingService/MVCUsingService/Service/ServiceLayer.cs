using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Services.Description;
using MVCUsingService.Models;

namespace MVCUsingService.Service
{   
    public class ServiceLayer
    { static List<Employee> emplist = new List<Employee>();
        
        public IEnumerable<Employee> GetPerson()
        {
            //Employee e = new Employee { id = 0, name = "Rahul", position = "Manager", age = 35, salary = 45000 };
            // emplist.Add(e);
            return emplist;
        }

        
        public void insertEmp(Employee e)
        {
            emplist.Add(e);
        }

        public Employee getAEmployee(int id)
        {
            Employee employee=new Employee();
            foreach(var i in emplist)
            {
                if (i.id == id)
                {
                    employee = i;
                    break;
                }
            }
            return employee;
        }

        public void Edit(Employee e)
        {
            foreach(var i in emplist)
            {
                if (i.id == e.id)
                {
                    i.name = e.name;
                    i.position = e.position;
                    i.salary = e.salary;
                    i.age = e.age;
                   
                }
            }
        }

        public void Delete(int id)
        {
            foreach (var i in emplist)
            {
                if (i.id == id)
                {
                    emplist.Remove(i);
                }
            }
        }

    }
}