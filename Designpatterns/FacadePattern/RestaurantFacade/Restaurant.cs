using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Interface;

namespace FacadePattern.RestaurantFacade
{
    class Restaurant
    {
        private IBurger _burger;
        private IPizza _pizza;

        public Restaurant()
        {
            _burger = new Burger();
            _pizza = new Pizza();
        }

        public void NonVegPizza()
        {
            _pizza.GetNonVegPizza();
        }
        public void VegPizzz()
        {
            _pizza.GetNonVegPizza();
        }
        public void NonVegBurger()
        {
            _burger.NonVegBurger();
        }
        public void VegBurger()
        {
            _burger.VegBurger();
        }

    }
}
