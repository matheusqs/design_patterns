using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Singleton
{
    class Singleton : IPattern
    {
        public void execute()
        {
            var singleton1 = SingletonClass.getInstance();
            var singleton2 = SingletonClass.getInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works! Both objects are from the same instance.");
            } else
            {
                Console.WriteLine("Singleton fails! The objects are from different instances.");
            }
        }
    }
}
