using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEg
{
    class Calculator
    {  
        public event DCalculateAlert AditionCompleted = null;
        public void Add(int x,int y,int answer)
        {
            if (AditionCompleted != null)
            {
                AditionCompleted(x, y, x + y);
            }
        }
    }
}
