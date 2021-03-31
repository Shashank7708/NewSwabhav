using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndDept
{   [Table("Dept")]
    class Dept
    {
        [Key]
        public int Deptid { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual List<Emp> DeptEmployee { get; }
        public Dept()
        {
            DeptEmployee = new List<Emp>();
        }
    }
}
