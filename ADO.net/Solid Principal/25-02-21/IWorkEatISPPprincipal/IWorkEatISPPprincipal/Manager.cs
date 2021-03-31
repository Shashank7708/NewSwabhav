using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWorkEatISPPprincipal
{
    class Manager:IWork,IEat
    {
        void IEat.starteat()
        {
            Console.WriteLine("Manager is eation");
        }
        void IWork.stopwork()
        {
            Console.WriteLine("Manager Has stop Working");
        }
        void IWork.startwork()
        {
            Console.WriteLine("I am Working");
        }
        void IEat.endeat()
        {
            Console.WriteLine("Manager stop eating");
        }
    }
}
