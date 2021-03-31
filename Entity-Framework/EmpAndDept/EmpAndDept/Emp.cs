using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndDept
{
    class Emp
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public virtual Dept dept { get; set; }
    }
}
