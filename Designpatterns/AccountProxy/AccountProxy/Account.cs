using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProxy
{
    class Account
    {
      public  string _accountname;
        public double _balance;
        public string _accountNo;

        public Account(string name,double balance,string accno)
        {
            this._accountname = name;
            this._balance = balance;
            this._accountNo = accno;
        }

        public virtual void Deposit(double amt)
        {
            _balance = _balance + amt;
        }
        public void Withdraw(double withdraw)
        {
            _balance = _balance - withdraw;
        }
        public string GetaccountNmae { get { return _accountname; } }
        public string getAccountNo { get { return _accountNo; } }
        public double getBalance { get { return _balance; } }

    }
}
