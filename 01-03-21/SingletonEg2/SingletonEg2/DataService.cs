using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEg2
{
    class DataService
    {
        static DataService bucket=new DataService();
       static  DataService()
        {
            Console.WriteLine("Service Created");
        }
        public static DataService getInst()
        {
            if (bucket == null)
                bucket = new DataService();
            return bucket;
        }
        public void processData()
        {
            Console.WriteLine("Hash COde Of CUrrent Data Service is "+bucket.GetHashCode());
        }
    }
}
