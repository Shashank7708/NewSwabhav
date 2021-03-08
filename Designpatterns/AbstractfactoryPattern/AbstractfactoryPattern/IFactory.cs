using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractfactoryPattern
{
    interface IFactory
    {
        FactoryDataItem Getdata(int type);
    }
}
