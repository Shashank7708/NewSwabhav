using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccounPolymorphism
{
   abstract class Account
    {
        private int acc_no;
        private string account_name;
        protected double bal;

        public Account(int acc_no,string account_name,double bal)
        {
            this.acc_no = acc_no;
            this.account_name = account_name;
            this.bal = bal;
        }

        public int GetAcc_no()
        {
            return this.acc_no;
        }
        public string GetAccountName()
        {
            return this.account_name;
        }
        public double GetBalance()
        {
            return this.bal;
        }
        public void deposit(int amt)
        {
            if (amt > 0)
            {
                bal = bal + amt;
            }
        }
        public abstract void withdraw(int amt);
    }
}
