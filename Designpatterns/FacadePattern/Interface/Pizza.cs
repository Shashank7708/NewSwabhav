using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Interface
{
    class Pizza : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonvegToppings();
            Console.WriteLine("Non-Veg Pizza is Ready");

        }

        public void GetVegPizza()
        {
            GetVegToppings();
            Console.WriteLine("Veg Pizza is Ready");
        }

        public void GetNonvegToppings()
        {
            Console.WriteLine("Non Veg Topping");
        }

        public void GetVegToppings()
        {
            Console.WriteLine("Veg Topping");
        }
    }
}
