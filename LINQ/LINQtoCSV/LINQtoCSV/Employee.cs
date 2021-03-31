using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoCSV
{
    class Employee
    {
        public int EMPNO { get; set; }
        public string ENAME { get; set; }
        public string JOB { get; set; }
        public string MGR_ID { get; set; }
      public string DOJ { get; set; }
        public string SAL { get; set; }
        public string COMM { get; set; }
        public int DEPTNO { get; set; }

        internal static Employee ParseRow(string row)
        {
            var column = row.Split(',');
      
                return new Employee()
                {
                    EMPNO = int.Parse(column[0]),
                    ENAME = column[1],
                      JOB = column[2],
                   MGR_ID =column[3].ToString(),
                     DOJ = column[4].ToString(),
                     SAL = column[5].ToString(),
                     COMM = column[6].ToString(),
                      DEPTNO = int.Parse(column[7]),
                };
            
      
        }

        public string EMPINFO
        {
            get
            {
                return $"{EMPNO,4} {ENAME,10} {JOB,10} {MGR_ID,4} {DOJ,10}  {SAL,6} {COMM,6} {DEPTNO,5}";
            }
        }
    }
}
