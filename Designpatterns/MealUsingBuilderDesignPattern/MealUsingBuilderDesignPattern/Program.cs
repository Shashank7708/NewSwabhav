using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealbuilder = new MealBuilder();
            PrintMeal(mealbuilder.VegMeal());
            PrintMeal( mealbuilder.NonVegMeal());
            Console.Read();
           
        }

        public static void PrintMeal(Meal meal)
        {
            Console.ForegroundColor = ConsoleColor.White;
            meal.showItems();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TotalCost:" + meal.getCost());
        }
    }
}
