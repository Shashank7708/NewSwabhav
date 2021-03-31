using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmployeeListFromDatabase
{
    class Department
    {
        public int DEPTNO { get; set; }
        public string DNAME { get; set; }
        public string LOC { get; set; }

        public string FULLINFO
        {
            get { return $"{DEPTNO} {DNAME} {LOC}"; }
        }

    }
}
