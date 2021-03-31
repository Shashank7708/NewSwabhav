using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoCSV
{
    class Department
    {
        public int DEPTNO { get; set; }
        public string DNAME { get; set; }
        public string LOC { get; set; }

        public string DEPTINFO
        {
            get
            {
                return $"{DEPTNO,6} {DNAME,5} {LOC,10}";
            }
        }

        internal static Department ParseRow(string row)
        {
            var colum = row.Split(',');
            return new Department()
            {
                DEPTNO = int.Parse(colum[0]),
                DNAME = colum[1],
                LOC = colum[2]

            };
        }
    }
}
