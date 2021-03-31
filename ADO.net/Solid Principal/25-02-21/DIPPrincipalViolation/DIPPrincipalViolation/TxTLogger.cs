using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPPrincipalViolation
{
    class TxTLogger
    {
        public void log(String error)
        {
            Console.WriteLine("Writing to text File");
            Console.WriteLine(error);
        }
    }
}
