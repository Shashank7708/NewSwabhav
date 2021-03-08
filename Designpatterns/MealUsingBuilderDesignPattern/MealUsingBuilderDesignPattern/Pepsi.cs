using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class Pepsi:Item
    {
        float Item.price()
        {
            return 35.0f;
        }
        string Item.name()
        {
            return "Pepsi";
        }
    }
}
