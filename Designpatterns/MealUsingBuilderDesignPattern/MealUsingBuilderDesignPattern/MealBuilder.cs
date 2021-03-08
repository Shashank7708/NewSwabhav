using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealUsingBuilderDesignPattern
{
    class MealBuilder
    {
        public Meal VegMeal()
        {
            Meal m = new Meal();
            m.addItem(new VegBurger());
            m.addItem(new Pepsi());
            m.addItem(new FrenchFries());
            return m;
        }
        public Meal NonVegMeal()
        {
            Meal m = new Meal();
            m.addItem(new NonvegBurger());
            m.addItem(new Coke());
            m.addItem(new FrenchFries());
            return m;
        }
    }
}
