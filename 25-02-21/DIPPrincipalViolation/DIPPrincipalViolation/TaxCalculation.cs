using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPPrincipalViolation
{
    class TaxCalculation
    {
        public LogType _log;
        public TaxCalculation(LogType log)
        {
            this._log=log;
        }
        public LogType getLog { get { return this._log; } }

        public int calculate(int amount,int rate)
        {
            try
            {
                int r = amount / rate;
                return r;
            }
            catch(Exception e)
            {
                if (this.getLog == LogType.TXT)
                {
                    TxTLogger txtf = new TxTLogger();
                    txtf.log(e.Message);
                    return -1;
                }
                XmlLogger xm = new XmlLogger();
                xm.log(e.Message);
                return -1;
            }
        }

    }
    
}
