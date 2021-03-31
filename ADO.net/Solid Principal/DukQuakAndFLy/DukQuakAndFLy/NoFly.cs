using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukQuakAndFLy
{
    class NoFly:Fly
    {
        void Fly.duckfly()
        {
            Console.WriteLine("Fly Fly");
        }
    }
}
