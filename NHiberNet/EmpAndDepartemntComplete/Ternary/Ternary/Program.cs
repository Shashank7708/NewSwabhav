using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* using (var session2 = Helper11.OpenSession())
             {
                 using (var transaction = session2.BeginTransaction())
                 {
                     var category = new Department { name = "yomy" };
                     var post = new Employee { name = "GtAway",salary=4000,position="Manager" };


                     post.Department = category;
                     session2.Save(post);
                     if (post is Employee)
                     {
                         category.Employee.Add(post);
                     }
                     session2.Save(category);

                     transaction.Commit();
                     Console.WriteLine("hello");



                 }
             }
            */

            // InsertDepartment("History");
            // InsertEmp("Sharon",40000,"Asst-Manager","History");
            // InsertEmp("Vishal", 30000, "Developer", "History");
            //  InsertEmp("Shehan", 25000, "Developer", "History");
            // InsertEmp("Omkar", 50000, "Asst-Manager", "yomy");
            // InsertDepartment("Science");
            //  InsertEmp("Gaurav", 4000, "Manager", "Science");
            // InsertEmp("Omkar", 50000, "Asst-Manager", "Science");
            //  FindEmployee();
            FetchDepartentAndEMp();
            Console.WriteLine("Done");
            Console.ReadLine();
        }


        public static void InsertDepartment(string deptName)
        {
            using (var session = Helper11.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {


                    var department = new Department
                    {
                        name = deptName,
                    };

                    session.Save(department);
                    transaction.Commit();
                    Console.WriteLine($"Departent: {deptName} added.");
                }
                Console.Read();
            }
        }

        public static void InsertEmp(string name,double salary,string position, string categoryName)
        {
            using (var session = Helper11.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var departments = session.CreateCriteria<Department>().List<Department>();
                    int id = 0;
                    foreach (var cat in departments)
                    {
                        if (cat.name == categoryName)
                        {
                            id = cat.id;
                        }
                    }
                    var department = session.Get<Department>(id);



                    var employee = new Employee
                    {
                        name = name,
                        salary =salary,
                        position=position,
                    };

                    employee.Department = department;

                    session.Save(employee);
                    transaction.Commit();
                    Console.WriteLine($"Employee {name} added.");
                }
                Console.ReadKey();
            }
        }
        public static void FindEmployee()
        {
            using (var session = Helper11.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var data = session.Query<Employee>().Where(x => x.id == 2);
                    foreach (var cp in data)
                    {
                        Console.WriteLine($"Dept-id: {cp.id}\nName: {cp.name}\nSalary: {cp.salary}\nPosition: {cp.position}\nDepartment: {cp.Department.name}");
                    }
                }
            }
        }


        public static void FetchDepartentAndEMp()
        {
            using (var session = Helper11.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var emp = session.CreateCriteria<Employee>();
                    var dept = session.CreateCriteria<Department>();
                    var result = from i in session.CreateCriteria<Department>().List<Department>()
                                 join j in session.CreateCriteria<Employee>().List<Employee>()
                                 on i.id equals j.Department.id
                                 select new
                                 {
                                     j.id, j.position, j.salary, i.name
                                 };
                    foreach (var cp in result)
                    {
                        Console.WriteLine("Empp Info:");
                        Console.WriteLine($"Emp-Id: {cp.id} Emp-Position: {cp.position} Emp-Salary: {cp.salary} Deptartment: {cp.name}");
                    }
                }
            }

        }
    }
}
