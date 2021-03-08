using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Audi:IAutoMobile
    {
       void IAutoMobile.start()
        {
            Console.WriteLine("Start Audi");
        }
        void IAutoMobile.stop()
        {
            Console.WriteLine("Stop Audi");
        }
    }
}
