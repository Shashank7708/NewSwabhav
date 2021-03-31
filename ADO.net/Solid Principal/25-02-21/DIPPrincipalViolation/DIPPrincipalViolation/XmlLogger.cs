using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPPrincipalViolation
{
    class XmlLogger
    {
        public void log(String logerror)
        {
            Console.WriteLine("Printing Error to XML File");
            Console.WriteLine(logerror);
        }
    }
}
