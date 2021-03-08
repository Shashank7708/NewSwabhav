using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractfactoryPattern
{
    class ShapeFactory:AbstractFactory
    {
        public override FactoryDataItem Getdata(int type)
        {
            FactoryDataItem factoryDataItem = null;
            switch((ShapeType)type)
            {
                case ShapeType.Circle:
                    factoryDataItem = new FactoryDataItem(new Circle());
                    break;
                case ShapeType.Rectangle:
                    factoryDataItem = new FactoryDataItem(new Rectangle());
                    break;
                case ShapeType.Square:
                    factoryDataItem = new FactoryDataItem(new Square());
                    break;

            }
            return factoryDataItem;
        }
    }
}
