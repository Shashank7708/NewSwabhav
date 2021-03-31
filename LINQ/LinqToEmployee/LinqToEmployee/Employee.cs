using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEmployee
{
    class Employee
    {
        public string name { get; set; }
        public string Job { get; set; }
        public double salary { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{name} {Job} {salary}";
            }
        }
    }
}
