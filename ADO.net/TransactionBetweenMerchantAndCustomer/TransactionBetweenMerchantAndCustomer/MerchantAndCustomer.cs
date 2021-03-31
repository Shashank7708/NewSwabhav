using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionBetweenMerchantAndCustomer
{
    abstract class MerchantAndCustomer
    {
       public int id { get; set; }
       public  string name { get; set; }
      public  string balance { get; set; }
        
       public string fullInfo
        {
            get
            {
                return $"{id} {name} {balance}";
            }
        }
    }
}
