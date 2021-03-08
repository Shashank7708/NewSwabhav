using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipal
{
    class GoldCustomer:ICustomerDiscount
    {
        double ICustomerDiscount.customerDiscount(double subTotal)
        {
            return subTotal - (subTotal * .5);
        }
    }
}
