using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUsingbuilderPrincipal
{
    class Builder
    {
        int _accNo;
        private string _name;
        double _balance;
        string _branch;
        double _interestRate;
        
        public Builder(int accountNO)
        {  
            this._accNo = accountNO;
        }
        public void SetName(string name) { this._name = name; }
        public void SetBalance(double balance){ this._balance = balance; }
        public void setInterestRate(double interest){ this._interestRate = interest; }
        public void branch(string branch)  { this._branch = branch; }

        public Account build()
        {
            Account account1 = new Account();
            account1.AccountNo = _accNo;
            account1.AccountHolderName = _name;
            account1.Balance = _balance;
            account1.BranchName = _branch;
            account1.InterestRate = _interestRate;
            return account1;
        }

    }
}
