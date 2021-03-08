using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAndTurkeyUsingAdapter
{
    class AdapterTurkey:Duck
    {
        Turkey _turkey;
        public AdapterTurkey(Turkey turkey)
        {
            _turkey = turkey;
        }

        void Duck.Quack()
        {
            _turkey.Gobble();
        }

        void Duck.fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

    }
}
