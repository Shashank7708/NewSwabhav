using ChainOfResponsibilityPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Interface
{
    interface IChain
    {
         void SetNextChain(IChain nextChain);

        double Calculate(Numbers request);
    }
}
