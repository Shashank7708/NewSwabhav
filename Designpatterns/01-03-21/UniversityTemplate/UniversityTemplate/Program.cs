using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            University n1 = new TechnicalCourse();
            n1.startProcess();
            n1 = new NontechnicalCourse();
            n1.startProcess();
            Console.ReadLine();

        }
    }
}
