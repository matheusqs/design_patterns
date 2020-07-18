using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Factory
{
    class CreatorFactory : Creator
    {
        public override IPattern createPattern()
        {
            return new Factory();
        }
    }
}
