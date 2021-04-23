using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.RestaurantFacade;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant vishalRestaurant = new Restaurant();
            vishalRestaurant.NonVegPizza();
            Console.ReadLine();
        }
    }
}
