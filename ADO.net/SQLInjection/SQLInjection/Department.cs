using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLInjection
{
    class Department
    {
        public string DEPTNO { get; set; }
        public string DNAME { get; set; }
        public string LOC { get; set; }

        public string FULLINFO
        {
            get { return $"{DEPTNO} {DNAME} {LOC}"; }
        }

    }
}
