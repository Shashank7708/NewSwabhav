using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAndTurkeyUsingAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            Turkey turkey = new WildTurkey();

            Duck turkeyAdapter = new AdapterTurkey(turkey);
            Console.WriteLine("Turkey does:");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("Duck does:");
            duck.fly();
            duck.Quack();

            Console.WriteLine("TurkeyAdapter does:");
            turkeyAdapter.Quack();
            turkeyAdapter.fly();
            Console.ReadLine();

        }
    }
}
