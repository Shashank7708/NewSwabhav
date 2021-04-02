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
           // Employee e = new Employee { id = 0, name = "Rahul", position = "Manager", age = 35, salary = 45000 };
           // emplist.Add(e);
            return emplist;
        }

        
        public void insertEmp(Employee e)
        {
            emplist.Add(e);
        }


    }
}