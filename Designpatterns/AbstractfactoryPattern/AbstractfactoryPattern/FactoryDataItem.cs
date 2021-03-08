using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractfactoryPattern
{
    class FactoryDataItem
    { object _dataitem;
        public FactoryDataItem(object dataItem)
        {
            this._dataitem = dataItem;
        }
        public object DataItem { get { return this._dataitem; } }




    }
}
