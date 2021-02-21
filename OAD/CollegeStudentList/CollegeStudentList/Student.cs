using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollegeStudentList
{
    class Student
    {
        private int id;
        private string studentName;
        private string collegeName;
        private string clas;
        private string department;
        public List<Student> studentlist = new List<Student>(); 
        public Student(int id,string name,string collegeName,string clas,string dept)
        {
            this.id = id;
            this.studentName = name;
            this.collegeName = collegeName;
            this.clas = clas;
            this.department = dept;
            
            
        }
        public int Getid()
        {
            return this.id;
        }
        public string Getname()
        {
            return this.studentName;
        }
        public string GetCollegeName()
        {
            return this.collegeName;
        }
        public string GetClass()
        {
            return this.clas;
        }
        public string getDepartment()
        {
            return this.department;
        } 
    }
}
