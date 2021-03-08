using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class IAutoMobileFactory
    {
        public IAutoMobile make(CarType car)
        {
            if (car == CarType.audi)
            {
                return new Audi();
            }
            else if (car == CarType.bmw)
            {
                return new Bmw();
            }
            else
            {
                
                return null;
            }
        }
    }
}
