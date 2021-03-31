using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCrud
{   [Table("Emp")]
    class Emp
    {   [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public double esalary { get; set; }
        

    }
}
