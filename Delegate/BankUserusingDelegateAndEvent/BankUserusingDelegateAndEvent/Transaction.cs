using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserusingDelegateAndEvent
{
    class Transaction
    {
        public event DelegateWithdraw WithdrawEvent;
        public event DelegateDeposit DepositEvent = null;

        Bank _b;
        public void Withdraw(Bank b1, double amt)
        {
            this._b = b1;


            if (_b.Balance - amt > 500)
            {
                _b.Balance -= amt;


            }
            WithdrawEvent(b1, amt);

        }

        public void Deposit(Bank b1, double amt)
        {
            this._b = b1;


            if (_b.Balance - amt > 500)
            {
                _b.Balance += amt;


            }
            DepositEvent(b1, amt);

        }
    }
}
