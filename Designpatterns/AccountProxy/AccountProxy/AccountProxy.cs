using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProxy
{
    class AccountProxy:Account
    {
        Account a;
        public AccountProxy(string accno,string accountName,double balance) : base( accountName,balance,accno )
        {
            _accountNo = accno;
            accountName = _accountname;
            _balance = balance;
            a = new Account(accountName,balance,accno);
        }

       new public  void Deposit(double amt)
        {
            Console.WriteLine("Before Depositing date and time:"+DateTime.Now);
            Console.WriteLine("Balance Before Depositing:" + getBalance);
           base.Deposit(200);
            Console.WriteLine("After Depositing date and time:" + DateTime.Now);
            Console.WriteLine("Balance After Depositing:" + getBalance);



        }
    }
}
