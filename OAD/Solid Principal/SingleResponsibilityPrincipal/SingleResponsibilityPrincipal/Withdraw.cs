using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipal
{
    class Withdraw
    { 
        public bool withdraw(Bank b,double amt)
        {
            if (b.bal - amt > 500)
            {
                return true;
            }
            else
                return false;
        }
    }
}
