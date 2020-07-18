using Design_Patterns.Interfaces;
using Design_Patterns.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Builder
{
    class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        private static PizzaBuilder _instance;

        private PizzaBuilder()
        {
            this.reset();
        }

        public static PizzaBuilder getInstance()
        {
            if(_instance == null)
            {
                _instance = new PizzaBuilder();
            }

            return _instance;
        }

        public void reset()
        {
            this._pizza = new Pizza();
        }

        public Pizza getPizza()
        {
            Pizza result = this._pizza;

            this.reset();

            return result;
        }

        public void prepareDough()
        {
            this._pizza.Add("Dough");
        }

        public void prepareSauce()
        {
            this._pizza.Add("Sauce");
        }

        public void putCheese()
        {
            this._pizza.Add("Cheese");
        }

        public void putBacon()
        {
            this._pizza.Add("Bacon");
        }

        public void putPepperoni()
        {
            this._pizza.Add("Pepperoni");
        }

        public void putOnion()
        {
            this._pizza.Add("Onion");
        }

        public void putGarlic()
        {
            this._pizza.Add("Garlic");
        }

        public void putTomato()
        {
            this._pizza.Add("Tomato");
        }

        public void putChicken()
        {
            this._pizza.Add("Chicken");
        }

        public void putCheedar()
        {
            this._pizza.Add("Cheedar");
        }

        public void putCatupiry()
        {
            this._pizza.Add("Catupiry");
        }

        public void putOregano()
        {
            this._pizza.Add("Oregano");
        }

        public void bake()
        {
            this._pizza.Add("Bake");
        }

        public void putMozzarella()
        {
            this._pizza.Add("Mozzarella");
        }
    }
}
