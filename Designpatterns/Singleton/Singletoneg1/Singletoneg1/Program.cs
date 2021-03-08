using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletoneg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.instanceOfSingleton;
            singleton.Dosomething();
            Console.ReadLine();
        }
    }
}
