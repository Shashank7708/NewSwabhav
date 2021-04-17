using ChainOfResponsibilityPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Interface
{
    class Subtract : IChain
    {
        private IChain _nextInChain;
        public double Calculate(Numbers request)
        {
            if (request.Operation.ToLower().Equals("subtract"))
            {
                return request.Number1 - request.Number2;
            }
            else
            {
               return _nextInChain.Calculate(request);
            }
        }

        public void SetNextChain(IChain nextChain)
        {
            this._nextInChain = nextChain;
        }
    }
}
