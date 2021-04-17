using ChainOfResponsibilityPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Interface
{
    class Division:IChain
    {
        private IChain _nextInChain;
        public double Calculate(Numbers request)
        {
            if (request.Operation.ToLower().Equals("division"))
            {
                return (request.Number1/request.Number2);
            }
            else
            {
                return -0.00;
            }
        }

        public void SetNextChain(IChain nextChain)
        {
            this._nextInChain = nextChain;
        }
    }
}
