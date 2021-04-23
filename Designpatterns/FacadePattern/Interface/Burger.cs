using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Interface
{
    class Burger : IBurger
    {
        public void NonVegBurger()
        {
            NonvegPatti();
            Console.WriteLine("NonVeg Burger is Ready");
        }

        public void VegBurger()
        {
            VegPatti();
            Console.WriteLine("Veg Burger is Ready");
        }

        public void NonvegPatti()
        {
            Console.WriteLine("Non Veg Patti");
        }

        public void VegPatti()
        {
            Console.WriteLine("Veg Patti");
        }
    }
}
