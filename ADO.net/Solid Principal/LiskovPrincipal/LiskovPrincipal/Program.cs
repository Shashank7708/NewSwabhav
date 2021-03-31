using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthyFood h1 = new HealthyFood();
            HealthyFood h2 = new Salad();                  //Valid
            //But
            //Not Valid if healthyfood is inherited by Pizza or other junk food

        }
    }
}
