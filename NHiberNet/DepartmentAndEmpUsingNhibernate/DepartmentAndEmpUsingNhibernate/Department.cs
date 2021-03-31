using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmpUsingNhibernate
{
    public class Department
    {
        public virtual int id{get;set;}
        public virtual string name { get; set; }
        public virtual IList<Employee> Employee { get; set; } = new List<Employee>();

    }
}
