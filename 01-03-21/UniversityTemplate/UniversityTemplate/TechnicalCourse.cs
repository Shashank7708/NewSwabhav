using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityTemplate
{
    class TechnicalCourse:University
    {
        public override void fillForm()
        {
            Console.WriteLine("Filling Technical Course Form");
        }
        public override void feePayment()
        {
            Console.WriteLine("Paying Technical Course Fee");
        }
       
    }
}
