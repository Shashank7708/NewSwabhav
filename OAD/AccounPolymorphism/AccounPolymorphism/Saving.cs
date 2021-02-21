using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccounPolymorphism
{
    class Saving:Account
    {
        private const int MIN_Balance = 500;
        public Saving(int acc_no, string account_name, double bal) : base(acc_no, account_name, bal)
        {

        }
        public override void withdraw(int amt)
        {
            if (bal > MIN_Balance)
            {
                bal = bal - amt;
            }
            else
                Console.WriteLine("Alert:Not Sufficient Balance");
        }
    }
}
