using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CollegeStudentList
{
    class College
    { public List<Student> studentlist = new List<Student>();
       
        
        public void AddToStudentList(int id,string studentname,string collegeName,string clas,
            string dept,int clgid,string location)
        {
            Student studentdetail = new Student(id, studentname, collegeName, clas,dept);
            if (studentdetail.GetCollegeName().ToLower().Equals("stjohn"))
            {
                studentlist.Add(studentdetail);
                studentlist.Sort((x, y) => x.GetClass().CompareTo(y.GetClass()));
            }
            else if (studentdetail.GetCollegeName().ToLower().Equals("francis"))
            {
                studentlist.Add(studentdetail);
                studentlist.Sort((x, y) => x.GetClass().CompareTo(y.GetClass()));
            }
         }
       
       
        

    }
}
