using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityTemplate
{
  abstract  class University
    {
        public abstract void fillForm();
     
        public abstract void feePayment();
        public void startProcess()
        {
            fillForm();
            
            feePayment();
        }
    }
}
