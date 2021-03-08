using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class NonvegBurger:Item
    {
        float Item.price()
        {
            return 110.0f;
        }
        string Item.name()
        {
            return "Non-Veg Burger";
        }
    }
}
