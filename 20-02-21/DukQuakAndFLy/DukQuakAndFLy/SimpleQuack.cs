using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukQuakAndFLy
{
    class SimpleQuack:Quack
    {
        void Quack.duckQuack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
