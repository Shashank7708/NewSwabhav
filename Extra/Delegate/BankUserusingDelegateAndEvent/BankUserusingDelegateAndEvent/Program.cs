using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserusingDelegateAndEvent
{
    public delegate void DelegateWithdraw(Bank b1, double amt);
    public delegate void DelegateDeposit(Bank b1, double amt);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banking application Using Event And Delegate");
            Bank b1 = new Bank(101, "Rahul", 2000f);
            User user1 = new User();


            Transaction t1 = new Transaction();
            t1.DepositEvent += user1.TransactionDeposit;
            t1.WithdrawEvent += user1.TransactionWithdraw;
            t1.Withdraw(b1, 500);
            t1.Deposit(b1, 200);
            Console.Read();


        }
        

        
    }
}
