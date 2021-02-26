using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPPrincipalViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculation txc = new TaxCalculation(LogType.XML);

            Console.WriteLine(txc.calculate(10, 5));
            Console.WriteLine(txc.calculate(0, 0));
            Console.Read();
        }
    }
    public enum LogType
    {
        XML,
        TXT
    }
}
