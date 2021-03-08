using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUsingbuilderPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder(101);
            builder.SetName("Rahul");
            builder.SetBalance(4000);
            builder.branch("Vasai");
            builder.setInterestRate(4.5);
            //Account account = builder.build();
           // Console.WriteLine("AccountNO: " + account.AccountNo + "\nName:" + account.AccountHolderName + "\nBalance:" + account.Balance + "\nInterestRate:" + account.InterestRate);
            Console.Read();
            
        }
    }
}
