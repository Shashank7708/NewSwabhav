using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace GetEmployeeListFromDatabase
{
    class Operations
    {
        public List<Department> GetDEPT()
        {
            using (IDbConnection connect = new SqlConnection(Helper.CnnVal("Sample")))
            {
                Console.WriteLine("Connection Sucessfull...!");
                Console.WriteLine("Connected Database :" + connect.Database);



                var output = connect.Query<Department>("select * from DEPT").ToList();
                return output;



            }

        }

        internal void insertIntoDeptTable(int deptno, string deptName, string deptLoc)
        {   
            using (var connect = new SqlConnection(Helper.CnnVal("Sample")))
            {
                Department d = new Department { DEPTNO = deptno, DNAME = deptName, LOC = deptLoc };
                List<Department> deptList = new List<Department>();
                deptList.Add(d);
                connect.Execute("Insert_In_DEPT @DEPTNO,@DNAME,@LOC", deptList);
            }
        }

        public void deleteFromDeptTable(int deptNo)
        {   
            try
            {
                var deptNO = deptNo;
                using (var connect = new SqlConnection(Helper.CnnVal("Sample")))
                {
                    connect.Execute($"delete from DEPT where DEPTNO={deptNO}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateDeptTable(int deptno, string Dname)
        {
            try
            {
                using (var connect = new SqlConnection(Helper.CnnVal("Sample")))
                {
                    connect.Execute($"Update DEPT set DNAME='{Dname}' where DEPTNO={deptno}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Department> GetDEPT1()
        {
            using (IDbConnection connect = new SqlConnection(Helper.CnnVal("Sample")))
            {
                var output1 = connect.Query<Department>("select * from DEPT where DEPTNO in(select DEPTNO from EMP where ENAME='SMITH')").ToList();
                return output1;
            }
        }
    }
}