using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractfactoryPattern
{
  abstract  class AbstractFactory:IFactory
    {
        public abstract FactoryDataItem Getdata(int type);
    }
}
