using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUsingbuilderPrincipal
{
    class Account
    {
       

        public int AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string BranchName { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return "AccountNO: " + AccountNo + "\nName:" + AccountHolderName + "\nBalance:" + Balance + "\nInterestRate:" + InterestRate;
        }
    }
}
