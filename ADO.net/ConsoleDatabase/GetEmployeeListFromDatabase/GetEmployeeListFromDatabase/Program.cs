using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmployeeListFromDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation1 = new Operations();
  
            PrintDepartmentList();
            //  insertIntoDepartment(60, "HR", "COLOMBO");
            //  List<Department> deptlist1 = operation1.GetDEPT();
            // Console.WriteLine("AFTER INSERT:");
            // PrintDepartmentList(deptlist1);
            Console.WriteLine("After Deletion\n");
            RecordtodeleteFromDept(60);

            updateDepartmentTable( 40,"HR");
            Console.WriteLine("After Updation");
            PrintDepartmentList();
            Console.WriteLine("\n\n\nNested Query");
            List<Department> a = operation1.GetDEPT1();
            foreach(Department i in a)
            {
                Console.WriteLine(i.FULLINFO);
            }
            string b = "hhel";
            Console.WriteLine(b[1]);

            Console.ReadLine();

        }

        private static void updateDepartmentTable(int deptno, string dname)
        {
            Operations o1 = new Operations();
            o1.updateDeptTable(deptno, dname);
        }

        private static void RecordtodeleteFromDept(int deptNo)
        { List<int> deleteFromRecord = new List<int>();
            deleteFromRecord.Add(deptNo);
            Operations o1 = new Operations();
            o1.deleteFromDeptTable(deptNo);
        }

        private static void PrintDepartmentList()
        {
            Operations operation1 = new Operations();
            List<Department> deptlist1 = operation1.GetDEPT();
            Console.ForegroundColor = ConsoleColor.Red;
           foreach(Department i in deptlist1)
            {
                Console.WriteLine(i.FULLINFO);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void insertIntoDepartment(int deptno,string deptName,string deptLoc)
        {
            Operations o1 = new Operations();
            o1.insertIntoDeptTable(deptno, deptName, deptLoc);
        }
    }
}
