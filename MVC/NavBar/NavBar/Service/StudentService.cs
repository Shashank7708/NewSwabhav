using NavBar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavBar.Service
{
    public static class StudentService
    {
        public static bool Validate(string login,string password)
        {
            if (login == "admin" && password == "Admin")
                return true;
            return false;
        }

        public static List<Student> getstudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { id = 1, name = "Romy" });
            students.Add(new Student { id = 2, name = "Roy" });
            students.Add(new Student { id = 3, name = "Rahul" });
            students.Add(new Student { id = 4, name = "Rohit" });
            return students;

        }

    }
}