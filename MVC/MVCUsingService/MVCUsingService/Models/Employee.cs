using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCUsingService.Models
{
    public class Employee
    {   [Required(ErrorMessage ="Id Required")]
        public int id { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Name")]
        public string name { get; set; }


        [Required(ErrorMessage = "Please Enter Valid Position")]
        public string position { get; set; }

        [Required(ErrorMessage = "Age Cannot be Null")]
        [Range(18,60)]
        public int age { get; set; }


        [Required(ErrorMessage = "Salary Cannor be Null")]
        public double salary { get; set; }


    }

    public class EmployeeVM
    {

        public int age { get; set; }

        public string name { get; set; }
        public int id { get; set; }


        public string position { get; set; }

        
      


      
        public double salary { get; set; }
        public string salaryCol { get; set; }

    }

}