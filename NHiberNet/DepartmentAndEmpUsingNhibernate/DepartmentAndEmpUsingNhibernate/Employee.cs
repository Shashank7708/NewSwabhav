using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmpUsingNhibernate
{
   public class Employee
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual double salary { get; set; }
        public virtual string position { get; set; }
        public virtual Department Department { get; set; }

    }
}
