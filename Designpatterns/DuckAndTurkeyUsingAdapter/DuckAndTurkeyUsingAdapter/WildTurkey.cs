using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAndTurkeyUsingAdapter
{
    class WildTurkey:Turkey
    {
        void Turkey.Gobble()
        {
            Console.WriteLine("wildTurkey's Gobble");
        }
        void Turkey.Fly()
        {
            Console.WriteLine("WildTurkey is flying");
        }
    }
}
