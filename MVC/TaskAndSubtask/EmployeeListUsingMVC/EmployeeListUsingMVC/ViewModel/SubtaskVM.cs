using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeListUsingMVC.ViewModel
{
    public class SubtaskVM
    {   
       public string parentname { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string status { get; set; }


    }
}