using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccounPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Saving s1 = new Saving(101, "Romy", 2500);
            Current c1 = new Current(201,"Rohan",4500);
            
            PrintAccountDetails(c1);
            c1.deposit(1000);
            AfterWithdraw(c1);
            c1.withdraw(2000);
            AfterWithdraw(c1);
            c1.withdraw(3400);
            AfterWithdraw(c1);
            c1.withdraw(400);
            Console.Read();


        }
        private static void PrintAccountDetails(Current c)
        {
            Console.WriteLine("Account_no: {0}\nAccoount_Name: {1}\nBalance: {2}", c.GetAcc_no(), c.GetAccountName(), c.GetBalance());
        }
        private static void AfterWithdraw(Current c)
        {
            Console.WriteLine("After Transaction");
            Console.WriteLine("Bal:" + c.GetBalance());
        }
    }
}
