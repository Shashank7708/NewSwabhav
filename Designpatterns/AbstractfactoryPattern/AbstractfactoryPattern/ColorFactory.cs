using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractfactoryPattern
{
    class ColorFactory : AbstractFactory
    {
        public override FactoryDataItem Getdata(int type)
        {
            FactoryDataItem factoryDataItem = null;
            switch ((ColorType)type)
            {
                case ColorType.red:
                    factoryDataItem = new FactoryDataItem(new Red());
                    break;
                case ColorType.blue:
                    factoryDataItem = new FactoryDataItem(new Blue());
                    break;
                case ColorType.green:
                    factoryDataItem = new FactoryDataItem(new Greeb());
                    break;

            }
            return factoryDataItem;
        }
    }
}