using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Interfaces
{
    interface IPizzaBuilder
    {
        public void reset();
        public void prepareDough();
        public void prepareSauce();
        public void putCheese();
        public void putBacon();
        public void putPepperoni();
        public void putOnion();
        public void putGarlic();
        public void putTomato();
        public void putChicken();
        public void putCheedar();
        public void putCatupiry();
        public void putOregano();
        public void bake();
    }
}
