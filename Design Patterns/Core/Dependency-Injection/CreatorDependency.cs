using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Dependency_Injection
{
    class CreatorDependency : Creator
    {
        public override IPattern createPattern()
        {
            return new Dependency();
        }
    }
}
