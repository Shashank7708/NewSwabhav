using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDeposit
{
    interface IFixedDeposit
    {
        double CalculateFixedDeposit();
        int getAccno { get; }
        string getName { get; }
        double getPrincipa { get; }
       int getyears { get; }
        int getFestival { get ; }
        double GetFinalAmount { get; }

        }
}
