using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Builder
{
    class CreatorBuilder : Creator
    {
        public override IPattern createPattern()
        {
            return new Builder();
        }
    }
}
