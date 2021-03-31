using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWorkEat
{
    class Manager:IworkEat
    {
        void IworkEat.starteat()
        {
            Console.WriteLine("Manager is eation");
        }
        void IworkEat.stopwork()
        {
            Console.WriteLine("Manager Has stop Working");
        }
        void IworkEat.startwork()
        {
            Console.WriteLine("I am Working");
        }
        void IworkEat.endeat()
        {
            Console.WriteLine("Manager stop eating");
        }
    }
}
