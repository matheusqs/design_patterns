using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Builder
{
    class Builder : IPattern
    {
        public void execute()
        {
            var director = new PizzaDirector();
            var builder = new PizzaBuilder();

            director.pizzaBuilder = builder;

            Console.WriteLine("Chicken with Catupiry Pizza:");
            director.prepareChickenAndCatupiry();
            Console.WriteLine(builder.getPizza().ListParts());

            Console.WriteLine("Four Cheeses Pizza:");
            director.prepareFourCheese();
            Console.WriteLine(builder.getPizza().ListParts());
        }
    }
}
