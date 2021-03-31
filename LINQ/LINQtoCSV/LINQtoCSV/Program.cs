using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LINQtoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var deptlist = processDeptCsv("C:\\NewSwabhav\\CsvFiles\\Dept.csv");
           var employeelist = proceeEMPCsv("C:\\NewSwabhav\\CsvFiles\\Emp.csv");
           
            foreach(var i in employeelist)
            {
                Console.WriteLine(i.EMPINFO);
            }
            Console.WriteLine("\n\nDepartment Info:");
            foreach(var i in deptlist)
            {
                Console.WriteLine(i.DEPTINFO);
            }
            Console.WriteLine("\nSorted Department List:");
            deptlist = deptlist.OrderBy(x => x.DNAME);
            foreach (var i in deptlist)
            {
                Console.WriteLine(i.DEPTINFO);
            }
           
            //Console.WriteLine($"Search Result:\n{j}");
           var empAndDept= from emp in employeelist
                           join dept in deptlist
                           on emp.DEPTNO equals dept.DEPTNO
                           select new
                           {
                               dept.DEPTNO,
                               dept.DNAME,
                               emp.ENAME,
                               emp.DOJ
                           };
            Console.WriteLine("\nInnerJoin:");
            foreach( var i in empAndDept)
            {
                Console.WriteLine($"{i.DEPTNO,6} {i.DNAME,6} {i.ENAME,5}{i.DOJ,5}");
            }
            var list = deptlist.Where(x => x.DEPTNO > 10).OrderBy(x=>x.DEPTNO);
            Console.WriteLine("Get Dept on Greater than 10");
            foreach(var i in list)
            {
                Console.WriteLine($"{i.DEPTNO,4}{i.DNAME,10}");
            }
            var deptno = from i in deptlist
                         select new
                         {
                             i.DEPTNO
                         };
            Console.WriteLine("Only deptNo");
            foreach (var i in deptno)
            {
                Console.WriteLine($"{i.DEPTNO}");
            }
            var sumOfDeptNo = deptlist.Sum(x => x.DEPTNO);
            Console.WriteLine("Sum of deptNO:" + sumOfDeptNo);


            Console.ReadLine();
        }

       /* public bool GetRow(string address)
        {   
            IEnumerable<Department> li=cc;
        }*/
        private static IEnumerable<Department> processDeptCsv(string address)
        {
            return File.ReadAllLines(address).Skip(1).Where(row => row.Length > 0).Select(Department.ParseRow).ToList();
        }

        private static IEnumerable<Employee> proceeEMPCsv(string address)
        {
            return File.ReadAllLines(address).Skip(1).Where(row => row.Length > 0).Select(Employee.ParseRow).ToList();
        }


    }
}

