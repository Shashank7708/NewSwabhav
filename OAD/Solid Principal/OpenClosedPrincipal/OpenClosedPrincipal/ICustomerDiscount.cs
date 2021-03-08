using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipal
{
    interface ICustomerDiscount
    {
        double customerDiscount(double subTotal);
    }
}
