using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWorkEat
{
    class Robot:IworkEat
    {
        void IworkEat.starteat()
        {
            Console.WriteLine("Robot is eation");
        }
        void IworkEat.stopwork()
        {
            Console.WriteLine("Robot Has stop Working");
        }
        void IworkEat.startwork()
        {
            Console.WriteLine("Robot am Working");
        }
        void IworkEat.endeat()
        {
            Console.WriteLine("Robot stop eating");
        }
    }
}
