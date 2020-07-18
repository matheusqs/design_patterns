using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Singleton
{
    class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass() { }

        public static SingletonClass getInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonClass();
            }

            return _instance;
        }
    }
}
