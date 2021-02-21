using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStudentList
{
    class Program
    {
        static College c = new College();

        static List<College> collegelist = new List<College>();
        static void Main(string[] args)
        {   
            
            AddtoCollege(101, "Rahul", "StJohn", "5","Computer Science",7701,"Vasai");
           AddtoCollege(102, "Romy", "StJohn", "10","EXTC",7701, "Vasai");
            AddtoCollege(103, "Shehan", "StJohn", "12","Computer Science", 7701, "Vasai");
            AddtoCollege(104, "Chinmay", "StJohn", "10","Mechanical", 7701, "Vasai");
            AddtoCollege(105, "Sharon", "StJohn", "11","EXTC", 7701, "Vasai");

            AddtoCollege(106, "Sumit", "francis", "12", "Computer Science",801,"Borivali");
            AddtoCollege(107, "Maria", "francis", "4","EXTC", 801, "Borivali");
            AddtoCollege(108, "Sharan", "francis", "8","Mechanical", 801, "Borivali");
            AddtoCollege(109, "Dany", "Francis", "9","Computer Science", 801, "Borivali");
            AddtoCollege(110, "Baban", "francis", "10","EXTC", 801, "Borivali");
            
            PrintStudentDetails(c.studentlist);
            Console.ReadLine();

            
            

        }
        static void AddtoCollege(int id,string name,string collegename,string clas,string dept,
            int clgid,string location) 
        {
            
            c.AddToStudentList(id, name, collegename, clas,dept,clgid,location);
            
            
        }

        static void PrintStudentDetails(List<Student> Studentdetail)
        { 
            foreach(Student i in Studentdetail)
            {
                
                Console.WriteLine("{0}  {1}  {2}  {3}", i.Getid(), i.Getname(), i.GetCollegeName(), i.GetClass());
            }
        }
    }
}
