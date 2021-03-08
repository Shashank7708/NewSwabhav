using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class Coke:Item
    {
        float Item.price()
        {
            return 40.0f;
        }
        string Item.name()
        {
            return "Coke";
        }
    }
}
