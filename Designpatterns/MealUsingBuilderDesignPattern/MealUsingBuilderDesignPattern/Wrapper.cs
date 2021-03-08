using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class Wrapper:Packing
    {
         String Packing.pack()
        {
            return "Wrapper";
        }
    }
}
