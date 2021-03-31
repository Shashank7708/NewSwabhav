using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPlusSubtract
{
    class Context
    { Strategy _strategy;
        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }
        public int runStrategy(int num1,int num2)
        {
            return this._strategy.doOperation(num1,num2);
        }
    }
}
