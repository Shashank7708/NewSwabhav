using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukQuakAndFLy
{
    class SimpleFly:Fly
    {
        void Fly.duckfly()
        {
            Console.WriteLine("NoFly");
        }
    }
}
