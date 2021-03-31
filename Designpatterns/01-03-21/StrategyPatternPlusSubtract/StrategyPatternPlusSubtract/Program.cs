using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPlusSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c1 = new Context(new OperationAdd());
            Console.WriteLine("Operation Add: " + c1.runStrategy(4, 5));

            Context c2 = new Context(new OperationSubtract());
            Console.WriteLine("Operation Subtract: " + c2.runStrategy(7, 3));


            Context c3 = new Context(new OperationMultiply());
            Console.WriteLine("Operation Multiply: " + c3.runStrategy(7, 3));
            Console.ReadLine();

        }
    }
}
