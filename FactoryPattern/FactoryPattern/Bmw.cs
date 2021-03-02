using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Bmw:IAutoMobile
    {
        void IAutoMobile.start()
        {
            Console.WriteLine("Start BMW");
        }
        void IAutoMobile.stop()
        {
            Console.WriteLine("Stop BMW");
        }
    }
}
