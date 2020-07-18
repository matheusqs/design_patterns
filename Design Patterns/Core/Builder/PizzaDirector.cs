using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Builder
{
    class PizzaDirector
    {
        private IPizzaBuilder _pizzaBuilder;

        public IPizzaBuilder pizzaBuilder
        {
            set { _pizzaBuilder = value; }
        }
        
        public void prepareChickenAndCatupiry()
        {
            this._pizzaBuilder.prepareDough();
            this._pizzaBuilder.prepareSauce();
            this._pizzaBuilder.putMozzarella();
            this._pizzaBuilder.putOregano();
            this._pizzaBuilder.putChicken();
            this._pizzaBuilder.putCatupiry();
            this._pizzaBuilder.bake();
        }

        public void prepareFourCheese()
        {
            this._pizzaBuilder.prepareDough();
            this._pizzaBuilder.prepareSauce();
            this._pizzaBuilder.putMozzarella();
            this._pizzaBuilder.putOregano();
            this._pizzaBuilder.putPepperoni();
            this._pizzaBuilder.putCatupiry();
            this._pizzaBuilder.putCheedar();
            this._pizzaBuilder.bake();
        }
    }
}
