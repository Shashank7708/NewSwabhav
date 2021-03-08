using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class FrenchFries:Item
    {
        float Item.price()
        {
            return 45.0f;
        }
        string Item.name()
        {
            return "Fries";
        }
    }
}
