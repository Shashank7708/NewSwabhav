using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Model
{
   public class Numbers
    {
        private int _number1;
        private int _number2;
        private string _operation;
        public Numbers(int number1,int number2,string operation)
        {
            this._number1 = number1;
            this._number2 = number2;
            this._operation = operation;
        }

        public int Number1
        {
            get { return this._number1; }
        }
        public int Number2
        {
            get { return this._number2; }
        }
        public string Operation
        {
            get { return this._operation; }
        }


    }
}
