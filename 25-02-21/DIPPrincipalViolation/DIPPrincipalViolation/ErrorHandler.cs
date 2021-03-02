using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPPrincipalViolation
{
    class ErrorHandler
    {
        public int error(Exception e,LogType getLog)
        {
            if (getLog == LogType.TXT)
            {
                TxTLogger txtf = new TxTLogger();
                txtf.log(e.Message);
                return -1;
            }
            else
            {
                XmlLogger xm = new XmlLogger();
                xm.log(e.Message);
                return -1;
            }
        }
    }
}
