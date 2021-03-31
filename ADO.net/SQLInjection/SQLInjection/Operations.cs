using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace SQLInjection
{
    class Operations
    {
        public List<Department> GetData(int id)
        {
            using (var connect = new SqlConnection(Helper.CnnVal("Sample")))
            {
                var output = connect.Query<Department>($"select * from DEPT where DEPTNO={id}").ToList();
                return output;





                /*
                StringBuilder cmd = new StringBuilder("SELECT * FROM DEPT where 1=1");
                cmd.Append(" and DEPTNO=@id");
                SqlParameter param = new SqlParameter("@id", id);
                SqlCommand cmd1 = new SqlCommand(cmd.ToString(), connect);

                cmd1.Parameters.Add(param);
                List<Department> item = new List<Department>();
                using (var objReader = cmd1.ExecuteReader())
                {
                    
                        while (objReader.Read())
                        {
                            Department d = new Department()
                            {
                                DEPTNO = objReader.ge("DEPTNO"),
                                DNAME = objReader.GetString("DNAME"),
                                LOC = objReader.GetString("LOC")
                            };
                            item.Add(d);

                        }
            
                }
            }
                */
            }
        }
    }
}
