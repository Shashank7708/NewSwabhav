using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPlusSubtract
{
    class OperationAdd:Strategy
    {
        int Strategy.doOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
