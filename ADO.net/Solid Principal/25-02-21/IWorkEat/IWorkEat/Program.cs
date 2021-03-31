using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWorkEat
{
    class Program
    {
        static void Main(string[] args)
        {
            IworkEat r = new Robot();
            r.startwork();
            r.stopwork();
            r.starteat();
            r.endeat();
            Console.Read();
        }
    }
}
