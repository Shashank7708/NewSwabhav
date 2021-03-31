using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserusingDelegateAndEvent
{
   public class Bank
    {
        int _Acountno;
        string _name;
        double _balance;
        double _withdrawAmt;
        double DepositAmt;

       


        public Bank(int accno, string name, double balance)
        {
            this._Acountno = accno;
            this._name = name;
            this._balance = balance;
        }

        public int AccountNo { get { return this._Acountno; } }
        public string Name { get { return this._name; } }
        public double Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
        }
        public double WithdrawAMt { get { return _withdrawAmt; } }
        


        public bool Withdraw(double amt)
        {
            this._withdrawAmt = amt;
            if (_balance - amt > 500)
            {
                _balance -= amt;


                return true;
            }
            return false;
        }
        
        public bool Deposit(double amt)
        {
            if (amt > 0)
            {
                _balance += amt;
                return true;
            }
            return false;

        }
    }
}
