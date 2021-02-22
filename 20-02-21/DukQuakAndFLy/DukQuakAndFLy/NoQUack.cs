using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukQuakAndFLy
{
    class NoQUack:Quack
    {
        void Quack.duckQuack()
        {
            Console.WriteLine("No Quack");
        }
    }
}
