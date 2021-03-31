using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukQuakAndFLy
{
    class Program
    {
        static void Main(string[] args)
        {
            Fly f1 = new NoFly();
            f1.duckfly();
            Fly f2 = new SimpleFly();
            f2.duckfly();
            Quack q1 = new SimpleQuack();
            q1.duckQuack();
            Quack q2 = new NoQUack();
            q2.duckQuack();
            Console.Read();
        }
    }
}
