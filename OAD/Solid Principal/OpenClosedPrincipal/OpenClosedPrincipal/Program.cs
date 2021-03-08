using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price: 500");
            ICustomerDiscount goldCustomer = new GoldCustomer();
           Console.WriteLine("Discounted Price for Gold Customer:"+ goldCustomer.customerDiscount(500));
            ICustomerDiscount normalCustomer = new NormalCustomer();
            Console.WriteLine("Normal Customer:" + normalCustomer.customerDiscount(500));
            Console.ReadLine();
        }
    }
}
