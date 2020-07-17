using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core
{
    abstract class Creator
    {
        public abstract IPattern createPattern();

        public void execute()
        {
            IPattern pattern = createPattern();
            pattern.execute();
        }
    }
}
