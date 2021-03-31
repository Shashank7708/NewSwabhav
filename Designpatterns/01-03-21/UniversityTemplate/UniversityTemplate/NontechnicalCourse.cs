using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityTemplate
{
    class NontechnicalCourse:University
    {
        public override void fillForm()
        {
            Console.WriteLine("Filling nonTechnical Course Form");
        }
        public override void feePayment()
        {
            Console.WriteLine("Paying non Technical Course Fee");
        }

    }
}
