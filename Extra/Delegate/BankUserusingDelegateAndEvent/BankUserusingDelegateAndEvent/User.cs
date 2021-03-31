using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserusingDelegateAndEvent
{
  public  class User
    {
      public  void TransactionWithdraw(Bank b1,double amt)
        {
            Console.WriteLine("\nBOI-Accountno:{0} \nWithdraw:{1}\nAvailabe balance:{2}", b1.AccountNo,amt,b1.Balance); ;
        }
      public  void TransactionDeposit(Bank b1, double amt)
        {
            Console.WriteLine("\nBOI-Accountno:{0} \nDeposit:{1}\nAvailabe balance:{2}", b1.AccountNo, amt,b1.Balance);
        }

    }
}
