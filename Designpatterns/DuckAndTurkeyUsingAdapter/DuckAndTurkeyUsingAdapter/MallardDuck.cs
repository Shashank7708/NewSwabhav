using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAndTurkeyUsingAdapter
{
    class MallardDuck:Duck
    {
        void Duck.Quack()
        {
            Console.WriteLine("MallordDuck's Quack");
        }
        void Duck.fly()
        {
            Console.WriteLine("MallordDuck is Flying");
        }
    }
}
