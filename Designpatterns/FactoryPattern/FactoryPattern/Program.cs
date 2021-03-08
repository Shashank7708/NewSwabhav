using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoMobileFactory f1 = new IAutoMobileFactory();
          IAutoMobile bmw=  f1.make(CarType.bmw);
            bmw.start();
            bmw.stop();
          IAutoMobile audi= f1.make(CarType.audi);
            audi.stop();
            audi.start();
            Console.WriteLine("Case 2:");

           IAutoMobile unspecified= f1.make(CarType.unspecified);
            if (unspecified == null)
            {
                Console.WriteLine("Not available");
            }
            Console.WriteLine("Case 3:");

            IAutoMobile bmw1 = new Bmw();
            bmw1.start();
            bmw1.stop();
            Console.Read();
        }
    }

    enum CarType
    {
        bmw,
        audi,
        unspecified
        
    }
}
