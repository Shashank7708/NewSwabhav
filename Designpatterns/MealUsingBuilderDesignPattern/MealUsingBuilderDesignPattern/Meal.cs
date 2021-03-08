using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class Meal
    {
        List<Item> itemlist = new List<Item>();

        public void addItem(Item item)
        {
            itemlist.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0f;

            foreach (Item i in itemlist)
            {
                cost += i.price();
            }
            return cost;
        }

        public void showItems()
        {

            foreach (Item i in itemlist)
            {
                Console.Write("Item : " + i.name());
                Console.WriteLine(", Price : " + i.price());
            }
        }
    }
}
