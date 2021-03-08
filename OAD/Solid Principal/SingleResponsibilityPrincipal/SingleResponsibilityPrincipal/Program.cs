using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank acc1 = new Bank() { bal = 4500, _accountno = 101 };
            Bank acc2 = new Bank() { bal = 1500, _accountno = 102 };
            Withdraw wd = new Withdraw();

            PrintInfo(wd.withdraw(acc1, 3000), acc1);
            PrintInfo(wd.withdraw(acc2, 1400), acc2);
            Console.Read();


        }
        static void PrintInfo(bool isSuccessful,Bank acc1)
        {
            if (isSuccessful)
            {
                Console.WriteLine("Transaction SuccessFul");
                Console.WriteLine(acc1.bal);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
