using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame1
{
    class Die
    {
        private int _value;

     static   int roll()
        {
            Random rnd = new Random();

            return rnd.Next(1, 6);
        }

        public int getValue()
        {
            this._value = (int)roll();
            return this._value;
        }
    }
}
